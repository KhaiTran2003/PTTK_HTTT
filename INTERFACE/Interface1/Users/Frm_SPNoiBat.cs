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

namespace Interface1.Users
{
    public partial class Frm_SPNoiBat : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=DataFirst;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HangHoa";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
        }

        public Frm_SPNoiBat()
        {
            InitializeComponent();
        }

        private void Frm_SPNoiBat_Load(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string productName = text_nameProduct.Text;

            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string query = "SELECT * FROM HangHoa WHERE TenSp LIKE @TenSp";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenSp", "%" + productName + "%"); // Tìm kiếm sản phẩm chứa tên sản phẩm

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            Frm_ThanhToan frm_ThanhToan = new Frm_ThanhToan();
                            frm_ThanhToan.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm nào có tên: " + productName);
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_ThanhToan frm_ThanhToan = new Frm_ThanhToan();
            frm_ThanhToan.Show();
        }
    }
}
