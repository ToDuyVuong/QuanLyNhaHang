
namespace QuanLyNhaHang
{
    partial class DoanhThuForm
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
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(336, 70);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(569, 242);
            this.dataGridViewDoanhThu.TabIndex = 0;
            // 
            // DoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 586);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Name = "DoanhThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThuForm";
            this.Load += new System.EventHandler(this.DoanhThuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
    }
}