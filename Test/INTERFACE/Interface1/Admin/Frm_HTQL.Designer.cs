
namespace Interface1
{
    partial class Frm_HTQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_them1 = new System.Windows.Forms.Button();
            this.bt_xoa1 = new System.Windows.Forms.Button();
            this.bt_xoa2 = new System.Windows.Forms.Button();
            this.bt_them2 = new System.Windows.Forms.Button();
            this.tb_mahethong = new System.Windows.Forms.TextBox();
            this.tb_macongti = new System.Windows.Forms.TextBox();
            this.tb_tenchucnanght = new System.Windows.Forms.TextBox();
            this.tb_manql = new System.Windows.Forms.TextBox();
            this.tb_maht = new System.Windows.Forms.TextBox();
            this.tb_ho = new System.Windows.Forms.TextBox();
            this.tb_tendem = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_tenhtduocql = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_sua1 = new System.Windows.Forms.Button();
            this.bt_sua2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ CÔNG TY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các chức năng hệ thống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Người quản lý";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(15, 29);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(942, 112);
            this.dgv1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv2);
            this.groupBox2.Location = new System.Drawing.Point(6, 585);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người quản lý";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(21, 22);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(942, 128);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(6, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 22);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "MaHeThong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "MaCongTy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "TenChucNangHT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "MaNQL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "MaHT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "TenDem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ten";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(603, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "SDT";
            // 
            // bt_them1
            // 
            this.bt_them1.Location = new System.Drawing.Point(841, 113);
            this.bt_them1.Name = "bt_them1";
            this.bt_them1.Size = new System.Drawing.Size(105, 40);
            this.bt_them1.TabIndex = 18;
            this.bt_them1.Text = "Thêm";
            this.bt_them1.UseVisualStyleBackColor = true;
            this.bt_them1.Click += new System.EventHandler(this.bt_them1_Click);
            // 
            // bt_xoa1
            // 
            this.bt_xoa1.Location = new System.Drawing.Point(841, 170);
            this.bt_xoa1.Name = "bt_xoa1";
            this.bt_xoa1.Size = new System.Drawing.Size(105, 40);
            this.bt_xoa1.TabIndex = 19;
            this.bt_xoa1.Text = "Xóa";
            this.bt_xoa1.UseVisualStyleBackColor = true;
            this.bt_xoa1.Click += new System.EventHandler(this.bt_xoa1_Click);
            // 
            // bt_xoa2
            // 
            this.bt_xoa2.Location = new System.Drawing.Point(841, 536);
            this.bt_xoa2.Name = "bt_xoa2";
            this.bt_xoa2.Size = new System.Drawing.Size(105, 45);
            this.bt_xoa2.TabIndex = 20;
            this.bt_xoa2.Text = "Xóa";
            this.bt_xoa2.UseVisualStyleBackColor = true;
            this.bt_xoa2.Click += new System.EventHandler(this.bt_xoa2_Click);
            // 
            // bt_them2
            // 
            this.bt_them2.Location = new System.Drawing.Point(841, 429);
            this.bt_them2.Name = "bt_them2";
            this.bt_them2.Size = new System.Drawing.Size(105, 44);
            this.bt_them2.TabIndex = 21;
            this.bt_them2.Text = "Thêm";
            this.bt_them2.UseVisualStyleBackColor = true;
            this.bt_them2.Click += new System.EventHandler(this.bt_them2_Click);
            // 
            // tb_mahethong
            // 
            this.tb_mahethong.Location = new System.Drawing.Point(27, 143);
            this.tb_mahethong.Name = "tb_mahethong";
            this.tb_mahethong.Size = new System.Drawing.Size(149, 30);
            this.tb_mahethong.TabIndex = 22;
            // 
            // tb_macongti
            // 
            this.tb_macongti.Location = new System.Drawing.Point(306, 143);
            this.tb_macongti.Name = "tb_macongti";
            this.tb_macongti.Size = new System.Drawing.Size(156, 30);
            this.tb_macongti.TabIndex = 23;
            // 
            // tb_tenchucnanght
            // 
            this.tb_tenchucnanght.Location = new System.Drawing.Point(578, 143);
            this.tb_tenchucnanght.Name = "tb_tenchucnanght";
            this.tb_tenchucnanght.Size = new System.Drawing.Size(153, 30);
            this.tb_tenchucnanght.TabIndex = 24;
            // 
            // tb_manql
            // 
            this.tb_manql.Location = new System.Drawing.Point(138, 429);
            this.tb_manql.Name = "tb_manql";
            this.tb_manql.Size = new System.Drawing.Size(100, 30);
            this.tb_manql.TabIndex = 25;
            // 
            // tb_maht
            // 
            this.tb_maht.Location = new System.Drawing.Point(138, 489);
            this.tb_maht.Name = "tb_maht";
            this.tb_maht.Size = new System.Drawing.Size(100, 30);
            this.tb_maht.TabIndex = 26;
            // 
            // tb_ho
            // 
            this.tb_ho.Location = new System.Drawing.Point(138, 541);
            this.tb_ho.Name = "tb_ho";
            this.tb_ho.Size = new System.Drawing.Size(100, 30);
            this.tb_ho.TabIndex = 27;
            // 
            // tb_tendem
            // 
            this.tb_tendem.Location = new System.Drawing.Point(454, 429);
            this.tb_tendem.Name = "tb_tendem";
            this.tb_tendem.Size = new System.Drawing.Size(100, 30);
            this.tb_tendem.TabIndex = 28;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(454, 489);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(100, 30);
            this.tb_ten.TabIndex = 29;
            // 
            // tb_tenhtduocql
            // 
            this.tb_tenhtduocql.Location = new System.Drawing.Point(454, 546);
            this.tb_tenhtduocql.Name = "tb_tenhtduocql";
            this.tb_tenhtduocql.Size = new System.Drawing.Size(100, 30);
            this.tb_tenhtduocql.TabIndex = 30;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(696, 432);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(100, 30);
            this.tb_sdt.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "TenHTduocQL";
            // 
            // bt_sua1
            // 
            this.bt_sua1.Location = new System.Drawing.Point(841, 58);
            this.bt_sua1.Name = "bt_sua1";
            this.bt_sua1.Size = new System.Drawing.Size(105, 39);
            this.bt_sua1.TabIndex = 34;
            this.bt_sua1.Text = "Sửa";
            this.bt_sua1.UseVisualStyleBackColor = true;
            this.bt_sua1.Click += new System.EventHandler(this.bt_sua1_Click);
            // 
            // bt_sua2
            // 
            this.bt_sua2.Location = new System.Drawing.Point(841, 484);
            this.bt_sua2.Name = "bt_sua2";
            this.bt_sua2.Size = new System.Drawing.Size(105, 41);
            this.bt_sua2.TabIndex = 35;
            this.bt_sua2.Text = "Sửa";
            this.bt_sua2.UseVisualStyleBackColor = true;
            this.bt_sua2.Click += new System.EventHandler(this.bt_sua2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 124);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(27, 238);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(942, 102);
            this.dgv3.TabIndex = 0;
            this.dgv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellContentClick);
            // 
            // Frm_HTQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_sua2);
            this.Controls.Add(this.bt_sua1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_tenhtduocql);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_tendem);
            this.Controls.Add(this.tb_ho);
            this.Controls.Add(this.tb_maht);
            this.Controls.Add(this.tb_manql);
            this.Controls.Add(this.tb_tenchucnanght);
            this.Controls.Add(this.tb_macongti);
            this.Controls.Add(this.tb_mahethong);
            this.Controls.Add(this.bt_them2);
            this.Controls.Add(this.bt_xoa2);
            this.Controls.Add(this.bt_xoa1);
            this.Controls.Add(this.bt_them1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_HTQL";
            this.Text = "Frm_HTQL";
            this.Load += new System.EventHandler(this.Frm_HTQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_them1;
        private System.Windows.Forms.Button bt_xoa1;
        private System.Windows.Forms.Button bt_xoa2;
        private System.Windows.Forms.Button bt_them2;
        private System.Windows.Forms.TextBox tb_mahethong;
        private System.Windows.Forms.TextBox tb_macongti;
        private System.Windows.Forms.TextBox tb_tenchucnanght;
        private System.Windows.Forms.TextBox tb_manql;
        private System.Windows.Forms.TextBox tb_maht;
        private System.Windows.Forms.TextBox tb_ho;
        private System.Windows.Forms.TextBox tb_tendem;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_tenhtduocql;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_sua1;
        private System.Windows.Forms.Button bt_sua2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv3;
    }
}