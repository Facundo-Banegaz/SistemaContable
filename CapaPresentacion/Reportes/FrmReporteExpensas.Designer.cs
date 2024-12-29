namespace CapaPresentacion
{
    partial class FrmReporteExpensas
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
            this.spReporteExpensasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes = new CapaPresentacion.DsReportes();
            this.Rpt_Expensa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporte_ExpensasTableAdapter = new CapaPresentacion.DsReportesTableAdapters.SpReporte_ExpensasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteExpensasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // spReporteExpensasBindingSource
            // 
            this.spReporteExpensasBindingSource.DataMember = "SpReporte_Expensas";
            this.spReporteExpensasBindingSource.DataSource = this.dsReportes;
            // 
            // dsReportes
            // 
            this.dsReportes.DataSetName = "DsReportes";
            this.dsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpt_Expensa
            // 
            this.Rpt_Expensa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReporteExpensasBindingSource;
            this.Rpt_Expensa.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpt_Expensa.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RprtExpensa.rdlc";
            this.Rpt_Expensa.Location = new System.Drawing.Point(0, 0);
            this.Rpt_Expensa.Name = "Rpt_Expensa";
            this.Rpt_Expensa.ServerReport.BearerToken = null;
            this.Rpt_Expensa.Size = new System.Drawing.Size(1358, 829);
            this.Rpt_Expensa.TabIndex = 0;
            // 
            // spReporte_ExpensasTableAdapter
            // 
            this.spReporte_ExpensasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteExpensas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 829);
            this.Controls.Add(this.Rpt_Expensa);
            this.Name = "FrmReporteExpensas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Expensas";
            this.Load += new System.EventHandler(this.FrmReporteExpensas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReporteExpensasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpt_Expensa;
        private System.Windows.Forms.BindingSource spReporteExpensasBindingSource;
        private DsReportes dsReportes;
        private DsReportesTableAdapters.SpReporte_ExpensasTableAdapter spReporte_ExpensasTableAdapter;
    }
}