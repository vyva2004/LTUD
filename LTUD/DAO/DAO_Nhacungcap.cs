using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Nhacungcap
    {
        private string _Mancc;
        private string _Tenncc;
        private string _Diachi;
        private string _SDT;
        private string _MSThue;

        public DAO_Nhacungcap(string mancc, string tenncc, string diachi, string sDT, string mSThue)
        {
            Mancc = mancc;
            Tenncc = tenncc;
            Diachi = diachi;
            SDT = sDT;
            MSThue = mSThue;
        }

        public string Mancc { get => _Mancc; set => _Mancc = value; }
        public string Tenncc { get => _Tenncc; set => _Tenncc = value; }
        public string Diachi { get => _Diachi; set => _Diachi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string MSThue { get => _MSThue; set => _MSThue = value; }

        public DAO_Nhacungcap() { }
    }
}
