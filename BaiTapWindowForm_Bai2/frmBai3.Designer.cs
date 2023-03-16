
namespace BaiTapWindowForm_Bai2
{
    partial class frmBai3
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNoiHoTen = new System.Windows.Forms.RadioButton();
            this.rdTinhGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số n: ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(263, 31);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(156, 20);
            this.txtHo.TabIndex = 1;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(263, 59);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(156, 20);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(263, 93);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(156, 20);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhGiaiThua);
            this.groupBox1.Controls.Add(this.rdNoiHoTen);
            this.groupBox1.Location = new System.Drawing.Point(217, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán: ";
            // 
            // rdNoiHoTen
            // 
            this.rdNoiHoTen.AutoSize = true;
            this.rdNoiHoTen.Checked = true;
            this.rdNoiHoTen.Location = new System.Drawing.Point(33, 30);
            this.rdNoiHoTen.Name = "rdNoiHoTen";
            this.rdNoiHoTen.Size = new System.Drawing.Size(89, 17);
            this.rdNoiHoTen.TabIndex = 0;
            this.rdNoiHoTen.Text = "Nối họ và tên";
            this.rdNoiHoTen.UseVisualStyleBackColor = true;
            // 
            // rdTinhGiaiThua
            // 
            this.rdTinhGiaiThua.AutoSize = true;
            this.rdTinhGiaiThua.Location = new System.Drawing.Point(33, 63);
            this.rdTinhGiaiThua.Name = "rdTinhGiaiThua";
            this.rdTinhGiaiThua.Size = new System.Drawing.Size(114, 17);
            this.rdTinhGiaiThua.TabIndex = 0;
            this.rdTinhGiaiThua.Text = "Tính giai thừa số n";
            this.rdTinhGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(248, 244);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(156, 28);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(303, 289);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(10, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhGiaiThua;
        private System.Windows.Forms.RadioButton rdNoiHoTen;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}