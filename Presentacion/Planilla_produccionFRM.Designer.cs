
namespace Presentacion
{
    partial class Planilla_produccionFRM
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
            this.PanificadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.combo_sectores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanificadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanificadosBindingSource
            // 
            this.PanificadosBindingSource.DataSource = typeof(BE.Panificados);
            // 
            // SectoresBindingSource
            // 
            this.SectoresBindingSource.DataSource = typeof(Presentacion.Sectores);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PanificadosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SectoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(931, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // combo_sectores
            // 
            this.combo_sectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sectores.FormattingEnabled = true;
            this.combo_sectores.Location = new System.Drawing.Point(352, 63);
            this.combo_sectores.Name = "combo_sectores";
            this.combo_sectores.Size = new System.Drawing.Size(165, 21);
            this.combo_sectores.TabIndex = 1;
            this.combo_sectores.SelectionChangeCommitted += new System.EventHandler(this.combo_sectores_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(365, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar sectores";
            // 
            // Planilla_produccionFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_sectores);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Planilla_produccionFRM";
            this.Text = "Imprimir planilla de produccion";
            this.Load += new System.EventHandler(this.Reporte_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanificadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PanificadosBindingSource;
        private System.Windows.Forms.ComboBox combo_sectores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource SectoresBindingSource;
    }
}