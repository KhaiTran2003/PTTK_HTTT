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
    public partial class Frm_NCC : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
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

        //Thêm
        private void button3_Click_1(object sender, EventArgs e)
        {
            string maNCC = textBox1.Text;
            string tenNCC = textBox2.Text;
            string diaChiNCC = textBox3.Text;
            string maCongTy = textBox4.Text;
            string soDienThoaiNCC = textBox5.Text;

            // Thực hiện kiểm tra dữ liệu hợp lệ ở đây (ví dụ: kiểm tra chuỗi không rỗng)

            // Thực hiện lệnh SQL để thêm dữ liệu vào bảng NhaCungCap
            string insertQuery = "INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChiNCC, MaCongTi, SoDienThoaiNCC) VALUES (@MaNCC, @TenNCC, @DiaChiNCC, @MaCongTi, @SoDienThoaiNCC)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@MaNCC", maNCC);
                command.Parameters.AddWithValue("@TenNCC", tenNCC);
                command.Parameters.AddWithValue("@DiaChiNCC", diaChiNCC);
                command.Parameters.AddWithValue("@MaCongTi", maCongTy);
                command.Parameters.AddWithValue("@SoDienThoaiNCC", soDienThoaiNCC);

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
        private void button2_Click_1(object sender, EventArgs e)
        {
            string maNCC = textBox1.Text;
            string tenNCC = textBox2.Text;
            string diaChiNCC = textBox3.Text;
            string maCongTy = textBox4.Text;
            string soDienThoaiNCC = textBox5.Text;

            // Thực hiện kiểm tra dữ liệu hợp lệ ở đây (ví dụ: kiểm tra chuỗi không rỗng)

            // Thực hiện lệnh SQL để cập nhật dữ liệu trong bảng NhaCungCap
            string updateQuery = "UPDATE NhaCungCap SET TenNCC = @TenNCC, DiaChiNCC = @DiaChiNCC, MaCongTi = @MaCongTi WHERE MaNCC = @MaNCC, SoDienThoaiNCC = @SoDienThoaiNCC";
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@MaNCC", maNCC);
                command.Parameters.AddWithValue("@TenNCC", tenNCC);
                command.Parameters.AddWithValue("@DiaChiNCC", diaChiNCC);
                command.Parameters.AddWithValue("@MaCongTi", maCongTy);
                command.Parameters.AddWithValue("@SoDienThoaiNCC",soDienThoaiNCC );

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
