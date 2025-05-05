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
    public partial class Phieunhaphang : Form
    {
        public Phieunhaphang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Phieunhaphang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        BUL_SieuThiPNH bul_stNH = new BUL_SieuThiPNH();
        DAO_PNH dao_pnh = new DAO_PNH();
        private void Phieunhaphang_Load(object sender, EventArgs e)
        {
            dgv_danhsachphieunhaphang.DataSource = bul_stNH.GetDataFromPNH();
            cbo_mancc.DataSource = bul_stNH.loadDSNCC();
            cbo_mancc.DisplayMember = "MANCC";
            cbo_mancc.ValueMember = "MANCC";
            cbo_manv.DataSource = bul_stNH.loadDSNV();
            cbo_manv.DisplayMember = "MANV";
            cbo_manv.ValueMember = "MANV";
        }

        private void dgv_danhsachphieunhaphang_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachphieunhaphang.CurrentCell.RowIndex;
            txt_maphieunhaphang.Text = dgv_danhsachphieunhaphang.Rows[row].Cells[0].Value.ToString().Trim();
            cbo_mancc.SelectedValue = dgv_danhsachphieunhaphang.Rows[row].Cells[1].Value.ToString().Trim();
            cbo_manv.SelectedValue = dgv_danhsachphieunhaphang.Rows[row].Cells[2].Value.ToString().Trim();
            dtp_ngaynhap.Text = dgv_danhsachphieunhaphang.Rows[row].Cells[3].Value.ToString().Trim();
        }

        private void dgv_danhsachphieunhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_pnh.MaPNH = txt_maphieunhaphang.Text;
            dao_pnh.MaNCC = cbo_mancc.SelectedValue.ToString();
            dao_pnh.MaNV = cbo_manv.SelectedValue.ToString(); ;
            dao_pnh.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text.ToString());
            if (bul_stNH.ThemPNH(dao_pnh))
            {
                dgv_danhsachphieunhaphang.DataSource = bul_stNH.GetDataFromPNH();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_pnh.MaPNH = txt_maphieunhaphang.Text;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (bul_stNH.XoaPNH(dao_pnh))
                {
                    dgv_danhsachphieunhaphang.DataSource = bul_stNH.GetDataFromPNH();
                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
                }
            }
            txt_maphieunhaphang.Clear();
            cbo_mancc.Text = null;
            cbo_manv.Text = null;
            txt_maphieunhaphang.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_pnh.MaPNH = txt_maphieunhaphang.Text;
            dao_pnh.MaNCC = cbo_mancc.SelectedValue.ToString();
            dao_pnh.MaNV = cbo_manv.SelectedValue.ToString();
            dao_pnh.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text.ToString());
            if (bul_stNH.SuaPNH(dao_pnh))
            {
                dgv_danhsachphieunhaphang.DataSource = bul_stNH.GetDataFromPNH();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!!");
            }
        }
    }
}
