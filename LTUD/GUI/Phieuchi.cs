using BUL;
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
    public partial class Phieuchi : Form
    {
        public Phieuchi()
        {
            InitializeComponent();
        }
        BUL_SieuThiPC bul_pc = new BUL_SieuThiPC();
        private void Phieuchi_Load(object sender, EventArgs e)
        {
            dgv_danhsachphieuchi.DataSource = bul_pc.LayDSPC();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Phieuchi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
