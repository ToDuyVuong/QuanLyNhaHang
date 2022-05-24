
namespace QuanLyNhaHang
{
    partial class ThongKeMonAnForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTong = new System.Windows.Forms.Label();
            this.labelThongKe = new System.Windows.Forms.Label();
            this.chartTron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTong.Location = new System.Drawing.Point(629, 402);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(55, 24);
            this.labelTong.TabIndex = 7;
            this.labelTong.Text = "Tổng";
            // 
            // labelThongKe
            // 
            this.labelThongKe.AutoSize = true;
            this.labelThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongKe.Location = new System.Drawing.Point(376, 26);
            this.labelThongKe.Name = "labelThongKe";
            this.labelThongKe.Size = new System.Drawing.Size(94, 24);
            this.labelThongKe.TabIndex = 6;
            this.labelThongKe.Text = "Thống Kê";
            // 
            // chartTron
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTron.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartTron.Legends.Add(legend5);
            this.chartTron.Location = new System.Drawing.Point(455, 74);
            this.chartTron.Name = "chartTron";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Tron";
            this.chartTron.Series.Add(series5);
            this.chartTron.Size = new System.Drawing.Size(300, 300);
            this.chartTron.TabIndex = 5;
            this.chartTron.Text = "chart2";
            // 
            // chartCot
            // 
            chartArea6.Name = "ChartArea1";
            this.chartCot.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartCot.Legends.Add(legend6);
            this.chartCot.Location = new System.Drawing.Point(46, 74);
            this.chartCot.Name = "chartCot";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "DoAn";
            this.chartCot.Series.Add(series6);
            this.chartCot.Size = new System.Drawing.Size(300, 300);
            this.chartCot.TabIndex = 4;
            this.chartCot.Text = "chart1";
            // 
            // ThongKeMonAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTong);
            this.Controls.Add(this.labelThongKe);
            this.Controls.Add(this.chartTron);
            this.Controls.Add(this.chartCot);
            this.Name = "ThongKeMonAnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeMonAnForm";
            this.Load += new System.EventHandler(this.ThongKeMonAnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTong;
        private System.Windows.Forms.Label labelThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTron;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
    }
}