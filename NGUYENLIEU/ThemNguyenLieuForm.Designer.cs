
namespace QuanLyNhaHang
{
    partial class ThemNguyenLieuForm
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
            System.Windows.Forms.Label labelDonVi;
            this.comboBoxDonVi = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelKhoiLuong = new System.Windows.Forms.Label();
            this.labelTenNguyenLieu = new System.Windows.Forms.Label();
            this.textBoxKhoiLuong = new System.Windows.Forms.TextBox();
            this.textBoxTenNguyenLieu = new System.Windows.Forms.TextBox();
            labelDonVi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDonVi
            // 
            this.comboBoxDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDonVi.FormattingEnabled = true;
            this.comboBoxDonVi.Items.AddRange(new object[] {
            "kg",
            "gr",
            "l",
            "ml"});
            this.comboBoxDonVi.Location = new System.Drawing.Point(234, 207);
            this.comboBoxDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDonVi.Name = "comboBoxDonVi";
            this.comboBoxDonVi.Size = new System.Drawing.Size(204, 32);
            this.comboBoxDonVi.TabIndex = 18;
            // 
            // labelDonVi
            // 
            labelDonVi.AutoSize = true;
            labelDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDonVi.Location = new System.Drawing.Point(39, 210);
            labelDonVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelDonVi.Name = "labelDonVi";
            labelDonVi.Size = new System.Drawing.Size(79, 24);
            labelDonVi.TabIndex = 17;
            labelDonVi.Text = "Đơn Vị:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(303, 276);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 50);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.Firebrick;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(131, 276);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(135, 50);
            this.buttonThem.TabIndex = 15;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(124, 23);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(298, 38);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Thêm Nguyên Liệu";
            // 
            // labelKhoiLuong
            // 
            this.labelKhoiLuong.AutoSize = true;
            this.labelKhoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhoiLuong.Location = new System.Drawing.Point(39, 156);
            this.labelKhoiLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKhoiLuong.Name = "labelKhoiLuong";
            this.labelKhoiLuong.Size = new System.Drawing.Size(123, 24);
            this.labelKhoiLuong.TabIndex = 13;
            this.labelKhoiLuong.Text = "Khối Lượng:";
            // 
            // labelTenNguyenLieu
            // 
            this.labelTenNguyenLieu.AutoSize = true;
            this.labelTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNguyenLieu.Location = new System.Drawing.Point(37, 108);
            this.labelTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenNguyenLieu.Name = "labelTenNguyenLieu";
            this.labelTenNguyenLieu.Size = new System.Drawing.Size(178, 24);
            this.labelTenNguyenLieu.TabIndex = 12;
            this.labelTenNguyenLieu.Text = "Tên Nguyên Liệu:";
            // 
            // textBoxKhoiLuong
            // 
            this.textBoxKhoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKhoiLuong.Location = new System.Drawing.Point(234, 155);
            this.textBoxKhoiLuong.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKhoiLuong.Name = "textBoxKhoiLuong";
            this.textBoxKhoiLuong.Size = new System.Drawing.Size(204, 29);
            this.textBoxKhoiLuong.TabIndex = 11;
            // 
            // textBoxTenNguyenLieu
            // 
            this.textBoxTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNguyenLieu.Location = new System.Drawing.Point(234, 107);
            this.textBoxTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenNguyenLieu.Name = "textBoxTenNguyenLieu";
            this.textBoxTenNguyenLieu.Size = new System.Drawing.Size(204, 29);
            this.textBoxTenNguyenLieu.TabIndex = 10;
            // 
            // ThemNguyenLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(500, 368);
            this.Controls.Add(this.comboBoxDonVi);
            this.Controls.Add(labelDonVi);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelKhoiLuong);
            this.Controls.Add(this.labelTenNguyenLieu);
            this.Controls.Add(this.textBoxKhoiLuong);
            this.Controls.Add(this.textBoxTenNguyenLieu);
            this.Name = "ThemNguyenLieuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguyenLieuForm";
            this.Load += new System.EventHandler(this.ThemNguyenLieuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDonVi;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelKhoiLuong;
        private System.Windows.Forms.Label labelTenNguyenLieu;
        private System.Windows.Forms.TextBox textBoxKhoiLuong;
        private System.Windows.Forms.TextBox textBoxTenNguyenLieu;
    }
}