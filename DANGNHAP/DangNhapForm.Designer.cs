
namespace QuanLyNhaHang
{
    partial class DangNhapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            this.radioButtonQuanLy = new System.Windows.Forms.RadioButton();
            this.radioButtonNhanVien = new System.Windows.Forms.RadioButton();
            this.buttonThemTaiKhoan = new System.Windows.Forms.Button();
            this.linkLabelTaiKhoanDangNhap = new System.Windows.Forms.LinkLabel();
            this.pictureBoxLogoDangNhap = new System.Windows.Forms.PictureBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.groupBoxChucVu = new System.Windows.Forms.GroupBox();
            this.groupBoxCaLamViec = new System.Windows.Forms.GroupBox();
            this.radioButtonCa1 = new System.Windows.Forms.RadioButton();
            this.radioButtonCa2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCa3 = new System.Windows.Forms.RadioButton();
            this.radioButtonTamNghi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDangNhap)).BeginInit();
            this.groupBoxChucVu.SuspendLayout();
            this.groupBoxCaLamViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonQuanLy
            // 
            this.radioButtonQuanLy.AutoSize = true;
            this.radioButtonQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuanLy.Location = new System.Drawing.Point(168, 19);
            this.radioButtonQuanLy.Name = "radioButtonQuanLy";
            this.radioButtonQuanLy.Size = new System.Drawing.Size(81, 22);
            this.radioButtonQuanLy.TabIndex = 34;
            this.radioButtonQuanLy.TabStop = true;
            this.radioButtonQuanLy.Text = "Quản Lý";
            this.radioButtonQuanLy.UseVisualStyleBackColor = true;
            this.radioButtonQuanLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radioButtonQuanLy_KeyPress);
            // 
            // radioButtonNhanVien
            // 
            this.radioButtonNhanVien.AutoSize = true;
            this.radioButtonNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNhanVien.Location = new System.Drawing.Point(31, 19);
            this.radioButtonNhanVien.Name = "radioButtonNhanVien";
            this.radioButtonNhanVien.Size = new System.Drawing.Size(93, 22);
            this.radioButtonNhanVien.TabIndex = 33;
            this.radioButtonNhanVien.TabStop = true;
            this.radioButtonNhanVien.Text = "Nhân Viên";
            this.radioButtonNhanVien.UseVisualStyleBackColor = true;
            // 
            // buttonThemTaiKhoan
            // 
            this.buttonThemTaiKhoan.AutoSize = true;
            this.buttonThemTaiKhoan.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.buttonThemTaiKhoan.Location = new System.Drawing.Point(85, 435);
            this.buttonThemTaiKhoan.Name = "buttonThemTaiKhoan";
            this.buttonThemTaiKhoan.Size = new System.Drawing.Size(194, 54);
            this.buttonThemTaiKhoan.TabIndex = 32;
            this.buttonThemTaiKhoan.Text = "Thêm Tài Khoản";
            this.buttonThemTaiKhoan.UseVisualStyleBackColor = false;
            this.buttonThemTaiKhoan.Click += new System.EventHandler(this.buttonThemTaiKhoan_Click);
            // 
            // linkLabelTaiKhoanDangNhap
            // 
            this.linkLabelTaiKhoanDangNhap.AutoSize = true;
            this.linkLabelTaiKhoanDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTaiKhoanDangNhap.ForeColor = System.Drawing.Color.Red;
            this.linkLabelTaiKhoanDangNhap.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelTaiKhoanDangNhap.Location = new System.Drawing.Point(259, 60);
            this.linkLabelTaiKhoanDangNhap.Name = "linkLabelTaiKhoanDangNhap";
            this.linkLabelTaiKhoanDangNhap.Size = new System.Drawing.Size(374, 39);
            this.linkLabelTaiKhoanDangNhap.TabIndex = 31;
            this.linkLabelTaiKhoanDangNhap.TabStop = true;
            this.linkLabelTaiKhoanDangNhap.Text = "Tài Khoản Đăng Nhập";
            // 
            // pictureBoxLogoDangNhap
            // 
            this.pictureBoxLogoDangNhap.Image = global::QuanLyNhaHang.Properties.Resources.mau_sac_logo_1024x640;
            this.pictureBoxLogoDangNhap.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoDangNhap.InitialImage")));
            this.pictureBoxLogoDangNhap.Location = new System.Drawing.Point(90, 37);
            this.pictureBoxLogoDangNhap.Name = "pictureBoxLogoDangNhap";
            this.pictureBoxLogoDangNhap.Size = new System.Drawing.Size(116, 77);
            this.pictureBoxLogoDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoDangNhap.TabIndex = 30;
            this.pictureBoxLogoDangNhap.TabStop = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.Silver;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonThoat.Location = new System.Drawing.Point(514, 435);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(194, 54);
            this.buttonThoat.TabIndex = 29;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.AutoSize = true;
            this.buttonDangNhap.BackColor = System.Drawing.Color.Gold;
            this.buttonDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.Color.Red;
            this.buttonDangNhap.Location = new System.Drawing.Point(302, 435);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(194, 54);
            this.buttonDangNhap.TabIndex = 28;
            this.buttonDangNhap.Text = "Đăng Nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatKhau.ForeColor = System.Drawing.Color.Black;
            this.textBoxMatKhau.Location = new System.Drawing.Point(265, 193);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '*';
            this.textBoxMatKhau.Size = new System.Drawing.Size(337, 30);
            this.textBoxMatKhau.TabIndex = 27;
            this.textBoxMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMatKhau_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(136, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật Khẩu:";
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(265, 136);
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(337, 30);
            this.textBoxTaiKhoan.TabIndex = 25;
            this.textBoxTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTaiKhoan_KeyPress);
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTaiKhoan.Location = new System.Drawing.Point(136, 136);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(94, 20);
            this.labelTaiKhoan.TabIndex = 24;
            this.labelTaiKhoan.Text = "Tài Khoản:";
            // 
            // groupBoxChucVu
            // 
            this.groupBoxChucVu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxChucVu.Controls.Add(this.radioButtonNhanVien);
            this.groupBoxChucVu.Controls.Add(this.radioButtonQuanLy);
            this.groupBoxChucVu.Location = new System.Drawing.Point(266, 250);
            this.groupBoxChucVu.Name = "groupBoxChucVu";
            this.groupBoxChucVu.Size = new System.Drawing.Size(336, 62);
            this.groupBoxChucVu.TabIndex = 35;
            this.groupBoxChucVu.TabStop = false;
            this.groupBoxChucVu.Text = "Chức vụ";
            // 
            // groupBoxCaLamViec
            // 
            this.groupBoxCaLamViec.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxCaLamViec.Controls.Add(this.radioButtonCa3);
            this.groupBoxCaLamViec.Controls.Add(this.radioButtonTamNghi);
            this.groupBoxCaLamViec.Controls.Add(this.radioButtonCa1);
            this.groupBoxCaLamViec.Controls.Add(this.radioButtonCa2);
            this.groupBoxCaLamViec.Location = new System.Drawing.Point(198, 339);
            this.groupBoxCaLamViec.Name = "groupBoxCaLamViec";
            this.groupBoxCaLamViec.Size = new System.Drawing.Size(404, 62);
            this.groupBoxCaLamViec.TabIndex = 36;
            this.groupBoxCaLamViec.TabStop = false;
            this.groupBoxCaLamViec.Text = "Ca Làm Việc";
            // 
            // radioButtonCa1
            // 
            this.radioButtonCa1.AutoSize = true;
            this.radioButtonCa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCa1.Location = new System.Drawing.Point(44, 19);
            this.radioButtonCa1.Name = "radioButtonCa1";
            this.radioButtonCa1.Size = new System.Drawing.Size(57, 22);
            this.radioButtonCa1.TabIndex = 33;
            this.radioButtonCa1.TabStop = true;
            this.radioButtonCa1.Text = "Ca 1";
            this.radioButtonCa1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCa2
            // 
            this.radioButtonCa2.AutoSize = true;
            this.radioButtonCa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCa2.Location = new System.Drawing.Point(123, 19);
            this.radioButtonCa2.Name = "radioButtonCa2";
            this.radioButtonCa2.Size = new System.Drawing.Size(57, 22);
            this.radioButtonCa2.TabIndex = 34;
            this.radioButtonCa2.TabStop = true;
            this.radioButtonCa2.Text = "Ca 2";
            this.radioButtonCa2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCa3
            // 
            this.radioButtonCa3.AutoSize = true;
            this.radioButtonCa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCa3.Location = new System.Drawing.Point(212, 19);
            this.radioButtonCa3.Name = "radioButtonCa3";
            this.radioButtonCa3.Size = new System.Drawing.Size(57, 22);
            this.radioButtonCa3.TabIndex = 35;
            this.radioButtonCa3.TabStop = true;
            this.radioButtonCa3.Text = "Ca 3";
            this.radioButtonCa3.UseVisualStyleBackColor = true;
            // 
            // radioButtonTamNghi
            // 
            this.radioButtonTamNghi.AutoSize = true;
            this.radioButtonTamNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTamNghi.Location = new System.Drawing.Point(303, 19);
            this.radioButtonTamNghi.Name = "radioButtonTamNghi";
            this.radioButtonTamNghi.Size = new System.Drawing.Size(90, 22);
            this.radioButtonTamNghi.TabIndex = 36;
            this.radioButtonTamNghi.TabStop = true;
            this.radioButtonTamNghi.Text = "Tạm Nghĩ";
            this.radioButtonTamNghi.UseVisualStyleBackColor = true;
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.groupBoxCaLamViec);
            this.Controls.Add(this.groupBoxChucVu);
            this.Controls.Add(this.buttonThemTaiKhoan);
            this.Controls.Add(this.linkLabelTaiKhoanDangNhap);
            this.Controls.Add(this.pictureBoxLogoDangNhap);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTaiKhoan);
            this.Controls.Add(this.labelTaiKhoan);
            this.Name = "DangNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhapForm";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDangNhap)).EndInit();
            this.groupBoxChucVu.ResumeLayout(false);
            this.groupBoxChucVu.PerformLayout();
            this.groupBoxCaLamViec.ResumeLayout(false);
            this.groupBoxCaLamViec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radioButtonQuanLy;
        public System.Windows.Forms.RadioButton radioButtonNhanVien;
        private System.Windows.Forms.Button buttonThemTaiKhoan;
        private System.Windows.Forms.LinkLabel linkLabelTaiKhoanDangNhap;
        private System.Windows.Forms.PictureBox pictureBoxLogoDangNhap;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.GroupBox groupBoxChucVu;
        private System.Windows.Forms.GroupBox groupBoxCaLamViec;
        public System.Windows.Forms.RadioButton radioButtonCa3;
        public System.Windows.Forms.RadioButton radioButtonTamNghi;
        public System.Windows.Forms.RadioButton radioButtonCa1;
        public System.Windows.Forms.RadioButton radioButtonCa2;
    }
}