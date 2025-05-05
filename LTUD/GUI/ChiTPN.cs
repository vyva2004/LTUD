using BUL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChiTPN : Form
    {
        public ChiTPN()
        {
            InitializeComponent();
        }

        private void btn_thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        BUL_SieuThiCTPN bulCTPN = new BUL_SieuThiCTPN();
        DAO_Chitietphieunhap dao_CTPN = new DAO_Chitietphieunhap();
        private void ChiTPN_Load(object sender, EventArgs e)
        {
            dgv_danhsachquanlyphieunhap.DataSource = bulCTPN.LaydsCTPN();
            
        }

        private void dgv_danhsachquanlyphieunhap_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachquanlyphieunhap.CurrentCell.RowIndex;
            txt_maphieunhap.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[0].Value.ToString().Trim();
            txt_mhh.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[1].Value.ToString().Trim();
            txt_gianhap.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[2].Value.ToString().Trim();
            txt_soluongnhap.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[3].Value.ToString().Trim();
            txt_thanhtien.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[4].Value.ToString().Trim();
            txt_chieukhau.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[5].Value.ToString().Trim();
            txt_tongtien.Text = dgv_danhsachquanlyphieunhap.Rows[row].Cells[6].Value.ToString().Trim();
        }

        private void dgv_danhsachquanlyphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_CTPN .MaCTPN = txt_maphieunhap.Text;
            dao_CTPN.MaHH = txt_mhh.Text;
            dao_CTPN.GiaNhap = txt_gianhap.Text;
            dao_CTPN.SL = txt_soluongnhap.Text;
            dao_CTPN.ThanhTien = txt_thanhtien.Text;
            dao_CTPN.ChietKhau = txt_chieukhau.Text;
            dao_CTPN.TongTien = txt_tongtien.Text;
            if (bulCTPN.ThemCTPN(dao_CTPN) == true)
            {
                dgv_danhsachquanlyphieunhap.DataSource = bulCTPN.LaydsCTPN();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_CTPN.MaCTPN = txt_maphieunhap.Text;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (bulCTPN.XoaCTPN(dao_CTPN) == true)
                {
                    dgv_danhsachquanlyphieunhap.DataSource = bulCTPN.LaydsCTPN();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
            }
            txt_maphieunhap.Clear();
            txt_mhh.Clear();
            txt_gianhap.Clear();
            txt_soluongnhap.Clear();
            txt_thanhtien.Clear();
            txt_chieukhau.Clear();
            txt_tongtien.Clear();
            txt_maphieunhap.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_CTPN.MaCTPN = txt_maphieunhap.Text;
            dao_CTPN.MaHH = txt_mhh.Text;
            dao_CTPN.GiaNhap = txt_gianhap.Text;
            dao_CTPN.SL = txt_soluongnhap.Text;
            dao_CTPN.ThanhTien = txt_thanhtien.Text;
            dao_CTPN.ChietKhau = txt_chieukhau.Text;
            dao_CTPN.TongTien = txt_tongtien.Text;
            if (bulCTPN.SuaCTPN(dao_CTPN) == true)
            {
                dgv_danhsachquanlyphieunhap.DataSource = bulCTPN.LaydsCTPN();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }
    }
}
