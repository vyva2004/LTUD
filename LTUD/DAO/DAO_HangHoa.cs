using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_HangHoa
    {
        private string _MaHH;
        private string _MaL;
        private string _TenHH;
        private string _DVT;
        private string _DG;
        private string _VAT;

        public DAO_HangHoa(string maHH, string maL, string tenHH, string dVT, string dG, string vAT)
        {
            MaHH = maHH;
            MaL = maL;
            TenHH = tenHH;
            DVT = dVT;
            DG = dG;
            VAT = vAT;
        }

        public string MaHH { get => _MaHH; set => _MaHH = value; }
        public string MaL { get => _MaL; set => _MaL = value; }
        public string TenHH { get => _TenHH; set => _TenHH = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
        public string DG { get => _DG; set => _DG = value; }
        public string VAT { get => _VAT; set => _VAT = value; }
        public DAO_HangHoa() { }
    }
}
