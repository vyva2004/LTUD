using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BUL_SieuThiPNH
    {
        clsSieuThi clsPNH = new clsSieuThi();
        //lay ds PNH
        public DataTable GetDataFromPNH()
        {
            return clsPNH.GetDataFromPNH();
        }
        public bool ThemPNH(DAO_PNH daoPNH)
        {
            return clsPNH.ThemPNH(daoPNH);
        }
        public bool XoaPNH(DAO_PNH daoPNH)
        {
            return clsPNH.XoaPNH(daoPNH);
        }
        public bool SuaPNH(DAO_PNH daoPNH)
        {
            return clsPNH.SuaPNH(daoPNH);
        }
        public DataTable loadDSNV()
        {
            return clsPNH.loadDSNV();
        }
        public DataTable loadDSNCC() 
        {
            return clsPNH.loadDSNCC();
        }
    }
}
