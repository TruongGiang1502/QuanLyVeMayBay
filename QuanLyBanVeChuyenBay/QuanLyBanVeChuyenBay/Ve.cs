using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeChuyenBay
{
    public class Ve
    {
        String TenHK;
        String MaCB;
        String HangVe;
        String NgayBanVe;
        String GiaVe;
        String TinhTrangVe;
        public Ve() { }

        public Ve(String a, String b, String c, String d, String e)
        {
            this.TenHK = a;
            this.MaCB = b;
            this.HangVe = c;
            this.NgayBanVe = d;
            this.GiaVe = e;
        }

        public String getTenHK
        {
            get
            {
                return TenHK;
            }
        }
        public String getMaCB
        {
            get
            {
                return MaCB;
            }
        }
        public String getHangVe
        {
            get
            {
                return HangVe;
            }
        }
        public String getNgayBan
        {
            get
            {
                return NgayBanVe;
            }
        }
        public String getGiaVe
        {
            get
            {
                return GiaVe;
            }
        }
        public String getTinhTrangVe
        {
            get
            {
                return TinhTrangVe;
            }
        }
    }
}
