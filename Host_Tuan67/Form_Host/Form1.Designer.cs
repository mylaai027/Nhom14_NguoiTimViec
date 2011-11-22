namespace Form_Host
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
            this.baseaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mex = new System.Windows.Forms.CheckBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_EndPoints1 = new System.Windows.Forms.CheckBox();
            this.NetTCPBinding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contract1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_NetTCPBinding = new System.Windows.Forms.TextBox();
            this.tb_WSHttpBinding = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contract2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.binding_txt2 = new System.Windows.Forms.TextBox();
            this.cb_Endpoint2 = new System.Windows.Forms.CheckBox();
            this.tb_BasicHttpBinding = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contract3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.binding_txt3 = new System.Windows.Forms.TextBox();
            this.cb_Endpoint3 = new System.Windows.Forms.CheckBox();
            this.thongbao = new System.Windows.Forms.Label();
            this.batloi = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // baseaddress
            // 
            this.baseaddress.Location = new System.Drawing.Point(91, 12);
            this.baseaddress.Name = "baseaddress";
            this.baseaddress.Size = new System.Drawing.Size(189, 20);
            this.baseaddress.TabIndex = 0;
            this.baseaddress.Text = "localhost:8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base Address";
            // 
            // mex
            // 
            this.mex.AutoSize = true;
            this.mex.Checked = true;
            this.mex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mex.Location = new System.Drawing.Point(16, 38);
            this.mex.Name = "mex";
            this.mex.Size = new System.Drawing.Size(79, 17);
            this.mex.TabIndex = 3;
            this.mex.Text = "Show MEX";
            this.mex.UseVisualStyleBackColor = true;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(286, 43);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 4;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(381, 43);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 5;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(474, 43);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Save Config";
            this.save.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "End points";
            // 
            // cb_EndPoints1
            // 
            this.cb_EndPoints1.AutoSize = true;
            this.cb_EndPoints1.Location = new System.Drawing.Point(19, 79);
            this.cb_EndPoints1.Name = "cb_EndPoints1";
            this.cb_EndPoints1.Size = new System.Drawing.Size(38, 17);
            this.cb_EndPoints1.TabIndex = 8;
            this.cb_EndPoints1.Text = "1. ";
            this.cb_EndPoints1.UseVisualStyleBackColor = true;
            // 
            // NetTCPBinding
            // 
            this.NetTCPBinding.Location = new System.Drawing.Point(99, 79);
            this.NetTCPBinding.Name = "NetTCPBinding";
            this.NetTCPBinding.Size = new System.Drawing.Size(127, 20);
            this.NetTCPBinding.TabIndex = 9;
            this.NetTCPBinding.Text = "NetTCPBinding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contract";
            // 
            // contract1
            // 
            this.contract1.Location = new System.Drawing.Point(286, 76);
            this.contract1.Name = "contract1";
            this.contract1.Size = new System.Drawing.Size(100, 20);
            this.contract1.TabIndex = 11;
            this.contract1.Text = "NetTCP_ITimViec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // tb_NetTCPBinding
            // 
            this.tb_NetTCPBinding.Location = new System.Drawing.Point(449, 76);
            this.tb_NetTCPBinding.Name = "tb_NetTCPBinding";
            this.tb_NetTCPBinding.Size = new System.Drawing.Size(100, 20);
            this.tb_NetTCPBinding.TabIndex = 13;
            this.tb_NetTCPBinding.Text = "NetTCPBinding";
            // 
            // tb_WSHttpBinding
            // 
            this.tb_WSHttpBinding.Location = new System.Drawing.Point(449, 102);
            this.tb_WSHttpBinding.Name = "tb_WSHttpBinding";
            this.tb_WSHttpBinding.Size = new System.Drawing.Size(100, 20);
            this.tb_WSHttpBinding.TabIndex = 19;
            this.tb_WSHttpBinding.Text = "WSHttpBinding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address";
            // 
            // contract2
            // 
            this.contract2.Location = new System.Drawing.Point(286, 102);
            this.contract2.Name = "contract2";
            this.contract2.Size = new System.Drawing.Size(100, 20);
            this.contract2.TabIndex = 17;
            this.contract2.Text = "WSHttp_ITimViec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contract";
            // 
            // binding_txt2
            // 
            this.binding_txt2.Location = new System.Drawing.Point(99, 105);
            this.binding_txt2.Name = "binding_txt2";
            this.binding_txt2.Size = new System.Drawing.Size(127, 20);
            this.binding_txt2.TabIndex = 15;
            this.binding_txt2.Text = "WSHttpBinding";
            // 
            // cb_Endpoint2
            // 
            this.cb_Endpoint2.AutoSize = true;
            this.cb_Endpoint2.Location = new System.Drawing.Point(19, 105);
            this.cb_Endpoint2.Name = "cb_Endpoint2";
            this.cb_Endpoint2.Size = new System.Drawing.Size(38, 17);
            this.cb_Endpoint2.TabIndex = 14;
            this.cb_Endpoint2.Text = "2. ";
            this.cb_Endpoint2.UseVisualStyleBackColor = true;
            // 
            // tb_BasicHttpBinding
            // 
            this.tb_BasicHttpBinding.Location = new System.Drawing.Point(449, 128);
            this.tb_BasicHttpBinding.Name = "tb_BasicHttpBinding";
            this.tb_BasicHttpBinding.Size = new System.Drawing.Size(100, 20);
            this.tb_BasicHttpBinding.TabIndex = 25;
            this.tb_BasicHttpBinding.Text = "BasicHttpBinding";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Address";
            // 
            // contract3
            // 
            this.contract3.Location = new System.Drawing.Point(286, 128);
            this.contract3.Name = "contract3";
            this.contract3.Size = new System.Drawing.Size(100, 20);
            this.contract3.TabIndex = 23;
            this.contract3.Text = "BasicHttp_ITimViec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Contract";
            // 
            // binding_txt3
            // 
            this.binding_txt3.Location = new System.Drawing.Point(99, 131);
            this.binding_txt3.Name = "binding_txt3";
            this.binding_txt3.Size = new System.Drawing.Size(127, 20);
            this.binding_txt3.TabIndex = 21;
            this.binding_txt3.Text = "BasicHttpBinding";
            // 
            // cb_Endpoint3
            // 
            this.cb_Endpoint3.AutoSize = true;
            this.cb_Endpoint3.Location = new System.Drawing.Point(19, 131);
            this.cb_Endpoint3.Name = "cb_Endpoint3";
            this.cb_Endpoint3.Size = new System.Drawing.Size(38, 17);
            this.cb_Endpoint3.TabIndex = 20;
            this.cb_Endpoint3.Text = "3. ";
            this.cb_Endpoint3.UseVisualStyleBackColor = true;
            // 
            // thongbao
            // 
            this.thongbao.AutoSize = true;
            this.thongbao.Location = new System.Drawing.Point(19, 162);
            this.thongbao.Name = "thongbao";
            this.thongbao.Size = new System.Drawing.Size(0, 13);
            this.thongbao.TabIndex = 26;
            // 
            // batloi
            // 
            this.batloi.AutoSize = true;
            this.batloi.Location = new System.Drawing.Point(309, 162);
            this.batloi.Name = "batloi";
            this.batloi.Size = new System.Drawing.Size(0, 13);
            this.batloi.TabIndex = 27;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(287, 12);
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(262, 20);
            this.tb.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 187);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.batloi);
            this.Controls.Add(this.thongbao);
            this.Controls.Add(this.tb_BasicHttpBinding);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contract3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.binding_txt3);
            this.Controls.Add(this.cb_Endpoint3);
            this.Controls.Add(this.tb_WSHttpBinding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contract2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.binding_txt2);
            this.Controls.Add(this.cb_Endpoint2);
            this.Controls.Add(this.tb_NetTCPBinding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contract1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NetTCPBinding);
            this.Controls.Add(this.cb_EndPoints1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.mex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseaddress);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mex;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_EndPoints1;
        private System.Windows.Forms.TextBox NetTCPBinding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contract1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_NetTCPBinding;
        private System.Windows.Forms.TextBox tb_WSHttpBinding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contract2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox binding_txt2;
        private System.Windows.Forms.CheckBox cb_Endpoint2;
        private System.Windows.Forms.TextBox tb_BasicHttpBinding;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contract3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox binding_txt3;
        private System.Windows.Forms.CheckBox cb_Endpoint3;
        private System.Windows.Forms.Label thongbao;
        private System.Windows.Forms.Label batloi;
        private System.Windows.Forms.TextBox tb;
    }
}

