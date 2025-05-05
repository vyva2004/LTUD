namespace WindowsFormsApp1
{
    partial class Nhacungcap
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
            this.lbl_mncc = new System.Windows.Forms.Label();
            this.lbl_tncc = new System.Windows.Forms.Label();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.lbl_dc = new System.Windows.Forms.Label();
            this.lbl_mst = new System.Windows.Forms.Label();
            this.txt_manhacungcap = new System.Windows.Forms.TextBox();
            this.txt_tennhacungcap = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_masothue = new System.Windows.Forms.TextBox();
            this.dgv_danhsachnhacungcap = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachnhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_td
            // 
            this.lbl_td.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_td.AutoSize = true;
            this.lbl_td.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_td.Location = new System.Drawing.Point(241, 21);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(323, 29);
            this.lbl_td.TabIndex = 1;
            this.lbl_td.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mncc
            // 
            this.lbl_mncc.AutoSize = true;
            this.lbl_mncc.Location = new System.Drawing.Point(44, 80);
            this.lbl_mncc.Name = "lbl_mncc";
            this.lbl_mncc.Size = new System.Drawing.Size(94, 13);
            this.lbl_mncc.TabIndex = 2;
            this.lbl_mncc.Text = "Mã nhà cung cấp:";
            // 
            // lbl_tncc
            // 
            this.lbl_tncc.AutoSize = true;
            this.lbl_tncc.Location = new System.Drawing.Point(44, 106);
            this.lbl_tncc.Name = "lbl_tncc";
            this.lbl_tncc.Size = new System.Drawing.Size(98, 13);
            this.lbl_tncc.TabIndex = 2;
            this.lbl_tncc.Text = "Tên nhà cung cấp:";
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(44, 134);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(73, 13);
            this.lbl_sdt.TabIndex = 2;
            this.lbl_sdt.Text = "Số điện thoại:";
            // 
            // lbl_dc
            // 
            this.lbl_dc.AutoSize = true;
            this.lbl_dc.Location = new System.Drawing.Point(44, 162);
            this.lbl_dc.Name = "lbl_dc";
            this.lbl_dc.Size = new System.Drawing.Size(43, 13);
            this.lbl_dc.TabIndex = 2;
            this.lbl_dc.Text = "Địa chỉ:";
            // 
            // lbl_mst
            // 
            this.lbl_mst.AutoSize = true;
            this.lbl_mst.Location = new System.Drawing.Point(44, 192);
            this.lbl_mst.Name = "lbl_mst";
            this.lbl_mst.Size = new System.Drawing.Size(63, 13);
            this.lbl_mst.TabIndex = 2;
            this.lbl_mst.Text = "Mã số thuế:";
            // 
            // txt_manhacungcap
            // 
            this.txt_manhacungcap.Location = new System.Drawing.Point(166, 80);
            this.txt_manhacungcap.Name = "txt_manhacungcap";
            this.txt_manhacungcap.Size = new System.Drawing.Size(234, 20);
            this.txt_manhacungcap.TabIndex = 3;
            // 
            // txt_tennhacungcap
            // 
            this.txt_tennhacungcap.Location = new System.Drawing.Point(166, 106);
            this.txt_tennhacungcap.Name = "txt_tennhacungcap";
            this.txt_tennhacungcap.Size = new System.Drawing.Size(234, 20);
            this.txt_tennhacungcap.TabIndex = 3;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(166, 131);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(234, 20);
            this.txt_sdt.TabIndex = 3;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(166, 159);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(234, 20);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_masothue
            // 
            this.txt_masothue.Location = new System.Drawing.Point(166, 185);
            this.txt_masothue.Name = "txt_masothue";
            this.txt_masothue.Size = new System.Drawing.Size(234, 20);
            this.txt_masothue.TabIndex = 3;
            // 
            // dgv_danhsachnhacungcap
            // 
            this.dgv_danhsachnhacungcap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachnhacungcap.Location = new System.Drawing.Point(1, 223);
            this.dgv_danhsachnhacungcap.Name = "dgv_danhsachnhacungcap";
            this.dgv_danhsachnhacungcap.Size = new System.Drawing.Size(800, 229);
            this.dgv_danhsachnhacungcap.TabIndex = 4;
            this.dgv_danhsachnhacungcap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachnhacungcap_CellContentClick);
            this.dgv_danhsachnhacungcap.Click += new System.EventHandler(this.dgv_danhsachnhacungcap_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(427, 80);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(427, 115);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(427, 153);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(427, 187);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_danhsachnhacungcap);
            this.Controls.Add(this.txt_masothue);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tennhacungcap);
            this.Controls.Add(this.txt_manhacungcap);
            this.Controls.Add(this.lbl_mst);
            this.Controls.Add(this.lbl_dc);
            this.Controls.Add(this.lbl_sdt);
            this.Controls.Add(this.lbl_tncc);
            this.Controls.Add(this.lbl_mncc);
            this.Controls.Add(this.lbl_td);
            this.Name = "Nhacungcap";
            this.Text = "Nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nhacungcap_FormClosing);
            this.Load += new System.EventHandler(this.Nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachnhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label lbl_mncc;
        private System.Windows.Forms.Label lbl_tncc;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.Label lbl_dc;
        private System.Windows.Forms.Label lbl_mst;
        private System.Windows.Forms.TextBox txt_manhacungcap;
        private System.Windows.Forms.TextBox txt_tennhacungcap;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_masothue;
        private System.Windows.Forms.DataGridView dgv_danhsachnhacungcap;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
    }
}