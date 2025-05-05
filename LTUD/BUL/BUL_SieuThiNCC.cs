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
    public class BUL_SieuThiNCC
    {
        clsSieuThi clsNCC = new clsSieuThi();
        //lay ds form NCC
        public DataTable GetDataFromNCC()
        {
            return clsNCC.GetDataFromNCC();
        }
        public bool ThemNCC(DAO_Nhacungcap daoNCC)
        {
            return clsNCC.ThemNCC(daoNCC);
        }
        public bool XoaNCC(DAO_Nhacungcap daoNCC)
        {
            return clsNCC.XoaNCC(daoNCC);
        }
        public bool SuaNCC(DAO_Nhacungcap daoNCC)
        {
            return clsNCC.SuaNCC(daoNCC);
        }
    }
}
