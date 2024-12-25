namespace PERSONEL_TAKİP_OTOMASyonu
{
    partial class frmizinHareketRaporu
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
            this.personellTakibi1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personellTakibi1DataSet = new PERSONEL_TAKİP_OTOMASyonu.PersonellTakibi1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.İzinRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izinRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İzinRaporTableAdapter = new PERSONEL_TAKİP_OTOMASyonu.PersonellTakibi1DataSetTableAdapters.İzinRaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İzinRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinRaporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personellTakibi1DataSetBindingSource
            // 
            this.personellTakibi1DataSetBindingSource.DataSource = this.personellTakibi1DataSet;
            this.personellTakibi1DataSetBindingSource.Position = 0;
            // 
            // personellTakibi1DataSet
            // 
            this.personellTakibi1DataSet.DataSetName = "PersonellTakibi1DataSet";
            this.personellTakibi1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.izinRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PERSONEL_TAKİP_OTOMASyonu.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1374, 778);
            this.reportViewer1.TabIndex = 0;
            // 
            // İzinRaporBindingSource
            // 
            this.İzinRaporBindingSource.DataMember = "İzinRapor";
            this.İzinRaporBindingSource.DataSource = this.personellTakibi1DataSet;
            // 
            // izinRaporBindingSource
            // 
            this.izinRaporBindingSource.DataMember = "İzinRapor";
            this.izinRaporBindingSource.DataSource = this.personellTakibi1DataSetBindingSource;
            // 
            // İzinRaporTableAdapter
            // 
            this.İzinRaporTableAdapter.ClearBeforeFill = true;
            // 
            // frmizinHareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 778);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmizinHareketRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareket Raporu";
            this.Load += new System.EventHandler(this.frmizinHareketRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İzinRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinRaporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personellTakibi1DataSetBindingSource;
        private PersonellTakibi1DataSet personellTakibi1DataSet;
        private System.Windows.Forms.BindingSource İzinRaporBindingSource;
        private System.Windows.Forms.BindingSource izinRaporBindingSource;
        private PersonellTakibi1DataSetTableAdapters.İzinRaporTableAdapter İzinRaporTableAdapter;
    }
}