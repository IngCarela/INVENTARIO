namespace INVENTARIO
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.iNVENTARIODBDataSetProductos = new INVENTARIO.INVENTARIODBDataSetProductos();
            this.iNVENTARIODBDataSetProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVENTARIODBDataSetProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aRTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRTICULOSTableAdapter = new INVENTARIO.INVENTARIODBDataSetProductosTableAdapters.ARTICULOSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnACliente = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.iNVENTARIODBDataSetCliente = new INVENTARIO.INVENTARIODBDataSetCliente();
            this.iNVENTARIODBDataSetClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new INVENTARIO.INVENTARIODBDataSetClienteTableAdapters.CLIENTESTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(120, 37);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 0;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // iNVENTARIODBDataSetProductos
            // 
            this.iNVENTARIODBDataSetProductos.DataSetName = "INVENTARIODBDataSetProductos";
            this.iNVENTARIODBDataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTARIODBDataSetProductosBindingSource
            // 
            this.iNVENTARIODBDataSetProductosBindingSource.DataSource = this.iNVENTARIODBDataSetProductos;
            this.iNVENTARIODBDataSetProductosBindingSource.Position = 0;
            // 
            // iNVENTARIODBDataSetProductosBindingSource1
            // 
            this.iNVENTARIODBDataSetProductosBindingSource1.DataSource = this.iNVENTARIODBDataSetProductos;
            this.iNVENTARIODBDataSetProductosBindingSource1.Position = 0;
            // 
            // aRTICULOSBindingSource
            // 
            this.aRTICULOSBindingSource.DataMember = "ARTICULOS";
            this.aRTICULOSBindingSource.DataSource = this.iNVENTARIODBDataSetProductosBindingSource1;
            // 
            // aRTICULOSTableAdapter
            // 
            this.aRTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // btnACliente
            // 
            this.btnACliente.Location = new System.Drawing.Point(258, 74);
            this.btnACliente.Name = "btnACliente";
            this.btnACliente.Size = new System.Drawing.Size(96, 23);
            this.btnACliente.TabIndex = 4;
            this.btnACliente.Text = "Agregar Cliente";
            this.btnACliente.UseVisualStyleBackColor = true;
            this.btnACliente.Click += new System.EventHandler(this.btnACliente_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(488, 38);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(488, 77);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdArticulo,
            this.colMonto,
            this.colCantidad,
            this.colIdCliente});
            this.dataGridView1.Location = new System.Drawing.Point(47, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.HeaderText = "Articulo";
            this.colIdArticulo.Name = "colIdArticulo";
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colIdCliente
            // 
            this.colIdCliente.HeaderText = "Cliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Location = new System.Drawing.Point(207, 346);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(75, 23);
            this.btnRegistros.TabIndex = 11;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(370, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(534, 346);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Facturar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(120, 74);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 14;
            // 
            // iNVENTARIODBDataSetCliente
            // 
            this.iNVENTARIODBDataSetCliente.DataSetName = "INVENTARIODBDataSetCliente";
            this.iNVENTARIODBDataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTARIODBDataSetClienteBindingSource
            // 
            this.iNVENTARIODBDataSetClienteBindingSource.DataSource = this.iNVENTARIODBDataSetCliente;
            this.iNVENTARIODBDataSetClienteBindingSource.Position = 0;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.iNVENTARIODBDataSetClienteBindingSource;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 396);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnACliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProducto);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTARIODBDataSetClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.BindingSource iNVENTARIODBDataSetProductosBindingSource1;
        private INVENTARIODBDataSetProductos iNVENTARIODBDataSetProductos;
        private System.Windows.Forms.BindingSource iNVENTARIODBDataSetProductosBindingSource;
        private System.Windows.Forms.BindingSource aRTICULOSBindingSource;
        private INVENTARIODBDataSetProductosTableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnACliente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.BindingSource iNVENTARIODBDataSetClienteBindingSource;
        private INVENTARIODBDataSetCliente iNVENTARIODBDataSetCliente;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private INVENTARIODBDataSetClienteTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}