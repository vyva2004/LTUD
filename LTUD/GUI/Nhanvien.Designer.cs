namespace WindowsFormsApp1
{
    partial class Nhanvien
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
            this.lbl_td = new System.Windows.Forms.Label();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.lbl_mcv = new System.Windows.Forms.Label();
            this.cbo_chucvu = new System.Windows.Forms.ComboBox();
            this.lbl_tnv = new System.Windows.Forms.Label();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.lbl_gt = new System.Windows.Forms.Label();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.lbl_ns = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_dc = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.dgv_danhsachsinhvien = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_td
            // 
            this.lbl_td.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_td.AutoSize = true;
            this.lbl_td.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_td.Location = new System.Drawing.Point(283, 37);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(269, 29);
            this.lbl_td.TabIndex = 0;
            this.lbl_td.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.Location = new System.Drawing.Point(51, 80);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(75, 13);
            this.lbl_manv.TabIndex = 1;
            this.lbl_manv.Text = "Mã nhân viên:";
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(144, 77);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(136, 20);
            this.txt_manhanvien.TabIndex = 2;
            // 
            // lbl_mcv
            // 
            this.lbl_mcv.AutoSize = true;
            this.lbl_mcv.Location = new System.Drawing.Point(51, 114);
            this.lbl_mcv.Name = "lbl_mcv";
            this.lbl_mcv.Size = new System.Drawing.Size(71, 13);
            this.lbl_mcv.TabIndex = 1;
            this.lbl_mcv.Text = "Tên chức vụ:";
            this.lbl_mcv.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbo_chucvu
            // 
            this.cbo_chucvu.FormattingEnabled = true;
            this.cbo_chucvu.Location = new System.Drawing.Point(144, 105);
            this.cbo_chucvu.Name = "cbo_chucvu";
            this.cbo_chucvu.Size = new System.Drawing.Size(136, 21);
            this.cbo_chucvu.TabIndex = 3;
            this.cbo_chucvu.SelectedIndexChanged += new System.EventHandler(this.cbo_chucvu_SelectedIndexChanged);
            // 
            // lbl_tnv
            // 
            this.lbl_tnv.AutoSize = true;
            this.lbl_tnv.Location = new System.Drawing.Point(51, 138);
            this.lbl_tnv.Name = "lbl_tnv";
            this.lbl_tnv.Size = new System.Drawing.Size(79, 13);
            this.lbl_tnv.TabIndex = 1;
            this.lbl_tnv.Text = "Tên nhân viên:";
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(144, 135);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(136, 20);
            this.txt_tennhanvien.TabIndex = 2;
            // 
            // lbl_gt
            // 
            this.lbl_gt.AutoSize = true;
            this.lbl_gt.Location = new System.Drawing.Point(51, 163);
            this.lbl_gt.Name = "lbl_gt";
            this.lbl_gt.Size = new System.Drawing.Size(47, 13);
            this.lbl_gt.TabIndex = 1;
            this.lbl_gt.Text = "Giới tính";
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(144, 163);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(45, 17);
            this.rdo_nam.TabIndex = 4;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(195, 163);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(37, 17);
            this.rdo_nu.TabIndex = 4;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // lbl_ns
            // 
            this.lbl_ns.AutoSize = true;
            this.lbl_ns.Location = new System.Drawing.Point(51, 193);
            this.lbl_ns.Name = "lbl_ns";
            this.lbl_ns.Size = new System.Drawing.Size(57, 13);
            this.lbl_ns.TabIndex = 1;
            this.lbl_ns.Text = "Ngày sinh:";
            this.lbl_ns.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(144, 185);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(136, 20);
            this.dtp_ngaysinh.TabIndex = 5;
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(382, 87);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(73, 13);
            this.lbl_sdt.TabIndex = 1;
            this.lbl_sdt.Text = "Số điện thoại:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(477, 80);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(136, 20);
            this.txt_sdt.TabIndex = 2;
            this.txt_sdt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_dc
            // 
            this.lbl_dc.AutoSize = true;
            this.lbl_dc.Location = new System.Drawing.Point(382, 114);
            this.lbl_dc.Name = "lbl_dc";
            this.lbl_dc.Size = new System.Drawing.Size(43, 13);
            this.lbl_dc.TabIndex = 1;
            this.lbl_dc.Text = "Địa chỉ:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(477, 111);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(136, 20);
            this.txt_diachi.TabIndex = 2;
            this.txt_diachi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgv_danhsachsinhvien
            // 
            this.dgv_danhsachsinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachsinhvien.Location = new System.Drawing.Point(2, 280);
            this.dgv_danhsachsinhvien.Name = "dgv_danhsachsinhvien";
            this.dgv_danhsachsinhvien.Size = new System.Drawing.Size(799, 175);
            this.dgv_danhsachsinhvien.TabIndex = 6;
            this.dgv_danhsachsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsinhvien_CellClick);
            this.dgv_danhsachsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsinhvien_CellContentClick);
            this.dgv_danhsachsinhvien.Click += new System.EventHandler(this.dgv_danhsachsinhvien_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(50, 239);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(180, 239);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(320, 239);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(452, 239);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_danhsachsinhvien);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.rdo_nu);
            this.Controls.Add(this.rdo_nam);
            this.Controls.Add(this.cbo_chucvu);
            this.Controls.Add(this.txt_tennhanvien);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_manhanvien);
            this.Controls.Add(this.lbl_ns);
            this.Controls.Add(this.lbl_gt);
            this.Controls.Add(this.lbl_tnv);
            this.Controls.Add(this.lbl_mcv);
            this.Controls.Add(this.lbl_dc);
            this.Controls.Add(this.lbl_sdt);
            this.Controls.Add(this.lbl_manv);
            this.Controls.Add(this.lbl_td);
            this.Name = "Nhanvien";
            this.Text = "Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nhanvien_FormClosing);
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label lbl_manv;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.Label lbl_mcv;
        private System.Windows.Forms.ComboBox cbo_chucvu;
        private System.Windows.Forms.Label lbl_tnv;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.Label lbl_gt;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.Label lbl_ns;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lbl_dc;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.DataGridView dgv_danhsachsinhvien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
    }
}