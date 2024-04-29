namespace TranNhatThang_QLSV
{
    partial class FrmTimKiem_SinhVien_SQL
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
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridKetQua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.optMalop = new System.Windows.Forms.RadioButton();
            this.optHoten = new System.Windows.Forms.RadioButton();
            this.optMasv = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaLop
            // 
            this.cboMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(189, 143);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(372, 28);
            this.cboMaLop.TabIndex = 15;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(189, 104);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(372, 27);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(189, 69);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(372, 27);
            this.txtMaSV.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(662, 123);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 44);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(662, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 44);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridKetQua
            // 
            this.dataGridKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKetQua.Location = new System.Drawing.Point(12, 207);
            this.dataGridKetQua.Name = "dataGridKetQua";
            this.dataGridKetQua.RowHeadersWidth = 51;
            this.dataGridKetQua.RowTemplate.Height = 24;
            this.dataGridKetQua.Size = new System.Drawing.Size(776, 219);
            this.dataGridKetQua.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM THÔNG TIN SINH VIÊN";
            // 
            // optMalop
            // 
            this.optMalop.AutoSize = true;
            this.optMalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMalop.Location = new System.Drawing.Point(87, 147);
            this.optMalop.Name = "optMalop";
            this.optMalop.Size = new System.Drawing.Size(85, 24);
            this.optMalop.TabIndex = 18;
            this.optMalop.TabStop = true;
            this.optMalop.Text = "Mã lớp:";
            this.optMalop.UseVisualStyleBackColor = true;
            // 
            // optHoten
            // 
            this.optHoten.AutoSize = true;
            this.optHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHoten.Location = new System.Drawing.Point(87, 108);
            this.optHoten.Name = "optHoten";
            this.optHoten.Size = new System.Drawing.Size(90, 24);
            this.optHoten.TabIndex = 16;
            this.optHoten.TabStop = true;
            this.optHoten.Text = "Họ tên: ";
            this.optHoten.UseVisualStyleBackColor = true;
            // 
            // optMasv
            // 
            this.optMasv.AutoSize = true;
            this.optMasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMasv.Location = new System.Drawing.Point(87, 73);
            this.optMasv.Name = "optMasv";
            this.optMasv.Size = new System.Drawing.Size(85, 24);
            this.optMasv.TabIndex = 17;
            this.optMasv.TabStop = true;
            this.optMasv.Text = "Mã SV:";
            this.optMasv.UseVisualStyleBackColor = true;
            // 
            // FrmTimKiem_SinhVien_SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.optMalop);
            this.Controls.Add(this.optHoten);
            this.Controls.Add(this.optMasv);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridKetQua);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiem_SinhVien_SQL";
            this.Text = "FrmTimKiem_SinhVien_SQL";
            this.Load += new System.EventHandler(this.FrmTimKiem_SinhVien_SQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optMalop;
        private System.Windows.Forms.RadioButton optHoten;
        private System.Windows.Forms.RadioButton optMasv;
    }
}