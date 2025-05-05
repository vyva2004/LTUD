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
    public partial class Hanghoa : Form
    {
        public Hanghoa()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hanghoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        BUL_SieuThiHH bl_stHH = new BUL_SieuThiHH();
        DAO_HangHoa dao_hh = new DAO_HangHoa();
        private void Hanghoa_Load(object sender, EventArgs e)
        {
            dgv_danhsachhanghoa.DataSource = bl_stHH.GetDataFromHH();
            cbo_maloai.DataSource = bl_stHH.LoadDSLH();
            cbo_maloai.DisplayMember = "TENLOAI";
            cbo_maloai.ValueMember = "MALOAI";
        }

        private void dgv_danhsachhanghoa_Click(object sender, EventArgs e)
        {
            int row = dgv_danhsachhanghoa.CurrentCell.RowIndex;
            txt_mahh.Text = dgv_danhsachhanghoa.Rows[row].Cells[0].Value.ToString().Trim();
            cbo_maloai.SelectedValue = dgv_danhsachhanghoa.Rows[row].Cells[1].Value.ToString().Trim();
            txt_tenhh.Text = dgv_danhsachhanghoa.Rows[row].Cells[2].Value.ToString().Trim();
            txt_dvtinh.Text = dgv_danhsachhanghoa.Rows[row].Cells[3].Value.ToString().Trim();
            txt_dongia.Text = dgv_danhsachhanghoa.Rows[row].Cells[4].Value.ToString().Trim();
            txt_vat.Text = dgv_danhsachhanghoa.Rows[row].Cells[5].Value.ToString().Trim();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            dao_hh.MaHH = txt_mahh.Text;
            dao_hh.MaL = cbo_maloai.SelectedValue.ToString();
            dao_hh.TenHH = txt_tenhh.Text;
            dao_hh.DVT = txt_dvtinh.Text;
            dao_hh.DG = txt_dongia.Text;
            dao_hh.VAT = txt_vat.Text;
            if (bl_stHH.ThemHH(dao_hh) == true)
            {
                dgv_danhsachhanghoa.DataSource = bl_stHH.GetDataFromHH();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void dgv_danhsachhanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dao_hh.MaHH = txt_mahh.Text;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) 
            {
                if (bl_stHH.XoaHH(dao_hh) == true)
                {
                    dgv_danhsachhanghoa.DataSource = bl_stHH.GetDataFromHH();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
            }
            txt_mahh.Clear();
            cbo_maloai.Text=null;
            txt_tenhh.Clear();
            txt_dvtinh.Clear();
            txt_dongia.Clear();
            txt_vat.Clear();
            txt_mahh.Focus();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dao_hh.MaHH = txt_mahh.Text;
            dao_hh.MaL = cbo_maloai.SelectedValue.ToString();
            dao_hh.TenHH = txt_tenhh.Text;
            dao_hh.DVT = txt_dvtinh.Text;
            dao_hh.DG = txt_dongia.Text;
            dao_hh.VAT = txt_vat.Text;
            if (bl_stHH.SuaHH(dao_hh) == true)
            {
                dgv_danhsachhanghoa.DataSource = bl_stHH.GetDataFromHH();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }
    }
}
