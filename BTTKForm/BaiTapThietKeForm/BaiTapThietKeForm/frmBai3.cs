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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);


            // Quay lại ô nhập đầu sau khi nhấn nhập
            txtTuMoi.Focus();
            // ô từ mới sẽ được làm trống
            txtTuMoi.Text = "";
            //ô nghĩa từ sẽ được làm trống
            txtNghia.Text = "";
            listBox1.SelectedIndex = listBox1.Items.Count - 1;//
            txtHienThiNghia.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;

            txtHienThiNghia.Text = list[stt];
        }
    }
}
