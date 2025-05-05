using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_SieuThiPC
    {
        clsSieuThi clsPC = new clsSieuThi();
        public DataTable LayDSPC()
        {
            return clsPC.LayDSPC();
        }
    }
}
