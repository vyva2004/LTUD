namespace WindowsFormsApp1
{
    partial class Chucvu
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
            this.lbl_mcv = new System.Windows.Forms.Label();
            this.lbl_tcv = new System.Windows.Forms.Label();
            this.txt_machucvu = new System.Windows.Forms.TextBox();
            this.dgv_danhsachchucvu = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_tenchucvu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachchucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_td
            // 
            this.lbl_td.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_td.AutoSize = true;
            this.lbl_td.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_td.Location = new System.Drawing.Point(282, 28);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(244, 29);
            this.lbl_td.TabIndex = 2;
            this.lbl_td.Text = "QUẢN LÝ CHỨC VỤ";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mcv
            // 
            this.lbl_mcv.AutoSize = true;
            this.lbl_mcv.Location = new System.Drawing.Point(77, 114);
            this.lbl_mcv.Name = "lbl_mcv";
            this.lbl_mcv.Size = new System.Drawing.Size(67, 13);
            this.lbl_mcv.TabIndex = 3;
            this.lbl_mcv.Text = "Mã chức vụ:";
            // 
            // lbl_tcv
            // 
            this.lbl_tcv.AutoSize = true;
            this.lbl_tcv.Location = new System.Drawing.Point(77, 152);
            this.lbl_tcv.Name = "lbl_tcv";
            this.lbl_tcv.Size = new System.Drawing.Size(71, 13);
            this.lbl_tcv.TabIndex = 3;
            this.lbl_tcv.Text = "Tên chức vụ:";
            // 
            // txt_machucvu
            // 
            this.txt_machucvu.Location = new System.Drawing.Point(177, 106);
            this.txt_machucvu.Name = "txt_machucvu";
            this.txt_machucvu.Size = new System.Drawing.Size(121, 20);
            this.txt_machucvu.TabIndex = 5;
            // 
            // dgv_danhsachchucvu
            // 
            this.dgv_danhsachchucvu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhsachchucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachchucvu.Location = new System.Drawing.Point(-1, 273);
            this.dgv_danhsachchucvu.Name = "dgv_danhsachchucvu";
            this.dgv_danhsachchucvu.Size = new System.Drawing.Size(802, 177);
            this.dgv_danhsachchucvu.TabIndex = 6;
            this.dgv_danhsachchucvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachchucvu_CellContentClick);
            this.dgv_danhsachchucvu.Click += new System.EventHandler(this.dgv_danhsachchucvu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(390, 106);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(519, 106);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(390, 161);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(519, 161);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_tenchucvu
            // 
            this.txt_tenchucvu.Location = new System.Drawing.Point(177, 152);
            this.txt_tenchucvu.Name = "txt_tenchucvu";
            this.txt_tenchucvu.Size = new System.Drawing.Size(121, 20);
            this.txt_tenchucvu.TabIndex = 8;
            // 
            // Chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tenchucvu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_danhsachchucvu);
            this.Controls.Add(this.txt_machucvu);
            this.Controls.Add(this.lbl_tcv);
            this.Controls.Add(this.lbl_mcv);
            this.Controls.Add(this.lbl_td);
            this.Name = "Chucvu";
            this.Text = "Chức vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chucvu_FormClosing);
            this.Load += new System.EventHandler(this.Chucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachchucvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label lbl_mcv;
        private System.Windows.Forms.Label lbl_tcv;
        private System.Windows.Forms.TextBox txt_machucvu;
        private System.Windows.Forms.DataGridView dgv_danhsachchucvu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_tenchucvu;
    }
}