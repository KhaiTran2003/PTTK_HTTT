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
        //string str = @"Data Source=LAPTOP-VNRKQGE2\SQLEXPRESS;Initial Catalog=HeThongVinFast;Integrated Security=True";
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
            dgv2.DataSource = table;
        }

        public Frm_HTQL()
        {
            InitializeComponent();
        }

        private void Frm_HTQL_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
            loaddata2();
        }
       

        // phan bang chi tiet
        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* tb_mahethong.ReadOnly = true;*/// phan ma he thong chi cho xem, khong duoc xoa tai phan sua, xoa
            int i;
            i = dgv3.CurrentRow.Index;
            tb_mahethong.Text = dgv3.Rows[i].Cells[0].Value.ToString();
            tb_macongti.Text = dgv3.Rows[i].Cells[1].Value.ToString();
            tb_tenchucnanght.Text = dgv3.Rows[i].Cells[2].Value.ToString();
        }


        private void bt_sua1_Click(object sender, EventArgs e)
        {
             command = connection.CreateCommand();
            //command.CommandText = "update HeThongQuanLiCTVinFast set MaHeThong= '"+ tb_mahethong.Text + "', MaCongTy= '" + tb_macongti.Text + "', TenChucNangHT = N'" + tb_tenchucnanght.Text + "' ";
            //command.ExecuteNonQuery();
            //loaddata1();
            command = connection.CreateCommand();
            command.CommandText = "update HeThongQuanLiCTVinFast set MaCongTy= @MaCongTy, TenChucNangHT = @TenChucNangHT where MaHeThong= @MaHeThong";
            command.Parameters.AddWithValue("@MaCongTy", tb_macongti.Text);
            command.Parameters.AddWithValue("@TenChucNangHT", tb_tenchucnanght.Text);
            command.Parameters.AddWithValue("@MaHeThong", tb_mahethong.Text);
            command.ExecuteNonQuery();
            loaddata1();
        }
        private void bt_them1_Click(object sender, EventArgs e)
        {
            //kiem tra ma cong ti do co ton tai khong
            string maCongTi = "CT001";
            string checkQuery = "SELECT COUNT(*) FROM CongTiVinFast WHERE MaCongTi = @MaCongTi";
            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("@MaCongTi", maCongTi);
            int count = (int)checkCommand.ExecuteScalar();

            // Nếu giá trị không tồn tại, thêm giá trị mới vào bảng "CongTiVinFast"
            if (count == 0)
            {
                string insertCongTiQuery = "INSERT INTO CongTiVinFast (MaCongTi, SoDienThoaiCT, DiaDiemCT) " +
                    "VALUES (@MaCongTi, @SoDienThoaiCT, @DiaDiemCT)";
                SqlCommand insertCongTiCommand = new SqlCommand(insertCongTiQuery, connection);
                insertCongTiCommand.Parameters.AddWithValue("@MaCongTi", maCongTi);
                insertCongTiCommand.Parameters.AddWithValue("@SoDienThoaiCT", "0123456789");
                insertCongTiCommand.Parameters.AddWithValue("@DiaDiemCT", "Địa điểm công ty");

                insertCongTiCommand.ExecuteNonQuery();
            }
            //kiem tra bang ghi da ton tai
            string checkQuery2 = "SELECT COUNT(*) FROM HeThongQuanLiCTVinFast WHERE MaHeThong = @MaHeThong";
            SqlCommand checkCommand2 = new SqlCommand(checkQuery, connection);
            checkCommand.Parameters.AddWithValue("@MaHeThong", "HT001");
            int count2 = (int)checkCommand.ExecuteScalar();

            // Nếu bản ghi đã tồn tại, xóa nó trước khi thêm bản ghi mới
            if (count2 > 0)
            {
                string deleteQuery = "DELETE FROM HeThongQuanLiCTVinFast WHERE MaHeThong = @MaHeThong";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@MaHeThong", "HT001");
                deleteCommand.ExecuteNonQuery();
            }
            //string maCongTi = "CT001";
            //string checkQuery = "SELECT COUNT(*) FROM CongTiVinFast WHERE MaCongTi = @MaCongTi";
            //SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
            //checkCommand.Parameters.AddWithValue("@MaCongTi", maCongTi);
            //int count = (int)checkCommand.ExecuteScalar();

            //// Nếu giá trị không tồn tại, hiển thị thông báo lỗi hoặc thực hiện xử lý tương ứng
            //if (count == 0)
            //{
            //    MessageBox.Show("Giá trị 'MaCongTi' không tồn tại trong bảng 'CongTiVinFast'.");
            //    return;
            //}



            //command = connection.CreateCommand();
            //command.CommandText = "insert into HeThongQuanLiCTVinFast values('"+tb_mahethong.Text+"', '"+tb_macongti.Text + "', '"+tb_tenchucnanght.Text+"')";
            //command.ExecuteNonQuery();
            //loaddata1();
            command = connection.CreateCommand();
            command.CommandText = "insert into HeThongQuanLiCTVinFast values(@MaHeThong, @MaCongTy, @TenChucNangHT)";
            command.Parameters.AddWithValue("@MaHeThong", tb_mahethong.Text);
            command.Parameters.AddWithValue("@MaCongTy", tb_macongti.Text);
            command.Parameters.AddWithValue("@TenChucNangHT", tb_tenchucnanght.Text);
             command.ExecuteNonQuery();
            loaddata1();
        }

        private void bt_xoa1_Click(object sender, EventArgs e)
        {
            //xoa bang ghi co tham chieu den o day la bang KHACH HANG
            string deleteKhachHangQuery = "DELETE FROM KhachHang WHERE MaHeThong = @MaHeThong";
            SqlCommand deleteKhachHangCommand = new SqlCommand(deleteKhachHangQuery, connection);
            deleteKhachHangCommand.Parameters.AddWithValue("@MaHeThong", tb_mahethong.Text);
            deleteKhachHangCommand.ExecuteNonQuery();
            //xoa bang ghi co tham chieu den o day la bang NGUOI QUAN LI
            string deleteNguoiQuanLyQuery = "DELETE FROM NguoiQuanLyHT WHERE MaHeThong = @MaHeThong";
            SqlCommand deleteNguoiQuanLyCommand = new SqlCommand(deleteNguoiQuanLyQuery, connection);
            deleteNguoiQuanLyCommand.Parameters.AddWithValue("@MaHeThong", tb_mahethong.Text);
            deleteNguoiQuanLyCommand.ExecuteNonQuery();
            //command = connection.CreateCommand();
            //command.CommandText = "delete from HeThongQuanLiCTVinFast where MaHeThong= '"+tb_mahethong.Text+"' ";
            //command.ExecuteNonQuery();
            //loaddata1();
            command = connection.CreateCommand();
            command.CommandText = "delete from HeThongQuanLiCTVinFast where MaHeThong= @MaHeThong";
            command.Parameters.AddWithValue("@MaHeThong", tb_mahethong.Text);
            command.ExecuteNonQuery();
            loaddata1();
        }
        



        //phan nguoi quan li
        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* tb_manql.ReadOnly = true;*/// phan ma nguoi quan li chi cho xem, khong duoc xoa tai phan sua, xoa
            int i;
            i = dgv2.CurrentRow.Index;
            tb_manql.Text = dgv2.Rows[i].Cells[0].Value.ToString();
            tb_maht.Text = dgv2.Rows[i].Cells[1].Value.ToString();
            tb_ho.Text = dgv2.Rows[i].Cells[2].Value.ToString();
            tb_tendem.Text = dgv2.Rows[i].Cells[3].Value.ToString();
            tb_ten.Text = dgv2.Rows[i].Cells[4].Value.ToString();
            tb_tenhtduocql.Text = dgv2.Rows[i].Cells[5].Value.ToString();
            tb_sdt.Text = dgv2.Rows[i].Cells[6].Value.ToString();
        }

        private void bt_them2_Click(object sender, EventArgs e)// phan them tai phan nguoi quan li
        {

            //command = connection.CreateCommand();
            //command.CommandText = "insert into NguoiQuanLyHT values('" + tb_manql.Text + "', '" + tb_maht.Text + "', '" + tb_ho.Text + "' , '" + tb_tendem.Text + "' , '" + tb_ten.Text + "' , '" + tb_tenhtduocql.Text + "' , '" + tb_sdt.Text + "')";
            //command.ExecuteNonQuery();
            //loaddata2();
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO NguoiQuanLyHT VALUES (@MaNQL, @MaHeThong, @Ho, @TenDem, @Ten, @TenHeThongDuocQL, @SoDienThoai)";
            command.Parameters.AddWithValue("@MaNQL", tb_manql.Text);
            command.Parameters.AddWithValue("@MaHeThong", tb_maht.Text);
            command.Parameters.AddWithValue("@Ho", tb_ho.Text);
            command.Parameters.AddWithValue("@TenDem", tb_tendem.Text);
            command.Parameters.AddWithValue("@Ten", tb_ten.Text);
            command.Parameters.AddWithValue("@TenHeThongDuocQL", tb_tenhtduocql.Text);
            command.Parameters.AddWithValue("@SoDienThoai", tb_sdt.Text);
            command.ExecuteNonQuery();
            loaddata2();
        }



        private void bt_sua2_Click(object sender, EventArgs e)// phan sua tai phan nguoi quan li
        {
            //command = connection.CreateCommand();
            //command.CommandText = "update NguoiQuanLyHT set MaNQL='" + tb_manql.Text + "', MaHeThong= '" + tb_maht.Text + "', HoNQL='" + tb_ho.Text + "' , TenDemNQL='" + tb_tendem.Text + "' , TenNQL='" + tb_ten.Text + "' , TenHeThongDuocQL='" + tb_tenhtduocql.Text + "' , SoDienThoaiNQL='" + tb_sdt.Text + "' ";
            //command.ExecuteNonQuery();
            //loaddata2();
            command = connection.CreateCommand();
            command.CommandText = "update NguoiQuanLyHT set MaHeThong= @MaHeThong, Ho= @Ho, TenDem= @TenDem, Ten= @Ten, TenHeThongDuocQL= @TenHeThongDuocQL, SoDienThoai= @SoDienThoai where MaNQL= @MaNQL";
            command.Parameters.AddWithValue("@MaHeThong", tb_maht.Text);
            command.Parameters.AddWithValue("@Ho", tb_ho.Text);
            command.Parameters.AddWithValue("@TenDem", tb_tendem.Text);
            command.Parameters.AddWithValue("@Ten", tb_ten.Text);
            command.Parameters.AddWithValue("@TenHeThongDuocQL", tb_tenhtduocql.Text);
            command.Parameters.AddWithValue("@SoDienThoai", tb_sdt.Text);
            command.Parameters.AddWithValue("@MaNQL", tb_manql.Text);
            command.ExecuteNonQuery();
            loaddata2();
        }


        private void bt_xoa2_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "delete from NguoiQuanLyHT where MaNQL= '" + tb_manql.Text + "' ";
            //command.ExecuteNonQuery();
            //loaddata2();
            command = connection.CreateCommand();
            command.CommandText = "delete from NguoiQuanLyHT where MaNQL= @MaNQL";
            command.Parameters.AddWithValue("@MaNQL", tb_manql.Text);
            command.ExecuteNonQuery();
            loaddata2();
        }

        
    }
}
