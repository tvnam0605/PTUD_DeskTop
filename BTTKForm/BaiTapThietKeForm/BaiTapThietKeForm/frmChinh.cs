using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            frmBai1 frmBai1 = new frmBai1();
            frmBai1.MdiParent = this;
            frmBai1.Show();

        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            frmBai2 frmBai2 = new frmBai2();
            frmBai2.MdiParent = this;
            frmBai2.Show();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            frmBai3 frmBai3 = new frmBai3();
            frmBai3.MdiParent = this;
            frmBai3.Show();
        }

        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            var form = new frmBai4();
            form.ShowDialog();
        }
    }
}
