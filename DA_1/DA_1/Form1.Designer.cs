namespace DA_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtđiaiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btntinhtoan = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtthoigian = new System.Windows.Forms.TextBox();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(17, 14);
            this.plotView1.Margin = new System.Windows.Forms.Padding(5);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(975, 688);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plotView1.Click += new System.EventHandler(this.plotView1_Click);
            this.plotView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plotView1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1003, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa điểm đến:";
            // 
            // txtđiaiem
            // 
            this.txtđiaiem.Location = new System.Drawing.Point(1159, 31);
            this.txtđiaiem.Name = "txtđiaiem";
            this.txtđiaiem.Size = new System.Drawing.Size(297, 35);
            this.txtđiaiem.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(1008, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 253);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ma trận trọng số:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(438, 219);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbLog);
            this.groupBox2.Location = new System.Drawing.Point(1011, 633);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(6, 28);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(426, 197);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthem.Location = new System.Drawing.Point(1122, 267);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 43);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoa.Location = new System.Drawing.Point(1296, 267);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 43);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btntinhtoan
            // 
            this.btntinhtoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntinhtoan.ImageOptions.Image")));
            this.btntinhtoan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btntinhtoan.Location = new System.Drawing.Point(1180, 594);
            this.btntinhtoan.Name = "btntinhtoan";
            this.btntinhtoan.Size = new System.Drawing.Size(93, 43);
            this.btntinhtoan.TabIndex = 12;
            this.btntinhtoan.Text = "Tính toán";
            this.btntinhtoan.Click += new System.EventHandler(this.btntinhtoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1004, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(1032, 75);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 35);
            this.txtx.TabIndex = 14;
            this.txtx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1148, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y";
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(1174, 78);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(100, 35);
            this.txty.TabIndex = 14;
            this.txty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1291, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time";
            // 
            // txtthoigian
            // 
            this.txtthoigian.Location = new System.Drawing.Point(1356, 75);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.Size = new System.Drawing.Size(100, 35);
            this.txtthoigian.TabIndex = 14;
            this.txtthoigian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txty_KeyPress);
            // 
            // dt_from
            // 
            this.dt_from.Checked = false;
            this.dt_from.CustomFormat = "HH:mm";
            this.dt_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_from.Location = new System.Drawing.Point(1246, 133);
            this.dt_from.Name = "dt_from";
            this.dt_from.ShowCheckBox = true;
            this.dt_from.Size = new System.Drawing.Size(210, 35);
            this.dt_from.TabIndex = 16;
            this.dt_from.Value = new System.DateTime(2019, 12, 5, 15, 43, 33, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1006, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Thời gian bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1006, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thời gian địa điểm đến";
            // 
            // dt_to
            // 
            this.dt_to.Checked = false;
            this.dt_to.CustomFormat = "HH:mm";
            this.dt_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_to.Location = new System.Drawing.Point(1246, 203);
            this.dt_to.Name = "dt_to";
            this.dt_to.ShowCheckBox = true;
            this.dt_to.Size = new System.Drawing.Size(210, 35);
            this.dt_to.TabIndex = 19;
            this.dt_to.Value = new System.DateTime(2019, 12, 5, 16, 43, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 888);
            this.Controls.Add(this.dt_to);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_from);
            this.Controls.Add(this.txtthoigian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntinhtoan);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtđiaiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plotView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtđiaiem;
       // private DevExpress.XtraEditors.SimpleButton btnthem;
        //private DevExpress.XtraEditors.SimpleButton btnxoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbLog;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btntinhtoan;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtthoigian;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_to;
    }
}

