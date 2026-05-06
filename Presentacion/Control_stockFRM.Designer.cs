
namespace Presentacion
{
    partial class Control_stockFRM
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PanificadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanificadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PanificadosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.LoteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reporte_stock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1064, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // PanificadosBindingSource
            // 
            this.PanificadosBindingSource.DataSource = typeof(BE.Panificados);
            // 
            // LoteBindingSource
            // 
            this.LoteBindingSource.DataSource = typeof(BE.Lote);
            // 
            // Control_stockFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 517);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Control_stockFRM";
            this.Text = "Control de stock";
            this.Load += new System.EventHandler(this.Control_stockFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanificadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PanificadosBindingSource;
        private System.Windows.Forms.BindingSource LoteBindingSource;
    }
}