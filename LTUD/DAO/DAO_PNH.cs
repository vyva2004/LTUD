using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_PNH
    {
        private string _MaPNH;
        private string _MaNCC;
        private string _MaNV;
        private DateTime _NgayNhap;

        public DAO_PNH(string maPNH, string maNCC, string maNV, DateTime ngayNhap)
        {
            _MaPNH = maPNH;
            _MaNCC = maNCC;
            _MaNV = maNV;
            _NgayNhap = ngayNhap;
        }

        public string MaPNH { get => _MaPNH; set => _MaPNH = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public DateTime NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
        public DAO_PNH() { }
    }
}
