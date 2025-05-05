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
    public class BUL_SieuThiCTPN
    {
        clsSieuThi clsCTPN = new clsSieuThi();
        public DataTable LaydsCTPN()
        {
            return clsCTPN.LayDSCTPN();
        }
        public DataTable loadDSLH()
        {
            return clsCTPN.loadDSLH();
        }
        public bool ThemCTPN(DAO_Chitietphieunhap daoCTPN)
        {
            return clsCTPN.ThemCTPN(daoCTPN);
        }
        public bool XoaCTPN(DAO_Chitietphieunhap daoCTPN)
        {
            return clsCTPN.XoaCTPN(daoCTPN);
        }
        public bool SuaCTPN(DAO_Chitietphieunhap daoCTPN)
        {
            return clsCTPN.SuaCTPN(daoCTPN);
        }
    }
}
