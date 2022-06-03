
namespace QuanLyNhaHang
{
    partial class DanhSachMonForm
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
            this.labelDanhSachMon = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.labelTenMon = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDanhSachMon
            // 
            this.labelDanhSachMon.AutoSize = true;
            this.labelDanhSachMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhSachMon.Location = new System.Drawing.Point(142, 30);
            this.labelDanhSachMon.Name = "labelDanhSachMon";
            this.labelDanhSachMon.Size = new System.Drawing.Size(370, 54);
            this.labelDanhSachMon.TabIndex = 14;
            this.labelDanhSachMon.Text = "Danh Sách Món";
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(500, 550);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(107, 35);
            this.buttonThoat.TabIndex = 13;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(571, 321);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.Location = new System.Drawing.Point(289, 126);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(223, 29);
            this.textBoxTimKiem.TabIndex = 16;
            // 
            // labelTenMon
            // 
            this.labelTenMon.AutoSize = true;
            this.labelTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMon.Location = new System.Drawing.Point(30, 129);
            this.labelTenMon.Name = "labelTenMon";
            this.labelTenMon.Size = new System.Drawing.Size(249, 24);
            this.labelTenMon.TabIndex = 15;
            this.labelTenMon.Text = "Tìm Kiếm Theo Tên Mon:";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.Orange;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(528, 125);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(79, 32);
            this.buttonTimKiem.TabIndex = 17;
            this.buttonTimKiem.Text = "Tìm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonTaiLai
            // 
            this.buttonTaiLai.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiLai.Location = new System.Drawing.Point(34, 550);
            this.buttonTaiLai.Name = "buttonTaiLai";
            this.buttonTaiLai.Size = new System.Drawing.Size(107, 35);
            this.buttonTaiLai.TabIndex = 18;
            this.buttonTaiLai.Text = "Tải Lại";
            this.buttonTaiLai.UseVisualStyleBackColor = false;
            this.buttonTaiLai.Click += new System.EventHandler(this.buttonTaiLai_Click);
            // 
            // DanhSachMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(647, 609);
            this.Controls.Add(this.buttonTaiLai);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.labelTenMon);
            this.Controls.Add(this.labelDanhSachMon);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachMonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachMonForm";
            this.Load += new System.EventHandler(this.DanhSachMonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDanhSachMon;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label labelTenMon;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonTaiLai;
    }
}