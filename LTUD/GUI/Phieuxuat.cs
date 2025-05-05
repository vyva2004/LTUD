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
    public partial class Phieuxuat : Form
    {
        public Phieuxuat()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BUL_SieuThiPX bul_px = new BUL_SieuThiPX();
        private void Phieuxuat_Load(object sender, EventArgs e)
        {
            dgv_danhsachquanlyphieuxuat.DataSource = bul_px.LayDSPX();
        }

        private void Phieuxuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
