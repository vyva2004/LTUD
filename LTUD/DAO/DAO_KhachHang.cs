using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private DateTime _Ngaysinh;
        private string _GioiTinh;
        private string _CMND;
        private string _SDT;
        private string _STK;

        public DAO_KhachHang(string maKH, string tenKH, DateTime ngaysinh, string gioiTinh, string cMND, string sDT, string sTK)
        {
            MaKH = maKH;
            TenKH = tenKH;
            Ngaysinh = ngaysinh;
            GioiTinh = gioiTinh;
            CMND = cMND;
            SDT = sDT;
            STK = sTK;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public DateTime Ngaysinh { get => _Ngaysinh; set => _Ngaysinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string STK { get => _STK; set => _STK = value; }
        public DAO_KhachHang() { }
    }
}
