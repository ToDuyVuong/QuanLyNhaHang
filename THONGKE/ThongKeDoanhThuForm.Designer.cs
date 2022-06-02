
namespace QuanLyNhaHang
{
    partial class ThongKeDoanhThuForm
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
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelLocTheoNgay = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.radioButtonLocTheoNgay = new System.Windows.Forms.RadioButton();
            this.labelThongKeDoanhThu = new System.Windows.Forms.Label();
            this.labelBieuDoDoanhThu = new System.Windows.Forms.Label();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(49, 379);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "doanhthu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(570, 441);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.groupBox2.Controls.Add(this.labelLocTheoNgay);
            this.groupBox2.Controls.Add(this.dateTimePickerNgayBatDau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(49, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 73);
            this.groupBox2.TabIndex = 6;
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
            // buttonLoc
            // 
            this.buttonLoc.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(553, 195);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(66, 35);
            this.buttonLoc.TabIndex = 7;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = false;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(872, 807);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(132, 37);
            this.buttonThoat.TabIndex = 70;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(732, 379);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(272, 340);
            this.dataGridViewDoanhThu.TabIndex = 71;
            // 
            // radioButtonLocTheoNgay
            // 
            this.radioButtonLocTheoNgay.AutoSize = true;
            this.radioButtonLocTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLocTheoNgay.Location = new System.Drawing.Point(49, 131);
            this.radioButtonLocTheoNgay.Name = "radioButtonLocTheoNgay";
            this.radioButtonLocTheoNgay.Size = new System.Drawing.Size(127, 22);
            this.radioButtonLocTheoNgay.TabIndex = 72;
            this.radioButtonLocTheoNgay.TabStop = true;
            this.radioButtonLocTheoNgay.Text = "Lọc Theo Ngày";
            this.radioButtonLocTheoNgay.UseVisualStyleBackColor = true;
            this.radioButtonLocTheoNgay.CheckedChanged += new System.EventHandler(this.radioButtonLocTheoNgay_CheckedChanged);
            // 
            // labelThongKeDoanhThu
            // 
            this.labelThongKeDoanhThu.AutoSize = true;
            this.labelThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongKeDoanhThu.Location = new System.Drawing.Point(245, 34);
            this.labelThongKeDoanhThu.Name = "labelThongKeDoanhThu";
            this.labelThongKeDoanhThu.Size = new System.Drawing.Size(486, 54);
            this.labelThongKeDoanhThu.TabIndex = 73;
            this.labelThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            // 
            // labelBieuDoDoanhThu
            // 
            this.labelBieuDoDoanhThu.AutoSize = true;
            this.labelBieuDoDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBieuDoDoanhThu.Location = new System.Drawing.Point(43, 300);
            this.labelBieuDoDoanhThu.Name = "labelBieuDoDoanhThu";
            this.labelBieuDoDoanhThu.Size = new System.Drawing.Size(268, 31);
            this.labelBieuDoDoanhThu.TabIndex = 74;
            this.labelBieuDoDoanhThu.Text = "Biểu Đồ Doanh Thu";
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.Location = new System.Drawing.Point(738, 741);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(175, 24);
            this.labelTongDoanhThu.TabIndex = 75;
            this.labelTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // ThongKeDoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1059, 856);
            this.Controls.Add(this.labelTongDoanhThu);
            this.Controls.Add(this.labelBieuDoDoanhThu);
            this.Controls.Add(this.labelThongKeDoanhThu);
            this.Controls.Add(this.radioButtonLocTheoNgay);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartDoanhThu);
            this.Name = "ThongKeDoanhThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeDoanhThuForm";
            this.Load += new System.EventHandler(this.ThongKeDoanhThuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Label labelLocTheoNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        public System.Windows.Forms.RadioButton radioButtonLocTheoNgay;
        private System.Windows.Forms.Label labelThongKeDoanhThu;
        private System.Windows.Forms.Label labelBieuDoDoanhThu;
        private System.Windows.Forms.Label labelTongDoanhThu;
    }
}