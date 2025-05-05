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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dSNhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien s = new Nhanvien();
            s.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang a = new Khachhang();
            a.Show();
        }

        private void danhSáchHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hanghoa b = new Hanghoa();
            b.Show();
        }

        private void danhSáchLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loaihang c = new Loaihang();
            c.Show();
        }

        private void danhSáchChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chucvu f = new Chucvu();
            f.Show();
        }

        private void danhSáchChiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTPN h = new ChiTPN();
            h.Show();
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhacungcap k = new Nhacungcap();
            k.Show();
        }

        private void danhSáchPhiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieuchi l = new Phieuchi();
            l.Show();
        }

        private void danhSáchPhiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieunhaphang i = new Phieunhaphang();
            i.Show();
        }

        private void danhSáchPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieuxuat o = new Phieuxuat();
            o.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
