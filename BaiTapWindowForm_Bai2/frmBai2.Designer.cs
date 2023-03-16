
namespace BaiTapWindowForm_Bai2
{
    partial class frmBai2
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
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ hai:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(251, 28);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(131, 20);
            this.txtS1.TabIndex = 1;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(251, 66);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(131, 20);
            this.txtS2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(237, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(17, 21);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(50, 17);
            this.rdCong.TabIndex = 0;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            this.rdCong.CheckedChanged += new System.EventHandler(this.rdCong_CheckedChanged);
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Checked = true;
            this.rdTru.Location = new System.Drawing.Point(17, 44);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(41, 17);
            this.rdTru.TabIndex = 0;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            this.rdTru.CheckedChanged += new System.EventHandler(this.rdCong_CheckedChanged);
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(17, 67);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(51, 17);
            this.rdNhan.TabIndex = 0;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            this.rdNhan.CheckedChanged += new System.EventHandler(this.rdCong_CheckedChanged);
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(17, 90);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(46, 17);
            this.rdChia.TabIndex = 0;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            this.rdChia.CheckedChanged += new System.EventHandler(this.rdCong_CheckedChanged);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(235, 249);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(145, 33);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả là:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(324, 296);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(10, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = ".";
            this.lblKetQua.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}