
namespace BaiTapWindowForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.rdTongN = new System.Windows.Forms.RadioButton();
            this.btnXemKq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số n:";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(206, 39);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(121, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.Text = "0";
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(206, 74);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(121, 20);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.Text = "0";
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(206, 111);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(121, 20);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.Text = "0";
            this.txtSoN.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongN);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Location = new System.Drawing.Point(182, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán:";
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Checked = true;
            this.rdTongAB.Location = new System.Drawing.Point(20, 27);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(99, 17);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.Text = "Tính tổng a + b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            // 
            // rdTongN
            // 
            this.rdTongN.AutoSize = true;
            this.rdTongN.Location = new System.Drawing.Point(20, 63);
            this.rdTongN.Name = "rdTongN";
            this.rdTongN.Size = new System.Drawing.Size(83, 17);
            this.rdTongN.TabIndex = 0;
            this.rdTongN.Text = "Tính tổng N";
            this.rdTongN.UseVisualStyleBackColor = true;
            this.rdTongN.CheckedChanged += new System.EventHandler(this.rdTongN_CheckedChanged);
            // 
            // btnXemKq
            // 
            this.btnXemKq.Location = new System.Drawing.Point(195, 280);
            this.btnXemKq.Name = "btnXemKq";
            this.btnXemKq.Size = new System.Drawing.Size(131, 27);
            this.btnXemKq.TabIndex = 3;
            this.btnXemKq.Text = "Xem kết quả";
            this.btnXemKq.UseVisualStyleBackColor = true;
            this.btnXemKq.Click += new System.EventHandler(this.btnXemKq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(265, 318);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongN;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.Button btnXemKq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}