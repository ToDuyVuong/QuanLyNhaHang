
namespace QuanLyNhaHang
{
    partial class DanhSachNguyenLieuForm
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
            this.comboBoxTimTheoLoai = new System.Windows.Forms.ComboBox();
            this.buttonTimTheoLoai = new System.Windows.Forms.Button();
            this.textBoxMocCuoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMocDau = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.buttonTimTheoTen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTimTheoKhoang = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTimTheoLoai
            // 
            this.comboBoxTimTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTimTheoLoai.FormattingEnabled = true;
            this.comboBoxTimTheoLoai.Items.AddRange(new object[] {
            "kg",
            "gr",
            "l",
            "ml"});
            this.comboBoxTimTheoLoai.Location = new System.Drawing.Point(279, 146);
            this.comboBoxTimTheoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTimTheoLoai.Name = "comboBoxTimTheoLoai";
            this.comboBoxTimTheoLoai.Size = new System.Drawing.Size(169, 32);
            this.comboBoxTimTheoLoai.TabIndex = 24;
            // 
            // buttonTimTheoLoai
            // 
            this.buttonTimTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimTheoLoai.Location = new System.Drawing.Point(64, 146);
            this.buttonTimTheoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimTheoLoai.Name = "buttonTimTheoLoai";
            this.buttonTimTheoLoai.Size = new System.Drawing.Size(192, 32);
            this.buttonTimTheoLoai.TabIndex = 23;
            this.buttonTimTheoLoai.Text = "Tìm theo loại ";
            this.buttonTimTheoLoai.UseVisualStyleBackColor = true;
            this.buttonTimTheoLoai.Click += new System.EventHandler(this.buttonTimTheoLoai_Click);
            // 
            // textBoxMocCuoi
            // 
            this.textBoxMocCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMocCuoi.Location = new System.Drawing.Point(554, 300);
            this.textBoxMocCuoi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMocCuoi.Name = "textBoxMocCuoi";
            this.textBoxMocCuoi.Size = new System.Drawing.Size(255, 29);
            this.textBoxMocCuoi.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "To";
            // 
            // textBoxMocDau
            // 
            this.textBoxMocDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMocDau.Location = new System.Drawing.Point(554, 263);
            this.textBoxMocDau.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMocDau.Name = "textBoxMocDau";
            this.textBoxMocDau.Size = new System.Drawing.Size(206, 29);
            this.textBoxMocDau.TabIndex = 20;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTen.Location = new System.Drawing.Point(279, 101);
            this.textBoxTen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(169, 29);
            this.textBoxTen.TabIndex = 18;
            // 
            // buttonTimTheoTen
            // 
            this.buttonTimTheoTen.AutoSize = true;
            this.buttonTimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimTheoTen.Location = new System.Drawing.Point(64, 98);
            this.buttonTimTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimTheoTen.Name = "buttonTimTheoTen";
            this.buttonTimTheoTen.Size = new System.Drawing.Size(192, 36);
            this.buttonTimTheoTen.TabIndex = 17;
            this.buttonTimTheoTen.Text = "Tìm theo tên";
            this.buttonTimTheoTen.UseVisualStyleBackColor = true;
            this.buttonTimTheoTen.Click += new System.EventHandler(this.buttonTimTheoTen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(354, 434);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 35);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 207);
            this.dataGridView1.TabIndex = 14;
            // 
            // buttonTimTheoKhoang
            // 
            this.buttonTimTheoKhoang.AutoSize = true;
            this.buttonTimTheoKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimTheoKhoang.Location = new System.Drawing.Point(554, 204);
            this.buttonTimTheoKhoang.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimTheoKhoang.Name = "buttonTimTheoKhoang";
            this.buttonTimTheoKhoang.Size = new System.Drawing.Size(255, 34);
            this.buttonTimTheoKhoang.TabIndex = 25;
            this.buttonTimTheoKhoang.Text = "Tìm theo khoảng khối lượng";
            this.buttonTimTheoKhoang.UseVisualStyleBackColor = true;
            this.buttonTimTheoKhoang.Click += new System.EventHandler(this.buttonTimTheoKhoang_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Brown;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(38, 435);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(99, 35);
            this.buttonRefresh.TabIndex = 26;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // DanhSachNguyenLieuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(853, 490);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonTimTheoKhoang);
            this.Controls.Add(this.comboBoxTimTheoLoai);
            this.Controls.Add(this.buttonTimTheoLoai);
            this.Controls.Add(this.textBoxMocCuoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMocDau);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.buttonTimTheoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachNguyenLieuForm";
            this.Text = "DanhSachNguyenLieuForm";
            this.Load += new System.EventHandler(this.DanhSachNguyenLieuForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTimTheoLoai;
        private System.Windows.Forms.Button buttonTimTheoLoai;
        private System.Windows.Forms.TextBox textBoxMocCuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMocDau;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Button buttonTimTheoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTimTheoKhoang;
        private System.Windows.Forms.Button buttonRefresh;
    }
}