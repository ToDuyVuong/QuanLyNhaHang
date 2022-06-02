
namespace QuanLyNhaHang
{
    partial class DanhSachOrderForm
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
            this.buttonXoaBan = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonXoaMon = new System.Windows.Forms.Button();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.labelMonAn = new System.Windows.Forms.Label();
            this.labelBanAn = new System.Windows.Forms.Label();
            this.labelTamTinh = new System.Windows.Forms.Label();
            this.textBoxLoaiThucAn = new System.Windows.Forms.TextBox();
            this.labelLoaiThucAn = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.labelGia = new System.Windows.Forms.Label();
            this.textBoxSoLuongMon = new System.Windows.Forms.TextBox();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.textBoxTenMon = new System.Windows.Forms.TextBox();
            this.labelTenMon = new System.Windows.Forms.Label();
            this.textBoxIdMon = new System.Windows.Forms.TextBox();
            this.labelIdMon = new System.Windows.Forms.Label();
            this.textBoxBanAn = new System.Windows.Forms.TextBox();
            this.labelIdBanAn = new System.Windows.Forms.Label();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.labelIdOrder = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.dataGridViewMonAn = new System.Windows.Forms.DataGridView();
            this.dataGridViewBanAn = new System.Windows.Forms.DataGridView();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            this.dataGridViewOrderBan = new System.Windows.Forms.DataGridView();
            this.labelDanhSachBanOrder = new System.Windows.Forms.Label();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.radioButtonDaOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonTatCa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXoaBan
            // 
            this.buttonXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonXoaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaBan.Location = new System.Drawing.Point(349, 242);
            this.buttonXoaBan.Name = "buttonXoaBan";
            this.buttonXoaBan.Size = new System.Drawing.Size(141, 31);
            this.buttonXoaBan.TabIndex = 54;
            this.buttonXoaBan.Text = "Xóa Order Bàn";
            this.buttonXoaBan.UseVisualStyleBackColor = false;
            this.buttonXoaBan.Click += new System.EventHandler(this.buttonXoaBan_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(27, 348);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(380, 274);
            this.dataGridViewOrder.TabIndex = 52;
            this.dataGridViewOrder.DoubleClick += new System.EventHandler(this.dataGridViewOrder_DoubleClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1327, 832);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(157, 44);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(250, 754);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(157, 44);
            this.buttonOrder.TabIndex = 50;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonXoaMon
            // 
            this.buttonXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaMon.Location = new System.Drawing.Point(707, 754);
            this.buttonXoaMon.Name = "buttonXoaMon";
            this.buttonXoaMon.Size = new System.Drawing.Size(157, 44);
            this.buttonXoaMon.TabIndex = 49;
            this.buttonXoaMon.Text = "Xóa Món";
            this.buttonXoaMon.UseVisualStyleBackColor = false;
            this.buttonXoaMon.Click += new System.EventHandler(this.buttonXoaMon_Click);
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMon.Location = new System.Drawing.Point(453, 754);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(208, 44);
            this.buttonThemMon.TabIndex = 48;
            this.buttonThemMon.Text = "Thêm/Sửa Món";
            this.buttonThemMon.UseVisualStyleBackColor = false;
            this.buttonThemMon.Click += new System.EventHandler(this.buttonThemMon_Click);
            // 
            // labelMonAn
            // 
            this.labelMonAn.AutoSize = true;
            this.labelMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonAn.Location = new System.Drawing.Point(928, 324);
            this.labelMonAn.Name = "labelMonAn";
            this.labelMonAn.Size = new System.Drawing.Size(112, 31);
            this.labelMonAn.TabIndex = 47;
            this.labelMonAn.Text = "Món Ăn";
            // 
            // labelBanAn
            // 
            this.labelBanAn.AutoSize = true;
            this.labelBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanAn.Location = new System.Drawing.Point(928, 15);
            this.labelBanAn.Name = "labelBanAn";
            this.labelBanAn.Size = new System.Drawing.Size(108, 31);
            this.labelBanAn.TabIndex = 46;
            this.labelBanAn.Text = "Bàn Ăn";
            // 
            // labelTamTinh
            // 
            this.labelTamTinh.AutoSize = true;
            this.labelTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamTinh.Location = new System.Drawing.Point(66, 670);
            this.labelTamTinh.Name = "labelTamTinh";
            this.labelTamTinh.Size = new System.Drawing.Size(105, 24);
            this.labelTamTinh.TabIndex = 45;
            this.labelTamTinh.Text = "Tạm Tính:";
            // 
            // textBoxLoaiThucAn
            // 
            this.textBoxLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoaiThucAn.Location = new System.Drawing.Point(641, 611);
            this.textBoxLoaiThucAn.Name = "textBoxLoaiThucAn";
            this.textBoxLoaiThucAn.Size = new System.Drawing.Size(223, 29);
            this.textBoxLoaiThucAn.TabIndex = 44;
            // 
            // labelLoaiThucAn
            // 
            this.labelLoaiThucAn.AutoSize = true;
            this.labelLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiThucAn.Location = new System.Drawing.Point(471, 616);
            this.labelLoaiThucAn.Name = "labelLoaiThucAn";
            this.labelLoaiThucAn.Size = new System.Drawing.Size(141, 24);
            this.labelLoaiThucAn.TabIndex = 43;
            this.labelLoaiThucAn.Text = "Loại Thức Ăn:";
            // 
            // textBoxGia
            // 
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGia.Location = new System.Drawing.Point(641, 544);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(223, 29);
            this.textBoxGia.TabIndex = 42;
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(471, 549);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(47, 24);
            this.labelGia.TabIndex = 41;
            this.labelGia.Text = "Giá:";
            // 
            // textBoxSoLuongMon
            // 
            this.textBoxSoLuongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongMon.Location = new System.Drawing.Point(641, 472);
            this.textBoxSoLuongMon.Name = "textBoxSoLuongMon";
            this.textBoxSoLuongMon.Size = new System.Drawing.Size(223, 29);
            this.textBoxSoLuongMon.TabIndex = 40;
            this.textBoxSoLuongMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuongMon_KeyPress);
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(471, 477);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(153, 24);
            this.labelSoLuong.TabIndex = 39;
            this.labelSoLuong.Text = "Số Lượng Mon:";
            // 
            // textBoxTenMon
            // 
            this.textBoxTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMon.Location = new System.Drawing.Point(641, 405);
            this.textBoxTenMon.Name = "textBoxTenMon";
            this.textBoxTenMon.Size = new System.Drawing.Size(223, 29);
            this.textBoxTenMon.TabIndex = 38;
            // 
            // labelTenMon
            // 
            this.labelTenMon.AutoSize = true;
            this.labelTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMon.Location = new System.Drawing.Point(471, 410);
            this.labelTenMon.Name = "labelTenMon";
            this.labelTenMon.Size = new System.Drawing.Size(100, 24);
            this.labelTenMon.TabIndex = 37;
            this.labelTenMon.Text = "Tên Món:";
            // 
            // textBoxIdMon
            // 
            this.textBoxIdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdMon.Location = new System.Drawing.Point(641, 338);
            this.textBoxIdMon.Name = "textBoxIdMon";
            this.textBoxIdMon.Size = new System.Drawing.Size(223, 29);
            this.textBoxIdMon.TabIndex = 36;
            // 
            // labelIdMon
            // 
            this.labelIdMon.AutoSize = true;
            this.labelIdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdMon.Location = new System.Drawing.Point(471, 343);
            this.labelIdMon.Name = "labelIdMon";
            this.labelIdMon.Size = new System.Drawing.Size(91, 24);
            this.labelIdMon.TabIndex = 35;
            this.labelIdMon.Text = "Mã Món:";
            // 
            // textBoxBanAn
            // 
            this.textBoxBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBanAn.Location = new System.Drawing.Point(180, 241);
            this.textBoxBanAn.Name = "textBoxBanAn";
            this.textBoxBanAn.Size = new System.Drawing.Size(147, 29);
            this.textBoxBanAn.TabIndex = 34;
            // 
            // labelIdBanAn
            // 
            this.labelIdBanAn.AutoSize = true;
            this.labelIdBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBanAn.Location = new System.Drawing.Point(22, 246);
            this.labelIdBanAn.Name = "labelIdBanAn";
            this.labelIdBanAn.Size = new System.Drawing.Size(118, 24);
            this.labelIdBanAn.TabIndex = 33;
            this.labelIdBanAn.Text = "Mã Bàn Ăn:";
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdOrder.Location = new System.Drawing.Point(180, 180);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.Size = new System.Drawing.Size(147, 29);
            this.textBoxIdOrder.TabIndex = 32;
            // 
            // labelIdOrder
            // 
            this.labelIdOrder.AutoSize = true;
            this.labelIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdOrder.Location = new System.Drawing.Point(22, 185);
            this.labelIdOrder.Name = "labelIdOrder";
            this.labelIdOrder.Size = new System.Drawing.Size(104, 24);
            this.labelIdOrder.TabIndex = 31;
            this.labelIdOrder.Text = "Mã Order:";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(475, 39);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(402, 54);
            this.labelOrder.TabIndex = 30;
            this.labelOrder.Text = "Danh Sách Order";
            // 
            // dataGridViewMonAn
            // 
            this.dataGridViewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonAn.Location = new System.Drawing.Point(932, 380);
            this.dataGridViewMonAn.Name = "dataGridViewMonAn";
            this.dataGridViewMonAn.Size = new System.Drawing.Size(561, 422);
            this.dataGridViewMonAn.TabIndex = 29;
            this.dataGridViewMonAn.DoubleClick += new System.EventHandler(this.dataGridViewMonAn_DoubleClick);
            // 
            // dataGridViewBanAn
            // 
            this.dataGridViewBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanAn.Location = new System.Drawing.Point(934, 64);
            this.dataGridViewBanAn.Name = "dataGridViewBanAn";
            this.dataGridViewBanAn.Size = new System.Drawing.Size(373, 227);
            this.dataGridViewBanAn.TabIndex = 28;
            this.dataGridViewBanAn.DoubleClick += new System.EventHandler(this.dataGridViewBanAn_DoubleClick);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.BackColor = System.Drawing.Color.Yellow;
            this.buttonTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiLai.Location = new System.Drawing.Point(934, 832);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(157, 44);
            this.buttonTaiLai.TabIndex = 55;
            this.buttonTaiLai.Text = "Tải lại";
            this.buttonTaiLai.UseVisualStyleBackColor = false;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // dataGridViewOrderBan
            // 
            this.dataGridViewOrderBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderBan.Location = new System.Drawing.Point(1352, 108);
            this.dataGridViewOrderBan.Name = "dataGridViewOrderBan";
            this.dataGridViewOrderBan.Size = new System.Drawing.Size(369, 183);
            this.dataGridViewOrderBan.TabIndex = 57;
            this.dataGridViewOrderBan.DoubleClick += new System.EventHandler(this.dataGridViewOrderBan_DoubleClick);
            // 
            // labelDanhSachBanOrder
            // 
            this.labelDanhSachBanOrder.AutoSize = true;
            this.labelDanhSachBanOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachBanOrder.Location = new System.Drawing.Point(1346, 15);
            this.labelDanhSachBanOrder.Name = "labelDanhSachBanOrder";
            this.labelDanhSachBanOrder.Size = new System.Drawing.Size(298, 31);
            this.labelDanhSachBanOrder.TabIndex = 58;
            this.labelDanhSachBanOrder.Text = "Danh Sách Bàn Order";
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.Location = new System.Drawing.Point(39, 754);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(157, 44);
            this.buttonThanhToan.TabIndex = 59;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // radioButtonDaOrder
            // 
            this.radioButtonDaOrder.AutoSize = true;
            this.radioButtonDaOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDaOrder.Location = new System.Drawing.Point(1486, 64);
            this.radioButtonDaOrder.Name = "radioButtonDaOrder";
            this.radioButtonDaOrder.Size = new System.Drawing.Size(102, 26);
            this.radioButtonDaOrder.TabIndex = 60;
            this.radioButtonDaOrder.TabStop = true;
            this.radioButtonDaOrder.Text = "Đã Order";
            this.radioButtonDaOrder.UseVisualStyleBackColor = true;
            this.radioButtonDaOrder.CheckedChanged += new System.EventHandler(this.radioButtonDaOrder_CheckedChanged);
            // 
            // radioButtonTatCa
            // 
            this.radioButtonTatCa.AutoSize = true;
            this.radioButtonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTatCa.Location = new System.Drawing.Point(1352, 64);
            this.radioButtonTatCa.Name = "radioButtonTatCa";
            this.radioButtonTatCa.Size = new System.Drawing.Size(83, 26);
            this.radioButtonTatCa.TabIndex = 61;
            this.radioButtonTatCa.TabStop = true;
            this.radioButtonTatCa.Text = "Tất Cả";
            this.radioButtonTatCa.UseVisualStyleBackColor = true;
            this.radioButtonTatCa.CheckedChanged += new System.EventHandler(this.radioButtonTatCa_CheckedChanged);
            // 
            // DanhSachOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1760, 905);
            this.Controls.Add(this.radioButtonTatCa);
            this.Controls.Add(this.radioButtonDaOrder);
            this.Controls.Add(this.buttonThanhToan);
            this.Controls.Add(this.labelDanhSachBanOrder);
            this.Controls.Add(this.dataGridViewOrderBan);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonXoaBan);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonXoaMon);
            this.Controls.Add(this.buttonThemMon);
            this.Controls.Add(this.labelMonAn);
            this.Controls.Add(this.labelBanAn);
            this.Controls.Add(this.labelTamTinh);
            this.Controls.Add(this.textBoxLoaiThucAn);
            this.Controls.Add(this.labelLoaiThucAn);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.textBoxSoLuongMon);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.textBoxTenMon);
            this.Controls.Add(this.labelTenMon);
            this.Controls.Add(this.textBoxIdMon);
            this.Controls.Add(this.labelIdMon);
            this.Controls.Add(this.textBoxBanAn);
            this.Controls.Add(this.labelIdBanAn);
            this.Controls.Add(this.textBoxIdOrder);
            this.Controls.Add(this.labelIdOrder);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.dataGridViewMonAn);
            this.Controls.Add(this.dataGridViewBanAn);
            this.Name = "DanhSachOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachOrderForm";
            this.Load += new System.EventHandler(this.DanhSachOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonXoaBan;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonXoaMon;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.Label labelMonAn;
        private System.Windows.Forms.Label labelBanAn;
        private System.Windows.Forms.TextBox textBoxLoaiThucAn;
        private System.Windows.Forms.Label labelLoaiThucAn;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox textBoxSoLuongMon;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox textBoxTenMon;
        private System.Windows.Forms.Label labelTenMon;
        private System.Windows.Forms.TextBox textBoxIdMon;
        private System.Windows.Forms.Label labelIdMon;
        private System.Windows.Forms.Label labelIdBanAn;
        private System.Windows.Forms.Label labelIdOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.DataGridView dataGridViewMonAn;
        private System.Windows.Forms.DataGridView dataGridViewBanAn;
        private System.Windows.Forms.Button buttonTaiLai;
        private System.Windows.Forms.DataGridView dataGridViewOrderBan;
        private System.Windows.Forms.Label labelDanhSachBanOrder;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelTamTinh;
        public System.Windows.Forms.TextBox textBoxBanAn;
        public System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.RadioButton radioButtonDaOrder;
        private System.Windows.Forms.RadioButton radioButtonTatCa;
    }
}