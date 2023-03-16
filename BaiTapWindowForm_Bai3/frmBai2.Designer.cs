
namespace BaiTapWindowForm_Bai3
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
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhTongN = new System.Windows.Forms.RadioButton();
            this.rdTinhNGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHienThiKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số nguyên dương N:";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(364, 17);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(165, 20);
            this.txtSoN.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhNGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTongN);
            this.groupBox1.Location = new System.Drawing.Point(283, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc:";
            // 
            // rdTinhTongN
            // 
            this.rdTinhTongN.AutoSize = true;
            this.rdTinhTongN.Location = new System.Drawing.Point(27, 31);
            this.rdTinhTongN.Name = "rdTinhTongN";
            this.rdTinhTongN.Size = new System.Drawing.Size(122, 17);
            this.rdTinhTongN.TabIndex = 0;
            this.rdTinhTongN.Text = "Tính tổng 1+2+...+N";
            this.rdTinhTongN.UseVisualStyleBackColor = true;
            // 
            // rdTinhNGiaiThua
            // 
            this.rdTinhNGiaiThua.AutoSize = true;
            this.rdTinhNGiaiThua.Checked = true;
            this.rdTinhNGiaiThua.Location = new System.Drawing.Point(27, 63);
            this.rdTinhNGiaiThua.Name = "rdTinhNGiaiThua";
            this.rdTinhNGiaiThua.Size = new System.Drawing.Size(102, 17);
            this.rdTinhNGiaiThua.TabIndex = 0;
            this.rdTinhNGiaiThua.TabStop = true;
            this.rdTinhNGiaiThua.Text = "Tính N giai thừa";
            this.rdTinhNGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(314, 224);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(151, 40);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem Kết Quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả là: ";
            // 
            // lblHienThiKQ
            // 
            this.lblHienThiKQ.AutoSize = true;
            this.lblHienThiKQ.Location = new System.Drawing.Point(395, 278);
            this.lblHienThiKQ.Name = "lblHienThiKQ";
            this.lblHienThiKQ.Size = new System.Drawing.Size(10, 13);
            this.lblHienThiKQ.TabIndex = 4;
            this.lblHienThiKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHienThiKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhNGiaiThua;
        private System.Windows.Forms.RadioButton rdTinhTongN;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHienThiKQ;
    }
}