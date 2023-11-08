
namespace Interface1
{
    partial class Frm_DNDK
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
            this.lb_DN = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_mk = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_mk = new System.Windows.Forms.TextBox();
            this.btn_dn = new System.Windows.Forms.Button();
            this.linklb_dky = new System.Windows.Forms.LinkLabel();
            this.linklb_cty = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_DN
            // 
            this.lb_DN.AutoSize = true;
            this.lb_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DN.Location = new System.Drawing.Point(198, 45);
            this.lb_DN.Name = "lb_DN";
            this.lb_DN.Size = new System.Drawing.Size(392, 39);
            this.lb_DN.TabIndex = 0;
            this.lb_DN.Text = "ĐĂNG NHẬP/ ĐĂNG KÝ";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(31, 134);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(132, 25);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Số điện thoại:";
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk.Location = new System.Drawing.Point(31, 200);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(99, 25);
            this.lb_mk.TabIndex = 2;
            this.lb_mk.Text = "Mật khẩu:";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(240, 136);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(308, 22);
            this.text_name.TabIndex = 3;
            // 
            // text_mk
            // 
            this.text_mk.Location = new System.Drawing.Point(240, 200);
            this.text_mk.Name = "text_mk";
            this.text_mk.Size = new System.Drawing.Size(308, 22);
            this.text_mk.TabIndex = 4;
            // 
            // btn_dn
            // 
            this.btn_dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dn.Location = new System.Drawing.Point(182, 250);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(111, 41);
            this.btn_dn.TabIndex = 5;
            this.btn_dn.Text = "Đăng nhập";
            this.btn_dn.UseVisualStyleBackColor = true;
            // 
            // linklb_dky
            // 
            this.linklb_dky.AutoSize = true;
            this.linklb_dky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_dky.Location = new System.Drawing.Point(511, 341);
            this.linklb_dky.Name = "linklb_dky";
            this.linklb_dky.Size = new System.Drawing.Size(152, 20);
            this.linklb_dky.TabIndex = 6;
            this.linklb_dky.TabStop = true;
            this.linklb_dky.Text = "Chưa có tài khoản?";
            this.linklb_dky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_dky_LinkClicked);
            // 
            // linklb_cty
            // 
            this.linklb_cty.AutoSize = true;
            this.linklb_cty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_cty.Location = new System.Drawing.Point(134, 341);
            this.linklb_cty.Name = "linklb_cty";
            this.linklb_cty.Size = new System.Drawing.Size(145, 20);
            this.linklb_cty.TabIndex = 8;
            this.linklb_cty.TabStop = true;
            this.linklb_cty.Text = "Quay về trang chủ";
            this.linklb_cty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_cty_LinkClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(490, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_DNDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linklb_cty);
            this.Controls.Add(this.linklb_dky);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.text_mk);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_DN);
            this.Name = "Frm_DNDK";
            this.Text = "Frm_DNDK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DN;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_mk;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.LinkLabel linklb_dky;
        private System.Windows.Forms.LinkLabel linklb_cty;
        private System.Windows.Forms.Button button2;
    }
}