using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_Bai3
{
    class NhanVien
    {
        public string MaNV { get; set; }

        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public float HeSoLuong { get; set; }

        public float HeSoPhuCap { get; set; }


        public NhanVien(string ma, string hoTen, DateTime ngaySinh, float heSoLuong, float heSoPhuCap)
        {
            MaNV = ma;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }
        public void TongLuong (float heSoLuong, float heSoPhuCap)
        {
            float tongLuong = (heSoLuong+heSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3},{4}", MaNV, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap);
        }
    }
}
