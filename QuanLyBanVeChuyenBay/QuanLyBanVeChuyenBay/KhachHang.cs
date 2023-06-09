using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeChuyenBay
{
    class KhachHang
    {
        String TenKH;
        String CMND;
        String SDT;
        String email;
        String NgaySinh;

        public KhachHang()
        {
        }

        public KhachHang(String a, String b, String c, String d, String e)
        {
            this.TenKH = a;
            this.CMND = b;
            this.SDT = c;
            this.email = d;
            this.NgaySinh = e;
        }

        public String getTenKH
        {
            get
            {
                return TenKH;
            }
        }
        public String getCMND
        {
            get
            {
                return CMND;
            }
        }
        public String getSDT
        {
            get
            {
                return SDT;
            }
        }
        public String getEmail
        {
            get
            {
                return email;
            }
        }
        public String getNgaySinh
        {
            get
            {
                return NgaySinh;
            }
        }
    }
}
