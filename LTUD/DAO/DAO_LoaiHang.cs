using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LoaiHang
    {
        private string _Maloai;
        private string _Tenloai;

        public DAO_LoaiHang(string maloai, string tenloai)
        {
            Maloai = maloai;
            Tenloai = tenloai;
        }

        public string Maloai
        {
            get => _Maloai;
            set => _Maloai = value;
        }
        public string Tenloai
        {
            get => _Tenloai;
            set => _Tenloai = value;
        }
        public DAO_LoaiHang() { }

    }
}
