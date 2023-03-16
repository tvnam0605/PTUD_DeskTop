using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_Bai2
{
    class ThietBi
    {
        public string MaTB { get; set; }
        public string TenTB { get; set; }
        public string NuocSX { get; set; }
       
        public int DonGia { get; set; }

        public int SoLuong { get; set; }

        public ThietBi(string ma, string ten, string nuoc, int gia, int sl)
        {
            MaTB = ma;
            TenTB = ten;
            NuocSX = nuoc;
            DonGia = gia;
            SoLuong = sl;

        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaTB, TenTB, NuocSX, DonGia,SoLuong);
        }
        public void ThanhTien()
            
        {
            int thanhtien;
            thanhtien = DonGia * SoLuong;
            

        }    
    }
}
