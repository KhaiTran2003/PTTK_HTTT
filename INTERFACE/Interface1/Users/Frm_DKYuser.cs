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
    public partial class Frm_DKYuser : Form
    {

        public Frm_DKYuser()
        {
            InitializeComponent();
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");
        }
        //Đăng ký
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";

            string ho = tb_ho.Text;
            string tenDem = tb_tendem.Text;
            string ten = tb_ten.Text;
            string matKhau = tb_mk.Text;
            string xacNhanMatKhau = textBox3.Text;
            string gioiTinh = cb_gioitinh.SelectedItem.ToString();
            DateTime ngaySinh = dateTimePicker1.Value;
            int soDienThoai;

            // Kiểm tra xác nhận mật khẩu
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng");
                return;
            }

            // Kiểm tra số điện thoại hợp lệ
            if (!int.TryParse(tb_sdt.Text, out soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo mã ngẫu nhiên cho MaTaiKhoanKH
                string maTaiKhoanKH = GenerateRandomMaTaiKhoanKH(connection);

                // Kiểm tra số điện thoại đã tồn tại trong bảng hay chưa
                string checkPhoneQuery = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
                using (SqlCommand command = new SqlCommand(checkPhoneQuery, connection))
                {
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                        return;
                    }
                }

                // Thêm dữ liệu vào bảng KhachHang
                string insertQuery = "INSERT INTO KhachHang (MaTaiKhoanKH, MatKhau, Ho, TenDem, Ten, GioiTinh, NgaySinh, SoDienThoai, DiaChi) VALUES (@MaTaiKhoanKH, @MatKhau, @Ho, @TenDem, @Ten, @GioiTinh, @NgaySinh, @SoDienThoai, @DiaChi)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaTaiKhoanKH", maTaiKhoanKH);
                    command.Parameters.AddWithValue("@Ho", ho);
                    command.Parameters.AddWithValue("@TenDem", tenDem);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);


                    var rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại");
                    }
                }
            }
        }
        //Random mã khách hàng
        private string GenerateRandomMaTaiKhoanKH(SqlConnection connection)
        {
            // Tạo mã ngẫu nhiên cho MaTaiKhoanKH
            string maTaiKhoanKH;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(100, 999); // Số ngẫu nhiên từ 1000 đến 9999
                maTaiKhoanKH = "KH" + randomNumber.ToString();

                // Kiểm tra xem mã đã tồn tại trong bảng KhachHang chưa
                string checkDuplicateQuery = "SELECT COUNT(*) FROM KhachHang WHERE MaTaiKhoanKH = @MaTaiKhoanKH";
                using (SqlCommand command = new SqlCommand(checkDuplicateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaTaiKhoanKH", maTaiKhoanKH);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        // Mã chưa tồn tại, thoát khỏi vòng lặp
                        break;
                    }
                }
            } while (true);

            return maTaiKhoanKH;
        }
        private void btn_exitDKY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DKYuser_Load(object sender, EventArgs e)
        {

        }
    }
}
