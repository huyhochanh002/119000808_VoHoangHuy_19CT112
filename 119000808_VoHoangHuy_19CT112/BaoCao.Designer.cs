namespace _119000808_VoHoangHuy_19CT112
{
    partial class BaoCao
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
            this.RPT_HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banGasDataSet = new _119000808_VoHoangHuy_19CT112.BanGasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPTHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_HOADONTableAdapter = new _119000808_VoHoangHuy_19CT112.BanGasDataSetTableAdapters.RPT_HOADONTableAdapter();
            this.banGasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_HOADONBindingSource
            // 
            this.RPT_HOADONBindingSource.DataMember = "RPT_HOADON";
            this.RPT_HOADONBindingSource.DataSource = this.banGasDataSet;
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
            reportDataSource1.Value = this.RPT_HOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_119000808_VoHoangHuy_19CT112.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1091, 591);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // rPTHOADONBindingSource
            // 
            this.rPTHOADONBindingSource.DataMember = "RPT_HOADON";
            this.rPTHOADONBindingSource.DataSource = this.banGasDataSet;
            // 
            // rPT_HOADONTableAdapter
            // 
            this.rPT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // banGasDataSetBindingSource
            // 
            this.banGasDataSetBindingSource.DataSource = this.banGasDataSet;
            this.banGasDataSetBindingSource.Position = 0;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 591);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banGasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rPTHOADONBindingSource;
        private BanGasDataSet banGasDataSet;
        private BanGasDataSetTableAdapters.RPT_HOADONTableAdapter rPT_HOADONTableAdapter;
        private System.Windows.Forms.BindingSource banGasDataSetBindingSource;
        private System.Windows.Forms.BindingSource RPT_HOADONBindingSource;
    }
}