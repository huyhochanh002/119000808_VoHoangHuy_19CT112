namespace _119000808_VoHoangHuy_19CT112
{
    partial class Gas
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.data_gas = new System.Windows.Forms.DataGridView();
            this.pn_top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_msgas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ton = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gas)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_main.Controls.Add(this.data_gas);
            this.pn_main.Controls.Add(this.pn_top);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1023, 557);
            this.pn_main.TabIndex = 0;
            // 
            // data_gas
            // 
            this.data_gas.AllowUserToAddRows = false;
            this.data_gas.AllowUserToDeleteRows = false;
            this.data_gas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_gas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_gas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_gas.GridColor = System.Drawing.Color.White;
            this.data_gas.Location = new System.Drawing.Point(0, 208);
            this.data_gas.Name = "data_gas";
            this.data_gas.ReadOnly = true;
            this.data_gas.Size = new System.Drawing.Size(1023, 349);
            this.data_gas.TabIndex = 1;
            this.data_gas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gas_CellClick);
            // 
            // pn_top
            // 
            this.pn_top.Controls.Add(this.label5);
            this.pn_top.Controls.Add(this.btn_dong);
            this.pn_top.Controls.Add(this.btn_clear);
            this.pn_top.Controls.Add(this.btn_delete);
            this.pn_top.Controls.Add(this.button1);
            this.pn_top.Controls.Add(this.btn_them);
            this.pn_top.Controls.Add(this.txt_msgas);
            this.pn_top.Controls.Add(this.label1);
            this.pn_top.Controls.Add(this.label2);
            this.pn_top.Controls.Add(this.label3);
            this.pn_top.Controls.Add(this.label4);
            this.pn_top.Controls.Add(this.txt_ton);
            this.pn_top.Controls.Add(this.txt_dongia);
            this.pn_top.Controls.Add(this.txt_size);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1023, 208);
            this.pn_top.TabIndex = 0;
            this.pn_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_top_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(251, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tiền = DG x 1000";
            // 
            // btn_dong
            // 
            this.btn_dong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.Color.Red;
            this.btn_dong.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.close_window_48px;
            this.btn_dong.Location = new System.Drawing.Point(975, 11);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(37, 34);
            this.btn_dong.TabIndex = 35;
            this.btn_dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clear.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.user_40px1;
            this.btn_clear.Location = new System.Drawing.Point(680, 127);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(149, 60);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Làm Mới";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.bitten_apple_50px;
            this.btn_delete.Location = new System.Drawing.Point(515, 127);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 60);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.check;
            this.button1.Location = new System.Drawing.Point(346, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 60);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cập Nhật";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_them.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.cap_nhat;
            this.btn_them.Location = new System.Drawing.Point(159, 127);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(158, 60);
            this.btn_them.TabIndex = 31;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_msgas
            // 
            this.txt_msgas.Enabled = false;
            this.txt_msgas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msgas.Location = new System.Drawing.Point(200, 28);
            this.txt_msgas.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msgas.Name = "txt_msgas";
            this.txt_msgas.Size = new System.Drawing.Size(158, 32);
            this.txt_msgas.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(85, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Số Gas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(491, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số Lượng Tồn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(85, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Đơn Gía";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(491, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Size";
            // 
            // txt_ton
            // 
            this.txt_ton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ton.Location = new System.Drawing.Point(648, 75);
            this.txt_ton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ton.Name = "txt_ton";
            this.txt_ton.Size = new System.Drawing.Size(158, 32);
            this.txt_ton.TabIndex = 30;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.Location = new System.Drawing.Point(200, 73);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(47, 32);
            this.txt_dongia.TabIndex = 28;
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.Location = new System.Drawing.Point(648, 29);
            this.txt_size.Margin = new System.Windows.Forms.Padding(2);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(158, 32);
            this.txt_size.TabIndex = 29;
            // 
            // Gas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 557);
            this.Controls.Add(this.pn_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gas";
            this.Text = "Gas";
            this.Load += new System.EventHandler(this.Gas_Load);
            this.pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_gas)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.DataGridView data_gas;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.TextBox txt_msgas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ton;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Label label5;
    }
}