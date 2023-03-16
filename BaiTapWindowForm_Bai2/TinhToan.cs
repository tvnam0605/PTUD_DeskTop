using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_Bai2
{
    class TinhToan
    {
        public static void Cong(int a, int b, ref int kq)
        {
            kq = a + b;
        }
        public static void Tru(int a, int b, ref int kq)
        {
            kq = a - b;
        }
        public static void Nhan(int a, int b, ref int kq)
        {
            kq = a * b;
        }
        public static void Chia(int a, int b, ref int kq)
        {
            kq = a / b;
        }
    }
}
