
namespace QuanLyNhaHang
{
    partial class ThemBanAnForm
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
            this.buttonThemBanAn = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelBanAn = new System.Windows.Forms.Label();
            this.labelSoLuongGhe = new System.Windows.Forms.Label();
            this.labeltrangthai = new System.Windows.Forms.Label();
            this.textBoxIdBanAn = new System.Windows.Forms.TextBox();
            this.textBoxSoLuongGhe = new System.Windows.Forms.TextBox();
            this.radioButtonTrong = new System.Windows.Forms.RadioButton();
            this.radioButtonSuDung = new System.Windows.Forms.RadioButton();
            this.labelThemBanAn = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonThemBanAn
            // 
            this.buttonThemBanAn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonThemBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemBanAn.Location = new System.Drawing.Point(120, 319);
            this.buttonThemBanAn.Name = "buttonThemBanAn";
            this.buttonThemBanAn.Size = new System.Drawing.Size(173, 46);
            this.buttonThemBanAn.TabIndex = 0;
            this.buttonThemBanAn.Text = "Thêm Bàn Ăn";
            this.buttonThemBanAn.UseVisualStyleBackColor = false;
            this.buttonThemBanAn.Click += new System.EventHandler(this.buttonThemBanAn_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(341, 319);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(173, 46);
            this.buttonThoat.TabIndex = 1;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelBanAn
            // 
            this.labelBanAn.AutoSize = true;
            this.labelBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanAn.Location = new System.Drawing.Point(175, 102);
            this.labelBanAn.Name = "labelBanAn";
            this.labelBanAn.Size = new System.Drawing.Size(118, 24);
            this.labelBanAn.TabIndex = 2;
            this.labelBanAn.Text = "Mã Bàn Ăn:";
            // 
            // labelSoLuongGhe
            // 
            this.labelSoLuongGhe.AutoSize = true;
            this.labelSoLuongGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongGhe.Location = new System.Drawing.Point(57, 167);
            this.labelSoLuongGhe.Name = "labelSoLuongGhe";
            this.labelSoLuongGhe.Size = new System.Drawing.Size(236, 24);
            this.labelSoLuongGhe.TabIndex = 3;
            this.labelSoLuongGhe.Text = "Số Lượng Ghế Của Bàn:";
            // 
            // labeltrangthai
            // 
            this.labeltrangthai.AutoSize = true;
            this.labeltrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltrangthai.Location = new System.Drawing.Point(175, 233);
            this.labeltrangthai.Name = "labeltrangthai";
            this.labeltrangthai.Size = new System.Drawing.Size(118, 24);
            this.labeltrangthai.TabIndex = 4;
            this.labeltrangthai.Text = "Trạng Thái:";
            // 
            // textBoxIdBanAn
            // 
            this.textBoxIdBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdBanAn.Location = new System.Drawing.Point(341, 102);
            this.textBoxIdBanAn.Name = "textBoxIdBanAn";
            this.textBoxIdBanAn.Size = new System.Drawing.Size(185, 27);
            this.textBoxIdBanAn.TabIndex = 5;
            this.textBoxIdBanAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdBanAn_KeyPress);
            // 
            // textBoxSoLuongGhe
            // 
            this.textBoxSoLuongGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongGhe.Location = new System.Drawing.Point(341, 164);
            this.textBoxSoLuongGhe.Name = "textBoxSoLuongGhe";
            this.textBoxSoLuongGhe.Size = new System.Drawing.Size(185, 27);
            this.textBoxSoLuongGhe.TabIndex = 6;
            this.textBoxSoLuongGhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuongGhe_KeyPress);
            // 
            // radioButtonTrong
            // 
            this.radioButtonTrong.AutoSize = true;
            this.radioButtonTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrong.Location = new System.Drawing.Point(341, 233);
            this.radioButtonTrong.Name = "radioButtonTrong";
            this.radioButtonTrong.Size = new System.Drawing.Size(68, 24);
            this.radioButtonTrong.TabIndex = 7;
            this.radioButtonTrong.TabStop = true;
            this.radioButtonTrong.Text = "Trống";
            this.radioButtonTrong.UseVisualStyleBackColor = true;
            // 
            // radioButtonSuDung
            // 
            this.radioButtonSuDung.AutoSize = true;
            this.radioButtonSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSuDung.Location = new System.Drawing.Point(436, 233);
            this.radioButtonSuDung.Name = "radioButtonSuDung";
            this.radioButtonSuDung.Size = new System.Drawing.Size(90, 24);
            this.radioButtonSuDung.TabIndex = 8;
            this.radioButtonSuDung.TabStop = true;
            this.radioButtonSuDung.Text = "Sử Dụng";
            this.radioButtonSuDung.UseVisualStyleBackColor = true;
            this.radioButtonSuDung.CheckedChanged += new System.EventHandler(this.radioButtonSuDung_CheckedChanged);
            // 
            // labelThemBanAn
            // 
            this.labelThemBanAn.AutoSize = true;
            this.labelThemBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThemBanAn.ForeColor = System.Drawing.Color.Black;
            this.labelThemBanAn.Location = new System.Drawing.Point(163, 38);
            this.labelThemBanAn.Name = "labelThemBanAn";
            this.labelThemBanAn.Size = new System.Drawing.Size(268, 36);
            this.labelThemBanAn.TabIndex = 9;
            this.labelThemBanAn.Text = "Thêm Bàn Ăn Mới";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Yellow;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(547, 97);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(97, 35);
            this.buttonCheck.TabIndex = 10;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // ThemBanAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(678, 427);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelThemBanAn);
            this.Controls.Add(this.radioButtonSuDung);
            this.Controls.Add(this.radioButtonTrong);
            this.Controls.Add(this.textBoxSoLuongGhe);
            this.Controls.Add(this.textBoxIdBanAn);
            this.Controls.Add(this.labeltrangthai);
            this.Controls.Add(this.labelSoLuongGhe);
            this.Controls.Add(this.labelBanAn);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThemBanAn);
            this.Name = "ThemBanAnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemBanAnForm";
            this.Load += new System.EventHandler(this.ThemBanAnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThemBanAn;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelBanAn;
        private System.Windows.Forms.Label labelSoLuongGhe;
        private System.Windows.Forms.Label labeltrangthai;
        private System.Windows.Forms.TextBox textBoxIdBanAn;
        private System.Windows.Forms.TextBox textBoxSoLuongGhe;
        private System.Windows.Forms.RadioButton radioButtonTrong;
        private System.Windows.Forms.RadioButton radioButtonSuDung;
        private System.Windows.Forms.Label labelThemBanAn;
        private System.Windows.Forms.Button buttonCheck;
    }
}