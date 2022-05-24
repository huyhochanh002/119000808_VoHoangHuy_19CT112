namespace _119000808_VoHoangHuy_19CT112
{
    partial class BaoCaoTheoNgay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RPT_HOADONTHEONGAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banGasDataSet = new _119000808_VoHoangHuy_19CT112.BanGasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPTHOADONTHEONGAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_HOADONTHEONGAYTableAdapter = new _119000808_VoHoangHuy_19CT112.BanGasDataSetTableAdapters.RPT_HOADONTHEONGAYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_HOADONTHEONGAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTHOADONTHEONGAYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_HOADONTHEONGAYBindingSource
            // 
            this.RPT_HOADONTHEONGAYBindingSource.DataMember = "RPT_HOADONTHEONGAY";
            this.RPT_HOADONTHEONGAYBindingSource.DataSource = this.banGasDataSet;
            // 
            // banGasDataSet
            // 
            this.banGasDataSet.DataSetName = "BanGasDataSet";
            this.banGasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPT_HOADONTHEONGAYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_119000808_VoHoangHuy_19CT112.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1121, 607);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPTHOADONTHEONGAYBindingSource
            // 
            this.rPTHOADONTHEONGAYBindingSource.DataMember = "RPT_HOADONTHEONGAY";
            this.rPTHOADONTHEONGAYBindingSource.DataSource = this.banGasDataSet;
            // 
            // rPT_HOADONTHEONGAYTableAdapter
            // 
            this.rPT_HOADONTHEONGAYTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1121, 607);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaoCaoTheoNgay";
            this.Text = "BaoCaoTheoNgay";
            this.Load += new System.EventHandler(this.BaoCaoTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_HOADONTHEONGAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTHOADONTHEONGAYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_HOADONTHEONGAYBindingSource;
        private BanGasDataSet banGasDataSet;
        private System.Windows.Forms.BindingSource rPTHOADONTHEONGAYBindingSource;
        private BanGasDataSetTableAdapters.RPT_HOADONTHEONGAYTableAdapter rPT_HOADONTHEONGAYTableAdapter;
    }
}