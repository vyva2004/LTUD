namespace WindowsFormsApp1
{
    partial class Khachhang
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
            this.lbl_mkh = new System.Windows.Forms.Label();
            this.lbl_tkh = new System.Windows.Forms.Label();
            this.lbl_ns = new System.Windows.Forms.Label();
            this.lbl_gt = new System.Windows.Forms.Label();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.lbl_cccd = new System.Windows.Forms.Label();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.txt_socccd = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_danhsachkhachhang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_td
            // 
            this.lbl_td.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_td.AutoSize = true;
            this.lbl_td.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_td.Location = new System.Drawing.Point(251, 53);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(297, 29);
            this.lbl_td.TabIndex = 4;
            this.lbl_td.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mkh
            // 
            this.lbl_mkh.AutoSize = true;
            this.lbl_mkh.Location = new System.Drawing.Point(78, 119);
            this.lbl_mkh.Name = "lbl_mkh";
            this.lbl_mkh.Size = new System.Drawing.Size(85, 13);
            this.lbl_mkh.TabIndex = 5;
            this.lbl_mkh.Text = "Mã khách hàng:";
            // 
            // lbl_tkh
            // 
            this.lbl_tkh.AutoSize = true;
            this.lbl_tkh.Location = new System.Drawing.Point(78, 154);
            this.lbl_tkh.Name = "lbl_tkh";
            this.lbl_tkh.Size = new System.Drawing.Size(89, 13);
            this.lbl_tkh.TabIndex = 5;
            this.lbl_tkh.Text = "Tên khách hàng:";
            // 
            // lbl_ns
            // 
            this.lbl_ns.AutoSize = true;
            this.lbl_ns.Location = new System.Drawing.Point(78, 185);
            this.lbl_ns.Name = "lbl_ns";
            this.lbl_ns.Size = new System.Drawing.Size(57, 13);
            this.lbl_ns.TabIndex = 5;
            this.lbl_ns.Text = "Ngày sinh:";
            // 
            // lbl_gt
            // 
            this.lbl_gt.AutoSize = true;
            this.lbl_gt.Location = new System.Drawing.Point(78, 225);
            this.lbl_gt.Name = "lbl_gt";
            this.lbl_gt.Size = new System.Drawing.Size(50, 13);
            this.lbl_gt.TabIndex = 5;
            this.lbl_gt.Text = "Giới tính:";
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(196, 221);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(45, 17);
            this.rdo_nam.TabIndex = 6;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(279, 221);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(37, 17);
            this.rdo_nu.TabIndex = 6;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // lbl_cccd
            // 
            this.lbl_cccd.AutoSize = true;
            this.lbl_cccd.Location = new System.Drawing.Point(385, 122);
            this.lbl_cccd.Name = "lbl_cccd";
            this.lbl_cccd.Size = new System.Drawing.Size(55, 13);
            this.lbl_cccd.TabIndex = 5;
            this.lbl_cccd.Text = "Số CCCD:";
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(385, 153);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(73, 13);
            this.lbl_sdt.TabIndex = 5;
            this.lbl_sdt.Text = "Số điện thoại:";
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(195, 119);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(138, 20);
            this.txt_makhachhang.TabIndex = 7;
            this.txt_makhachhang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(195, 154);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(138, 20);
            this.txt_tenkhachhang.TabIndex = 7;
            this.txt_tenkhachhang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_socccd
            // 
            this.txt_socccd.Location = new System.Drawing.Point(462, 119);
            this.txt_socccd.Name = "txt_socccd";
            this.txt_socccd.Size = new System.Drawing.Size(155, 20);
            this.txt_socccd.TabIndex = 7;
            this.txt_socccd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(462, 150);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(155, 20);
            this.txt_sdt.TabIndex = 7;
            this.txt_sdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(195, 185);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(138, 20);
            this.dtp_ngaysinh.TabIndex = 8;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(528, 251);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(396, 251);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(256, 251);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(126, 251);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_danhsachkhachhang
            // 
            this.dgv_danhsachkhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachkhachhang.Location = new System.Drawing.Point(0, 295);
            this.dgv_danhsachkhachhang.Name = "dgv_danhsachkhachhang";
            this.dgv_danhsachkhachhang.Size = new System.Drawing.Size(799, 156);
            this.dgv_danhsachkhachhang.TabIndex = 13;
            this.dgv_danhsachkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachkhachhang_CellContentClick);
            this.dgv_danhsachkhachhang.Click += new System.EventHandler(this.dgv_danhsachkhachhang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số tài khoản:";
            // 
            // txt_stk
            // 
            this.txt_stk.Location = new System.Drawing.Point(462, 182);
            this.txt_stk.Name = "txt_stk";
            this.txt_stk.Size = new System.Drawing.Size(155, 20);
            this.txt_stk.TabIndex = 7;
            this.txt_stk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_danhsachkhachhang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.txt_stk);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_socccd);
            this.Controls.Add(this.txt_tenkhachhang);
            this.Controls.Add(this.txt_makhachhang);
            this.Controls.Add(this.rdo_nu);
            this.Controls.Add(this.rdo_nam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sdt);
            this.Controls.Add(this.lbl_cccd);
            this.Controls.Add(this.lbl_gt);
            this.Controls.Add(this.lbl_ns);
            this.Controls.Add(this.lbl_tkh);
            this.Controls.Add(this.lbl_mkh);
            this.Controls.Add(this.lbl_td);
            this.Name = "Khachhang";
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Khachhang_FormClosing);
            this.Load += new System.EventHandler(this.Khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label lbl_mkh;
        private System.Windows.Forms.Label lbl_tkh;
        private System.Windows.Forms.Label lbl_ns;
        private System.Windows.Forms.Label lbl_gt;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.Label lbl_cccd;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.TextBox txt_makhachhang;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.TextBox txt_socccd;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_danhsachkhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stk;
    }
}