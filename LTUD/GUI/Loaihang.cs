using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DAO;

namespace WindowsFormsApp1
{
    public partial class Loaihang : Form
    {
        public Loaihang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BUL_SieuThiLH bul_lh = new BUL_SieuThiLH();
        DAO_LoaiHang dao_lh = new DAO_LoaiHang();
        private void Loaihang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Loaihang_Load(object sender, EventArgs e)
        {
            dgv_danhsachloaihang.DataSource = bul_lh.GetDataFromLH();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_lh.Maloai=txt_maloai.Text;
            dao_lh.Tenloai=txt_tenloai.Text;
            if(bul_lh.ThemLH(dao_lh)==true)
            {
                dgv_danhsachloaihang.DataSource=bul_lh.GetDataFromLH();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void dgv_danhsachloaihang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_danhsachloaihang_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachloaihang.CurrentCell.RowIndex;
            txt_maloai.Text = dgv_danhsachloaihang.Rows[row].Cells[0].Value.ToString().Trim();
            txt_tenloai.Text = dgv_danhsachloaihang.Rows[row].Cells[1].Value.ToString().Trim();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_lh.Maloai = txt_maloai.Text;
            DialogResult rs = MessageBox.Show("bạn có muốn xóa không??", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                if (bul_lh.XoaLH(dao_lh))
                {
                    dgv_danhsachloaihang.DataSource = bul_lh.GetDataFromLH();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
                txt_maloai.Clear();
                txt_tenloai.Clear();
                txt_maloai.Focus();
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_lh.Maloai = txt_maloai.Text;
            dao_lh.Tenloai = txt_tenloai.Text;         
               if( bul_lh.SuaLH(dao_lh))
                {
                    dgv_danhsachloaihang.DataSource = bul_lh.GetDataFromLH();
                }
               else
                {
                    MessageBox.Show("Sửa không thành công!!");
                }
            }
        }
    }
