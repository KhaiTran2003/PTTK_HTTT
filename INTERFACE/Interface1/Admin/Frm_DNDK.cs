using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface1
{
    public partial class Frm_DNDK : Form
    {
        public Frm_DNDK()
        {
            InitializeComponent();
        }

        private void linklb_dky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DKY frm_dky = new Frm_DKY();
            frm_dky.Show();
        }

        private void linklb_cty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_MAIN frm_main = new Frm_MAIN();
            frm_main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
