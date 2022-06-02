
namespace QuanLyNhaHang
{
    partial class ChamCongForm
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
            this.buttonCLose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCLose
            // 
            this.buttonCLose.Location = new System.Drawing.Point(628, 349);
            this.buttonCLose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(106, 38);
            this.buttonCLose.TabIndex = 3;
            this.buttonCLose.Text = "Close";
            this.buttonCLose.UseVisualStyleBackColor = true;
            this.buttonCLose.Click += new System.EventHandler(this.buttonCLose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 303);
            this.dataGridView1.TabIndex = 2;
            // 
            // ChamCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 598);
            this.Controls.Add(this.buttonCLose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChamCongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamCongForm";
            this.Load += new System.EventHandler(this.ChamCongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}