using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INVENTARIO.MODELO;

namespace INVENTARIO
{
    public partial class Articulos : Form
    {
        INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();
        public Articulos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int precio;
            try
            {
                precio = Convert.ToInt32(txttPrecio.Text);

                ARTICULOS articulos = new ARTICULOS
                {
                    Articulo = txtArticulo.Text,
                    Cantidad = txtCantidad.Text,
                    Precio = precio
                };

                if (txtArticulo.Text == "" && txtCantidad.Text == "" && txttPrecio.Text == "")
                {
                    MessageBox.Show("Hay campos vacios", "CAMPOS VACIOS");
                }
                db.ARTICULOS.Add(articulos);
                db.SaveChanges();

                MessageBox.Show("Articulo insertado con exito!!!!", "Articulos");

                txtArticulo.Text = txtCantidad.Text = txttPrecio.Text = "";
                txtArticulo.Focus();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
        }
    }
}
