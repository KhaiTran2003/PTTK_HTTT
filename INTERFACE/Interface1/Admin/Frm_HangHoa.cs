﻿using System;
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
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO HangHoa (MaSP, TenSP, NgaySX, Gia, SoLuong, HinhAnh, MaCongTy) VALUES (@MaSP, @TenSp, @NgaySX, @Gia, @SoLuong, @HinhAnh, @MaCongTy)"; 
            command.Parameters.AddWithValue("@MaSP", tb_MaSP.Text);
            command.Parameters.AddWithValue("@TenSp",tb_tenSP.Text);
            command.Parameters.AddWithValue("@NgaySX",dtp_ngaySX.Text);
            command.Parameters.AddWithValue("@Gia",tb_gia.Text);
            command.Parameters.AddWithValue("@SoLuong",tb_SL.Text);
            command.Parameters.AddWithValue("@HinhAnh",pictureBox1.ImageLocation);
            command.Parameters.AddWithValue("@MaCongTy",tb_MaCTY.Text="CT001");

            command.ExecuteNonQuery();
            loaddata();
        }
        
        //Sửa
        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trên DataGridView chưa
            if (dgv.SelectedRows.Count > 0)
            {
                btn_sua.Click += (senderLuu, eLuu) =>
                {
                    // Thực hiện truy vấn SQL UPDATE để cập nhật dữ liệu trong cơ sở dữ liệu
                    string sql = "UPDATE HangHoa SET TenSP=@TenSP, NgaySX=@NgaySX, Gia=@Gia, SoLuong=@SoLuong, HinhAnh=@HinhAnh, MaCongTy=@MaCongTy WHERE MaSP=@MaSP";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@MaSP", tb_MaSP.Text);
                        command.Parameters.AddWithValue("@TenSP", tb_tenSP.Text);
                        command.Parameters.AddWithValue("@NgaySX", dtp_ngaySX.Value);
                        command.Parameters.AddWithValue("@Gia", float.Parse(tb_gia.Text));
                        command.Parameters.AddWithValue("@SoLuong", int.Parse(tb_SL.Text));
                        command.Parameters.AddWithValue("@HinhAnh", pictureBox1.ImageLocation);
                        command.Parameters.AddWithValue("@MaCongTy", tb_MaCTY.Text="CT001");

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
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                // Lấy Mã sản phẩm từ dòng đã chọn
                int masp = Convert.ToInt32(dgv.SelectedRows[0].Cells["MaSP"].Value);

                // Chuỗi truy vấn SQL để xóa sản phẩm dựa trên Mã sản phẩm
                string sql = "DELETE FROM HangHoa WHERE MaSP = @MaSP";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MaSP", masp);

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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaCTY.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_MaSP.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_tenSP.Text = dgv.Rows[i].Cells[1].Value.ToString();
            dtp_ngaySX.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_gia.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_SL.Text = dgv.Rows[i].Cells[4].Value.ToString();
            pictureBox1.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_MaCTY.Text = dgv.Rows[i].Cells[6].Value.ToString();
        }
    }
}
