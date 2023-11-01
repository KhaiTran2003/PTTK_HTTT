
namespace Interface1
{
    partial class Frm_MAIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DNDK = new System.Windows.Forms.Button();
            this.btn_HTQL = new System.Windows.Forms.Button();
            this.btn_CTY = new System.Windows.Forms.Button();
            this.btn_NCC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_DNDK = new System.Windows.Forms.Label();
            this.lb_HTQL = new System.Windows.Forms.Label();
            this.lb_CTY = new System.Windows.Forms.Label();
            this.lb_NCC = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 108);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRANG CHỦ HỆ THỐNG CÔNG TY VINFAST";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 35);
            this.panel3.TabIndex = 3;
            // 
            // btn_DNDK
            // 
            this.btn_DNDK.Location = new System.Drawing.Point(672, 201);
            this.btn_DNDK.Name = "btn_DNDK";
            this.btn_DNDK.Size = new System.Drawing.Size(140, 45);
            this.btn_DNDK.TabIndex = 7;
            this.btn_DNDK.Text = "Đăng nhập/ Đăng ký";
            this.btn_DNDK.Click += new System.EventHandler(this.btn_DNDK_Click);
            // 
            // btn_HTQL
            // 
            this.btn_HTQL.Location = new System.Drawing.Point(672, 331);
            this.btn_HTQL.Name = "btn_HTQL";
            this.btn_HTQL.Size = new System.Drawing.Size(140, 45);
            this.btn_HTQL.TabIndex = 4;
            this.btn_HTQL.Text = "Chi tiết quản lý ";
            this.btn_HTQL.UseVisualStyleBackColor = true;
            this.btn_HTQL.Click += new System.EventHandler(this.btn_HTQL_Click);
            // 
            // btn_CTY
            // 
            this.btn_CTY.Location = new System.Drawing.Point(672, 467);
            this.btn_CTY.Name = "btn_CTY";
            this.btn_CTY.Size = new System.Drawing.Size(140, 45);
            this.btn_CTY.TabIndex = 4;
            this.btn_CTY.Text = "Trang chủ";
            this.btn_CTY.UseVisualStyleBackColor = true;
            this.btn_CTY.Click += new System.EventHandler(this.btn_CTY_Click);
            // 
            // btn_NCC
            // 
            this.btn_NCC.Location = new System.Drawing.Point(672, 601);
            this.btn_NCC.Name = "btn_NCC";
            this.btn_NCC.Size = new System.Drawing.Size(140, 45);
            this.btn_NCC.TabIndex = 4;
            this.btn_NCC.Text = "Chi tiết";
            this.btn_NCC.UseVisualStyleBackColor = true;
            this.btn_NCC.Click += new System.EventHandler(this.btn_NCC_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aquamarine;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 682);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 71);
            this.panel4.TabIndex = 6;
            // 
            // lb_DNDK
            // 
            this.lb_DNDK.AutoSize = true;
            this.lb_DNDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DNDK.Location = new System.Drawing.Point(50, 217);
            this.lb_DNDK.Name = "lb_DNDK";
            this.lb_DNDK.Size = new System.Drawing.Size(228, 29);
            this.lb_DNDK.TabIndex = 8;
            this.lb_DNDK.Text = "Đăng nhập/ Đăng ký";
            // 
            // lb_HTQL
            // 
            this.lb_HTQL.AutoSize = true;
            this.lb_HTQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HTQL.Location = new System.Drawing.Point(50, 347);
            this.lb_HTQL.Name = "lb_HTQL";
            this.lb_HTQL.Size = new System.Drawing.Size(192, 29);
            this.lb_HTQL.TabIndex = 13;
            this.lb_HTQL.Text = "Hệ thống quản lý";
            // 
            // lb_CTY
            // 
            this.lb_CTY.AutoSize = true;
            this.lb_CTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CTY.Location = new System.Drawing.Point(50, 483);
            this.lb_CTY.Name = "lb_CTY";
            this.lb_CTY.Size = new System.Drawing.Size(115, 29);
            this.lb_CTY.TabIndex = 14;
            this.lb_CTY.Text = "Giới thiệu";
            // 
            // lb_NCC
            // 
            this.lb_NCC.AutoSize = true;
            this.lb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NCC.Location = new System.Drawing.Point(50, 601);
            this.lb_NCC.Name = "lb_NCC";
            this.lb_NCC.Size = new System.Drawing.Size(160, 29);
            this.lb_NCC.TabIndex = 15;
            this.lb_NCC.Text = "Nhà cung cấp";
            // 
            // Frm_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lb_NCC);
            this.Controls.Add(this.lb_CTY);
            this.Controls.Add(this.lb_HTQL);
            this.Controls.Add(this.lb_DNDK);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_NCC);
            this.Controls.Add(this.btn_CTY);
            this.Controls.Add(this.btn_HTQL);
            this.Controls.Add(this.btn_DNDK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MAIN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_DNDK;
        private System.Windows.Forms.Button btn_HTQL;
        private System.Windows.Forms.Button btn_CTY;
        private System.Windows.Forms.Button btn_NCC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_DNDK;
        private System.Windows.Forms.Label lb_HTQL;
        private System.Windows.Forms.Label lb_CTY;
        private System.Windows.Forms.Label lb_NCC;
    }
}

