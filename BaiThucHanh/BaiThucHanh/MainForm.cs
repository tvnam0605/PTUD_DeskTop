using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

      
        //click đôi vào nút chương trình sẽ tự động tạo hàm sự kiện này
        // khi ta click vào thì chương trình sẽ làm gì
        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;

            MessageBox.Show($"Xin chao ban {tenDaNhap}. rat vui duoc gap ban!", "Thông điệp chào mừng");
        }
        // ví du bên trên nhập gì thì bên dưới sao chép lại
        // hộp thoại sao chép không cho phép gõ, chỉ cho phép sao chép bên trên lại, xử lý như sau
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

      

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
