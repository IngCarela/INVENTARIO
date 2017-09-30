namespace INVENTARIO
{
    partial class Ventas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.INVENTARIODBDFacturaDataset = new INVENTARIO.INVENTARIODBDFacturaDataset();
            this.DETALLEFACTURASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DETALLEFACTURASTableAdapter = new INVENTARIO.INVENTARIODBDFacturaDatasetTableAdapters.DETALLEFACTURASTableAdapter();
            this.VentaDataSet1 = new INVENTARIO.VentaDataSet1();
            this.Factura_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Factura_ViewTableAdapter = new INVENTARIO.VentaDataSet1TableAdapters.Factura_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.INVENTARIODBDFacturaDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETALLEFACTURASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factura_ViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Ventas";
            reportDataSource2.Value = this.Factura_ViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "INVENTARIO.REPORTE.Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(644, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // INVENTARIODBDFacturaDataset
            // 
            this.INVENTARIODBDFacturaDataset.DataSetName = "INVENTARIODBDFacturaDataset";
            this.INVENTARIODBDFacturaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DETALLEFACTURASBindingSource
            // 
            this.DETALLEFACTURASBindingSource.DataMember = "DETALLEFACTURAS";
            this.DETALLEFACTURASBindingSource.DataSource = this.INVENTARIODBDFacturaDataset;
            // 
            // DETALLEFACTURASTableAdapter
            // 
            this.DETALLEFACTURASTableAdapter.ClearBeforeFill = true;
            // 
            // VentaDataSet1
            // 
            this.VentaDataSet1.DataSetName = "VentaDataSet1";
            this.VentaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Factura_ViewBindingSource
            // 
            this.Factura_ViewBindingSource.DataMember = "Factura_View";
            this.Factura_ViewBindingSource.DataSource = this.VentaDataSet1;
            // 
            // Factura_ViewTableAdapter
            // 
            this.Factura_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 470);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INVENTARIODBDFacturaDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETALLEFACTURASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factura_ViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DETALLEFACTURASBindingSource;
        private INVENTARIODBDFacturaDataset INVENTARIODBDFacturaDataset;
        private INVENTARIODBDFacturaDatasetTableAdapters.DETALLEFACTURASTableAdapter DETALLEFACTURASTableAdapter;
        private System.Windows.Forms.BindingSource Factura_ViewBindingSource;
        private VentaDataSet1 VentaDataSet1;
        private VentaDataSet1TableAdapters.Factura_ViewTableAdapter Factura_ViewTableAdapter;
    }
}