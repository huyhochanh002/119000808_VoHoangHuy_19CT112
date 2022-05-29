namespace _119000808_VoHoangHuy_19CT112
{
    partial class LichsuKhachHang
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
            this.datalichsuKH = new System.Windows.Forms.DataGridView();
            this.list_msKH = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datalichsuKH)).BeginInit();
            this.SuspendLayout();
            // 
            // datalichsuKH
            // 
            this.datalichsuKH.AllowUserToAddRows = false;
            this.datalichsuKH.AllowUserToDeleteRows = false;
            this.datalichsuKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalichsuKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.datalichsuKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalichsuKH.Location = new System.Drawing.Point(-2, 157);
            this.datalichsuKH.Name = "datalichsuKH";
            this.datalichsuKH.ReadOnly = true;
            this.datalichsuKH.Size = new System.Drawing.Size(1231, 491);
            this.datalichsuKH.TabIndex = 0;
            // 
            // list_msKH
            // 
            this.list_msKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.list_msKH.FormattingEnabled = true;
            this.list_msKH.Location = new System.Drawing.Point(1235, 157);
            this.list_msKH.Name = "list_msKH";
            this.list_msKH.Size = new System.Drawing.Size(228, 485);
            this.list_msKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(379, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch Sử Mua Hàng Của Khách";
            // 
            // LichsuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1468, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_msKH);
            this.Controls.Add(this.datalichsuKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LichsuKhachHang";
            this.Text = "LichsuKhachHang";
            this.Load += new System.EventHandler(this.LichsuKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalichsuKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datalichsuKH;
        private System.Windows.Forms.ListBox list_msKH;
        private System.Windows.Forms.Label label1;
    }
}