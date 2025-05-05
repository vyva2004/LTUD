using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Phieuchi
    {
        private string _SoPC;
        private string _MaPN;
        private string _TenNC;
        private DateTime _NgayChi;
        private string _STC;
        private string _STBC;
        private string _GC;

        public DAO_Phieuchi(string soPC, string maPN, string tenNC, DateTime ngayChi, string sTC, string sTBC, string gC)
        {
            _SoPC = soPC;
            _MaPN = maPN;
            _TenNC = tenNC;
            _NgayChi = ngayChi;
            _STC = sTC;
            _STBC = sTBC;
            _GC = gC;
        }

        public string SoPC { get => _SoPC; set => _SoPC = value; }
        public string MaPN { get => _MaPN; set => _MaPN = value; }
        public string TenNC { get => _TenNC; set => _TenNC = value; }
        public DateTime NgayChi { get => _NgayChi; set => _NgayChi = value; }
        public string STC { get => _STC; set => _STC = value; }
        public string STBC { get => _STBC; set => _STBC = value; }
        public string GC { get => _GC; set => _GC = value; }
        public DAO_Phieuchi() { }
    }
}
