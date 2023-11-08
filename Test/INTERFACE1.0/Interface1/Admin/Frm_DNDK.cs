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
    public partial class Frm_DNDK : Form
    {
        public Frm_DNDK()
        {
            InitializeComponent();
        }

        private void linklb_dky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DKY frm_dky = new Frm_DKY();
            frm_dky.Show();
        }

        private void linklb_cty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_MAIN frm_main = new Frm_MAIN();
            frm_main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            string connectionString = @"Data Source=MINHDAT\\MINHDAT;Initial Catalog=VinFast;Integrated Security=True";
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
