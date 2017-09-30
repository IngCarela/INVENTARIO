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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();

            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cotizaciones cotizaciones = new Cotizaciones();

            cotizaciones.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();

            articulos.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas reporteDeVentas = new Ventas();

            reporteDeVentas.Show();
        }
    }
}
