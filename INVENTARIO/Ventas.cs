using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTARIO
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VentaDataSet1.Factura_View' Puede moverla o quitarla según sea necesario.
            this.Factura_ViewTableAdapter.Fill(this.VentaDataSet1.Factura_View);
            // TODO: esta línea de código carga datos en la tabla 'INVENTARIODBDFacturaDataset.DETALLEFACTURAS' Puede moverla o quitarla según sea necesario.
            this.DETALLEFACTURASTableAdapter.Fill(this.INVENTARIODBDFacturaDataset.DETALLEFACTURAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
