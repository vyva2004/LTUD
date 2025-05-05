using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_NhanVien
    {
        private string _MaNV;
        private string _MaCV;
        private string _TenNV;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _SDT;
        private string _DiaChi;

        public DAO_NhanVien(string maNV, string maCV, string tenNV, string gioiTinh, DateTime ngaySinh, string sDT, string diaChi)
        {
            _MaNV = maNV;
            _MaCV = maCV;
            _TenNV = tenNV;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _SDT = sDT;
            _DiaChi = diaChi;
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaCV { get => _MaCV; set => _MaCV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public DAO_NhanVien() { }
    }
}
