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
    public partial class Chucvu : Form
    {
        public Chucvu()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chucvu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        BUL_SieuThiCV bul_stCV = new BUL_SieuThiCV();
        DAO_Chucvu dao_cv = new DAO_Chucvu();
        private void Chucvu_Load(object sender, EventArgs e)
        {
            dgv_danhsachchucvu.DataSource = bul_stCV.GetDataFromCV();
            //cbo_tenchucvu.DataSource = bul_stCV.loadDSCV();
            //cbo_tenchucvu.DisplayMember = "TENCV";
            //cbo_tenchucvu.ValueMember = "TENCV";
        }

        private void dgv_danhsachchucvu_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachchucvu.CurrentCell.RowIndex;
            txt_machucvu.Text = dgv_danhsachchucvu.Rows[row].Cells[0].Value.ToString().Trim();
            txt_tenchucvu.Text = dgv_danhsachchucvu.Rows[row].Cells[1].Value.ToString().Trim();
        }

        private void dgv_danhsachchucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_cv.MaCV = txt_machucvu.Text;
            dao_cv.TenCV = txt_tenchucvu.Text;
            if(bul_stCV.ThemCV(dao_cv)==true)
            {
                dgv_danhsachchucvu.DataSource = bul_stCV.GetDataFromCV();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_cv.MaCV = txt_machucvu.Text;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không??", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes) 
            {
                if(bul_stCV.XoaCV(dao_cv)) 
                {
                    dgv_danhsachchucvu.DataSource = bul_stCV.GetDataFromCV();
                }else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            txt_machucvu.Clear();
            txt_tenchucvu.Clear();
            txt_machucvu.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_cv.MaCV = txt_machucvu.Text;
            dao_cv.TenCV = txt_tenchucvu.Text;
            if (bul_stCV.SuaCV(dao_cv))
            {
                dgv_danhsachchucvu.DataSource = bul_stCV.GetDataFromCV();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }
    }
}
