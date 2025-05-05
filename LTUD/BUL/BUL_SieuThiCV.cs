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
    public class BUL_SieuThiCV
    {
        clsSieuThi clsCV = new clsSieuThi();
        //lay ds CV
        public DataTable GetDataFromCV()
        {
            return clsCV.GetDataFromCV();
        }
        public DataTable loadDSCV()
        {
            return clsCV.loadDSCV();
        }
        public bool ThemCV(DAO_Chucvu daoCV)
        {
            return clsCV.ThemCV(daoCV); 
        }
        public bool XoaCV(DAO_Chucvu daoCV)
        {
            return clsCV.XoaCV(daoCV);
        }
        public bool SuaCV(DAO_Chucvu daoCV)
        {
            return clsCV.SuaCV(daoCV);
        }
    }
}
