
namespace QuanLyNhaHang
{
    partial class DanhSachBanAnForm
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
            this.labelDanhSachBanAn = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachBanAn = new System.Windows.Forms.DataGridView();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelTongSoLuongBanAn = new System.Windows.Forms.Label();
            this.labelDangSuDung = new System.Windows.Forms.Label();
            this.labelTongSoLuongBanTrong = new System.Windows.Forms.Label();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.labelSoLuongChoNgoi = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachBanAn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDanhSachBanAn
            // 
            this.labelDanhSachBanAn.AutoSize = true;
            this.labelDanhSachBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachBanAn.ForeColor = System.Drawing.Color.Black;
            this.labelDanhSachBanAn.Location = new System.Drawing.Point(242, 32);
            this.labelDanhSachBanAn.Name = "labelDanhSachBanAn";
            this.labelDanhSachBanAn.Size = new System.Drawing.Size(285, 36);
            this.labelDanhSachBanAn.TabIndex = 10;
            this.labelDanhSachBanAn.Text = "Danh Sách Bàn Ăn";
            // 
            // dataGridViewDanhSachBanAn
            // 
            this.dataGridViewDanhSachBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachBanAn.Location = new System.Drawing.Point(57, 174);
            this.dataGridViewDanhSachBanAn.Name = "dataGridViewDanhSachBanAn";
            this.dataGridViewDanhSachBanAn.Size = new System.Drawing.Size(363, 367);
            this.dataGridViewDanhSachBanAn.TabIndex = 11;
            this.dataGridViewDanhSachBanAn.DoubleClick += new System.EventHandler(this.dataGridViewDanhSachBanAn_DoubleClick);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(462, 495);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(173, 46);
            this.buttonThoat.TabIndex = 12;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelTongSoLuongBanAn
            // 
            this.labelTongSoLuongBanAn.AutoSize = true;
            this.labelTongSoLuongBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSoLuongBanAn.Location = new System.Drawing.Point(458, 178);
            this.labelTongSoLuongBanAn.Name = "labelTongSoLuongBanAn";
            this.labelTongSoLuongBanAn.Size = new System.Drawing.Size(179, 20);
            this.labelTongSoLuongBanAn.TabIndex = 25;
            this.labelTongSoLuongBanAn.Text = "Tổng Số Lượng Bàn Ăn:";
            // 
            // labelDangSuDung
            // 
            this.labelDangSuDung.AutoSize = true;
            this.labelDangSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangSuDung.Location = new System.Drawing.Point(458, 248);
            this.labelDangSuDung.Name = "labelDangSuDung";
            this.labelDangSuDung.Size = new System.Drawing.Size(216, 20);
            this.labelDangSuDung.TabIndex = 26;
            this.labelDangSuDung.Text = "Tổng Số Bàn Đang Sử Dụng:";
            // 
            // labelTongSoLuongBanTrong
            // 
            this.labelTongSoLuongBanTrong.AutoSize = true;
            this.labelTongSoLuongBanTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSoLuongBanTrong.Location = new System.Drawing.Point(458, 322);
            this.labelTongSoLuongBanTrong.Name = "labelTongSoLuongBanTrong";
            this.labelTongSoLuongBanTrong.Size = new System.Drawing.Size(151, 20);
            this.labelTongSoLuongBanTrong.TabIndex = 27;
            this.labelTongSoLuongBanTrong.Text = "Tổng Số Bàn Trống:";
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.BackColor = System.Drawing.Color.Yellow;
            this.buttonTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiLai.Location = new System.Drawing.Point(462, 403);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(173, 46);
            this.buttonTaiLai.TabIndex = 28;
            this.buttonTaiLai.Text = "Tải Lại";
            this.buttonTaiLai.UseVisualStyleBackColor = false;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // labelSoLuongChoNgoi
            // 
            this.labelSoLuongChoNgoi.AutoSize = true;
            this.labelSoLuongChoNgoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongChoNgoi.Location = new System.Drawing.Point(53, 115);
            this.labelSoLuongChoNgoi.Name = "labelSoLuongChoNgoi";
            this.labelSoLuongChoNgoi.Size = new System.Drawing.Size(169, 20);
            this.labelSoLuongChoNgoi.TabIndex = 29;
            this.labelSoLuongChoNgoi.Text = "Số Lượng Chổ Ngồi:";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(228, 115);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(101, 26);
            this.textBoxTimKiem.TabIndex = 30;
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(347, 111);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(73, 34);
            this.buttonTim.TabIndex = 31;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // DanhSachBanAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(761, 603);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.labelSoLuongChoNgoi);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.labelTongSoLuongBanTrong);
            this.Controls.Add(this.labelDangSuDung);
            this.Controls.Add(this.labelTongSoLuongBanAn);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.dataGridViewDanhSachBanAn);
            this.Controls.Add(this.labelDanhSachBanAn);
            this.Name = "DanhSachBanAnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachBanAnForm";
            this.Load += new System.EventHandler(this.DanhSachBanAnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachBanAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDanhSachBanAn;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachBanAn;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelTongSoLuongBanAn;
        private System.Windows.Forms.Label labelDangSuDung;
        private System.Windows.Forms.Label labelTongSoLuongBanTrong;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.Label labelSoLuongChoNgoi;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTim;
    }
}