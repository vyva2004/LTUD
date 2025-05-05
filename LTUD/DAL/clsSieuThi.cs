using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace DAL
{
    public class clsSieuThi
    {
        //khai bao bien
        HandleDB db = new HandleDB();
        //lay dsloaihang
        public DataTable GetDataFromLH()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "sp_LayDSLoaiHang";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        //them LH
        public bool ThemLH(DAO_LoaiHang dalLH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemLoaiHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MALOAI", dalLH.Maloai));
                cmd.Parameters.Add(new SqlParameter("@TENLOAI", dalLH.Tenloai));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi!!" + ex.Message);
            }

            return false;
        }
        //xoa LH
        public bool XoaLH(DAO_LoaiHang dalLH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoaLoaiHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MALOAI", dalLH.Maloai));
                if (cmd.ExecuteNonQuery() >= 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi!!" + ex.Message);
            }
            return false;
        }
        //Sua loai hang
        public bool SuaLH(DAO_LoaiHang daoLH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaLoaiHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MALOAI", daoLH.Maloai));
                cmd.Parameters.Add(new SqlParameter("@TENLOAI", daoLH.Tenloai));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi!!" + ex.Message);
            }

            return false;
        }
        //lay dsNCC
        public DataTable GetDataFromNCC()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "sp_LayDSNhaCungCap";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        //Them NCC
        public bool ThemNCC(DAO_Nhacungcap daoNCC)
        {
            try
            {
                bool Flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemNhaCungCap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", daoNCC.Mancc));
                cmd.Parameters.Add(new SqlParameter("@TENNCC", daoNCC.Tenncc));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", daoNCC.Diachi));
                cmd.Parameters.Add(new SqlParameter("@SDT", daoNCC.SDT));
                cmd.Parameters.Add(new SqlParameter("@MASOTHUE", daoNCC.MSThue));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Flag = true;
                }
                return Flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!!" + ex.Message);
            }
            return false;
        }
        //xoa NCC
        public bool XoaNCC(DAO_Nhacungcap daoNCC)
        {
            try
            {
                bool Flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoaNhaCungCap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", daoNCC.Mancc));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Flag = true;
                }
                return Flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!!" + ex.Message);
            }
            return false;
        }
        //Sua NCC
        public bool SuaNCC(DAO_Nhacungcap daoNCC)
        {
            try
            {
                bool Flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaNhaCungCap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANCC", daoNCC.Mancc));
                cmd.Parameters.Add(new SqlParameter("@TENNCC", daoNCC.Tenncc));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", daoNCC.Diachi));
                cmd.Parameters.Add(new SqlParameter("@SDT", daoNCC.SDT));
                cmd.Parameters.Add(new SqlParameter("@MASOTHUE", daoNCC.MSThue));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Flag = true;
                }
                return Flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!!" + ex.Message);
            }
            return false;
        }
        //lay dsKH
        public DataTable GetDataFromKH()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "sp_LayDSKhachHang";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        //them kh
        public bool ThemKH(DAO_KhachHang daoKH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemKhachHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAKH", daoKH.MaKH));
                cmd.Parameters.Add(new SqlParameter("@TENKH", daoKH.TenKH));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", daoKH.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", daoKH.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CMND", daoKH.CMND));
                cmd.Parameters.Add(new SqlParameter("@SDT", daoKH.SDT));
                cmd.Parameters.Add(new SqlParameter("@STK", daoKH.STK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!" + ex.Message);
            }
            return false;
        }
        //xoa KH
        public bool XoaKH(DAO_KhachHang daoKH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoaKhachhang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAKH", daoKH.MaKH));              
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!" + ex.Message);
            }
            return false;
        }
        //Sua KH
        public bool SuaKH(DAO_KhachHang daoKH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaKhachHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAKH", daoKH.MaKH));
                cmd.Parameters.Add(new SqlParameter("@TENKH", daoKH.TenKH));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", daoKH.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", daoKH.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CMND", daoKH.CMND));
                cmd.Parameters.Add(new SqlParameter("@SDT", daoKH.SDT));
                cmd.Parameters.Add(new SqlParameter("@STK", daoKH.STK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!" + ex.Message);
            }
            return false;
        }
        //lay dsHH
        public DataTable GetDataFromHH()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "sp_LayDSHangHoa";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        //them hh
        public bool ThemHH(DAO_HangHoa daoHH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemHangHoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAHH", daoHH.MaHH));
                cmd.Parameters.Add(new SqlParameter("@MALOAI", daoHH.MaL));
                cmd.Parameters.Add(new SqlParameter("@TENHH", daoHH.TenHH));
                cmd.Parameters.Add(new SqlParameter("@DVT", daoHH.DVT));
                cmd.Parameters.Add(new SqlParameter("@DONGIA", daoHH.DG));
                cmd.Parameters.Add(new SqlParameter("@VAT", daoHH.VAT));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //Xoa HH
        public bool XoaHH(DAO_HangHoa daoHH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoaHangHoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAHH", daoHH.MaHH));             
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //Sua HH
        public bool SuaHH(DAO_HangHoa daoHH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaHangHoa";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAHH", daoHH.MaHH));
                cmd.Parameters.Add(new SqlParameter("@MALOAI", daoHH.MaL));
                cmd.Parameters.Add(new SqlParameter("@TENHH", daoHH.TenHH));
                cmd.Parameters.Add(new SqlParameter("@DVT", daoHH.DVT));
                cmd.Parameters.Add(new SqlParameter("@DONGIA", daoHH.DG));
                cmd.Parameters.Add(new SqlParameter("@VAT", daoHH.VAT));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //lay dsCV
        public DataTable GetDataFromCV()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "sp_LayDSChucVu";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        // them CV
        public bool ThemCV(DAO_Chucvu daoCV)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemChucVu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MACV", daoCV.MaCV));
                cmd.Parameters.Add(new SqlParameter("@TENCV", daoCV.TenCV));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //xoa CV
        public bool XoaCV(DAO_Chucvu daoCV)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoaChucVu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MACV", daoCV.MaCV));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //Sua CV
        public bool SuaCV(DAO_Chucvu daoCV)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaChucVu";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MACV", daoCV.MaCV));
                cmd.Parameters.Add(new SqlParameter("@TENCV", daoCV.TenCV));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //lay dsnhanvien
        public DataTable GetDataFromNV()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "sp_LayDSNhanVien";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        //them nv
        public bool ThemNV(DAO_NhanVien daoNV)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANV", daoNV.MaNV));
                cmd.Parameters.Add(new SqlParameter("@MACV", daoNV.MaCV));
                cmd.Parameters.Add(new SqlParameter("@TENNV", daoNV.TenNV));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", daoNV.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", daoNV.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", daoNV.SDT));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", daoNV.DiaChi));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!!" + ex.Message);
            }
            return false;
        }
        //Xoa NV
        public bool XoaNV(DAO_NhanVien daoNV)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoanhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANV", daoNV.MaNV));              
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!!" + ex.Message);
            }
            return false;
        }
        //Sua NV
        public bool SuaNV(DAO_NhanVien daoNV)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MANV", daoNV.MaNV));
                cmd.Parameters.Add(new SqlParameter("@MACV", daoNV.MaCV));
                cmd.Parameters.Add(new SqlParameter("@TENNV", daoNV.TenNV));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", daoNV.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", daoNV.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", daoNV.SDT));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", daoNV.DiaChi));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!!" + ex.Message);
            }
            return false;
        }

        //lay dsPNH
        public DataTable GetDataFromPNH()
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.Connection = db.connection;
            sqlcm.CommandText = "LayDSPhieuNhapHang";
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(dt);
            return dt;
        }
        //Them PNH
        public bool ThemPNH(DAO_PNH daoPNH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "ThemPhieuNhapHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPHIEUNHAP", daoPNH.MaPNH));
                cmd.Parameters.Add(new SqlParameter("@MANCC", daoPNH.MaNCC));
                cmd.Parameters.Add(new SqlParameter("@MANV", daoPNH.MaNV));
                cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", daoPNH.NgayNhap));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //Xoa PNH
        public bool XoaPNH(DAO_PNH daoPNH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "XoaPhieuNhapHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPHIEUNHAP", daoPNH.MaPNH));               
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        //Sua PNH
        public bool SuaPNH(DAO_PNH daoPNH)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "SuaPhieuNhapHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPHIEUNHAP", daoPNH.MaPNH));
                cmd.Parameters.Add(new SqlParameter("@MANCC", daoPNH.MaNCC));
                cmd.Parameters.Add(new SqlParameter("@MANV", daoPNH.MaNV));
                cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", daoPNH.NgayNhap));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        public DataTable loadDSCV()
        {
            SqlCommand cmd = new SqlCommand("LayDSChucVu", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable loadDSLH()
        {
            SqlCommand cmd = new SqlCommand("LayDSLoaiHang", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable loadDSPN()
        {
            SqlCommand cmd = new SqlCommand("LayDSPhieuNhap", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable loadDSNV()
        {
            SqlCommand cmd = new SqlCommand("LayDSNhanVien", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable loadDSNCC()
        {
            SqlCommand cmd = new SqlCommand("LayDSNCC", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        //lay ds phieu chi
            public DataTable LayDSPC()
            {
                SqlCommand cmd = new SqlCommand("sp_LayDSPhieuChi", db.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        //lay ds phieu xuat
        public DataTable LayDSPX()
        {
            SqlCommand cmd = new SqlCommand("sp_LayDSPhieuXuat", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        //lay ds CTPN
        public DataTable LayDSCTPN()
        {
            SqlCommand cmd = new SqlCommand("sp_LayDSChiTietPhieuNhap", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool ThemCTPN(DAO_Chitietphieunhap daoCTPN)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_ThemChiTietPhieuNhap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPHIEUNHAP", daoCTPN.MaCTPN));
                cmd.Parameters.Add(new SqlParameter("@MAHH", daoCTPN.MaHH));
                cmd.Parameters.Add(new SqlParameter("@GIANHAP", daoCTPN.GiaNhap));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGNHAP", daoCTPN.SL));
                cmd.Parameters.Add(new SqlParameter("@THANHTIEN", daoCTPN.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@CHIETKHAU", daoCTPN.ChietKhau));
                cmd.Parameters.Add(new SqlParameter("@TONGTIEN", daoCTPN.TongTien));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!" + ex.Message);
            }
            return false;
        }
        public bool XoaCTPN(DAO_Chitietphieunhap daCTPN)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_XoaChiTietPhieuNhap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPHIEUNHAP", daCTPN.MaCTPN));
                if (cmd.ExecuteNonQuery() >= 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi!!" + ex.Message);
            }
            return false;
        }
        public bool SuaCTPN(DAO_Chitietphieunhap daoCTPN)
        {
            try
            {
                bool flag = false;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.connection;
                cmd.CommandText = "sp_SuaChiTietPhieuNhap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAPHIEUNHAP", daoCTPN.MaCTPN));
                cmd.Parameters.Add(new SqlParameter("@MAHH", daoCTPN.MaHH));
                cmd.Parameters.Add(new SqlParameter("@GIANHAP", daoCTPN.GiaNhap));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGNHAP", daoCTPN.SL));
                cmd.Parameters.Add(new SqlParameter("@THANHTIEN", daoCTPN.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@CHIETKHAU", daoCTPN.ChietKhau));
                cmd.Parameters.Add(new SqlParameter("@TONGTIEN", daoCTPN.TongTien));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi!!" + ex.Message);
            }

            return false;
        }
    }
}
