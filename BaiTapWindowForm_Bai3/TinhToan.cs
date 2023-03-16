using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_Bai3
{
    class TinhToan
    {

        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }
        public static void GiaiThua(int n)
        {
             int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
        }
           
    }
}
