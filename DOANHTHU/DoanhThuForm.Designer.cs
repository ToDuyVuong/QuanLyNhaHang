
namespace QuanLyNhaHang
{
    partial class DoanhThuForm
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
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelLocTheoNgay = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLocTheo = new System.Windows.Forms.Label();
            this.radioButtonTheoNgay = new System.Windows.Forms.RadioButton();
            this.radioButtonTheoMucTien = new System.Windows.Forms.RadioButton();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxMucTienKetThuc = new System.Windows.Forms.TextBox();
            this.labelMucTienDen = new System.Windows.Forms.Label();
            this.textBoxMucTienBatDau = new System.Windows.Forms.TextBox();
            this.labelMucTien = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXuatFile = new System.Windows.Forms.Button();
            this.labelDoanhThu = new System.Windows.Forms.Label();
            this.buttonInFile = new System.Windows.Forms.Button();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(36, 132);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(378, 383);
            this.dataGridViewDoanhThu.TabIndex = 0;
            this.dataGridViewDoanhThu.DoubleClick += new System.EventHandler(this.dataGridViewDoanhThu_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.groupBox2.Controls.Add(this.labelLocTheoNgay);
            this.groupBox2.Controls.Add(this.dateTimePickerNgayBatDau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.CustomFormat = "";
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(397, 32);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerNgayKetThuc.TabIndex = 11;
            this.dateTimePickerNgayKetThuc.Value = new System.DateTime(2022, 5, 30, 22, 4, 6, 0);
            // 
            // labelLocTheoNgay
            // 
            this.labelLocTheoNgay.AutoSize = true;
            this.labelLocTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocTheoNgay.Location = new System.Drawing.Point(23, 28);
            this.labelLocTheoNgay.Name = "labelLocTheoNgay";
            this.labelLocTheoNgay.Size = new System.Drawing.Size(152, 22);
            this.labelLocTheoNgay.TabIndex = 1;
            this.labelLocTheoNgay.Text = "Lọc Theo Ngày:";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.CustomFormat = "";
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(194, 32);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerNgayBatDau.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đến";
            // 
            // labelLocTheo
            // 
            this.labelLocTheo.AutoSize = true;
            this.labelLocTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocTheo.Location = new System.Drawing.Point(23, 16);
            this.labelLocTheo.Name = "labelLocTheo";
            this.labelLocTheo.Size = new System.Drawing.Size(100, 22);
            this.labelLocTheo.TabIndex = 0;
            this.labelLocTheo.Text = "Lọc Theo:";
            // 
            // radioButtonTheoNgay
            // 
            this.radioButtonTheoNgay.AutoSize = true;
            this.radioButtonTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTheoNgay.Location = new System.Drawing.Point(306, 19);
            this.radioButtonTheoNgay.Name = "radioButtonTheoNgay";
            this.radioButtonTheoNgay.Size = new System.Drawing.Size(103, 24);
            this.radioButtonTheoNgay.TabIndex = 39;
            this.radioButtonTheoNgay.TabStop = true;
            this.radioButtonTheoNgay.Text = "Theo Ngày";
            this.radioButtonTheoNgay.UseVisualStyleBackColor = true;
            this.radioButtonTheoNgay.CheckedChanged += new System.EventHandler(this.radioButtonTheoNgay_CheckedChanged);
            // 
            // radioButtonTheoMucTien
            // 
            this.radioButtonTheoMucTien.AutoSize = true;
            this.radioButtonTheoMucTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTheoMucTien.Location = new System.Drawing.Point(159, 19);
            this.radioButtonTheoMucTien.Name = "radioButtonTheoMucTien";
            this.radioButtonTheoMucTien.Size = new System.Drawing.Size(131, 24);
            this.radioButtonTheoMucTien.TabIndex = 38;
            this.radioButtonTheoMucTien.TabStop = true;
            this.radioButtonTheoMucTien.Text = "Theo Mức Tiền";
            this.radioButtonTheoMucTien.UseVisualStyleBackColor = true;
            this.radioButtonTheoMucTien.CheckedChanged += new System.EventHandler(this.radioButtonTheoMucTien_CheckedChanged);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(454, 33);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(100, 35);
            this.buttonTimKiem.TabIndex = 1;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(450, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 252);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox4.Controls.Add(this.textBoxMucTienKetThuc);
            this.groupBox4.Controls.Add(this.labelMucTienDen);
            this.groupBox4.Controls.Add(this.textBoxMucTienBatDau);
            this.groupBox4.Controls.Add(this.labelMucTien);
            this.groupBox4.Location = new System.Drawing.Point(6, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 69);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // textBoxMucTienKetThuc
            // 
            this.textBoxMucTienKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMucTienKetThuc.Location = new System.Drawing.Point(371, 19);
            this.textBoxMucTienKetThuc.Name = "textBoxMucTienKetThuc";
            this.textBoxMucTienKetThuc.Size = new System.Drawing.Size(149, 29);
            this.textBoxMucTienKetThuc.TabIndex = 3;
            // 
            // labelMucTienDen
            // 
            this.labelMucTienDen.AutoSize = true;
            this.labelMucTienDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMucTienDen.Location = new System.Drawing.Point(314, 22);
            this.labelMucTienDen.Name = "labelMucTienDen";
            this.labelMucTienDen.Size = new System.Drawing.Size(48, 24);
            this.labelMucTienDen.TabIndex = 2;
            this.labelMucTienDen.Text = "Đến";
            // 
            // textBoxMucTienBatDau
            // 
            this.textBoxMucTienBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMucTienBatDau.Location = new System.Drawing.Point(159, 16);
            this.textBoxMucTienBatDau.Name = "textBoxMucTienBatDau";
            this.textBoxMucTienBatDau.Size = new System.Drawing.Size(149, 29);
            this.textBoxMucTienBatDau.TabIndex = 1;
            // 
            // labelMucTien
            // 
            this.labelMucTien.AutoSize = true;
            this.labelMucTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMucTien.Location = new System.Drawing.Point(18, 19);
            this.labelMucTien.Name = "labelMucTien";
            this.labelMucTien.Size = new System.Drawing.Size(119, 24);
            this.labelMucTien.TabIndex = 0;
            this.labelMucTien.Text = "Mức tiền từ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonTheoMucTien);
            this.groupBox3.Controls.Add(this.labelLocTheo);
            this.groupBox3.Controls.Add(this.radioButtonTheoNgay);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 54);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(881, 436);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(157, 44);
            this.buttonThoat.TabIndex = 69;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXuatFile
            // 
            this.buttonXuatFile.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuatFile.Location = new System.Drawing.Point(456, 436);
            this.buttonXuatFile.Name = "buttonXuatFile";
            this.buttonXuatFile.Size = new System.Drawing.Size(157, 44);
            this.buttonXuatFile.TabIndex = 68;
            this.buttonXuatFile.Text = "Xuất File";
            this.buttonXuatFile.UseVisualStyleBackColor = false;
            this.buttonXuatFile.Click += new System.EventHandler(this.buttonXuatFile_Click);
            // 
            // labelDoanhThu
            // 
            this.labelDoanhThu.AutoSize = true;
            this.labelDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoanhThu.Location = new System.Drawing.Point(447, 9);
            this.labelDoanhThu.Name = "labelDoanhThu";
            this.labelDoanhThu.Size = new System.Drawing.Size(263, 54);
            this.labelDoanhThu.TabIndex = 70;
            this.labelDoanhThu.Text = "Doanh Thu";
            // 
            // buttonInFile
            // 
            this.buttonInFile.BackColor = System.Drawing.Color.Turquoise;
            this.buttonInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInFile.Location = new System.Drawing.Point(670, 436);
            this.buttonInFile.Name = "buttonInFile";
            this.buttonInFile.Size = new System.Drawing.Size(148, 44);
            this.buttonInFile.TabIndex = 71;
            this.buttonInFile.Text = "In File";
            this.buttonInFile.UseVisualStyleBackColor = false;
            this.buttonInFile.Click += new System.EventHandler(this.buttonInFile_Click);
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.Location = new System.Drawing.Point(32, 81);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(175, 24);
            this.labelTongDoanhThu.TabIndex = 72;
            this.labelTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // DoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1148, 562);
            this.Controls.Add(this.labelTongDoanhThu);
            this.Controls.Add(this.buttonInFile);
            this.Controls.Add(this.labelDoanhThu);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXuatFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Name = "DoanhThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThuForm";
            this.Load += new System.EventHandler(this.DoanhThuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Label labelLocTheoNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLocTheo;
        private System.Windows.Forms.RadioButton radioButtonTheoNgay;
        private System.Windows.Forms.RadioButton radioButtonTheoMucTien;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxMucTienBatDau;
        private System.Windows.Forms.Label labelMucTien;
        private System.Windows.Forms.TextBox textBoxMucTienKetThuc;
        private System.Windows.Forms.Label labelMucTienDen;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXuatFile;
        private System.Windows.Forms.Label labelDoanhThu;
        private System.Windows.Forms.Button buttonInFile;
        private System.Windows.Forms.Label labelTongDoanhThu;
    }
}