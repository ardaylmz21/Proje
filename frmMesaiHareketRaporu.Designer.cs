namespace PERSONEL_TAKİP_OTOMASyonu
{
    partial class frmMesaiHareketRaporu
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
            this.MesaiRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesaiRaporBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mesaiRaporTableAdapter = new PERSONEL_TAKİP_OTOMASyonu.PersonellTakibi1DataSetTableAdapters.MesaiRaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaiRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaiRaporBindingSource1)).BeginInit();
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
            reportDataSource1.Value = this.mesaiRaporBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PERSONEL_TAKİP_OTOMASyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1375, 735);
            this.reportViewer1.TabIndex = 0;
            // 
            // MesaiRaporBindingSource
            // 
            this.MesaiRaporBindingSource.DataMember = "MesaiRapor";
            this.MesaiRaporBindingSource.DataSource = this.personellTakibi1DataSet;
            // 
            // mesaiRaporBindingSource1
            // 
            this.mesaiRaporBindingSource1.DataMember = "MesaiRapor";
            this.mesaiRaporBindingSource1.DataSource = this.personellTakibi1DataSetBindingSource;
            // 
            // mesaiRaporTableAdapter
            // 
            this.mesaiRaporTableAdapter.ClearBeforeFill = true;
            // 
            // frmMesaiHareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMesaiHareketRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Hareket Raporu";
            this.Load += new System.EventHandler(this.frmMesaiHareketRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellTakibi1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesaiRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaiRaporBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personellTakibi1DataSetBindingSource;
        private PersonellTakibi1DataSet personellTakibi1DataSet;
        private System.Windows.Forms.BindingSource MesaiRaporBindingSource;
        private System.Windows.Forms.BindingSource mesaiRaporBindingSource1;
        private PersonellTakibi1DataSetTableAdapters.MesaiRaporTableAdapter mesaiRaporTableAdapter;
    }
}