using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface1.Users
{
    public partial class Frm_ThanhToan : Form
    {
        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Tính tiền
        private void button3_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            if (float.TryParse(tb_sodu.Text, out float sodu) && float.TryParse(tb_gia.Text, out float gia))
            {
                // Kiểm tra nếu số dư lớn hơn hoặc bằng giá
                if (sodu >= gia)
                {
                    MessageBox.Show("Thanh toán thành công.");
                }
                else
                {
                    MessageBox.Show("Số dư không đủ để thanh toán.");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập số thực trong các ô.");
            }

        }
    }
}
