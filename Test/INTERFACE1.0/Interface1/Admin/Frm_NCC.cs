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
    public partial class Frm_NCC : Form
    {
        private string str = "Data Source=MINHDAT\\MINHDAT;Initial Catalog=TenCSDL;Integrated Security=True";
        private SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhaCungCap";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public Frm_NCC()
        {
            InitializeComponent();
        }

        private void Frm_NCC_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        //Mã ncc
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Tên ncc
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Địa chỉ ncc
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Mã công ty
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Thêm
        private void button3_Click(object sender, EventArgs e)
        {
            string maNCC = textBox1.Text;
            string tenNCC = textBox2.Text;
            string diaChiNCC = textBox3.Text;
            string maCongTy = textBox4.Text;

            // Thực hiện kiểm tra dữ liệu hợp lệ ở đây (ví dụ: kiểm tra chuỗi không rỗng)

            // Thực hiện lệnh SQL để thêm dữ liệu vào bảng NhaCungCap
            string insertQuery = "INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChiNCC, MaCongTi) VALUES (@MaNCC, @TenNCC, @DiaChiNCC, @MaCongTi)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@MaNCC", maNCC);
                command.Parameters.AddWithValue("@TenNCC", tenNCC);
                command.Parameters.AddWithValue("@DiaChiNCC", diaChiNCC);
                command.Parameters.AddWithValue("@MaCongTi", maCongTy);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                    loaddata(); // Sau khi thêm dữ liệu, load lại dữ liệu để hiển thị
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại");
                }
            }
        }
        //Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            string maNCC = textBox1.Text;
            string tenNCC = textBox2.Text;
            string diaChiNCC = textBox3.Text;
            string maCongTy = textBox4.Text;

            // Thực hiện kiểm tra dữ liệu hợp lệ ở đây (ví dụ: kiểm tra chuỗi không rỗng)

            // Thực hiện lệnh SQL để cập nhật dữ liệu trong bảng NhaCungCap
            string updateQuery = "UPDATE NhaCungCap SET TenNCC = @TenNCC, DiaChiNCC = @DiaChiNCC, MaCongTi = @MaCongTi WHERE MaNCC = @MaNCC";
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@MaNCC", maNCC);
                command.Parameters.AddWithValue("@TenNCC", tenNCC);
                command.Parameters.AddWithValue("@DiaChiNCC", diaChiNCC);
                command.Parameters.AddWithValue("@MaCongTi", maCongTy);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata(); // Sau khi cập nhật dữ liệu, load lại dữ liệu để hiển thị
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại");
                }
            }
        }
        //Xóa
        private void button1_Click(object sender, EventArgs e)
        {
            string maNCC = textBox1.Text;

            // Thực hiện lệnh SQL để xóa dữ liệu từ bảng NhaCungCap
            string deleteQuery = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@MaNCC", maNCC);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    loaddata(); // Sau khi xóa dữ liệu, load lại dữ liệu để hiển thị
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại");
                }
            }
        }
    }
}
