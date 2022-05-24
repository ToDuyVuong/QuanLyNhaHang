
namespace QuanLyNhaHang
{
    partial class SuaMonAnForm
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
            this.datagridviewMonAn = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelTenMon = new System.Windows.Forms.Label();
            this.textboxGia = new System.Windows.Forms.TextBox();
            this.textboxSoLuong = new System.Windows.Forms.TextBox();
            this.comboxTenMon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewMonAn
            // 
            this.datagridviewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewMonAn.Location = new System.Drawing.Point(370, 45);
            this.datagridviewMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.datagridviewMonAn.Name = "datagridviewMonAn";
            this.datagridviewMonAn.RowHeadersWidth = 51;
            this.datagridviewMonAn.RowTemplate.Height = 24;
            this.datagridviewMonAn.Size = new System.Drawing.Size(677, 260);
            this.datagridviewMonAn.TabIndex = 15;
            this.datagridviewMonAn.DoubleClick += new System.EventHandler(this.datagridviewMonAn_DoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(170, 215);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 48);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(29, 148);
            this.labelGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(38, 24);
            this.labelGia.TabIndex = 13;
            this.labelGia.Text = "Giá";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(30, 99);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(92, 24);
            this.labelSoLuong.TabIndex = 12;
            this.labelSoLuong.Text = "Số Lượng";
            // 
            // labelTenMon
            // 
            this.labelTenMon.AutoSize = true;
            this.labelTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMon.Location = new System.Drawing.Point(29, 51);
            this.labelTenMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenMon.Name = "labelTenMon";
            this.labelTenMon.Size = new System.Drawing.Size(87, 24);
            this.labelTenMon.TabIndex = 11;
            this.labelTenMon.Text = "Tên Món";
            // 
            // textboxGia
            // 
            this.textboxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxGia.Location = new System.Drawing.Point(131, 144);
            this.textboxGia.Margin = new System.Windows.Forms.Padding(2);
            this.textboxGia.Name = "textboxGia";
            this.textboxGia.Size = new System.Drawing.Size(218, 29);
            this.textboxGia.TabIndex = 10;
            // 
            // textboxSoLuong
            // 
            this.textboxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSoLuong.Location = new System.Drawing.Point(132, 94);
            this.textboxSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.textboxSoLuong.Name = "textboxSoLuong";
            this.textboxSoLuong.Size = new System.Drawing.Size(218, 29);
            this.textboxSoLuong.TabIndex = 9;
            // 
            // comboxTenMon
            // 
            this.comboxTenMon.DisplayMember = "ten_mon";
            this.comboxTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTenMon.FormattingEnabled = true;
            this.comboxTenMon.Location = new System.Drawing.Point(131, 45);
            this.comboxTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.comboxTenMon.Name = "comboxTenMon";
            this.comboxTenMon.Size = new System.Drawing.Size(218, 32);
            this.comboxTenMon.TabIndex = 8;
            this.comboxTenMon.ValueMember = "ten_mon";
            // 
            // SuaMonAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1077, 372);
            this.Controls.Add(this.datagridviewMonAn);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelTenMon);
            this.Controls.Add(this.textboxGia);
            this.Controls.Add(this.textboxSoLuong);
            this.Controls.Add(this.comboxTenMon);
            this.Name = "SuaMonAnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaMonAnForm";
            this.Load += new System.EventHandler(this.SuaMonAnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewMonAn;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelTenMon;
        private System.Windows.Forms.TextBox textboxGia;
        private System.Windows.Forms.TextBox textboxSoLuong;
        private System.Windows.Forms.ComboBox comboxTenMon;
    }
}