using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interface1
{
    public partial class Frm_HangHoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangHoa";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public Frm_HangHoa()
        {
            InitializeComponent();
        }
        //Kết nối
        private void connect()
        {
            try { connection = new SqlConnection(str); connection.Open(); }
            catch { }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HangHoa_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            loaddata();
            connection.Close();
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tất cả các tệp ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tất cả các tệp|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string duongDanAnh = openFileDialog.FileName;

                pictureBox1.Image = Image.FromFile(duongDanAnh);
            }
        }
        //Mã SP
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Tên SP
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Ngày SX
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //Giá
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Số lượng
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //Mã công ty
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Hình ảnh
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO HangHoa (MaSP, TenSP, NgaySX, Gia, SoLuong, HinhAnh, MaCongTy) VALUES (@masp, @tensp, @ngaysx, @gia, @soluong, @hinhanh, @macongty)";

            int masp = int.Parse(textBox1.Text);
            string tensp = textBox2.Text;
            DateTime ngaysx = dateTimePicker1.Value;
            float gia = float.Parse(textBox4.Text);
            int soluong = int.Parse(textBox5.Text);
            string macongty = comboBox1.Text;
            string hinhanh = pictureBox1.ImageLocation;
            if (string.IsNullOrEmpty(hinhanh))
            {
                // Nếu đường dẫn hình ảnh rỗng, bạn có thể gán một giá trị mặc định hoặc thông báo lỗi tùy ý.
                hinhanh = "Đường dẫn mặc định hoặc thông báo lỗi";
            }

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@masp", masp);
                command.Parameters.AddWithValue("@tensp", tensp);
                command.Parameters.AddWithValue("@ngaysx", ngaysx);
                command.Parameters.AddWithValue("@gia", gia);
                command.Parameters.AddWithValue("@soluong", soluong);
                command.Parameters.AddWithValue("@hinhanh", hinhanh);
                command.Parameters.AddWithValue("@macongty", macongty);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Cập nhật lại dữ liệu trên DataGridView
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }

        }
        //Sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trên DataGridView chưa
            if (dgv.SelectedRows.Count > 0)
            {
                // Lấy Mã sản phẩm từ dòng đã chọn
                int masp = Convert.ToInt32(dgv.SelectedRows[0].Cells["MaSP"].Value);

                // Hiển thị thông tin của sản phẩm cần sửa trong các điều khiển trên giao diện
                string tensp = dgv.SelectedRows[0].Cells["TenSP"].Value.ToString();
                DateTime ngaysx = Convert.ToDateTime(dgv.SelectedRows[0].Cells["NgaySX"].Value);
                float gia = Convert.ToSingle(dgv.SelectedRows[0].Cells["Gia"].Value);
                int soluong = Convert.ToInt32(dgv.SelectedRows[0].Cells["SoLuong"].Value);
                string hinhanh = dgv.SelectedRows[0].Cells["HinhAnh"].Value.ToString();
                string macongty = dgv.SelectedRows[0].Cells["MaCongTy"].Value.ToString();

                // Hiển thị thông tin sản phẩm trong các điều khiển trên giao diện để cho phép chỉnh sửa
                textBox1.Text = masp.ToString();
                textBox2.Text = tensp;
                dateTimePicker1.Value = ngaysx;
                textBox4.Text = gia.ToString();
                textBox5.Text = soluong.ToString();
                comboBox1.Text = macongty;
                pictureBox1.ImageLocation = hinhanh;


                btn_sua.Click += (senderLuu, eLuu) =>
                {
                    // Thực hiện truy vấn SQL UPDATE để cập nhật dữ liệu trong cơ sở dữ liệu
                    string sql = "UPDATE HangHoa SET TenSP=@tensp, NgaySX=@ngaysx, Gia=@gia, SoLuong=@soluong, HinhAnh=@hinhanh, MaCongTy=@macongty WHERE MaSP=@masp";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@masp", masp);
                        command.Parameters.AddWithValue("@tensp", textBox2.Text);
                        command.Parameters.AddWithValue("@ngaysx", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@gia", float.Parse(textBox4.Text));
                        command.Parameters.AddWithValue("@soluong", int.Parse(textBox5.Text));
                        command.Parameters.AddWithValue("@hinhanh", pictureBox1.ImageLocation);
                        command.Parameters.AddWithValue("@macongty", comboBox1.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Cập nhật lại dữ liệu trên DataGridView sau khi sửa
                            loaddata();
                        }
                        else
                        {
                            MessageBox.Show("Sửa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }
                };
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                // Lấy Mã sản phẩm từ dòng đã chọn
                int masp = Convert.ToInt32(dgv.SelectedRows[0].Cells["MaSP"].Value);

                // Chuỗi truy vấn SQL để xóa sản phẩm dựa trên Mã sản phẩm
                string sql = "DELETE FROM HangHoa WHERE MaSP = @masp";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@masp", masp);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cập nhật lại dữ liệu trên DataGridView sau khi xóa
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
