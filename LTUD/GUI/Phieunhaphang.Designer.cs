namespace WindowsFormsApp1
{
    partial class Phieunhaphang
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
            this.lbl_mnh = new System.Windows.Forms.Label();
            this.lbl_ncc = new System.Windows.Forms.Label();
            this.lbl_mnv = new System.Windows.Forms.Label();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.txt_maphieunhaphang = new System.Windows.Forms.TextBox();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.dgv_danhsachphieunhaphang = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbo_mancc = new System.Windows.Forms.ComboBox();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphieunhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_tieude.Location = new System.Drawing.Point(228, 26);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(364, 29);
            this.lbl_tieude.TabIndex = 1;
            this.lbl_tieude.Text = "QUẢN LÝ PHIẾU NHẬP HÀNG";
            this.lbl_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tieude.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_mnh
            // 
            this.lbl_mnh.AutoSize = true;
            this.lbl_mnh.Location = new System.Drawing.Point(53, 90);
            this.lbl_mnh.Name = "lbl_mnh";
            this.lbl_mnh.Size = new System.Drawing.Size(108, 13);
            this.lbl_mnh.TabIndex = 2;
            this.lbl_mnh.Text = "Mã phiếu nhập hàng:";
            // 
            // lbl_ncc
            // 
            this.lbl_ncc.AutoSize = true;
            this.lbl_ncc.Location = new System.Drawing.Point(53, 128);
            this.lbl_ncc.Name = "lbl_ncc";
            this.lbl_ncc.Size = new System.Drawing.Size(94, 13);
            this.lbl_ncc.TabIndex = 3;
            this.lbl_ncc.Text = "Mã nhà cung cấp:";
            // 
            // lbl_mnv
            // 
            this.lbl_mnv.AutoSize = true;
            this.lbl_mnv.Location = new System.Drawing.Point(53, 157);
            this.lbl_mnv.Name = "lbl_mnv";
            this.lbl_mnv.Size = new System.Drawing.Size(75, 13);
            this.lbl_mnv.TabIndex = 4;
            this.lbl_mnv.Text = "Mã nhân viên:";
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Location = new System.Drawing.Point(53, 184);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(62, 13);
            this.lbl_ngaynhap.TabIndex = 4;
            this.lbl_ngaynhap.Text = "Ngày nhập:";
            // 
            // txt_maphieunhaphang
            // 
            this.txt_maphieunhaphang.Location = new System.Drawing.Point(202, 90);
            this.txt_maphieunhaphang.Name = "txt_maphieunhaphang";
            this.txt_maphieunhaphang.Size = new System.Drawing.Size(154, 20);
            this.txt_maphieunhaphang.TabIndex = 4;
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaynhap.Location = new System.Drawing.Point(202, 184);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(154, 20);
            this.dtp_ngaynhap.TabIndex = 5;
            // 
            // dgv_danhsachphieunhaphang
            // 
            this.dgv_danhsachphieunhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachphieunhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachphieunhaphang.Location = new System.Drawing.Point(-1, 225);
            this.dgv_danhsachphieunhaphang.Name = "dgv_danhsachphieunhaphang";
            this.dgv_danhsachphieunhaphang.Size = new System.Drawing.Size(800, 226);
            this.dgv_danhsachphieunhaphang.TabIndex = 6;
            this.dgv_danhsachphieunhaphang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachphieunhaphang_CellContentClick);
            this.dgv_danhsachphieunhaphang.Click += new System.EventHandler(this.dgv_danhsachphieunhaphang_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(583, 106);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(435, 106);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(435, 152);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(583, 151);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_mancc
            // 
            this.cbo_mancc.FormattingEnabled = true;
            this.cbo_mancc.Location = new System.Drawing.Point(202, 125);
            this.cbo_mancc.Name = "cbo_mancc";
            this.cbo_mancc.Size = new System.Drawing.Size(154, 21);
            this.cbo_mancc.TabIndex = 8;
            // 
            // cbo_manv
            // 
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.Location = new System.Drawing.Point(202, 154);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(154, 21);
            this.cbo_manv.TabIndex = 8;
            // 
            // Phieunhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_manv);
            this.Controls.Add(this.cbo_mancc);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.dgv_danhsachphieunhaphang);
            this.Controls.Add(this.dtp_ngaynhap);
            this.Controls.Add(this.txt_maphieunhaphang);
            this.Controls.Add(this.lbl_ngaynhap);
            this.Controls.Add(this.lbl_mnv);
            this.Controls.Add(this.lbl_ncc);
            this.Controls.Add(this.lbl_mnh);
            this.Controls.Add(this.lbl_tieude);
            this.Name = "Phieunhaphang";
            this.Text = "Phiếu nhập hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phieunhaphang_FormClosing);
            this.Load += new System.EventHandler(this.Phieunhaphang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphieunhaphang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_mnh;
        private System.Windows.Forms.Label lbl_ncc;
        private System.Windows.Forms.Label lbl_mnv;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.TextBox txt_maphieunhaphang;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.DataGridView dgv_danhsachphieunhaphang;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbo_mancc;
        private System.Windows.Forms.ComboBox cbo_manv;
    }
}