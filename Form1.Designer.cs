namespace CSharp_ChuviDientichHTron
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
            this.lblBK = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.chkCV = new System.Windows.Forms.CheckBox();
            this.chkbDT = new System.Windows.Forms.CheckBox();
            this.btnTinhL1 = new System.Windows.Forms.Button();
            this.btnTinhL2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBK
            // 
            this.lblBK.AutoSize = true;
            this.lblBK.Location = new System.Drawing.Point(38, 41);
            this.lblBK.Name = "lblBK";
            this.lblBK.Size = new System.Drawing.Size(68, 18);
            this.lblBK.TabIndex = 0;
            this.lblBK.Text = "Bán kính ";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(38, 237);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(64, 18);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Kết quả ";
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(126, 41);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(178, 26);
            this.txtBK.TabIndex = 1;
            this.txtBK.Text = "5.5";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(126, 229);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(178, 26);
            this.txtKQ.TabIndex = 1;
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(41, 135);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(90, 36);
            this.btnCV.TabIndex = 2;
            this.btnCV.Text = "Chu vi ";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(214, 135);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(90, 36);
            this.btnDT.TabIndex = 2;
            this.btnDT.Text = "Diện tích ";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Location = new System.Drawing.Point(428, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbDT);
            this.groupBox2.Controls.Add(this.chkCV);
            this.groupBox2.Location = new System.Drawing.Point(765, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 174);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại 2";
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(7, 26);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(71, 22);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "Chu vi ";
            this.rdbCV.UseVisualStyleBackColor = true;
            this.rdbCV.CheckedChanged += new System.EventHandler(this.rdbCV_CheckedChanged);
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(7, 81);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(86, 22);
            this.rdbDT.TabIndex = 0;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "Diện tích ";
            this.rdbDT.UseVisualStyleBackColor = true;
            this.rdbDT.CheckedChanged += new System.EventHandler(this.rdbDT_CheckedChanged);
            // 
            // chkCV
            // 
            this.chkCV.AutoSize = true;
            this.chkCV.Location = new System.Drawing.Point(24, 30);
            this.chkCV.Name = "chkCV";
            this.chkCV.Size = new System.Drawing.Size(72, 22);
            this.chkCV.TabIndex = 0;
            this.chkCV.Text = "Chu vi ";
            this.chkCV.UseVisualStyleBackColor = true;
            this.chkCV.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkbDT
            // 
            this.chkbDT.AutoSize = true;
            this.chkbDT.Location = new System.Drawing.Point(24, 81);
            this.chkbDT.Name = "chkbDT";
            this.chkbDT.Size = new System.Drawing.Size(82, 22);
            this.chkbDT.TabIndex = 0;
            this.chkbDT.Text = "Diện tích";
            this.chkbDT.UseVisualStyleBackColor = true;
            // 
            // btnTinhL1
            // 
            this.btnTinhL1.Location = new System.Drawing.Point(511, 232);
            this.btnTinhL1.Name = "btnTinhL1";
            this.btnTinhL1.Size = new System.Drawing.Size(75, 23);
            this.btnTinhL1.TabIndex = 4;
            this.btnTinhL1.Text = "Tính L1";
            this.btnTinhL1.UseVisualStyleBackColor = true;
            this.btnTinhL1.Click += new System.EventHandler(this.btnTinhL1_Click);
            // 
            // btnTinhL2
            // 
            this.btnTinhL2.Location = new System.Drawing.Point(888, 237);
            this.btnTinhL2.Name = "btnTinhL2";
            this.btnTinhL2.Size = new System.Drawing.Size(75, 23);
            this.btnTinhL2.TabIndex = 4;
            this.btnTinhL2.Text = "Tính L2";
            this.btnTinhL2.UseVisualStyleBackColor = true;
            this.btnTinhL2.Click += new System.EventHandler(this.btnTinhL2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(410, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(208, 74);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 623);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTinhL2);
            this.Controls.Add(this.btnTinhL1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblBK);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBK;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbDT;
        private System.Windows.Forms.CheckBox chkCV;
        private System.Windows.Forms.Button btnTinhL1;
        private System.Windows.Forms.Button btnTinhL2;
        private System.Windows.Forms.Button btnClose;
    }
}

