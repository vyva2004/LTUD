using BUL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        BUL_SieuThiNV bul_stNV = new BUL_SieuThiNV();
        DAO_NhanVien dao_nv = new DAO_NhanVien();
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            dgv_danhsachsinhvien.DataSource = bul_stNV.GetDataFromNV();
            cbo_chucvu.DataSource = bul_stNV.loadDSCV();
            cbo_chucvu.DisplayMember = "TENCV";
            cbo_chucvu.ValueMember = "MACV";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_nv.MaNV = txt_manhanvien.Text;
            dao_nv.MaCV = cbo_chucvu.SelectedValue.ToString();
            dao_nv.TenNV = txt_tennhanvien.Text;
            dao_nv.GioiTinh = rdo_nam.Checked ? "nam" : "nu";
            dao_nv.NgaySinh = DateTime.Parse(dtp_ngaysinh.Text.ToString());
            dao_nv.SDT = txt_sdt.Text;
            dao_nv.DiaChi = txt_diachi.Text;
            if (bul_stNV.ThemNV(dao_nv) == true)
            {
                dgv_danhsachsinhvien.DataSource = bul_stNV.GetDataFromNV();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void dgv_danhsachsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_danhsachsinhvien_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachsinhvien.CurrentCell.RowIndex;
            txt_manhanvien.Text = dgv_danhsachsinhvien.Rows[row].Cells[0].Value.ToString().Trim();
            cbo_chucvu.SelectedValue = dgv_danhsachsinhvien.Rows[row].Cells[1].Value.ToString().Trim();
            txt_tennhanvien.Text = dgv_danhsachsinhvien.Rows[row].Cells[2].Value.ToString().Trim();
            if (dgv_danhsachsinhvien.Rows[row].Cells[3].Value.ToString().Trim() == "nam")
            {
                rdo_nam.Checked = true;
            }
            else
            {
                rdo_nu.Checked = true;
            }
            dtp_ngaysinh.Text = dgv_danhsachsinhvien.Rows[row].Cells[4].Value.ToString().Trim();
            txt_sdt.Text = dgv_danhsachsinhvien.Rows[row].Cells[5].Value.ToString().Trim();
            txt_diachi.Text = dgv_danhsachsinhvien.Rows[row].Cells[6].Value.ToString().Trim();
        }

        private void dgv_danhsachsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_nv.MaNV = txt_manhanvien.Text;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không???", "Thông báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (bul_stNV.XoaNV(dao_nv))
                {
                    dgv_danhsachsinhvien.DataSource = bul_stNV.GetDataFromNV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!");
                }
            }
            txt_manhanvien.Clear();
            cbo_chucvu.Text = null;
            txt_tennhanvien.Clear();
            rdo_nam.Checked = true;
            dtp_ngaysinh.Text = null;
            txt_sdt.Clear();
            txt_diachi.Clear();
            txt_manhanvien.Focus();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_nv.MaNV = txt_manhanvien.Text;
            dao_nv.MaCV = cbo_chucvu.SelectedValue.ToString();
            dao_nv.TenNV = txt_tennhanvien.Text;
            dao_nv.GioiTinh = rdo_nam.Checked ? "nam" : "nu";
            dao_nv.NgaySinh = DateTime.Parse(dtp_ngaysinh.Text.ToString());
            dao_nv.SDT = txt_sdt.Text;
            dao_nv.DiaChi = txt_diachi.Text;
            if (bul_stNV.SuaNV(dao_nv))
            {
                dgv_danhsachsinhvien.DataSource = bul_stNV.GetDataFromNV();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }
    }
}

