using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_SieuThiPX
    {
        clsSieuThi clsPX = new clsSieuThi();
        public DataTable LayDSPX()
        {
            return clsPX.LayDSPX();
        }
    }
}
