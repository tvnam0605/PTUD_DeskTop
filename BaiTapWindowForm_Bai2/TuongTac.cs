using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_Bai2
{
    class TuongTac
    {
        public static void NoiChuoi( string ho, string ten)
        {
            string s = ho + " "+ ten;
        }
        public static long GiaiThua(int n)
        {
            int giaiThua=0;
            for (int i =1; i < n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
