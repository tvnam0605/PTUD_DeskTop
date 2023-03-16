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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("TB001", "Chuột", "Việt Nam", 20000, 5);

            lblThongBao.Text = tb.HienThi();
        }
    }
}
