
namespace QuanLyNhaHang
{
    partial class PhanCongNhanSuForm
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
            this.dataGridViewPhanCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPhanCong = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaCaLam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChinhSua = new System.Windows.Forms.Button();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonDaoCaLam = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.radioButtonTatCa = new System.Windows.Forms.RadioButton();
            this.radioButtonNhanVien = new System.Windows.Forms.RadioButton();
            this.radioButtonQuanLy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDaoCaQuanLy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhanCong
            // 
            this.dataGridViewPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhanCong.Location = new System.Drawing.Point(66, 258);
            this.dataGridViewPhanCong.Name = "dataGridViewPhanCong";
            this.dataGridViewPhanCong.Size = new System.Drawing.Size(384, 249);
            this.dataGridViewPhanCong.TabIndex = 0;
            this.dataGridViewPhanCong.DoubleClick += new System.EventHandler(this.dataGridViewPhanCong_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chú Thích Mã Ca Làm Đối Với Nhân Viên\r\nMã Ca = 1 => Ca 1 và Ca 2\r\nMã Ca = 2 => Ca" +
    " 2 và Ca 3\r\nMã Ca = 3 => Ca 3 và Ca 1";
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(822, 629);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(115, 41);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phân Công";
            // 
            // labelPhanCong
            // 
            this.labelPhanCong.AutoSize = true;
            this.labelPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhanCong.Location = new System.Drawing.Point(68, 136);
            this.labelPhanCong.Name = "labelPhanCong";
            this.labelPhanCong.Size = new System.Drawing.Size(188, 39);
            this.labelPhanCong.TabIndex = 4;
            this.labelPhanCong.Text = "Phân Công";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.Black;
            this.textBoxId.Location = new System.Drawing.Point(671, 381);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(266, 30);
            this.textBoxId.TabIndex = 51;
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTaiKhoan.Location = new System.Drawing.Point(511, 388);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(126, 20);
            this.labelTaiKhoan.TabIndex = 50;
            this.labelTaiKhoan.Text = "Mã Nhân Viên:";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxHoTen.Location = new System.Drawing.Point(671, 429);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(266, 30);
            this.textBoxHoTen.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(511, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Họ Và Tên:";
            // 
            // textBoxMaCaLam
            // 
            this.textBoxMaCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaCaLam.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaCaLam.Location = new System.Drawing.Point(671, 480);
            this.textBoxMaCaLam.Name = "textBoxMaCaLam";
            this.textBoxMaCaLam.Size = new System.Drawing.Size(266, 30);
            this.textBoxMaCaLam.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(511, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Mã Ca Làm:";
            // 
            // buttonChinhSua
            // 
            this.buttonChinhSua.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChinhSua.Location = new System.Drawing.Point(514, 550);
            this.buttonChinhSua.Name = "buttonChinhSua";
            this.buttonChinhSua.Size = new System.Drawing.Size(123, 41);
            this.buttonChinhSua.TabIndex = 56;
            this.buttonChinhSua.Text = "Chỉnh Sửa";
            this.buttonChinhSua.UseVisualStyleBackColor = false;
            this.buttonChinhSua.Click += new System.EventHandler(this.buttonChinhSua_Click);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.BackColor = System.Drawing.Color.Yellow;
            this.buttonTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiLai.Location = new System.Drawing.Point(327, 530);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(123, 41);
            this.buttonTaiLai.TabIndex = 57;
            this.buttonTaiLai.Text = "Tải Lại";
            this.buttonTaiLai.UseVisualStyleBackColor = false;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.Aqua;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(671, 550);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(123, 41);
            this.buttonThem.TabIndex = 58;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonDaoCaLam
            // 
            this.buttonDaoCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonDaoCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaoCaLam.Location = new System.Drawing.Point(66, 530);
            this.buttonDaoCaLam.Name = "buttonDaoCaLam";
            this.buttonDaoCaLam.Size = new System.Drawing.Size(236, 41);
            this.buttonDaoCaLam.TabIndex = 59;
            this.buttonDaoCaLam.Text = "Đảo Ca Nhân Viên";
            this.buttonDaoCaLam.UseVisualStyleBackColor = false;
            this.buttonDaoCaLam.Click += new System.EventHandler(this.buttonDaoCaLam_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(822, 550);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(115, 41);
            this.buttonXoa.TabIndex = 60;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // radioButtonTatCa
            // 
            this.radioButtonTatCa.AutoSize = true;
            this.radioButtonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTatCa.Location = new System.Drawing.Point(66, 212);
            this.radioButtonTatCa.Name = "radioButtonTatCa";
            this.radioButtonTatCa.Size = new System.Drawing.Size(89, 26);
            this.radioButtonTatCa.TabIndex = 64;
            this.radioButtonTatCa.TabStop = true;
            this.radioButtonTatCa.Text = "Tất Cả";
            this.radioButtonTatCa.UseVisualStyleBackColor = true;
            this.radioButtonTatCa.CheckedChanged += new System.EventHandler(this.radioButtonTatCa_CheckedChanged);
            // 
            // radioButtonNhanVien
            // 
            this.radioButtonNhanVien.AutoSize = true;
            this.radioButtonNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNhanVien.Location = new System.Drawing.Point(194, 212);
            this.radioButtonNhanVien.Name = "radioButtonNhanVien";
            this.radioButtonNhanVien.Size = new System.Drawing.Size(121, 26);
            this.radioButtonNhanVien.TabIndex = 63;
            this.radioButtonNhanVien.TabStop = true;
            this.radioButtonNhanVien.Text = "Nhân Viên";
            this.radioButtonNhanVien.UseVisualStyleBackColor = true;
            this.radioButtonNhanVien.CheckedChanged += new System.EventHandler(this.radioButtonNhanVien_CheckedChanged);
            // 
            // radioButtonQuanLy
            // 
            this.radioButtonQuanLy.AutoSize = true;
            this.radioButtonQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuanLy.Location = new System.Drawing.Point(347, 212);
            this.radioButtonQuanLy.Name = "radioButtonQuanLy";
            this.radioButtonQuanLy.Size = new System.Drawing.Size(103, 26);
            this.radioButtonQuanLy.TabIndex = 62;
            this.radioButtonQuanLy.TabStop = true;
            this.radioButtonQuanLy.Text = "Quản Lý";
            this.radioButtonQuanLy.UseVisualStyleBackColor = true;
            this.radioButtonQuanLy.CheckedChanged += new System.EventHandler(this.radioButtonQuanLy_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 176);
            this.label3.TabIndex = 65;
            this.label3.Text = "Chú Thích Mã Ca Làm Đối Với Quản Lý\r\nMã Ca = 1 => Ca 1 và Ca 2\r\nMã Ca = 2 => Ca 3" +
    " \r\nMã Ca = 3 => Ca 2 và Ca 3\r\nMã Ca = 4 => Ca 1 \r\nMã Ca = 5 => Ca 3 và Ca 1\r\nMã " +
    "Ca = 6 => Ca 2 \r\n\r\n";
            // 
            // buttonDaoCaQuanLy
            // 
            this.buttonDaoCaQuanLy.BackColor = System.Drawing.Color.Magenta;
            this.buttonDaoCaQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaoCaQuanLy.Location = new System.Drawing.Point(68, 592);
            this.buttonDaoCaQuanLy.Name = "buttonDaoCaQuanLy";
            this.buttonDaoCaQuanLy.Size = new System.Drawing.Size(382, 41);
            this.buttonDaoCaQuanLy.TabIndex = 66;
            this.buttonDaoCaQuanLy.Text = "Đảo Ca Làm Quản Lý";
            this.buttonDaoCaQuanLy.UseVisualStyleBackColor = false;
            this.buttonDaoCaQuanLy.Click += new System.EventHandler(this.buttonDaoCaQuanLy_Click);
            // 
            // PhanCongNhanSuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1016, 707);
            this.Controls.Add(this.buttonDaoCaQuanLy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonTatCa);
            this.Controls.Add(this.radioButtonNhanVien);
            this.Controls.Add(this.radioButtonQuanLy);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonDaoCaLam);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonChinhSua);
            this.Controls.Add(this.textBoxMaCaLam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelTaiKhoan);
            this.Controls.Add(this.labelPhanCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPhanCong);
            this.Name = "PhanCongNhanSuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCongNhanSuForm";
            this.Load += new System.EventHandler(this.PhanCongNhanSuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhanCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPhanCong;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaCaLam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChinhSua;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonDaoCaLam;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.RadioButton radioButtonTatCa;
        private System.Windows.Forms.RadioButton radioButtonNhanVien;
        private System.Windows.Forms.RadioButton radioButtonQuanLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDaoCaQuanLy;
    }
}