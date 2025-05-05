using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BUL
{
    public class BUL_SieuThiLH
    {
        //khai bao bien
        clsSieuThi clsSTLH = new clsSieuThi();
        //lay ds form LH
        public DataTable GetDataFromLH()
        {
            return clsSTLH.GetDataFromLH();
        }                
        //them lh
        public bool ThemLH(DAO_LoaiHang daoLH)
        {
            return clsSTLH.ThemLH(daoLH);
        }
        //xoa lh
        public bool XoaLH(DAO_LoaiHang daoLH)
        {
            return clsSTLH.XoaLH(daoLH);
        }
        public bool SuaLH(DAO_LoaiHang daoLH)
        {
            return clsSTLH.SuaLH(daoLH);
        }
    }
}
