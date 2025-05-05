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
    public class BUL_SIeuThiKH
    {
        clsSieuThi clsKH = new clsSieuThi();
        public DataTable GetDataFormKH()
        {
            return clsKH.GetDataFromKH();
        }
        public bool ThemKH(DAO_KhachHang daoKH)
        {
            return clsKH.ThemKH(daoKH);
        }
        public bool XoaKH(DAO_KhachHang daoKH)
        {
            return clsKH.XoaKH(daoKH);
        }
        public bool SuaKH(DAO_KhachHang daoKH)
        {
            return clsKH.SuaKH(daoKH);
        }
    }
}
