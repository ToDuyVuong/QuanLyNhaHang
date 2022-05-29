
namespace QuanLyNhaHang
{
    partial class AddOrderForm
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
            this.dataGridViewBanAn = new System.Windows.Forms.DataGridView();
            this.dataGridViewMonAn = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelIdOrder = new System.Windows.Forms.Label();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.textBoxBanAn = new System.Windows.Forms.TextBox();
            this.labelIdBanAn = new System.Windows.Forms.Label();
            this.textBoxIdMon = new System.Windows.Forms.TextBox();
            this.labelIdMon = new System.Windows.Forms.Label();
            this.textBoxTenMon = new System.Windows.Forms.TextBox();
            this.labelTenMon = new System.Windows.Forms.Label();
            this.textBoxSoLuongMon = new System.Windows.Forms.TextBox();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.labelGia = new System.Windows.Forms.Label();
            this.textBoxLoaiThucAn = new System.Windows.Forms.TextBox();
            this.labelLoaiThucAn = new System.Windows.Forms.Label();
            this.labelTamTinh = new System.Windows.Forms.Label();
            this.labelBanAn = new System.Windows.Forms.Label();
            this.labelMonAn = new System.Windows.Forms.Label();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.buttonXoaMon = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonXoaOrder = new System.Windows.Forms.Button();
            this.buttonXoaBan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBanAn
            // 
            this.dataGridViewBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanAn.Location = new System.Drawing.Point(894, 65);
            this.dataGridViewBanAn.Name = "dataGridViewBanAn";
            this.dataGridViewBanAn.Size = new System.Drawing.Size(358, 153);
            this.dataGridViewBanAn.TabIndex = 0;
            this.dataGridViewBanAn.DoubleClick += new System.EventHandler(this.dataGridViewBanAn_DoubleClick);
            // 
            // dataGridViewMonAn
            // 
            this.dataGridViewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonAn.Location = new System.Drawing.Point(894, 315);
            this.dataGridViewMonAn.Name = "dataGridViewMonAn";
            this.dataGridViewMonAn.Size = new System.Drawing.Size(561, 422);
            this.dataGridViewMonAn.TabIndex = 1;
            this.dataGridViewMonAn.DoubleClick += new System.EventHandler(this.dataGridViewMonAn_DoubleClick);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(610, 18);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(149, 54);
            this.labelOrder.TabIndex = 3;
            this.labelOrder.Text = "Order";
            // 
            // labelIdOrder
            // 
            this.labelIdOrder.AutoSize = true;
            this.labelIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdOrder.Location = new System.Drawing.Point(56, 83);
            this.labelIdOrder.Name = "labelIdOrder";
            this.labelIdOrder.Size = new System.Drawing.Size(104, 24);
            this.labelIdOrder.TabIndex = 4;
            this.labelIdOrder.Text = "Mã Order:";
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdOrder.Location = new System.Drawing.Point(214, 78);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.Size = new System.Drawing.Size(147, 29);
            this.textBoxIdOrder.TabIndex = 5;
            // 
            // textBoxBanAn
            // 
            this.textBoxBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBanAn.Location = new System.Drawing.Point(214, 139);
            this.textBoxBanAn.Name = "textBoxBanAn";
            this.textBoxBanAn.Size = new System.Drawing.Size(147, 29);
            this.textBoxBanAn.TabIndex = 7;
            // 
            // labelIdBanAn
            // 
            this.labelIdBanAn.AutoSize = true;
            this.labelIdBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBanAn.Location = new System.Drawing.Point(56, 144);
            this.labelIdBanAn.Name = "labelIdBanAn";
            this.labelIdBanAn.Size = new System.Drawing.Size(118, 24);
            this.labelIdBanAn.TabIndex = 6;
            this.labelIdBanAn.Text = "Mã Bàn Ăn:";
            // 
            // textBoxIdMon
            // 
            this.textBoxIdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdMon.Location = new System.Drawing.Point(619, 229);
            this.textBoxIdMon.Name = "textBoxIdMon";
            this.textBoxIdMon.Size = new System.Drawing.Size(223, 29);
            this.textBoxIdMon.TabIndex = 9;
            // 
            // labelIdMon
            // 
            this.labelIdMon.AutoSize = true;
            this.labelIdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdMon.Location = new System.Drawing.Point(449, 234);
            this.labelIdMon.Name = "labelIdMon";
            this.labelIdMon.Size = new System.Drawing.Size(91, 24);
            this.labelIdMon.TabIndex = 8;
            this.labelIdMon.Text = "Mã Món:";
            // 
            // textBoxTenMon
            // 
            this.textBoxTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMon.Location = new System.Drawing.Point(619, 296);
            this.textBoxTenMon.Name = "textBoxTenMon";
            this.textBoxTenMon.Size = new System.Drawing.Size(223, 29);
            this.textBoxTenMon.TabIndex = 11;
            // 
            // labelTenMon
            // 
            this.labelTenMon.AutoSize = true;
            this.labelTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMon.Location = new System.Drawing.Point(449, 301);
            this.labelTenMon.Name = "labelTenMon";
            this.labelTenMon.Size = new System.Drawing.Size(100, 24);
            this.labelTenMon.TabIndex = 10;
            this.labelTenMon.Text = "Tên Món:";
            // 
            // textBoxSoLuongMon
            // 
            this.textBoxSoLuongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongMon.Location = new System.Drawing.Point(619, 363);
            this.textBoxSoLuongMon.Name = "textBoxSoLuongMon";
            this.textBoxSoLuongMon.Size = new System.Drawing.Size(223, 29);
            this.textBoxSoLuongMon.TabIndex = 13;
            this.textBoxSoLuongMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuong_KeyPress);
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(449, 368);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(153, 24);
            this.labelSoLuong.TabIndex = 12;
            this.labelSoLuong.Text = "Số Lượng Mon:";
            // 
            // textBoxGia
            // 
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGia.Location = new System.Drawing.Point(619, 435);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(223, 29);
            this.textBoxGia.TabIndex = 15;
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(449, 440);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(47, 24);
            this.labelGia.TabIndex = 14;
            this.labelGia.Text = "Giá:";
            // 
            // textBoxLoaiThucAn
            // 
            this.textBoxLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoaiThucAn.Location = new System.Drawing.Point(619, 502);
            this.textBoxLoaiThucAn.Name = "textBoxLoaiThucAn";
            this.textBoxLoaiThucAn.Size = new System.Drawing.Size(223, 29);
            this.textBoxLoaiThucAn.TabIndex = 17;
            // 
            // labelLoaiThucAn
            // 
            this.labelLoaiThucAn.AutoSize = true;
            this.labelLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiThucAn.Location = new System.Drawing.Point(449, 507);
            this.labelLoaiThucAn.Name = "labelLoaiThucAn";
            this.labelLoaiThucAn.Size = new System.Drawing.Size(141, 24);
            this.labelLoaiThucAn.TabIndex = 16;
            this.labelLoaiThucAn.Text = "Loại Thức Ăn:";
            // 
            // labelTamTinh
            // 
            this.labelTamTinh.AutoSize = true;
            this.labelTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamTinh.Location = new System.Drawing.Point(55, 562);
            this.labelTamTinh.Name = "labelTamTinh";
            this.labelTamTinh.Size = new System.Drawing.Size(105, 24);
            this.labelTamTinh.TabIndex = 18;
            this.labelTamTinh.Text = "Tạm Tính:";
            // 
            // labelBanAn
            // 
            this.labelBanAn.AutoSize = true;
            this.labelBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanAn.Location = new System.Drawing.Point(890, 16);
            this.labelBanAn.Name = "labelBanAn";
            this.labelBanAn.Size = new System.Drawing.Size(108, 31);
            this.labelBanAn.TabIndex = 19;
            this.labelBanAn.Text = "Bàn Ăn";
            // 
            // labelMonAn
            // 
            this.labelMonAn.AutoSize = true;
            this.labelMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonAn.Location = new System.Drawing.Point(890, 259);
            this.labelMonAn.Name = "labelMonAn";
            this.labelMonAn.Size = new System.Drawing.Size(112, 31);
            this.labelMonAn.TabIndex = 20;
            this.labelMonAn.Text = "Món Ăn";
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMon.Location = new System.Drawing.Point(407, 646);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(157, 44);
            this.buttonThemMon.TabIndex = 21;
            this.buttonThemMon.Text = "Thêm Món";
            this.buttonThemMon.UseVisualStyleBackColor = false;
            this.buttonThemMon.Click += new System.EventHandler(this.buttonThemMon_Click);
            // 
            // buttonXoaMon
            // 
            this.buttonXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaMon.Location = new System.Drawing.Point(636, 646);
            this.buttonXoaMon.Name = "buttonXoaMon";
            this.buttonXoaMon.Size = new System.Drawing.Size(157, 44);
            this.buttonXoaMon.TabIndex = 22;
            this.buttonXoaMon.Text = "Xóa Món";
            this.buttonXoaMon.UseVisualStyleBackColor = false;
            this.buttonXoaMon.Click += new System.EventHandler(this.buttonXoaMon_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(179, 646);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(157, 44);
            this.buttonOrder.TabIndex = 23;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1218, 766);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(157, 44);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(59, 229);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(356, 302);
            this.dataGridViewOrder.TabIndex = 25;
            this.dataGridViewOrder.DoubleClick += new System.EventHandler(this.dataGridViewOrder_DoubleClick);
            // 
            // buttonXoaOrder
            // 
            this.buttonXoaOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonXoaOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaOrder.Location = new System.Drawing.Point(382, 77);
            this.buttonXoaOrder.Name = "buttonXoaOrder";
            this.buttonXoaOrder.Size = new System.Drawing.Size(106, 39);
            this.buttonXoaOrder.TabIndex = 26;
            this.buttonXoaOrder.Text = "Xóa Order";
            this.buttonXoaOrder.UseVisualStyleBackColor = false;
            this.buttonXoaOrder.Click += new System.EventHandler(this.buttonXoaOrder_Click);
            // 
            // buttonXoaBan
            // 
            this.buttonXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonXoaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaBan.Location = new System.Drawing.Point(382, 139);
            this.buttonXoaBan.Name = "buttonXoaBan";
            this.buttonXoaBan.Size = new System.Drawing.Size(106, 36);
            this.buttonXoaBan.TabIndex = 27;
            this.buttonXoaBan.Text = "Xóa Bàn";
            this.buttonXoaBan.UseVisualStyleBackColor = false;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1515, 822);
            this.Controls.Add(this.buttonXoaBan);
            this.Controls.Add(this.buttonXoaOrder);
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
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBanAn;
        private System.Windows.Forms.DataGridView dataGridViewMonAn;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelIdOrder;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.TextBox textBoxBanAn;
        private System.Windows.Forms.Label labelIdBanAn;
        private System.Windows.Forms.TextBox textBoxIdMon;
        private System.Windows.Forms.Label labelIdMon;
        private System.Windows.Forms.TextBox textBoxTenMon;
        private System.Windows.Forms.Label labelTenMon;
        private System.Windows.Forms.TextBox textBoxSoLuongMon;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox textBoxLoaiThucAn;
        private System.Windows.Forms.Label labelLoaiThucAn;
        private System.Windows.Forms.Label labelTamTinh;
        private System.Windows.Forms.Label labelBanAn;
        private System.Windows.Forms.Label labelMonAn;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.Button buttonXoaMon;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonXoaOrder;
        private System.Windows.Forms.Button buttonXoaBan;
    }
}