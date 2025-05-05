using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Chitietphieunhap
    {
        private string _MaCTPN;
        private string _MaHH;
        private string _GiaNhap;
        private string _SL;
        private string _ThanhTien;
        private string _ChietKhau;
        private string _TongTien;  

        public DAO_Chitietphieunhap(string maCTPN, string maHH, string giaNhap, string sL, string thanhTien, string chietKhau, string tongTien)
        {
            _MaCTPN = maCTPN;
            _MaHH = maHH;
            _GiaNhap = giaNhap;
            _SL = sL;
            _ThanhTien = thanhTien;
            _ChietKhau = chietKhau;
            _TongTien = tongTien;
        }

        public string MaCTPN { get => _MaCTPN; set => _MaCTPN = value; }
        public string MaHH { get => _MaHH; set => _MaHH = value; }
        public string GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
        public string SL { get => _SL; set => _SL = value; }
        public string ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public string ChietKhau { get => _ChietKhau; set => _ChietKhau = value; }
        public string TongTien { get => _TongTien; set => _TongTien = value; }

        public DAO_Chitietphieunhap() { }
    }
}
