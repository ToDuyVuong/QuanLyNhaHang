
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachBanAn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDanhSachBanAn
            // 
            this.labelDanhSachBanAn.AutoSize = true;
            this.labelDanhSachBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachBanAn.ForeColor = System.Drawing.Color.Black;
            this.labelDanhSachBanAn.Location = new System.Drawing.Point(78, 19);
            this.labelDanhSachBanAn.Name = "labelDanhSachBanAn";
            this.labelDanhSachBanAn.Size = new System.Drawing.Size(285, 36);
            this.labelDanhSachBanAn.TabIndex = 10;
            this.labelDanhSachBanAn.Text = "Danh Sách Bàn Ăn";
            // 
            // dataGridViewDanhSachBanAn
            // 
            this.dataGridViewDanhSachBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachBanAn.Location = new System.Drawing.Point(31, 74);
            this.dataGridViewDanhSachBanAn.Name = "dataGridViewDanhSachBanAn";
            this.dataGridViewDanhSachBanAn.Size = new System.Drawing.Size(363, 287);
            this.dataGridViewDanhSachBanAn.TabIndex = 11;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(114, 425);
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
            this.labelTongSoLuongBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSoLuongBanAn.Location = new System.Drawing.Point(28, 380);
            this.labelTongSoLuongBanAn.Name = "labelTongSoLuongBanAn";
            this.labelTongSoLuongBanAn.Size = new System.Drawing.Size(160, 17);
            this.labelTongSoLuongBanAn.TabIndex = 25;
            this.labelTongSoLuongBanAn.Text = "Tổng Số Lượng Bàn Ăn:";
            // 
            // DanhSachBanAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(429, 491);
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
    }
}