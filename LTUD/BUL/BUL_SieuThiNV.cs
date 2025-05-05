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
    public class BUL_SieuThiNV
    {
        clsSieuThi clsNV = new clsSieuThi();
        public DataTable GetDataFromNV()
        {
            return clsNV.GetDataFromNV();
        }
        public DataTable loadDSCV()
        {
            return clsNV.loadDSCV();
        }
        //them nv
        public bool ThemNV(DAO_NhanVien daoNV)
        {
            return clsNV.ThemNV(daoNV);
        }
        public bool XoaNV(DAO_NhanVien daoNV)
        {
            return clsNV.XoaNV(daoNV);
        }
        public bool SuaNV(DAO_NhanVien dAO_NhanVien)
        {
            return clsNV.SuaNV(dAO_NhanVien);
        }
    }
}
