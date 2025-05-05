namespace WindowsFormsApp1
{
    partial class Hanghoa
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
            this.lbl_mhh = new System.Windows.Forms.Label();
            this.lbl_ml = new System.Windows.Forms.Label();
            this.lbl__thh = new System.Windows.Forms.Label();
            this.lbl_dvt = new System.Windows.Forms.Label();
            this.lbl_dg = new System.Windows.Forms.Label();
            this.txt_mahh = new System.Windows.Forms.TextBox();
            this.txt_tenhh = new System.Windows.Forms.TextBox();
            this.txt_dvtinh = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_danhsachhanghoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vat = new System.Windows.Forms.TextBox();
            this.cbo_maloai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_td
            // 
            this.lbl_td.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_td.AutoSize = true;
            this.lbl_td.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_td.Location = new System.Drawing.Point(273, 26);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(264, 29);
            this.lbl_td.TabIndex = 5;
            this.lbl_td.Text = "QUẢN LÝ HÀNG HÓA";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_td.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_mhh
            // 
            this.lbl_mhh.AutoSize = true;
            this.lbl_mhh.Location = new System.Drawing.Point(54, 103);
            this.lbl_mhh.Name = "lbl_mhh";
            this.lbl_mhh.Size = new System.Drawing.Size(73, 13);
            this.lbl_mhh.TabIndex = 6;
            this.lbl_mhh.Text = "Mã hàng hóa:";
            // 
            // lbl_ml
            // 
            this.lbl_ml.AutoSize = true;
            this.lbl_ml.Location = new System.Drawing.Point(54, 136);
            this.lbl_ml.Name = "lbl_ml";
            this.lbl_ml.Size = new System.Drawing.Size(78, 13);
            this.lbl_ml.TabIndex = 6;
            this.lbl_ml.Text = "Loại hàng hóa:";
            // 
            // lbl__thh
            // 
            this.lbl__thh.AutoSize = true;
            this.lbl__thh.Location = new System.Drawing.Point(54, 165);
            this.lbl__thh.Name = "lbl__thh";
            this.lbl__thh.Size = new System.Drawing.Size(77, 13);
            this.lbl__thh.TabIndex = 6;
            this.lbl__thh.Text = "Tên hàng hóa:";
            // 
            // lbl_dvt
            // 
            this.lbl_dvt.AutoSize = true;
            this.lbl_dvt.Location = new System.Drawing.Point(429, 103);
            this.lbl_dvt.Name = "lbl_dvt";
            this.lbl_dvt.Size = new System.Drawing.Size(63, 13);
            this.lbl_dvt.TabIndex = 6;
            this.lbl_dvt.Text = "Đơn vị tính:";
            // 
            // lbl_dg
            // 
            this.lbl_dg.AutoSize = true;
            this.lbl_dg.Location = new System.Drawing.Point(429, 132);
            this.lbl_dg.Name = "lbl_dg";
            this.lbl_dg.Size = new System.Drawing.Size(47, 13);
            this.lbl_dg.TabIndex = 6;
            this.lbl_dg.Text = "Đơn giá:";
            // 
            // txt_mahh
            // 
            this.txt_mahh.Location = new System.Drawing.Point(177, 103);
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.Size = new System.Drawing.Size(159, 20);
            this.txt_mahh.TabIndex = 7;
            // 
            // txt_tenhh
            // 
            this.txt_tenhh.Location = new System.Drawing.Point(177, 162);
            this.txt_tenhh.Name = "txt_tenhh";
            this.txt_tenhh.Size = new System.Drawing.Size(159, 20);
            this.txt_tenhh.TabIndex = 7;
            // 
            // txt_dvtinh
            // 
            this.txt_dvtinh.Location = new System.Drawing.Point(502, 96);
            this.txt_dvtinh.Name = "txt_dvtinh";
            this.txt_dvtinh.Size = new System.Drawing.Size(159, 20);
            this.txt_dvtinh.TabIndex = 7;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(502, 129);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(159, 20);
            this.txt_dongia.TabIndex = 7;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(564, 214);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(432, 214);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(292, 214);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(162, 214);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_danhsachhanghoa
            // 
            this.dgv_danhsachhanghoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachhanghoa.Location = new System.Drawing.Point(-1, 263);
            this.dgv_danhsachhanghoa.Name = "dgv_danhsachhanghoa";
            this.dgv_danhsachhanghoa.Size = new System.Drawing.Size(801, 187);
            this.dgv_danhsachhanghoa.TabIndex = 12;
            this.dgv_danhsachhanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachhanghoa_CellContentClick);
            this.dgv_danhsachhanghoa.Click += new System.EventHandler(this.dgv_danhsachhanghoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "VAT:";
            // 
            // txt_vat
            // 
            this.txt_vat.Location = new System.Drawing.Point(502, 158);
            this.txt_vat.Name = "txt_vat";
            this.txt_vat.Size = new System.Drawing.Size(159, 20);
            this.txt_vat.TabIndex = 7;
            // 
            // cbo_maloai
            // 
            this.cbo_maloai.FormattingEnabled = true;
            this.cbo_maloai.Location = new System.Drawing.Point(177, 129);
            this.cbo_maloai.Name = "cbo_maloai";
            this.cbo_maloai.Size = new System.Drawing.Size(159, 21);
            this.cbo_maloai.TabIndex = 13;
            // 
            // Hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_maloai);
            this.Controls.Add(this.dgv_danhsachhanghoa);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_vat);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_tenhh);
            this.Controls.Add(this.txt_dvtinh);
            this.Controls.Add(this.txt_mahh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dg);
            this.Controls.Add(this.lbl_dvt);
            this.Controls.Add(this.lbl__thh);
            this.Controls.Add(this.lbl_ml);
            this.Controls.Add(this.lbl_mhh);
            this.Controls.Add(this.lbl_td);
            this.Name = "Hanghoa";
            this.Text = "Hàng hóa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hanghoa_FormClosing);
            this.Load += new System.EventHandler(this.Hanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label lbl_mhh;
        private System.Windows.Forms.Label lbl_ml;
        private System.Windows.Forms.Label lbl__thh;
        private System.Windows.Forms.Label lbl_dvt;
        private System.Windows.Forms.Label lbl_dg;
        private System.Windows.Forms.TextBox txt_mahh;
        private System.Windows.Forms.TextBox txt_tenhh;
        private System.Windows.Forms.TextBox txt_dvtinh;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_danhsachhanghoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vat;
        private System.Windows.Forms.ComboBox cbo_maloai;
    }
}