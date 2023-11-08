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
        string str = @"Data Source=MINHDAT\\MINHDAT;Initial Catalog=VinFast;Integrated Security=True";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HTQL_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
            loaddata2();
        }
        //Mã hệ thống
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Mã công ty
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Tên chức năng
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
