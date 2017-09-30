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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtProducto.Text == "" && txtCantidad.Text == "" && txtPrecio.Text == "")
            {
                MessageBox.Show("Hay campos vacios");
            }

            try
            {
                ARTICULOS articulos = new ARTICULOS
                {
                    Articulo = txtProducto.Text,
                    Cantidad = txtCantidad.Text,
                    Precio = Convert.ToInt32(txtPrecio.Text)
                };

                db.ARTICULOS.Add(articulos);
                db.SaveChanges();

                MessageBox.Show("Producto agregado");
                txtProducto.Text = txtCantidad.Text = txtPrecio.Text = "";
                txtProducto.Focus();

            }
            catch (Exception ex)
            {

                if (txtProducto.Text == "" && txtCantidad.Text == "" && txtPrecio.Text == "")
                {
                    MessageBox.Show("Hay campos vacios",ex.Message);
                }
            }
            
        }
    }
}
