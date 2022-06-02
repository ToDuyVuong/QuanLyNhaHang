
namespace QuanLyNhaHang
{
    partial class ThongKeMonForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTongSoLuongMon = new System.Windows.Forms.Label();
            this.labelBieuDoDoanhThu = new System.Windows.Forms.Label();
            this.labelThongKeMon = new System.Windows.Forms.Label();
            this.radioButtonLocTheoNgay = new System.Windows.Forms.RadioButton();
            this.dataGridViewThongKeTheoMon = new System.Windows.Forms.DataGridView();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelLocTheoNgay = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chartThongKeMon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeTheoMon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeMon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTongSoLuongMon
            // 
            this.labelTongSoLuongMon.AutoSize = true;
            this.labelTongSoLuongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSoLuongMon.Location = new System.Drawing.Point(752, 739);
            this.labelTongSoLuongMon.Name = "labelTongSoLuongMon";
            this.labelTongSoLuongMon.Size = new System.Drawing.Size(208, 24);
            this.labelTongSoLuongMon.TabIndex = 84;
            this.labelTongSoLuongMon.Text = "Tổng Số Lượng Món:";
            // 
            // labelBieuDoDoanhThu
            // 
            this.labelBieuDoDoanhThu.AutoSize = true;
            this.labelBieuDoDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBieuDoDoanhThu.Location = new System.Drawing.Point(67, 298);
            this.labelBieuDoDoanhThu.Name = "labelBieuDoDoanhThu";
            this.labelBieuDoDoanhThu.Size = new System.Drawing.Size(262, 31);
            this.labelBieuDoDoanhThu.TabIndex = 83;
            this.labelBieuDoDoanhThu.Text = "Biểu Đồ Theo Món ";
            // 
            // labelThongKeMon
            // 
            this.labelThongKeMon.AutoSize = true;
            this.labelThongKeMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongKeMon.Location = new System.Drawing.Point(492, 41);
            this.labelThongKeMon.Name = "labelThongKeMon";
            this.labelThongKeMon.Size = new System.Drawing.Size(340, 54);
            this.labelThongKeMon.TabIndex = 82;
            this.labelThongKeMon.Text = "Thống Kê Món";
            // 
            // radioButtonLocTheoNgay
            // 
            this.radioButtonLocTheoNgay.AutoSize = true;
            this.radioButtonLocTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLocTheoNgay.Location = new System.Drawing.Point(73, 129);
            this.radioButtonLocTheoNgay.Name = "radioButtonLocTheoNgay";
            this.radioButtonLocTheoNgay.Size = new System.Drawing.Size(127, 22);
            this.radioButtonLocTheoNgay.TabIndex = 81;
            this.radioButtonLocTheoNgay.TabStop = true;
            this.radioButtonLocTheoNgay.Text = "Lọc Theo Ngày";
            this.radioButtonLocTheoNgay.UseVisualStyleBackColor = true;
            this.radioButtonLocTheoNgay.CheckedChanged += new System.EventHandler(this.radioButtonLocTheoNgay_CheckedChanged);
            // 
            // dataGridViewThongKeTheoMon
            // 
            this.dataGridViewThongKeTheoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKeTheoMon.Location = new System.Drawing.Point(756, 377);
            this.dataGridViewThongKeTheoMon.Name = "dataGridViewThongKeTheoMon";
            this.dataGridViewThongKeTheoMon.Size = new System.Drawing.Size(469, 340);
            this.dataGridViewThongKeTheoMon.TabIndex = 80;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(1093, 802);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(132, 37);
            this.buttonThoat.TabIndex = 79;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonLoc
            // 
            this.buttonLoc.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(577, 193);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(66, 35);
            this.buttonLoc.TabIndex = 78;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = false;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.groupBox2.Controls.Add(this.labelLocTheoNgay);
            this.groupBox2.Controls.Add(this.dateTimePickerNgayBatDau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(73, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 73);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.CustomFormat = "";
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(321, 27);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerNgayKetThuc.TabIndex = 11;
            this.dateTimePickerNgayKetThuc.Value = new System.DateTime(2022, 5, 30, 22, 4, 6, 0);
            // 
            // labelLocTheoNgay
            // 
            this.labelLocTheoNgay.AutoSize = true;
            this.labelLocTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocTheoNgay.Location = new System.Drawing.Point(11, 25);
            this.labelLocTheoNgay.Name = "labelLocTheoNgay";
            this.labelLocTheoNgay.Size = new System.Drawing.Size(92, 22);
            this.labelLocTheoNgay.TabIndex = 1;
            this.labelLocTheoNgay.Text = "Từ Ngày:";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.CustomFormat = "";
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(118, 27);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerNgayBatDau.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đến";
            // 
            // chartThongKeMon
            // 
            chartArea4.Name = "ChartArea1";
            this.chartThongKeMon.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartThongKeMon.Legends.Add(legend4);
            this.chartThongKeMon.Location = new System.Drawing.Point(73, 377);
            this.chartThongKeMon.Name = "chartThongKeMon";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "mon";
            this.chartThongKeMon.Series.Add(series4);
            this.chartThongKeMon.Size = new System.Drawing.Size(570, 441);
            this.chartThongKeMon.TabIndex = 76;
            this.chartThongKeMon.Text = "chart1";
            // 
            // ThongKeMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1384, 875);
            this.Controls.Add(this.labelTongSoLuongMon);
            this.Controls.Add(this.labelBieuDoDoanhThu);
            this.Controls.Add(this.labelThongKeMon);
            this.Controls.Add(this.radioButtonLocTheoNgay);
            this.Controls.Add(this.dataGridViewThongKeTheoMon);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartThongKeMon);
            this.Name = "ThongKeMonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeMonForm";
            this.Load += new System.EventHandler(this.ThongKeMonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeTheoMon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTongSoLuongMon;
        private System.Windows.Forms.Label labelBieuDoDoanhThu;
        private System.Windows.Forms.Label labelThongKeMon;
        public System.Windows.Forms.RadioButton radioButtonLocTheoNgay;
        private System.Windows.Forms.DataGridView dataGridViewThongKeTheoMon;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Label labelLocTheoNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeMon;
    }
}