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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2003, 6, 5);
            NhanVien nv = new NhanVien("NV01", "Trần Văn Nam", dt, 10, 5);


            lblHienThi.Text = nv.HienThi();
        }
    }
}
