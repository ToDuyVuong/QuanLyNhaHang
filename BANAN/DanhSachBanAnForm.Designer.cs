
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
            this.dataGridViewDanhSachBanAn.Location = new System.Drawing.Point(39, 74);
            this.dataGridViewDanhSachBanAn.Name = "dataGridViewDanhSachBanAn";
            this.dataGridViewDanhSachBanAn.Size = new System.Drawing.Size(349, 287);
            this.dataGridViewDanhSachBanAn.TabIndex = 11;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(124, 392);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(173, 46);
            this.buttonThoat.TabIndex = 12;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // DanhSachBanAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(429, 450);
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
    }
}