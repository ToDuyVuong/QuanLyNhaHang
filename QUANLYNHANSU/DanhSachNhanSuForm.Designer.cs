
namespace QuanLyNhaHang
{
    partial class DanhSachNhanSuForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxLocTheoChucVu = new System.Windows.Forms.GroupBox();
            this.radioButtonTatCa = new System.Windows.Forms.RadioButton();
            this.radioButtonChucVuNhanVien = new System.Windows.Forms.RadioButton();
            this.radioButtonChucVuQuanLy = new System.Windows.Forms.RadioButton();
            this.dataGridViewDanhSachNhanSu = new System.Windows.Forms.DataGridView();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonXuatFileWord = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxLocTheoChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLocTheoChucVu
            // 
            this.groupBoxLocTheoChucVu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxLocTheoChucVu.Controls.Add(this.radioButtonTatCa);
            this.groupBoxLocTheoChucVu.Controls.Add(this.radioButtonChucVuNhanVien);
            this.groupBoxLocTheoChucVu.Controls.Add(this.radioButtonChucVuQuanLy);
            this.groupBoxLocTheoChucVu.Location = new System.Drawing.Point(102, 23);
            this.groupBoxLocTheoChucVu.Name = "groupBoxLocTheoChucVu";
            this.groupBoxLocTheoChucVu.Size = new System.Drawing.Size(410, 62);
            this.groupBoxLocTheoChucVu.TabIndex = 102;
            this.groupBoxLocTheoChucVu.TabStop = false;
            this.groupBoxLocTheoChucVu.Text = "Lọc Theo chức vụ";
            // 
            // radioButtonTatCa
            // 
            this.radioButtonTatCa.AutoSize = true;
            this.radioButtonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTatCa.Location = new System.Drawing.Point(293, 19);
            this.radioButtonTatCa.Name = "radioButtonTatCa";
            this.radioButtonTatCa.Size = new System.Drawing.Size(67, 22);
            this.radioButtonTatCa.TabIndex = 35;
            this.radioButtonTatCa.TabStop = true;
            this.radioButtonTatCa.Text = "Tất cả";
            this.radioButtonTatCa.UseVisualStyleBackColor = true;
            this.radioButtonTatCa.CheckedChanged += new System.EventHandler(this.radioButtonTatCa_CheckedChanged);
            // 
            // radioButtonChucVuNhanVien
            // 
            this.radioButtonChucVuNhanVien.AutoSize = true;
            this.radioButtonChucVuNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChucVuNhanVien.Location = new System.Drawing.Point(31, 19);
            this.radioButtonChucVuNhanVien.Name = "radioButtonChucVuNhanVien";
            this.radioButtonChucVuNhanVien.Size = new System.Drawing.Size(93, 22);
            this.radioButtonChucVuNhanVien.TabIndex = 33;
            this.radioButtonChucVuNhanVien.TabStop = true;
            this.radioButtonChucVuNhanVien.Text = "Nhân Viên";
            this.radioButtonChucVuNhanVien.UseVisualStyleBackColor = true;
            this.radioButtonChucVuNhanVien.CheckedChanged += new System.EventHandler(this.radioButtonChucVuNhanVien_CheckedChanged);
            // 
            // radioButtonChucVuQuanLy
            // 
            this.radioButtonChucVuQuanLy.AutoSize = true;
            this.radioButtonChucVuQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChucVuQuanLy.Location = new System.Drawing.Point(168, 19);
            this.radioButtonChucVuQuanLy.Name = "radioButtonChucVuQuanLy";
            this.radioButtonChucVuQuanLy.Size = new System.Drawing.Size(81, 22);
            this.radioButtonChucVuQuanLy.TabIndex = 34;
            this.radioButtonChucVuQuanLy.TabStop = true;
            this.radioButtonChucVuQuanLy.Text = "Quản Lý";
            this.radioButtonChucVuQuanLy.UseVisualStyleBackColor = true;
            this.radioButtonChucVuQuanLy.CheckedChanged += new System.EventHandler(this.radioButtonChucVuQuanLy_CheckedChanged);
            // 
            // dataGridViewDanhSachNhanSu
            // 
            this.dataGridViewDanhSachNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachNhanSu.Location = new System.Drawing.Point(102, 92);
            this.dataGridViewDanhSachNhanSu.Name = "dataGridViewDanhSachNhanSu";
            this.dataGridViewDanhSachNhanSu.Size = new System.Drawing.Size(1030, 737);
            this.dataGridViewDanhSachNhanSu.TabIndex = 103;
            this.dataGridViewDanhSachNhanSu.DoubleClick += new System.EventHandler(this.dataGridViewDanhSachNhanSu_DoubleClick);
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.Color.Lime;
            this.labelSoLuong.Location = new System.Drawing.Point(925, 849);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(106, 24);
            this.labelSoLuong.TabIndex = 104;
            this.labelSoLuong.Text = "Số Luong:";
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Black;
            this.buttonThoat.Location = new System.Drawing.Point(791, 894);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(194, 54);
            this.buttonThoat.TabIndex = 105;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.AutoSize = true;
            this.buttonPrint.BackColor = System.Drawing.Color.Magenta;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.Black;
            this.buttonPrint.Location = new System.Drawing.Point(239, 894);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(194, 54);
            this.buttonPrint.TabIndex = 106;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonXuatFileWord
            // 
            this.buttonXuatFileWord.AutoSize = true;
            this.buttonXuatFileWord.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonXuatFileWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuatFileWord.ForeColor = System.Drawing.Color.Black;
            this.buttonXuatFileWord.Location = new System.Drawing.Point(514, 894);
            this.buttonXuatFileWord.Name = "buttonXuatFileWord";
            this.buttonXuatFileWord.Size = new System.Drawing.Size(194, 54);
            this.buttonXuatFileWord.TabIndex = 107;
            this.buttonXuatFileWord.Text = "Xuất Ra Word";
            this.buttonXuatFileWord.UseVisualStyleBackColor = false;
            this.buttonXuatFileWord.Click += new System.EventHandler(this.buttonXuatFileWord_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1174, 279);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(546, 559);
            this.chart1.TabIndex = 108;
            this.chart1.Text = "chart1";
            // 
            // DanhSachNhanSuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1761, 960);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonXuatFileWord);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.groupBoxLocTheoChucVu);
            this.Controls.Add(this.dataGridViewDanhSachNhanSu);
            this.Name = "DanhSachNhanSuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachNhanSuForm";
            this.Load += new System.EventHandler(this.DanhSachNhanSuForm_Load);
            this.groupBoxLocTheoChucVu.ResumeLayout(false);
            this.groupBoxLocTheoChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocTheoChucVu;
        public System.Windows.Forms.RadioButton radioButtonTatCa;
        public System.Windows.Forms.RadioButton radioButtonChucVuNhanVien;
        public System.Windows.Forms.RadioButton radioButtonChucVuQuanLy;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachNhanSu;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonXuatFileWord;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}