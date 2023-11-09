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

        public Frm_HTQL()
        {
            InitializeComponent();
        }
        //xóa CN
        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HeThongQuanLiCTVinFast where('" + tb_maHT.Text + "','" + tb_macty.Text + "',N'" + tb_tenCN.Text + "')";
            command.ExecuteNonQuery();
            loaddata1();
        }
        //Xóa NQL
        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NguoiQuanLyHT where(MaNQL = '" + tb_maNQL.Text + "',MaHeThong = '" + tb_maHTnql.Text + "',Ho = N'" + tb_ho.Text + "',TenDem = N'" + tb_ho.Text + "',Ten=N'" + tb_tendem + "',Ten=N'" + tb_ten.Text + "',TenHeThongDuocQL = N'" + tb_tenHTdcql.Text + "',SoDienThoai=" + tb_sdt.Text + ")";
            command.ExecuteNonQuery();
            loaddata2();
        }
        //hiển thị database
        private void Frm_HTQL_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
            connection = new SqlConnection(str);
            connection.Open();
            loaddata2();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv3.CurrentRow.Index;
            tb_maHT.Text = dgv3.Rows[i].Cells[0].Value.ToString();
            tb_macty.Text = dgv3.Rows[i].Cells[1].Value.ToString();
            tb_tenCN.Text = dgv3.Rows[i].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tb_maNQL.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tb_maHTnql.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tb_ho.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tb_tendem.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tb_ten.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            tb_tenHTdcql.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void btn_suaCN_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HeThongQuanLiCTVinFast set(MaHeThong = '" + tb_maHT.Text + "',MaCongTy = '" + tb_macty.Text + "',TenChucNangHT = N'" + tb_tenCN.Text + "')";
            command.ExecuteNonQuery();
            loaddata1();
        }

        private void btn_themCN_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HeThongQuanLiCTVinFast values('"+tb_maHT.Text+"','"+tb_macty.Text+"',N'"+tb_tenCN.Text+"')";
            command.ExecuteNonQuery();
        }

        private void btn_themNQL_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NguoiQuanLyHT values(MaNQL = '" + tb_maNQL.Text + "',MaHeThong = '" + tb_maHTnql.Text + "',Ho = N'" + tb_ho.Text + "',TenDem = N'" + tb_ho.Text + "',Ten=N'" + tb_tendem + "',Ten=N'" + tb_ten.Text + "',TenHeThongDuocQL = N'" + tb_tenHTdcql.Text + "',SoDienThoai=" + tb_sdt.Text + ")";
            command.ExecuteNonQuery();
        }

        private void btn_suaNQL_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NguoiQuanLyHT set(MaNQL = '" + tb_maNQL.Text + "',MaHeThong = '" + tb_maHTnql.Text + "',Ho = N'" + tb_ho.Text + "',TenDem = N'"+tb_ho.Text+"',Ten=N'"+tb_tendem+"',Ten=N'"+tb_ten.Text+"',TenHeThongDuocQL = N'"+tb_tenHTdcql.Text+"',SoDienThoai="+tb_sdt.Text+")";
            command.ExecuteNonQuery();
            loaddata2();
        }
    }
}
