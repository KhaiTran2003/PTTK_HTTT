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

        //SqlConnection connection;
        //SqlCommand command;
        //string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataTable table = new DataTable();

        //void loaddata()
        //{
        //    command = connection.CreateCommand();
        //    command.CommandText = "select * from KhachHang";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    dgv.DataSource = table;

        //}

        public Frm_DKY()
        {
            InitializeComponent();
        }

        private void btn_exitDKY_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DKY_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(str);
            //connection.Open();
            //loaddata();
        }

        
    }
}
