
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
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.linkLabelTaiKhoanDangNhap = new System.Windows.Forms.LinkLabel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.groupBoxChucVu = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMucDichOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonMucDichQuanLy = new System.Windows.Forms.RadioButton();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.pictureBoxLogoDangNhap = new System.Windows.Forms.PictureBox();
            this.radioButtonChamCong = new System.Windows.Forms.RadioButton();
            this.groupBoxChucVu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDangNhap)).BeginInit();
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
            // buttonDangKy
            // 
            this.buttonDangKy.AutoSize = true;
            this.buttonDangKy.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangKy.ForeColor = System.Drawing.Color.Blue;
            this.buttonDangKy.Location = new System.Drawing.Point(104, 440);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(194, 54);
            this.buttonDangKy.TabIndex = 32;
            this.buttonDangKy.Text = "Đăng Ký";
            this.buttonDangKy.UseVisualStyleBackColor = false;
            this.buttonDangKy.Click += new System.EventHandler(this.buttonDangKy_Click);
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
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.Silver;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonThoat.Location = new System.Drawing.Point(538, 440);
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
            this.buttonDangNhap.Location = new System.Drawing.Point(321, 440);
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
            this.groupBoxChucVu.Location = new System.Drawing.Point(265, 616);
            this.groupBoxChucVu.Name = "groupBoxChucVu";
            this.groupBoxChucVu.Size = new System.Drawing.Size(336, 62);
            this.groupBoxChucVu.TabIndex = 35;
            this.groupBoxChucVu.TabStop = false;
            this.groupBoxChucVu.Text = "Chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.radioButtonMucDichOrder);
            this.groupBox1.Controls.Add(this.radioButtonMucDichQuanLy);
            this.groupBox1.Location = new System.Drawing.Point(265, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 62);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mục Đích";
            // 
            // radioButtonMucDichOrder
            // 
            this.radioButtonMucDichOrder.AutoSize = true;
            this.radioButtonMucDichOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMucDichOrder.Location = new System.Drawing.Point(32, 19);
            this.radioButtonMucDichOrder.Name = "radioButtonMucDichOrder";
            this.radioButtonMucDichOrder.Size = new System.Drawing.Size(64, 22);
            this.radioButtonMucDichOrder.TabIndex = 33;
            this.radioButtonMucDichOrder.TabStop = true;
            this.radioButtonMucDichOrder.Text = "Order";
            this.radioButtonMucDichOrder.UseVisualStyleBackColor = true;
            this.radioButtonMucDichOrder.CheckedChanged += new System.EventHandler(this.radioButtonMucDichOrder_CheckedChanged);
            // 
            // radioButtonMucDichQuanLy
            // 
            this.radioButtonMucDichQuanLy.AutoSize = true;
            this.radioButtonMucDichQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMucDichQuanLy.Location = new System.Drawing.Point(121, 19);
            this.radioButtonMucDichQuanLy.Name = "radioButtonMucDichQuanLy";
            this.radioButtonMucDichQuanLy.Size = new System.Drawing.Size(81, 22);
            this.radioButtonMucDichQuanLy.TabIndex = 34;
            this.radioButtonMucDichQuanLy.TabStop = true;
            this.radioButtonMucDichQuanLy.Text = "Quản Lý";
            this.radioButtonMucDichQuanLy.UseVisualStyleBackColor = true;
            this.radioButtonMucDichQuanLy.CheckedChanged += new System.EventHandler(this.radioButtonMucDichQuanLy_CheckedChanged);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.AutoSize = true;
            this.buttonCheckOut.BackColor = System.Drawing.Color.Cyan;
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.Black;
            this.buttonCheckOut.Location = new System.Drawing.Point(439, 342);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(194, 54);
            this.buttonCheckOut.TabIndex = 40;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = false;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.AutoSize = true;
            this.buttonCheckIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.Black;
            this.buttonCheckIn.Location = new System.Drawing.Point(239, 342);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(194, 54);
            this.buttonCheckIn.TabIndex = 39;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
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
            // radioButtonChamCong
            // 
            this.radioButtonChamCong.AutoSize = true;
            this.radioButtonChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChamCong.Location = new System.Drawing.Point(351, 563);
            this.radioButtonChamCong.Name = "radioButtonChamCong";
            this.radioButtonChamCong.Size = new System.Drawing.Size(93, 22);
            this.radioButtonChamCong.TabIndex = 35;
            this.radioButtonChamCong.TabStop = true;
            this.radioButtonChamCong.Text = "Nhân Viên";
            this.radioButtonChamCong.UseVisualStyleBackColor = true;
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(793, 712);
            this.Controls.Add(this.radioButtonChamCong);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxChucVu);
            this.Controls.Add(this.buttonDangKy);
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
            this.groupBoxChucVu.ResumeLayout(false);
            this.groupBoxChucVu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radioButtonQuanLy;
        public System.Windows.Forms.RadioButton radioButtonNhanVien;
        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.LinkLabel linkLabelTaiKhoanDangNhap;
        private System.Windows.Forms.PictureBox pictureBoxLogoDangNhap;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.GroupBox groupBoxChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButtonMucDichOrder;
        public System.Windows.Forms.RadioButton radioButtonMucDichQuanLy;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonCheckIn;
        public System.Windows.Forms.RadioButton radioButtonChamCong;
    }
}