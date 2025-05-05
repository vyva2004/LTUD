namespace WindowsFormsApp1
{
    partial class Loaihang
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
            this.lbl_ml = new System.Windows.Forms.Label();
            this.lbl_tl = new System.Windows.Forms.Label();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_danhsachloaihang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachloaihang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_td
            // 
            this.lbl_td.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_td.AutoSize = true;
            this.lbl_td.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_td.Location = new System.Drawing.Point(265, 44);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(267, 29);
            this.lbl_td.TabIndex = 5;
            this.lbl_td.Text = "QUẢN LÝ LOẠI HÀNG";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ml
            // 
            this.lbl_ml.AutoSize = true;
            this.lbl_ml.Location = new System.Drawing.Point(279, 111);
            this.lbl_ml.Name = "lbl_ml";
            this.lbl_ml.Size = new System.Drawing.Size(44, 13);
            this.lbl_ml.TabIndex = 6;
            this.lbl_ml.Text = "Mã loại:";
            // 
            // lbl_tl
            // 
            this.lbl_tl.AutoSize = true;
            this.lbl_tl.Location = new System.Drawing.Point(279, 155);
            this.lbl_tl.Name = "lbl_tl";
            this.lbl_tl.Size = new System.Drawing.Size(48, 13);
            this.lbl_tl.TabIndex = 6;
            this.lbl_tl.Text = "Tên loại:";
            this.lbl_tl.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(356, 108);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(151, 20);
            this.txt_maloai.TabIndex = 7;
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(356, 148);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(151, 20);
            this.txt_tenloai.TabIndex = 7;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(542, 206);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(410, 206);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(270, 206);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(140, 206);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_danhsachloaihang
            // 
            this.dgv_danhsachloaihang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachloaihang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachloaihang.Location = new System.Drawing.Point(0, 253);
            this.dgv_danhsachloaihang.Name = "dgv_danhsachloaihang";
            this.dgv_danhsachloaihang.Size = new System.Drawing.Size(799, 197);
            this.dgv_danhsachloaihang.TabIndex = 12;
            this.dgv_danhsachloaihang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachloaihang_CellContentClick);
            this.dgv_danhsachloaihang.Click += new System.EventHandler(this.dgv_danhsachloaihang_Click);
            // 
            // Loaihang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_danhsachloaihang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenloai);
            this.Controls.Add(this.txt_maloai);
            this.Controls.Add(this.lbl_tl);
            this.Controls.Add(this.lbl_ml);
            this.Controls.Add(this.lbl_td);
            this.Name = "Loaihang";
            this.Text = "Loại hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loaihang_FormClosing);
            this.Load += new System.EventHandler(this.Loaihang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachloaihang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label lbl_ml;
        private System.Windows.Forms.Label lbl_tl;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_danhsachloaihang;
    }
}