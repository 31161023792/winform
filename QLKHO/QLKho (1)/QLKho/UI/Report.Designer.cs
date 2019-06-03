namespace UI
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ChitietPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKhoDataSet = new UI.QLKhoDataSet();
            this.ChitietPhieuNhapTableAdapter = new UI.QLKhoDataSetTableAdapters.ChitietPhieuNhapTableAdapter();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportPhieuNhap = new DevExpress.XtraTab.XtraTabControl();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChitietDonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChitietDonHangTableAdapter = new UI.QLKhoDataSetTableAdapters.ChitietDonHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChitietPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKhoDataSet)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPhieuNhap)).BeginInit();
            this.ReportPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChitietDonHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChitietPhieuNhapBindingSource
            // 
            this.ChitietPhieuNhapBindingSource.DataMember = "ChitietPhieuNhap";
            this.ChitietPhieuNhapBindingSource.DataSource = this.QLKhoDataSet;
            // 
            // QLKhoDataSet
            // 
            this.QLKhoDataSet.DataSetName = "QLKhoDataSet";
            this.QLKhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChitietPhieuNhapTableAdapter
            // 
            this.ChitietPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(793, 416);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(793, 416);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ChitietPhieuNhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.ReportPhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(793, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportPhieuNhap
            // 
            this.ReportPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.ReportPhieuNhap.Name = "ReportPhieuNhap";
            this.ReportPhieuNhap.SelectedTabPage = this.xtraTabPage2;
            this.ReportPhieuNhap.Size = new System.Drawing.Size(800, 450);
            this.ReportPhieuNhap.TabIndex = 0;
            this.ReportPhieuNhap.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "ReportDonHang";
            reportDataSource4.Value = this.ChitietDonHangBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "UI.ReportDonHang.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(793, 416);
            this.reportViewer2.TabIndex = 0;
            // 
            // ChitietDonHangBindingSource
            // 
            this.ChitietDonHangBindingSource.DataMember = "ChitietDonHang";
            this.ChitietDonHangBindingSource.DataSource = this.QLKhoDataSet;
            // 
            // ChitietDonHangTableAdapter
            // 
            this.ChitietDonHangTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportPhieuNhap);
            this.Name = "Report";
            this.Text = "ReportPhieuNhap";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChitietPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKhoDataSet)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportPhieuNhap)).EndInit();
            this.ReportPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChitietDonHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ChitietPhieuNhapBindingSource;
        private QLKhoDataSet QLKhoDataSet;
        private QLKhoDataSetTableAdapters.ChitietPhieuNhapTableAdapter ChitietPhieuNhapTableAdapter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraTab.XtraTabControl ReportPhieuNhap;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ChitietDonHangBindingSource;
        private QLKhoDataSetTableAdapters.ChitietDonHangTableAdapter ChitietDonHangTableAdapter;
    }
}