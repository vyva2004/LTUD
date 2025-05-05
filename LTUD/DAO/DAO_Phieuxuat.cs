using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Phieuxuat
    {
        private string _MaPhieuXuat;
        private string _MaKH;
        private string _MaNV;
        private string _NgayXuat;

        public DAO_Phieuxuat(string maPhieuXuat, string maKH, string maNV, string ngayXuat)
        {
            _MaPhieuXuat = maPhieuXuat;
            _MaKH = maKH;
            _MaNV = maNV;
            _NgayXuat = ngayXuat;
        }

        public string MaPhieuXuat { get => _MaPhieuXuat; set => _MaPhieuXuat = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string NgayXuat { get => _NgayXuat; set => _NgayXuat = value; }
        public DAO_Phieuxuat() { }
    }
}
