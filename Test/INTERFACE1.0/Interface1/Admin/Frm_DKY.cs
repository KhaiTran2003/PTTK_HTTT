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
    public partial class Frm_DKY : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public Frm_DKY()
        {
            InitializeComponent();
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }

        private void btn_exitDKY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DKY_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btn_xacnhanDKY_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
            
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

            // Kiểm tra số điện thoại đã tồn tại trong bảng hay chưa
            if (!int.TryParse(textBox4.Text, out soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
                string insertQuery = "INSERT INTO NguoiQuanLyHT (MatKhau, Ho, TenDem, Ten, GioiTinh, NgaySinh, SoDienThoai, DiaChi) VALUES (@MatKhau, @Ho, @TenDem, @Ten, @GioiTinh, @NgaySinh, @SoDienThoai, @DiaChi)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
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
    }
}
