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

        public void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select  MaTaiKhoanKH, Ho, TenDem, Ten, MatKhau, GioiTinh,SoDienThoai,NgaySinh from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public Frm_DKY()
        {
            InitializeComponent();
            cb_gioiTinh.Items.Add("Nam");
            cb_gioiTinh.Items.Add("Nữ");
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

        //private void btn_xacnhanDKY_Click(object sender, EventArgs e)
        //{
        //    command = connection.CreateCommand();
        //    command.CommandText = "insert into KhachHang values(N'"+tb_mk.Text+ "', N'"+tb_ho.Text+ "', N'"+tb_tendem.Text+ "',N'"+tb_ten.Text+ "','"+cb_gioiTinh.Text+ "','"+dateTimePicker1.Text+ "','"+tb_sdt.Text+"')";
        //    command.ExecuteNonQuery();
        //}

        private void btn_xacnhanDKY_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
            string ho = tb_ho.Text;
            string tenDem = tb_tendem.Text;
            string ten = tb_ten.Text;
            string matKhau = tb_mk.Text;
            string xacNhanMatKhau = textBox3.Text;
            string gioiTinh = cb_gioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = dateTimePicker1.Value;
            int soDienThoai;

            //Kiểm tra xác nhận mật khẩu
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng");
                return;
            }

            //Kiểm tra số điện thoại hợp lệ
            if (!int.TryParse(tb_sdt.Text, out soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Tạo mã ngẫu nhiên cho MaTaiKhoanKH
                string maTaiKhoanKH = GenerateRandomMaTaiKhoanKH(connection);

                //Kiểm tra số điện thoại đã tồn tại trong bảng hay chưa
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

                //Thêm dữ liệu vào bảng KhachHang
                string insertQuery = "INSERT INTO KhachHang (MaTaiKhoanKH, Ho, TenDem, Ten,  MatKhau,SoDienThoai,GioiTinh,NgaySinh) VALUES (@MaTaiKhoanKH, @Ho, @TenDem, @Ten, @ MatKhau, @SoDienThoai,@GioiTinh,@NgaySinh)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaTaiKhoanKH", maTaiKhoanKH);
                    command.Parameters.AddWithValue("@Ho", ho);
                    command.Parameters.AddWithValue("@TenDem", tenDem);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                    //command.ExecuteNonQuery();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công");
                        //loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại");
                    }
                }
            }
        }
        //Random mã hệ thống
        private string GenerateRandomMaHeThong(SqlConnection connection)
        {
            string maHeThong;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 1000); // Số ngẫu nhiên từ 1 đến 999
                maHeThong = "HT" + randomNumber.ToString("D3"); // Format thành chuỗi với độ dài là 3, ví dụ: HT001, HT002,...

                // Kiểm tra xem mã đã tồn tại trong bảng HeThongCongTyVinfast chưa
                string checkDuplicateQuery = "SELECT COUNT(*) FROM HeThongQuanLiCTVinFast WHERE MaHeThong = @MaHeThong";
                using (SqlCommand command = new SqlCommand(checkDuplicateQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaHeThong", maHeThong);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        // Mã chưa tồn tại, thoát khỏi vòng lặp
                        break;
                    }
                }
            } while (true);

            return maHeThong;
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set MatKhau=  N'" + tb_mk.Text + "', Ho = N'" + tb_ho.Text + "',TenDem = N'" + tb_tendem.Text + "',Ten = N'" + tb_ten.Text + "',GioiTinh = N'" + cb_gioiTinh.Text + "',NgaySinh = '" + dateTimePicker1.Text + "',SoDienThoai = " + tb_sdt.Text + " where MaTaiKhoanKH = '"+tb_makh.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where  MatKhau=  N'" + tb_mk.Text + "', Ho = N'" + tb_ho.Text + "',TenDem = N'" + tb_tendem.Text + "',Ten = N'" + tb_ten.Text + "',GioiTinh = N'" + cb_gioiTinh.Text + "',NgaySinh = '" + dateTimePicker1.Text + "',SoDienThoai = " + tb_sdt.Text + " where MaTaiKhoanKH = '" + tb_makh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void Frm_DKY_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_makh.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_makh.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_ho.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_tendem.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_ten.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_mk.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_sdt.Text = dgv.Rows[i].Cells[6].Value.ToString();
            cb_gioiTinh.Text = dgv.Rows[i].Cells[5].Value.ToString();
            dateTimePicker1.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }
    }
}
