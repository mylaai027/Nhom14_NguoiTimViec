namespace Form_Client
{
    partial class Form1
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
            this.thanhvien = new System.Windows.Forms.Label();
            this.nhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Detai = new System.Windows.Forms.TextBox();
            this.NetTCPBinding = new System.Windows.Forms.Button();
            this.WSHttpBinding = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BasicHttpBinding = new System.Windows.Forms.Button();
            this.loi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thanhvien
            // 
            this.thanhvien.AutoSize = true;
            this.thanhvien.Location = new System.Drawing.Point(12, 116);
            this.thanhvien.Name = "thanhvien";
            this.thanhvien.Size = new System.Drawing.Size(96, 13);
            this.thanhvien.TabIndex = 0;
            this.thanhvien.Text = "Thành Viên Nhóm:";
            // 
            // nhom
            // 
            this.nhom.Location = new System.Drawing.Point(28, 142);
            this.nhom.Multiline = true;
            this.nhom.Name = "nhom";
            this.nhom.Size = new System.Drawing.Size(202, 100);
            this.nhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đề Tài:";
            // 
            // Detai
            // 
            this.Detai.Location = new System.Drawing.Point(28, 69);
            this.Detai.Multiline = true;
            this.Detai.Name = "Detai";
            this.Detai.Size = new System.Drawing.Size(202, 31);
            this.Detai.TabIndex = 4;
            // 
            // NetTCPBinding
            // 
            this.NetTCPBinding.Location = new System.Drawing.Point(12, 12);
            this.NetTCPBinding.Name = "NetTCPBinding";
            this.NetTCPBinding.Size = new System.Drawing.Size(91, 23);
            this.NetTCPBinding.TabIndex = 5;
            this.NetTCPBinding.Text = "NetTCPBinding";
            this.NetTCPBinding.UseVisualStyleBackColor = true;
            this.NetTCPBinding.Click += new System.EventHandler(this.NetTCPBinding_Click);
            // 
            // WSHttpBinding
            // 
            this.WSHttpBinding.Location = new System.Drawing.Point(109, 12);
            this.WSHttpBinding.Name = "WSHttpBinding";
            this.WSHttpBinding.Size = new System.Drawing.Size(97, 23);
            this.WSHttpBinding.TabIndex = 6;
            this.WSHttpBinding.Text = "WSHttpBinding";
            this.WSHttpBinding.UseVisualStyleBackColor = true;
            this.WSHttpBinding.Click += new System.EventHandler(this.WSHttpBinding_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // BasicHttpBinding
            // 
            this.BasicHttpBinding.Location = new System.Drawing.Point(234, 12);
            this.BasicHttpBinding.Name = "BasicHttpBinding";
            this.BasicHttpBinding.Size = new System.Drawing.Size(96, 23);
            this.BasicHttpBinding.TabIndex = 8;
            this.BasicHttpBinding.Text = "BasicHttpBinding";
            this.BasicHttpBinding.UseVisualStyleBackColor = true;
            this.BasicHttpBinding.Click += new System.EventHandler(this.BasicHttpBinding_Click);
            // 
            // loi
            // 
            this.loi.AutoSize = true;
            this.loi.Location = new System.Drawing.Point(171, 52);
            this.loi.Name = "loi";
            this.loi.Size = new System.Drawing.Size(35, 13);
            this.loi.TabIndex = 9;
            this.loi.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 243);
            this.Controls.Add(this.loi);
            this.Controls.Add(this.BasicHttpBinding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WSHttpBinding);
            this.Controls.Add(this.NetTCPBinding);
            this.Controls.Add(this.Detai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nhom);
            this.Controls.Add(this.thanhvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thanhvien;
        private System.Windows.Forms.TextBox nhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Detai;
        private System.Windows.Forms.Button NetTCPBinding;
        private System.Windows.Forms.Button WSHttpBinding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BasicHttpBinding;
        private System.Windows.Forms.Label loi;
    }
}

