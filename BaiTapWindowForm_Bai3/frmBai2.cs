using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_Bai3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            
            int n = int.Parse(txtSoN.Text);
            int kq=0;
            

            if (rdTinhTongN.Checked)
                kq = TinhToan.TongDaySo(n);
            else
              TinhToan.GiaiThua(n);


            lblHienThiKQ.Text = kq.ToString();
            
        }
    }
}
