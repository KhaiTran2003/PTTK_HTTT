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
    public partial class Frm_DNuser: Form
    {
        public Frm_DNuser()
        {
            InitializeComponent();
        }

        private void linklb_dky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DKYuser frm_dky = new Frm_DKYuser();
            frm_dky.Show();
        }

        private void linklb_cty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_userMAIN frm_main = new Frm_userMAIN();
            frm_main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DNuser_Load(object sender, EventArgs e)
        {

        }
    }
}
