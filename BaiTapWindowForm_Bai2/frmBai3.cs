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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            int n = int.Parse(txtSoN.Text);

            int s=0;
          
            if (rdNoiHoTen.Checked) 
                TuongTac.NoiChuoi(ho, ten);
            else
               TuongTac.GiaiThua(n);

            lblKetQua.Text = s.ToString();
        }
    }
}
