﻿using System;
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
    public partial class Frm_MAIN : Form
    {
        public Frm_MAIN()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }


        private void btn_DNDK_Click(object sender, EventArgs e)
        {
            Frm_DNDK frm_dndk = new Frm_DNDK();
            frm_dndk.Show();
        }

        private void btn_HTQL_Click(object sender, EventArgs e)
        {
            Frm_HTQL frm_htql = new Frm_HTQL();
            frm_htql.Show();
        }

        private void btn_CTY_Click(object sender, EventArgs e)
        {
            Frm_CTY frm_cty = new Frm_CTY();
            frm_cty.Show();
        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            Frm_NCC frm_ncc = new Frm_NCC();
            frm_ncc.Show();
        }

    }
}
