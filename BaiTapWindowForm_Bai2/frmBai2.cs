using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_Bai2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtS1.Text);
            int b = int.Parse(txtS2.Text);
            int s = 0;

            if (rdCong.Checked)

                TinhToan.Cong(a, b, ref s);

            else if (rdTru.Checked)
                TinhToan.Tru(a, b, ref s);
            else if (rdNhan.Checked)
                TinhToan.Nhan(a, b, ref s);
            else
                TinhToan.Chia(a, b, ref s);

            // hiển thị

            lblKetQua.Text = s.ToString();
            

        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }
    }
}
