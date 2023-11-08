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

namespace Interface1.Users
{
    public partial class Frm_DNuser: Form
    {
        public Frm_DNuser()
        {
            InitializeComponent();
        }

        private void linklb_dky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DKYuser frm_dky = new Frm_DKYuser();
            frm_dky.Show();
        }

        private void linklb_cty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_userMAIN frm_main = new Frm_userMAIN();
            frm_main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DNuser_Load(object sender, EventArgs e)
        {

        }

        //Số điện thoại
        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }
        //Mật khẩu
        private void text_mk_TextChanged(object sender, EventArgs e)
        {

        }
        //Đăng nhập
        private void btn_dn_Click(object sender, EventArgs e)
        {
            int soDienThoai;
            string matKhau = text_mk.Text;

            // Kiểm tra số điện thoại hợp lệ
            if (!int.TryParse(text_name.Text, out soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            string connectionString = "Data Source=MINHDAT\\MINHDAT;Initial Catalog=VinFast;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra thông tin trong bảng KhachHang
                string query = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai AND MatKhau = @MatKhau";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Đăng nhập thành công, thực hiện các hành động sau khi đăng nhập
                        MessageBox.Show("Đăng nhập thành công");
                        //Đường dẫn đến trang tiếp theo sau khi đăng nhập thành công
                    }
                    else
                    {
                        // Số điện thoại hoặc mật khẩu không đúng, hiển thị thông báo
                        MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng");
                    }
                }
            }
        }
    }
}
