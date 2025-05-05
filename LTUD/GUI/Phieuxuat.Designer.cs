namespace WindowsFormsApp1
{
    partial class Phieuxuat
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
            this.lbl_mpx = new System.Windows.Forms.Label();
            this.lbl_mkh = new System.Windows.Forms.Label();
            this.lbl_mnv = new System.Windows.Forms.Label();
            this.lbl_ngayxuat = new System.Windows.Forms.Label();
            this.txt_maphieuxuat = new System.Windows.Forms.TextBox();
            this.dtp_ngayxuat = new System.Windows.Forms.DateTimePicker();
            this.dgv_danhsachquanlyphieuxuat = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbo_makh = new System.Windows.Forms.ComboBox();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachquanlyphieuxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_tieude.Location = new System.Drawing.Point(274, 31);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(284, 29);
            this.lbl_tieude.TabIndex = 1;
            this.lbl_tieude.Text = "QUẢN LÝ PHIẾU XUẤT";
            this.lbl_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mpx
            // 
            this.lbl_mpx.AutoSize = true;
            this.lbl_mpx.Location = new System.Drawing.Point(90, 103);
            this.lbl_mpx.Name = "lbl_mpx";
            this.lbl_mpx.Size = new System.Drawing.Size(77, 13);
            this.lbl_mpx.TabIndex = 2;
            this.lbl_mpx.Text = "Mã phiếu xuất:";
            // 
            // lbl_mkh
            // 
            this.lbl_mkh.AutoSize = true;
            this.lbl_mkh.Location = new System.Drawing.Point(90, 139);
            this.lbl_mkh.Name = "lbl_mkh";
            this.lbl_mkh.Size = new System.Drawing.Size(85, 13);
            this.lbl_mkh.TabIndex = 3;
            this.lbl_mkh.Text = "Mã khách hàng:";
            // 
            // lbl_mnv
            // 
            this.lbl_mnv.AutoSize = true;
            this.lbl_mnv.Location = new System.Drawing.Point(387, 103);
            this.lbl_mnv.Name = "lbl_mnv";
            this.lbl_mnv.Size = new System.Drawing.Size(75, 13);
            this.lbl_mnv.TabIndex = 4;
            this.lbl_mnv.Text = "Mã nhân viên:";
            // 
            // lbl_ngayxuat
            // 
            this.lbl_ngayxuat.AutoSize = true;
            this.lbl_ngayxuat.Location = new System.Drawing.Point(387, 139);
            this.lbl_ngayxuat.Name = "lbl_ngayxuat";
            this.lbl_ngayxuat.Size = new System.Drawing.Size(58, 13);
            this.lbl_ngayxuat.TabIndex = 5;
            this.lbl_ngayxuat.Text = "Ngày xuất:";
            // 
            // txt_maphieuxuat
            // 
            this.txt_maphieuxuat.Location = new System.Drawing.Point(198, 103);
            this.txt_maphieuxuat.Name = "txt_maphieuxuat";
            this.txt_maphieuxuat.Size = new System.Drawing.Size(135, 20);
            this.txt_maphieuxuat.TabIndex = 6;
            // 
            // dtp_ngayxuat
            // 
            this.dtp_ngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayxuat.Location = new System.Drawing.Point(478, 139);
            this.dtp_ngayxuat.Name = "dtp_ngayxuat";
            this.dtp_ngayxuat.Size = new System.Drawing.Size(137, 20);
            this.dtp_ngayxuat.TabIndex = 7;
            // 
            // dgv_danhsachquanlyphieuxuat
            // 
            this.dgv_danhsachquanlyphieuxuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachquanlyphieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachquanlyphieuxuat.Location = new System.Drawing.Point(1, 241);
            this.dgv_danhsachquanlyphieuxuat.Name = "dgv_danhsachquanlyphieuxuat";
            this.dgv_danhsachquanlyphieuxuat.Size = new System.Drawing.Size(800, 209);
            this.dgv_danhsachquanlyphieuxuat.TabIndex = 8;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(522, 192);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(390, 192);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(250, 192);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(120, 192);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // cbo_makh
            // 
            this.cbo_makh.FormattingEnabled = true;
            this.cbo_makh.Location = new System.Drawing.Point(198, 139);
            this.cbo_makh.Name = "cbo_makh";
            this.cbo_makh.Size = new System.Drawing.Size(135, 21);
            this.cbo_makh.TabIndex = 13;
            // 
            // cbo_manv
            // 
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.Location = new System.Drawing.Point(478, 94);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(137, 21);
            this.cbo_manv.TabIndex = 14;
            // 
            // Phieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_manv);
            this.Controls.Add(this.cbo_makh);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_danhsachquanlyphieuxuat);
            this.Controls.Add(this.dtp_ngayxuat);
            this.Controls.Add(this.txt_maphieuxuat);
            this.Controls.Add(this.lbl_ngayxuat);
            this.Controls.Add(this.lbl_mnv);
            this.Controls.Add(this.lbl_mkh);
            this.Controls.Add(this.lbl_mpx);
            this.Controls.Add(this.lbl_tieude);
            this.Name = "Phieuxuat";
            this.Text = "Phiếu xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phieuxuat_FormClosing);
            this.Load += new System.EventHandler(this.Phieuxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachquanlyphieuxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_mpx;
        private System.Windows.Forms.Label lbl_mkh;
        private System.Windows.Forms.Label lbl_mnv;
        private System.Windows.Forms.Label lbl_ngayxuat;
        private System.Windows.Forms.TextBox txt_maphieuxuat;
        private System.Windows.Forms.DateTimePicker dtp_ngayxuat;
        private System.Windows.Forms.DataGridView dgv_danhsachquanlyphieuxuat;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbo_makh;
        private System.Windows.Forms.ComboBox cbo_manv;
    }
}