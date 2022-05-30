
namespace QuanLyNhaHang
{
    partial class ThanhToanForm
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
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelTamTinh = new System.Windows.Forms.Label();
            this.textBoxBanAn = new System.Windows.Forms.TextBox();
            this.labelIdBanAn = new System.Windows.Forms.Label();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.labelIdOrder = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelThanhToan = new System.Windows.Forms.Label();
            this.labelDanhSachBanOrder = new System.Windows.Forms.Label();
            this.dataGridViewOrderBan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.Location = new System.Drawing.Point(249, 655);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(157, 44);
            this.buttonThanhToan.TabIndex = 66;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(52, 267);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(563, 303);
            this.dataGridViewOrder.TabIndex = 65;
            // 
            // labelTamTinh
            // 
            this.labelTamTinh.AutoSize = true;
            this.labelTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamTinh.Location = new System.Drawing.Point(53, 596);
            this.labelTamTinh.Name = "labelTamTinh";
            this.labelTamTinh.Size = new System.Drawing.Size(105, 24);
            this.labelTamTinh.TabIndex = 64;
            this.labelTamTinh.Text = "Tạm Tính:";
            // 
            // textBoxBanAn
            // 
            this.textBoxBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBanAn.Location = new System.Drawing.Point(212, 190);
            this.textBoxBanAn.Name = "textBoxBanAn";
            this.textBoxBanAn.Size = new System.Drawing.Size(147, 29);
            this.textBoxBanAn.TabIndex = 63;
            // 
            // labelIdBanAn
            // 
            this.labelIdBanAn.AutoSize = true;
            this.labelIdBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBanAn.Location = new System.Drawing.Point(54, 195);
            this.labelIdBanAn.Name = "labelIdBanAn";
            this.labelIdBanAn.Size = new System.Drawing.Size(118, 24);
            this.labelIdBanAn.TabIndex = 62;
            this.labelIdBanAn.Text = "Mã Bàn Ăn:";
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdOrder.Location = new System.Drawing.Point(212, 129);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.Size = new System.Drawing.Size(147, 29);
            this.textBoxIdOrder.TabIndex = 61;
            // 
            // labelIdOrder
            // 
            this.labelIdOrder.AutoSize = true;
            this.labelIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdOrder.Location = new System.Drawing.Point(54, 134);
            this.labelIdOrder.Name = "labelIdOrder";
            this.labelIdOrder.Size = new System.Drawing.Size(104, 24);
            this.labelIdOrder.TabIndex = 60;
            this.labelIdOrder.Text = "Mã Order:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(630, 655);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(157, 44);
            this.buttonCancel.TabIndex = 67;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelThanhToan
            // 
            this.labelThanhToan.AutoSize = true;
            this.labelThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanhToan.Location = new System.Drawing.Point(282, 41);
            this.labelThanhToan.Name = "labelThanhToan";
            this.labelThanhToan.Size = new System.Drawing.Size(285, 54);
            this.labelThanhToan.TabIndex = 68;
            this.labelThanhToan.Text = "Thanh Toán";
            // 
            // labelDanhSachBanOrder
            // 
            this.labelDanhSachBanOrder.AutoSize = true;
            this.labelDanhSachBanOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachBanOrder.Location = new System.Drawing.Point(649, 64);
            this.labelDanhSachBanOrder.Name = "labelDanhSachBanOrder";
            this.labelDanhSachBanOrder.Size = new System.Drawing.Size(298, 31);
            this.labelDanhSachBanOrder.TabIndex = 70;
            this.labelDanhSachBanOrder.Text = "Danh Sách Bàn Order";
            // 
            // dataGridViewOrderBan
            // 
            this.dataGridViewOrderBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderBan.Location = new System.Drawing.Point(655, 113);
            this.dataGridViewOrderBan.Name = "dataGridViewOrderBan";
            this.dataGridViewOrderBan.Size = new System.Drawing.Size(368, 457);
            this.dataGridViewOrderBan.TabIndex = 69;
            this.dataGridViewOrderBan.DoubleClick += new System.EventHandler(this.dataGridViewOrderBan_DoubleClick);
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1075, 729);
            this.Controls.Add(this.labelDanhSachBanOrder);
            this.Controls.Add(this.dataGridViewOrderBan);
            this.Controls.Add(this.labelThanhToan);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonThanhToan);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.labelTamTinh);
            this.Controls.Add(this.textBoxBanAn);
            this.Controls.Add(this.labelIdBanAn);
            this.Controls.Add(this.textBoxIdOrder);
            this.Controls.Add(this.labelIdOrder);
            this.Name = "ThanhToanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToanForm";
            this.Load += new System.EventHandler(this.ThanhToanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelTamTinh;
        public System.Windows.Forms.TextBox textBoxBanAn;
        private System.Windows.Forms.Label labelIdBanAn;
        public System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.Label labelIdOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelThanhToan;
        private System.Windows.Forms.Label labelDanhSachBanOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderBan;
    }
}