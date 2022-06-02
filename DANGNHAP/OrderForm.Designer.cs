namespace QuanLyNhaHang
{
    partial class OrderForm
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
            this.buttonDanhSachBanAn = new System.Windows.Forms.Button();
            this.buttonDanhSachMon = new System.Windows.Forms.Button();
            this.buttonOrderNew = new System.Windows.Forms.Button();
            this.buttonDanhSachOrder = new System.Windows.Forms.Button();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDanhSachBanAn
            // 
            this.buttonDanhSachBanAn.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonDanhSachBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSachBanAn.Location = new System.Drawing.Point(50, 47);
            this.buttonDanhSachBanAn.Name = "buttonDanhSachBanAn";
            this.buttonDanhSachBanAn.Size = new System.Drawing.Size(193, 182);
            this.buttonDanhSachBanAn.TabIndex = 1;
            this.buttonDanhSachBanAn.Text = "Danh Sách Bàn";
            this.buttonDanhSachBanAn.UseVisualStyleBackColor = false;
            this.buttonDanhSachBanAn.Click += new System.EventHandler(this.buttonDanhSachBanAn_Click);
            // 
            // buttonDanhSachMon
            // 
            this.buttonDanhSachMon.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonDanhSachMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSachMon.Location = new System.Drawing.Point(280, 47);
            this.buttonDanhSachMon.Name = "buttonDanhSachMon";
            this.buttonDanhSachMon.Size = new System.Drawing.Size(193, 182);
            this.buttonDanhSachMon.TabIndex = 2;
            this.buttonDanhSachMon.Text = "Danh Sách Món Ăn";
            this.buttonDanhSachMon.UseVisualStyleBackColor = false;
            this.buttonDanhSachMon.Click += new System.EventHandler(this.buttonDanhSachMon_Click);
            // 
            // buttonOrderNew
            // 
            this.buttonOrderNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOrderNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderNew.Location = new System.Drawing.Point(50, 269);
            this.buttonOrderNew.Name = "buttonOrderNew";
            this.buttonOrderNew.Size = new System.Drawing.Size(193, 182);
            this.buttonOrderNew.TabIndex = 3;
            this.buttonOrderNew.Text = "Order New";
            this.buttonOrderNew.UseVisualStyleBackColor = false;
            this.buttonOrderNew.Click += new System.EventHandler(this.buttonOrderNew_Click);
            // 
            // buttonDanhSachOrder
            // 
            this.buttonDanhSachOrder.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonDanhSachOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSachOrder.Location = new System.Drawing.Point(510, 47);
            this.buttonDanhSachOrder.Name = "buttonDanhSachOrder";
            this.buttonDanhSachOrder.Size = new System.Drawing.Size(193, 182);
            this.buttonDanhSachOrder.TabIndex = 4;
            this.buttonDanhSachOrder.Text = "Danh Sách Order";
            this.buttonDanhSachOrder.UseVisualStyleBackColor = false;
            this.buttonDanhSachOrder.Click += new System.EventHandler(this.buttonDanhSachOrder_Click);
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.Violet;
            this.buttonThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.Location = new System.Drawing.Point(280, 269);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(193, 182);
            this.buttonThanhToan.TabIndex = 5;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(510, 269);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(193, 182);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(759, 498);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThanhToan);
            this.Controls.Add(this.buttonDanhSachOrder);
            this.Controls.Add(this.buttonOrderNew);
            this.Controls.Add(this.buttonDanhSachMon);
            this.Controls.Add(this.buttonDanhSachBanAn);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDanhSachBanAn;
        private System.Windows.Forms.Button buttonDanhSachMon;
        private System.Windows.Forms.Button buttonOrderNew;
        private System.Windows.Forms.Button buttonDanhSachOrder;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Button buttonThoat;
    }
}