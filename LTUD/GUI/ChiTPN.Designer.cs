namespace WindowsFormsApp1
{
    partial class ChiTPN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_danhsachquanlyphieunhap = new System.Windows.Forms.DataGridView();
            this.btn_thoát = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_chieukhau = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_soluongnhap = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.txt_maphieunhap = new System.Windows.Forms.TextBox();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.lbl_ck = new System.Windows.Forms.Label();
            this.lbl_tt = new System.Windows.Forms.Label();
            this.lbl_sln = new System.Windows.Forms.Label();
            this.lbl_gn = new System.Windows.Forms.Label();
            this.lbl_mhh = new System.Windows.Forms.Label();
            this.lbl_mpn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mhh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachquanlyphieunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danhsachquanlyphieunhap
            // 
            this.dgv_danhsachquanlyphieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachquanlyphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachquanlyphieunhap.Location = new System.Drawing.Point(-1, 281);
            this.dgv_danhsachquanlyphieunhap.Name = "dgv_danhsachquanlyphieunhap";
            this.dgv_danhsachquanlyphieunhap.Size = new System.Drawing.Size(802, 171);
            this.dgv_danhsachquanlyphieunhap.TabIndex = 27;
            this.dgv_danhsachquanlyphieunhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachquanlyphieunhap_CellContentClick);
            this.dgv_danhsachquanlyphieunhap.Click += new System.EventHandler(this.dgv_danhsachquanlyphieunhap_Click);
            // 
            // btn_thoát
            // 
            this.btn_thoát.Location = new System.Drawing.Point(602, 241);
            this.btn_thoát.Name = "btn_thoát";
            this.btn_thoát.Size = new System.Drawing.Size(75, 23);
            this.btn_thoát.TabIndex = 26;
            this.btn_thoát.Text = "Thoát";
            this.btn_thoát.UseVisualStyleBackColor = true;
            this.btn_thoát.Click += new System.EventHandler(this.btn_thoát_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(416, 241);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(249, 241);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(88, 241);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 23;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(488, 195);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(127, 20);
            this.txt_tongtien.TabIndex = 21;
            // 
            // txt_chieukhau
            // 
            this.txt_chieukhau.Location = new System.Drawing.Point(488, 160);
            this.txt_chieukhau.Name = "txt_chieukhau";
            this.txt_chieukhau.Size = new System.Drawing.Size(127, 20);
            this.txt_chieukhau.TabIndex = 20;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(488, 130);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(127, 20);
            this.txt_thanhtien.TabIndex = 19;
            // 
            // txt_soluongnhap
            // 
            this.txt_soluongnhap.Location = new System.Drawing.Point(488, 93);
            this.txt_soluongnhap.Name = "txt_soluongnhap";
            this.txt_soluongnhap.Size = new System.Drawing.Size(127, 20);
            this.txt_soluongnhap.TabIndex = 22;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(174, 156);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(127, 20);
            this.txt_gianhap.TabIndex = 18;
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.Location = new System.Drawing.Point(174, 93);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.Size = new System.Drawing.Size(127, 20);
            this.txt_maphieunhap.TabIndex = 16;
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Location = new System.Drawing.Point(394, 198);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(55, 13);
            this.lbl_tongtien.TabIndex = 14;
            this.lbl_tongtien.Text = "Tổng tiền:";
            // 
            // lbl_ck
            // 
            this.lbl_ck.AutoSize = true;
            this.lbl_ck.Location = new System.Drawing.Point(388, 163);
            this.lbl_ck.Name = "lbl_ck";
            this.lbl_ck.Size = new System.Drawing.Size(64, 13);
            this.lbl_ck.TabIndex = 13;
            this.lbl_ck.Text = "Chiếu khấu:";
            // 
            // lbl_tt
            // 
            this.lbl_tt.AutoSize = true;
            this.lbl_tt.Location = new System.Drawing.Point(388, 133);
            this.lbl_tt.Name = "lbl_tt";
            this.lbl_tt.Size = new System.Drawing.Size(61, 13);
            this.lbl_tt.TabIndex = 12;
            this.lbl_tt.Text = "Thành tiền:";
            // 
            // lbl_sln
            // 
            this.lbl_sln.AutoSize = true;
            this.lbl_sln.Location = new System.Drawing.Point(388, 100);
            this.lbl_sln.Name = "lbl_sln";
            this.lbl_sln.Size = new System.Drawing.Size(79, 13);
            this.lbl_sln.TabIndex = 11;
            this.lbl_sln.Text = "Số lượng nhập:";
            // 
            // lbl_gn
            // 
            this.lbl_gn.AutoSize = true;
            this.lbl_gn.Location = new System.Drawing.Point(74, 163);
            this.lbl_gn.Name = "lbl_gn";
            this.lbl_gn.Size = new System.Drawing.Size(53, 13);
            this.lbl_gn.TabIndex = 10;
            this.lbl_gn.Text = "Giá nhập:";
            // 
            // lbl_mhh
            // 
            this.lbl_mhh.AutoSize = true;
            this.lbl_mhh.Location = new System.Drawing.Point(74, 130);
            this.lbl_mhh.Name = "lbl_mhh";
            this.lbl_mhh.Size = new System.Drawing.Size(78, 13);
            this.lbl_mhh.TabIndex = 9;
            this.lbl_mhh.Text = "Loại hàng hóa:";
            // 
            // lbl_mpn
            // 
            this.lbl_mpn.AutoSize = true;
            this.lbl_mpn.Location = new System.Drawing.Point(74, 100);
            this.lbl_mpn.Name = "lbl_mpn";
            this.lbl_mpn.Size = new System.Drawing.Size(81, 13);
            this.lbl_mpn.TabIndex = 15;
            this.lbl_mpn.Text = "Mã phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ CHI TIẾT PHIẾU NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mhh
            // 
            this.txt_mhh.Location = new System.Drawing.Point(174, 123);
            this.txt_mhh.Name = "txt_mhh";
            this.txt_mhh.Size = new System.Drawing.Size(127, 20);
            this.txt_mhh.TabIndex = 16;
            // 
            // ChiTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_danhsachquanlyphieunhap);
            this.Controls.Add(this.btn_thoát);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_chieukhau);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_soluongnhap);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_mhh);
            this.Controls.Add(this.txt_maphieunhap);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.lbl_ck);
            this.Controls.Add(this.lbl_tt);
            this.Controls.Add(this.lbl_sln);
            this.Controls.Add(this.lbl_gn);
            this.Controls.Add(this.lbl_mhh);
            this.Controls.Add(this.lbl_mpn);
            this.Controls.Add(this.label1);
            this.Name = "ChiTPN";
            this.Text = "ChiTPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTPN_FormClosing);
            this.Load += new System.EventHandler(this.ChiTPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachquanlyphieunhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_danhsachquanlyphieunhap;
        private System.Windows.Forms.Button btn_thoát;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_chieukhau;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_soluongnhap;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.TextBox txt_maphieunhap;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.Label lbl_ck;
        private System.Windows.Forms.Label lbl_tt;
        private System.Windows.Forms.Label lbl_sln;
        private System.Windows.Forms.Label lbl_gn;
        private System.Windows.Forms.Label lbl_mhh;
        private System.Windows.Forms.Label lbl_mpn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mhh;
    }
}