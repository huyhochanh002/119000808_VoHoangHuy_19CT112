namespace _119000808_VoHoangHuy_19CT112
{
    partial class LichsuHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.rPTHoaDonBanGasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _119000808_VoHoangHuy_19CT112.DataSet1();
            this.rPT_HoaDonBanGasTableAdapter = new _119000808_VoHoangHuy_19CT112.DataSet1TableAdapters.RPT_HoaDonBanGasTableAdapter();
            this.data_HoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_msGAS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_msNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_msKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rPTHoaDonBanGasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_HoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rPTHoaDonBanGasBindingSource
            // 
            this.rPTHoaDonBanGasBindingSource.DataMember = "RPT_HoaDonBanGas";
            this.rPTHoaDonBanGasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPT_HoaDonBanGasTableAdapter
            // 
            this.rPT_HoaDonBanGasTableAdapter.ClearBeforeFill = true;
            // 
            // data_HoaDon
            // 
            this.data_HoaDon.AllowUserToAddRows = false;
            this.data_HoaDon.AllowUserToDeleteRows = false;
            this.data_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_HoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_HoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_HoaDon.Location = new System.Drawing.Point(0, 329);
            this.data_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.data_HoaDon.Name = "data_HoaDon";
            this.data_HoaDon.ReadOnly = true;
            this.data_HoaDon.RowHeadersWidth = 51;
            this.data_HoaDon.RowTemplate.Height = 24;
            this.data_HoaDon.Size = new System.Drawing.Size(1032, 324);
            this.data_HoaDon.TabIndex = 72;
            this.data_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_HoaDon_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_in);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_DC);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_sdtKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_tenKH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_msGAS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_msNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_msKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 325);
            this.panel1.TabIndex = 73;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clear.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.user_40px1;
            this.btn_clear.Location = new System.Drawing.Point(211, 206);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(186, 60);
            this.btn_clear.TabIndex = 73;
            this.btn_clear.Text = "Làm Sạch / Mới";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_in
            // 
            this.btn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_in.Image = global::_119000808_VoHoangHuy_19CT112.Properties.Resources.check;
            this.btn_in.Location = new System.Drawing.Point(53, 206);
            this.btn_in.Margin = new System.Windows.Forms.Padding(2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(154, 60);
            this.btn_in.TabIndex = 72;
            this.btn_in.Text = "In Hóa Đơn";
            this.btn_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(778, 34);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(153, 32);
            this.txt_tongtien.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(656, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Tổng Tiền";
            // 
            // txt_DC
            // 
            this.txt_DC.Enabled = false;
            this.txt_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DC.Location = new System.Drawing.Point(487, 140);
            this.txt_DC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(276, 32);
            this.txt_DC.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(300, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 68;
            this.label9.Text = "Địa Chỉ";
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Enabled = false;
            this.txt_sdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtKH.Location = new System.Drawing.Point(487, 86);
            this.txt_sdtKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(137, 32);
            this.txt_sdtKH.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(300, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "SDT Khách Hàng";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Enabled = false;
            this.txt_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(487, 28);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(137, 32);
            this.txt_tenKH.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(300, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // txt_msGAS
            // 
            this.txt_msGAS.Enabled = false;
            this.txt_msGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msGAS.Location = new System.Drawing.Point(214, 138);
            this.txt_msGAS.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msGAS.Name = "txt_msGAS";
            this.txt_msGAS.Size = new System.Drawing.Size(64, 32);
            this.txt_msGAS.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(49, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "MS Gas";
            // 
            // txt_msNV
            // 
            this.txt_msNV.Enabled = false;
            this.txt_msNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msNV.Location = new System.Drawing.Point(214, 86);
            this.txt_msNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msNV.Name = "txt_msNV";
            this.txt_msNV.Size = new System.Drawing.Size(64, 32);
            this.txt_msNV.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(49, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "MS Nhân Viên";
            // 
            // txt_msKH
            // 
            this.txt_msKH.Enabled = false;
            this.txt_msKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msKH.Location = new System.Drawing.Point(214, 28);
            this.txt_msKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msKH.Name = "txt_msKH";
            this.txt_msKH.Size = new System.Drawing.Size(64, 32);
            this.txt_msKH.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(49, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "MS Khách Hàng";
            // 
            // LichsuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_HoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichsuHoaDon";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTHoaDonBanGasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_HoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rPTHoaDonBanGasBindingSource;
        private DataSet1TableAdapters.RPT_HoaDonBanGasTableAdapter rPT_HoaDonBanGasTableAdapter;
        private System.Windows.Forms.DataGridView data_HoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_msGAS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_msNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_msKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_clear;
    }
}