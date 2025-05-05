namespace WindowsFormsApp1
{
    partial class Phieuchi
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
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.lbl_phieuchi = new System.Windows.Forms.Label();
            this.lbl_mpn = new System.Windows.Forms.Label();
            this.lbl_mnv = new System.Windows.Forms.Label();
            this.lbl_tnc = new System.Windows.Forms.Label();
            this.lbl_nc = new System.Windows.Forms.Label();
            this.lbl_stpc = new System.Windows.Forms.Label();
            this.lbl_stbc = new System.Windows.Forms.Label();
            this.lbl_gc = new System.Windows.Forms.Label();
            this.txt_sophieuchi = new System.Windows.Forms.TextBox();
            this.txt_nguoichi = new System.Windows.Forms.TextBox();
            this.dtp_ngaychi = new System.Windows.Forms.DateTimePicker();
            this.txt_sotienphaichi = new System.Windows.Forms.TextBox();
            this.txt_sotienbangchu = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_danhsachphieuchi = new System.Windows.Forms.DataGridView();
            this.cbo_maphieunhap = new System.Windows.Forms.ComboBox();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphieuchi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_tieude.Location = new System.Drawing.Point(266, 20);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(258, 29);
            this.lbl_tieude.TabIndex = 1;
            this.lbl_tieude.Text = "QUẢN LÝ PHIẾU CHI";
            this.lbl_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_phieuchi
            // 
            this.lbl_phieuchi.AutoSize = true;
            this.lbl_phieuchi.Location = new System.Drawing.Point(60, 85);
            this.lbl_phieuchi.Name = "lbl_phieuchi";
            this.lbl_phieuchi.Size = new System.Drawing.Size(69, 13);
            this.lbl_phieuchi.TabIndex = 2;
            this.lbl_phieuchi.Text = "Số phiếu chi:";
            // 
            // lbl_mpn
            // 
            this.lbl_mpn.AutoSize = true;
            this.lbl_mpn.Location = new System.Drawing.Point(60, 120);
            this.lbl_mpn.Name = "lbl_mpn";
            this.lbl_mpn.Size = new System.Drawing.Size(81, 13);
            this.lbl_mpn.TabIndex = 3;
            this.lbl_mpn.Text = "Mã phiếu nhập:";
            // 
            // lbl_mnv
            // 
            this.lbl_mnv.AutoSize = true;
            this.lbl_mnv.Location = new System.Drawing.Point(60, 151);
            this.lbl_mnv.Name = "lbl_mnv";
            this.lbl_mnv.Size = new System.Drawing.Size(75, 13);
            this.lbl_mnv.TabIndex = 4;
            this.lbl_mnv.Text = "Mã nhân viên:";
            // 
            // lbl_tnc
            // 
            this.lbl_tnc.AutoSize = true;
            this.lbl_tnc.Location = new System.Drawing.Point(60, 179);
            this.lbl_tnc.Name = "lbl_tnc";
            this.lbl_tnc.Size = new System.Drawing.Size(75, 13);
            this.lbl_tnc.TabIndex = 5;
            this.lbl_tnc.Text = "Tên người chi:";
            // 
            // lbl_nc
            // 
            this.lbl_nc.AutoSize = true;
            this.lbl_nc.Location = new System.Drawing.Point(441, 85);
            this.lbl_nc.Name = "lbl_nc";
            this.lbl_nc.Size = new System.Drawing.Size(52, 13);
            this.lbl_nc.TabIndex = 6;
            this.lbl_nc.Text = "Ngày chi:";
            // 
            // lbl_stpc
            // 
            this.lbl_stpc.AutoSize = true;
            this.lbl_stpc.Location = new System.Drawing.Point(441, 120);
            this.lbl_stpc.Name = "lbl_stpc";
            this.lbl_stpc.Size = new System.Drawing.Size(83, 13);
            this.lbl_stpc.TabIndex = 7;
            this.lbl_stpc.Text = "Số tiền phải chi:";
            // 
            // lbl_stbc
            // 
            this.lbl_stbc.AutoSize = true;
            this.lbl_stbc.Location = new System.Drawing.Point(441, 151);
            this.lbl_stbc.Name = "lbl_stbc";
            this.lbl_stbc.Size = new System.Drawing.Size(91, 13);
            this.lbl_stbc.TabIndex = 8;
            this.lbl_stbc.Text = "Số tiền bằng chữ:";
            // 
            // lbl_gc
            // 
            this.lbl_gc.AutoSize = true;
            this.lbl_gc.Location = new System.Drawing.Point(441, 179);
            this.lbl_gc.Name = "lbl_gc";
            this.lbl_gc.Size = new System.Drawing.Size(47, 13);
            this.lbl_gc.TabIndex = 9;
            this.lbl_gc.Text = "Ghi chú:";
            // 
            // txt_sophieuchi
            // 
            this.txt_sophieuchi.Location = new System.Drawing.Point(152, 82);
            this.txt_sophieuchi.Name = "txt_sophieuchi";
            this.txt_sophieuchi.Size = new System.Drawing.Size(127, 20);
            this.txt_sophieuchi.TabIndex = 4;
            // 
            // txt_nguoichi
            // 
            this.txt_nguoichi.Location = new System.Drawing.Point(152, 170);
            this.txt_nguoichi.Name = "txt_nguoichi";
            this.txt_nguoichi.Size = new System.Drawing.Size(127, 20);
            this.txt_nguoichi.TabIndex = 4;
            // 
            // dtp_ngaychi
            // 
            this.dtp_ngaychi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaychi.Location = new System.Drawing.Point(541, 85);
            this.dtp_ngaychi.Name = "dtp_ngaychi";
            this.dtp_ngaychi.Size = new System.Drawing.Size(137, 20);
            this.dtp_ngaychi.TabIndex = 5;
            // 
            // txt_sotienphaichi
            // 
            this.txt_sotienphaichi.Location = new System.Drawing.Point(541, 120);
            this.txt_sotienphaichi.Name = "txt_sotienphaichi";
            this.txt_sotienphaichi.Size = new System.Drawing.Size(137, 20);
            this.txt_sotienphaichi.TabIndex = 4;
            // 
            // txt_sotienbangchu
            // 
            this.txt_sotienbangchu.Location = new System.Drawing.Point(541, 146);
            this.txt_sotienbangchu.Name = "txt_sotienbangchu";
            this.txt_sotienbangchu.Size = new System.Drawing.Size(137, 20);
            this.txt_sotienbangchu.TabIndex = 4;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(541, 176);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(137, 20);
            this.txt_ghichu.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(79, 227);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(204, 227);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(362, 227);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(517, 227);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_danhsachphieuchi
            // 
            this.dgv_danhsachphieuchi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachphieuchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachphieuchi.Location = new System.Drawing.Point(-1, 256);
            this.dgv_danhsachphieuchi.Name = "dgv_danhsachphieuchi";
            this.dgv_danhsachphieuchi.Size = new System.Drawing.Size(802, 194);
            this.dgv_danhsachphieuchi.TabIndex = 7;
            // 
            // cbo_maphieunhap
            // 
            this.cbo_maphieunhap.FormattingEnabled = true;
            this.cbo_maphieunhap.Location = new System.Drawing.Point(152, 112);
            this.cbo_maphieunhap.Name = "cbo_maphieunhap";
            this.cbo_maphieunhap.Size = new System.Drawing.Size(127, 21);
            this.cbo_maphieunhap.TabIndex = 10;
            // 
            // cbo_manv
            // 
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.Location = new System.Drawing.Point(152, 143);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(127, 21);
            this.cbo_manv.TabIndex = 10;
            // 
            // Phieuchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_manv);
            this.Controls.Add(this.cbo_maphieunhap);
            this.Controls.Add(this.dgv_danhsachphieuchi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtp_ngaychi);
            this.Controls.Add(this.txt_nguoichi);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_sotienbangchu);
            this.Controls.Add(this.txt_sotienphaichi);
            this.Controls.Add(this.txt_sophieuchi);
            this.Controls.Add(this.lbl_gc);
            this.Controls.Add(this.lbl_stbc);
            this.Controls.Add(this.lbl_stpc);
            this.Controls.Add(this.lbl_nc);
            this.Controls.Add(this.lbl_tnc);
            this.Controls.Add(this.lbl_mnv);
            this.Controls.Add(this.lbl_mpn);
            this.Controls.Add(this.lbl_phieuchi);
            this.Controls.Add(this.lbl_tieude);
            this.Name = "Phieuchi";
            this.Text = "Phiếu chi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phieuchi_FormClosing);
            this.Load += new System.EventHandler(this.Phieuchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphieuchi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_phieuchi;
        private System.Windows.Forms.Label lbl_mpn;
        private System.Windows.Forms.Label lbl_mnv;
        private System.Windows.Forms.Label lbl_tnc;
        private System.Windows.Forms.Label lbl_nc;
        private System.Windows.Forms.Label lbl_stpc;
        private System.Windows.Forms.Label lbl_stbc;
        private System.Windows.Forms.Label lbl_gc;
        private System.Windows.Forms.TextBox txt_sophieuchi;
        private System.Windows.Forms.TextBox txt_nguoichi;
        private System.Windows.Forms.DateTimePicker dtp_ngaychi;
        private System.Windows.Forms.TextBox txt_sotienphaichi;
        private System.Windows.Forms.TextBox txt_sotienbangchu;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_danhsachphieuchi;
        private System.Windows.Forms.ComboBox cbo_maphieunhap;
        private System.Windows.Forms.ComboBox cbo_manv;
    }
}