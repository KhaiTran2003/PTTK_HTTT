using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interface1
{
    public partial class Frm_DKYuser : Form
    {

        public Frm_DKYuser()
        {
            InitializeComponent();
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }

        private void btn_exitDKY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Họ
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Tên đệm
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //Tên
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //Mật khẩu
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Xác nhận mật khẩu
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Số điện thoại
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Giới tính
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Địa chỉ
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //Ngày sinh
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //Xác nhận
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MINHDAT\\MINHDAT;Initial Catalog=VinFast;Integrated Security=True";

            string ho = textBox1.Text;
            string tenDem = textBox6.Text;
            string ten = textBox7.Text;
            string matKhau = textBox2.Text;
            string xacNhanMatKhau = textBox3.Text;
            string diachi = textBox5.Text;
            string gioiTinh = comboBox1.SelectedItem.ToString();
            DateTime ngaySinh = dateTimePicker1.Value;
            int soDienThoai;

            // Kiểm tra xác nhận mật khẩu
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng");
                return;
            }

            // Kiểm tra số điện thoại hợp lệ
            if (!int.TryParse(textBox4.Text, out soDienThoai))
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
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@Ho", ho);
                    command.Parameters.AddWithValue("@TenDem", tenDem);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", diachi);


                    int rowsAffected = command.ExecuteNonQuery();
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
    }
}
