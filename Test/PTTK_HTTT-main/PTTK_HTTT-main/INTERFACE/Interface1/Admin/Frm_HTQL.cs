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
    public partial class Frm_HTQL : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
        //string str = @" Data Source=LAPTOP-VNRKQGE2\SQLEXPRESS;Initial Catalog=HeThongVinFast1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HeThongQuanLiCTVinFast";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv3.DataSource = table;
        }
        void loaddata2()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NguoiQuanLyHT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        //hiển thị database
        private void Frm_HTQL_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
           
            loaddata2();
        }
       
        public Frm_HTQL()
        {
            InitializeComponent();
        }
        
        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv3.CurrentRow.Index;
            tb_maHT.Text = dgv3.Rows[i].Cells[0].Value.ToString();
            tb_macty.Text = dgv3.Rows[i].Cells[1].Value.ToString();
            tb_tenCN.Text = dgv3.Rows[i].Cells[2].Value.ToString();
        }

      
        //xóa CN
        private void btn_xoaCN_Click(object sender, EventArgs e)
        {
            //xoa bang ghi co tham chieu den o day la bang KHACH HANG
            string deleteKhachHangQuery = "DELETE FROM KhachHang WHERE MaHeThong = @MaHeThong";
            SqlCommand deleteKhachHangCommand = new SqlCommand(deleteKhachHangQuery, connection);
            deleteKhachHangCommand.Parameters.AddWithValue("@MaHeThong", tb_maHT.Text);
            deleteKhachHangCommand.ExecuteNonQuery();
            //xoa bang ghi co tham chieu den o day la bang NGUOI QUAN LI
            string deleteNguoiQuanLyQuery = "DELETE FROM NguoiQuanLyHT WHERE MaHeThong = @MaHeThong";
            SqlCommand deleteNguoiQuanLyCommand = new SqlCommand(deleteNguoiQuanLyQuery, connection);
            deleteNguoiQuanLyCommand.Parameters.AddWithValue("@MaHeThong", tb_macty.Text);
            deleteNguoiQuanLyCommand.ExecuteNonQuery();
            //command = connection.CreateCommand();
            //command.CommandText = "delete from HeThongQuanLiCTVinFast where MaHeThong= '"+tb_mahethong.Text+"' ";
            //command.ExecuteNonQuery();
            //loaddata1();
            command = connection.CreateCommand();
            command.CommandText = "delete from HeThongQuanLiCTVinFast where MaHeThong= @MaHeThong";
            command.Parameters.AddWithValue("@MaHeThong", tb_maHT.Text);
            command.ExecuteNonQuery();
            loaddata1();
           
        }
       
       
        private void btn_suaCN_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True"; /*@" Data Source=LAPTOP-VNRKQGE2\SQLEXPRESS;Initial Catalog=HeThongVinFast1;Integrated Security=True";*/
            string maHeThong = tb_maHT.Text;
            string maCongTy = tb_macty.Text;
            string tenHeThong = tb_tenCN.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE HeThongQuanLiCTVinFast SET TenHeThong = @TenHeThong WHERE MaHeThong = @MaHeThong";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@TenHeThong", tenHeThong);
                    updateCommand.Parameters.AddWithValue("@MaHeThong", maHeThong);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Sửa thành công
                        MessageBox.Show("Sửa thông tin thành công!");
                        // Thực hiện các hành động khác sau khi sửa thành công
                    }
                    else
                    {
                        // Không tìm thấy bản ghi cần sửa
                        MessageBox.Show("Không tìm thấy bản ghi cần sửa!");
                        // Thực hiện các hành động khác khi không tìm thấy bản ghi
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                //MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            
        }

        private void btn_themCN_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra xem mã công ty có tồn tại hay không
            string maCongTy = "CT001";
            string checkQuery = "SELECT COUNT(*) FROM CongTiVinFast WHERE MaCongTy = @MaCongTy";
            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("@MaCongTy", maCongTy);
            int count = (int)checkCommand.ExecuteScalar();

            // Nếu giá trị không tồn tại, thêm giá trị mới vào bảng CongTiVinFast
            if (count == 0)
            {
                string insertCongTiQuery = "INSERT INTO CongTiVinFast (MaCongTy, SoDienThoaiCT, DiaDiemCT) " +
                    "VALUES (@MaCongTy, @SoDienThoaiCT, @DiaDiemCT)";
                SqlCommand insertCongTiCommand = new SqlCommand(insertCongTiQuery, connection);
                insertCongTiCommand.Parameters.AddWithValue("@MaCongTy", maCongTy);
                insertCongTiCommand.Parameters.AddWithValue("@SoDienThoaiCT", 0);
                insertCongTiCommand.Parameters.AddWithValue("@DiaDiemCT", "Địa điểm công ty");

                insertCongTiCommand.ExecuteNonQuery();
            }

            //kiem tra bang ghi da ton tai hay khong
            string maHeThong = tb_maHT.Text;
            string checkQuery2 = "SELECT COUNT(*) FROM HeThongQuanLiCTVinFast WHERE MaHeThong = @MaHeThong";
            SqlCommand checkCommand2 = new SqlCommand(checkQuery2, connection);
            checkCommand2.Parameters.AddWithValue("@MaHeThong", maHeThong);
            int count2 = (int)checkCommand2.ExecuteScalar();

            // neu bang ghi da ton tai, thif xoa no truoc khi them bang ghi moi
            if (count2 > 0)
            {
                string deleteQuery = "DELETE FROM HeThongQuanLiCTVinFast WHERE MaHeThong = @MaHeThong";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@MaHeThong", maHeThong);
                deleteCommand.ExecuteNonQuery();
            }
            
            // Thêm bản ghi mới vào bảng HeThongQuanLiCTVinFast
            string insertHeThongQuery = "INSERT INTO HeThongQuanLiCTVinFast (MaHeThong, MaCongTy, TenChucNangHT) " +
                "VALUES (@MaHeThong, @MaCongTy, @TenChucNangHT)";
            SqlCommand insertHeThongCommand = new SqlCommand(insertHeThongQuery, connection);
            insertHeThongCommand.Parameters.AddWithValue("@MaHeThong", tb_maHT.Text);
            insertHeThongCommand.Parameters.AddWithValue("@MaCongTy", tb_macty.Text);
            insertHeThongCommand.Parameters.AddWithValue("@TenChucNangHT", tb_tenCN.Text);
            insertHeThongCommand.ExecuteNonQuery();
            loaddata1();
        }

        // lấy thông tin tự động
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tb_maNQL.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tb_maHTnql.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tb_ho.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tb_tendem.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            tb_ten.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            tb_tenHTdcql.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
        // thêm nql
        private void btn_themNQL_Click(object sender, EventArgs e)
        {
           
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO NguoiQuanLyHT VALUES (@MaNQL, @MaHeThong, @Ho, @TenDem, @Ten, @TenHeThongDuocQL, @SoDienThoai)";
            command.Parameters.AddWithValue("@MaNQL", tb_maNQL.Text);
            command.Parameters.AddWithValue("@MaHeThong", tb_maHTnql.Text);
            command.Parameters.AddWithValue("@Ho", tb_ho.Text);
            command.Parameters.AddWithValue("@TenDem", tb_tendem.Text);
            command.Parameters.AddWithValue("@Ten", tb_ten.Text);
            command.Parameters.AddWithValue("@TenHeThongDuocQL", tb_tenHTdcql.Text);
            command.Parameters.AddWithValue("@SoDienThoai", tb_sdt.Text);
           
            command.ExecuteNonQuery();
            loaddata2();  
        }

        private void btn_suaNQL_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NguoiQuanLyHT set(MaNQL = '" + tb_maNQL.Text + "',MaHeThong = '" + tb_maHTnql.Text + "',Ho = N'" + tb_ho.Text + "',TenDem = N'"+tb_ho.Text+"',Ten=N'"+tb_tendem+"',Ten=N'"+tb_ten.Text+"',TenHeThongDuocQL = N'"+tb_tenHTdcql.Text+"',SoDienThoai="+tb_sdt.Text+")";
            command.ExecuteNonQuery();
            loaddata2();
        }
        //Xóa NQL
        private void btn_xoaNQL_Click(object sender, EventArgs e)
        {
            //ket noi voi du lieu 
           
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";/* @" Data Source=LAPTOP-VNRKQGE2\SQLEXPRESS;Initial Catalog=HeThongVinFast1;Integrated Security=True";*/
            //nhan gia tri nut bam vua nhap tai bang maNQL
            string maNQL = tb_maNQL.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))// lien ket voi so duong dan csdl
            {
                connection.Open();

                string deleteQuery = "DELETE FROM NguoiQuanLyHT WHERE MaNQL = @MaNQL";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaNQL", maNQL);
                    command.ExecuteNonQuery();
                }

                loaddata2();
            }
            command = connection.CreateCommand();
            command.CommandText = "delete from NguoiQuanLyHT where MaNQL= @MaNQL";
            command.Parameters.AddWithValue("@MaNQL", tb_maNQL.Text);
            command.ExecuteNonQuery();
            loaddata2();


        }

    }
}
