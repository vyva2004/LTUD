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
    public class BUL_SieuThiHH
    {
        clsSieuThi clsHH = new clsSieuThi();
        //lay ds form HH
        public DataTable GetDataFromHH()
        {
            return clsHH.GetDataFromHH();
        }
        //them hh
        public bool ThemHH(DAO_HangHoa daohh)
        {
            return clsHH.ThemHH(daohh);
        }
        public bool XoaHH(DAO_HangHoa daoHH)
        {
            return clsHH.XoaHH(daoHH);
        }
        public bool SuaHH(DAO_HangHoa daoHH)
        {
            return clsHH.SuaHH(daoHH);
        }
        public DataTable LoadDSLH()
        {
            return clsHH.loadDSLH();
        }
    }
}
