using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUL;

namespace WindowsFormsApp1
{
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Khachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        BUL_SIeuThiKH bul_stKH = new BUL_SIeuThiKH();
        DAO_KhachHang dao_KH = new DAO_KhachHang();
        private void Khachhang_Load(object sender, EventArgs e)
        {
            dgv_danhsachkhachhang.DataSource = bul_stKH.GetDataFormKH();
        }

        private void dgv_danhsachkhachhang_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachkhachhang.CurrentCell.RowIndex;
            txt_makhachhang.Text = dgv_danhsachkhachhang.Rows[row].Cells[0].Value.ToString().Trim();
            txt_tenkhachhang.Text = dgv_danhsachkhachhang.Rows[row].Cells[1].Value.ToString().Trim();
            dtp_ngaysinh.Text = dgv_danhsachkhachhang.Rows[row].Cells[2].Value.ToString();
            if (dgv_danhsachkhachhang.Rows[row].Cells[3].Value.ToString().Trim() == "nam")
            {
                rdo_nam.Checked = true;
            }
            else
            {
                rdo_nu.Checked = true;
            }
            txt_socccd.Text = dgv_danhsachkhachhang.Rows[row].Cells[4].Value.ToString().Trim();
            txt_sdt.Text = dgv_danhsachkhachhang.Rows[row].Cells[5].Value.ToString().Trim();
            txt_stk.Text = dgv_danhsachkhachhang.Rows[row].Cells[6].Value.ToString().Trim();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_KH.MaKH = txt_makhachhang.Text;
            dao_KH.TenKH = txt_tenkhachhang.Text;
            dao_KH.Ngaysinh = DateTime.Parse(dtp_ngaysinh.Text.ToString());
            dao_KH.GioiTinh = rdo_nam.Checked ? "nam" : "nu";
            dao_KH.CMND = txt_socccd.Text;
            dao_KH.SDT = txt_sdt.Text;
            dao_KH.STK = txt_stk.Text;
            if (bul_stKH.ThemKH(dao_KH) == true)
            {
                dgv_danhsachkhachhang.DataSource = bul_stKH.GetDataFormKH();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void dgv_danhsachkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_KH.MaKH = txt_makhachhang.Text;
            DialogResult rs = MessageBox.Show("bạn có muốn xóa không??", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (bul_stKH.XoaKH(dao_KH))
                {
                    dgv_danhsachkhachhang.DataSource = bul_stKH.GetDataFormKH();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
                txt_makhachhang.Clear();
                txt_tenkhachhang.Clear();
                rdo_nam.Checked = true;
                txt_socccd.Clear();
                txt_sdt.Clear();
                txt_stk.Clear();
                txt_makhachhang.Focus();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_KH.MaKH = txt_makhachhang.Text;
            dao_KH.TenKH = txt_tenkhachhang.Text;
            dao_KH.Ngaysinh = DateTime.Parse(dtp_ngaysinh.Text.ToString());
            dao_KH.GioiTinh = rdo_nam.Checked ? "nam" : "nu";
            dao_KH.CMND = txt_socccd.Text;
            dao_KH.SDT = txt_sdt.Text;
            dao_KH.STK = txt_stk.Text;
            if (bul_stKH.SuaKH(dao_KH) == true)
            {
                dgv_danhsachkhachhang.DataSource = bul_stKH.GetDataFormKH();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }
    }
}
