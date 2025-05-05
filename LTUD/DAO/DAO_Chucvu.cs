using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Chucvu
    {
        private string _MaCV;
        private string _TenCV;

        public DAO_Chucvu(string maCV, string tenCV)
        {
            _MaCV = maCV;
            _TenCV = tenCV;
        }

        public string MaCV { get => _MaCV; set => _MaCV = value; }
        public string TenCV { get => _TenCV; set => _TenCV = value; }
        public DAO_Chucvu() { } 
    }
}
