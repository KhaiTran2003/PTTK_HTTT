﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface1.Users;

namespace Interface1
{
    public partial class Frm_CTY : Form
    {
        public Frm_CTY()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_DNDK frm_DNDK = new Frm_DNDK();
            frm_DNDK.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_DKYuser frm_DKYuser = new Frm_DKYuser();
            frm_DKYuser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_SPNoiBat sPNoiBat = new Frm_SPNoiBat();
            sPNoiBat.Show();
        }

        private void Frm_CTY_Load(object sender, EventArgs e)
        {

        }
    }
}
