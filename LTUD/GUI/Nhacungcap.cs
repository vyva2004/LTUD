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
    public partial class Nhacungcap : Form
    {
        public Nhacungcap()
        {
            InitializeComponent();
        }
        BUL_SieuThiNCC bul_NCC = new BUL_SieuThiNCC();
        DAO_Nhacungcap dao_ncc = new DAO_Nhacungcap();
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nhacungcap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            dgv_danhsachnhacungcap.DataSource = bul_NCC.GetDataFromNCC();
            
        }

        private void dgv_danhsachnhacungcap_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachnhacungcap.CurrentCell.RowIndex;
            txt_manhacungcap.Text = dgv_danhsachnhacungcap.Rows[row].Cells[0].Value.ToString().Trim();
            txt_tennhacungcap.Text = dgv_danhsachnhacungcap.Rows[row].Cells[1].Value.ToString().Trim();
            txt_diachi.Text = dgv_danhsachnhacungcap.Rows[row].Cells[2].Value.ToString().Trim();
            txt_sdt.Text = dgv_danhsachnhacungcap.Rows[row].Cells[3].Value.ToString().Trim();
            txt_masothue.Text = dgv_danhsachnhacungcap.Rows[row].Cells[4].Value.ToString().Trim();
        }

        private void dgv_danhsachnhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_ncc.Mancc = txt_manhacungcap.Text;
            dao_ncc.Tenncc = txt_tennhacungcap.Text;
            dao_ncc.Diachi = txt_diachi.Text;
            dao_ncc.SDT = txt_sdt.Text;
            dao_ncc.MSThue = txt_masothue.Text;
            if(bul_NCC.ThemNCC(dao_ncc))
            {
                dgv_danhsachnhacungcap.DataSource = bul_NCC.GetDataFromNCC();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_ncc.Mancc = txt_manhacungcap.Text;
            DialogResult rs = MessageBox.Show("bạn có muốn xóa không??", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (bul_NCC.XoaNCC(dao_ncc))
                {
                    dgv_danhsachnhacungcap.DataSource = bul_NCC.GetDataFromNCC();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
                txt_manhacungcap.Clear();
                txt_tennhacungcap.Clear();
                txt_diachi.Clear();
                txt_sdt.Clear();
                txt_masothue.Clear();
                txt_manhacungcap.Focus();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_ncc.Mancc = txt_manhacungcap.Text;
            dao_ncc.Tenncc = txt_tennhacungcap.Text;
            dao_ncc.Diachi = txt_diachi.Text;
            dao_ncc.SDT = txt_sdt.Text;
            dao_ncc.MSThue = txt_masothue.Text;
            if (bul_NCC.SuaNCC(dao_ncc))
            {
                dgv_danhsachnhacungcap.DataSource = bul_NCC.GetDataFromNCC();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }
    }
}
