
namespace QuanLyNhaHang
{
    partial class ChinhSuaNguyenLieuForm
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
            this.comboBoxDonVi = new System.Windows.Forms.ComboBox();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelTenNguyenLieu = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSoTien = new System.Windows.Forms.TextBox();
            this.labelSoTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.comboBoxDonVi.Location = new System.Drawing.Point(276, 303);
            this.comboBoxDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDonVi.Name = "comboBoxDonVi";
            this.comboBoxDonVi.Size = new System.Drawing.Size(202, 32);
            this.comboBoxDonVi.TabIndex = 20;
            // 
            // labelDonVi
            // 
            this.labelDonVi.AutoSize = true;
            this.labelDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonVi.Location = new System.Drawing.Point(62, 306);
            this.labelDonVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDonVi.Name = "labelDonVi";
            this.labelDonVi.Size = new System.Drawing.Size(79, 24);
            this.labelDonVi.TabIndex = 19;
            this.labelDonVi.Text = "Đơn Vị:";
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(27, 411);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(141, 49);
            this.buttonXoa.TabIndex = 18;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(276, 251);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(202, 29);
            this.textBoxSoLuong.TabIndex = 17;
            // 
            // textBoxTenNguyenLieu
            // 
            this.textBoxTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNguyenLieu.Location = new System.Drawing.Point(276, 197);
            this.textBoxTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenNguyenLieu.Name = "textBoxTenNguyenLieu";
            this.textBoxTenNguyenLieu.Size = new System.Drawing.Size(202, 29);
            this.textBoxTenNguyenLieu.TabIndex = 16;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.IndianRed;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(357, 411);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(141, 49);
            this.buttonHuy.TabIndex = 15;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhat.Location = new System.Drawing.Point(193, 411);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(141, 49);
            this.buttonCapNhat.TabIndex = 14;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(62, 251);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(106, 24);
            this.labelSoLuong.TabIndex = 13;
            this.labelSoLuong.Text = "Số Lượng:";
            // 
            // labelTenNguyenLieu
            // 
            this.labelTenNguyenLieu.AutoSize = true;
            this.labelTenNguyenLieu.BackColor = System.Drawing.Color.Coral;
            this.labelTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNguyenLieu.Location = new System.Drawing.Point(62, 199);
            this.labelTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenNguyenLieu.Name = "labelTenNguyenLieu";
            this.labelTenNguyenLieu.Size = new System.Drawing.Size(178, 24);
            this.labelTenNguyenLieu.TabIndex = 12;
            this.labelTenNguyenLieu.Text = "Tên Nguyên Liệu:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(528, 142);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(575, 318);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(281, 35);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(368, 38);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "Chỉnh Sửa Nguyên Liệu";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(62, 142);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(169, 24);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "Mã Nguyên Liệu:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(276, 142);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(202, 29);
            this.textBoxID.TabIndex = 22;
            // 
            // textBoxSoTien
            // 
            this.textBoxSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoTien.Location = new System.Drawing.Point(276, 360);
            this.textBoxSoTien.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSoTien.Name = "textBoxSoTien";
            this.textBoxSoTien.Size = new System.Drawing.Size(202, 29);
            this.textBoxSoTien.TabIndex = 27;
            // 
            // labelSoTien
            // 
            this.labelSoTien.AutoSize = true;
            this.labelSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoTien.Location = new System.Drawing.Point(62, 364);
            this.labelSoTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.Size = new System.Drawing.Size(89, 24);
            this.labelSoTien.TabIndex = 26;
            this.labelSoTien.Text = "Số Tiền:";
            // 
            // ChinhSuaNguyenLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1138, 526);
            this.Controls.Add(this.textBoxSoTien);
            this.Controls.Add(this.labelSoTien);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxDonVi);
            this.Controls.Add(this.labelDonVi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxTenNguyenLieu);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelTenNguyenLieu);
            this.Controls.Add(this.dataGridView);
            this.Name = "ChinhSuaNguyenLieuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSuaNguyenLieuForm";
            this.Load += new System.EventHandler(this.ChinhSuaNguyenLieuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDonVi;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxTenNguyenLieu;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelTenNguyenLieu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxSoTien;
        private System.Windows.Forms.Label labelSoTien;
    }
}