namespace UI
{
    partial class reportHangHoa
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
            this.HangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhoDataSet = new UI.QLKhoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HangHoaTableAdapter = new UI.QLKhoDataSetTableAdapters.HangHoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HangHoaBindingSource
            // 
            this.HangHoaBindingSource.DataMember = "HangHoa";
            this.HangHoaBindingSource.DataSource = this.qLKhoDataSet;
            // 
            // qLKhoDataSet
            // 
            this.qLKhoDataSet.DataSetName = "QLKhoDataSet";
            this.qLKhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportHangHoa";
            reportDataSource1.Value = this.HangHoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // HangHoaTableAdapter
            // 
            this.HangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // reportHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportHangHoa";
            this.Text = "reportHangHoa";
            this.Load += new System.EventHandler(this.reportHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLKhoDataSet qLKhoDataSet;
        private System.Windows.Forms.BindingSource HangHoaBindingSource;
        private QLKhoDataSetTableAdapters.HangHoaTableAdapter HangHoaTableAdapter;
    }
}