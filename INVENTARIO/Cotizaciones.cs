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
    public partial class Cotizaciones : Form
    {
        INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();

        public Cotizaciones()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.Show();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {

            cbProducto.DataSource = db.ARTICULOS.ToList();

            cbProducto.ValueMember = "id_articulo";
            cbProducto.DisplayMember = "Articulo";

            cbCliente.DataSource = db.CLIENTES.ToList();

            cbCliente.ValueMember = "Id_cliente";
            cbCliente.DisplayMember = "Nombre";
        }

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            try
            {
                int articulo, cliente, cantidad, monto;

                articulo = Convert.ToInt32(cbProducto.SelectedValue);
                cliente = Convert.ToInt32(cbCliente.SelectedValue);
                cantidad = Convert.ToInt32(txtCantidad.Text);
                monto = Convert.ToInt32(txtMonto.Text);

                dataGridView1.Rows.Add(articulo, cliente, cantidad, monto);

                txtMonto.Text = txtCantidad.Text = "";
                txtCantidad.Focus();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Problema con factura");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(fila.Index);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                

                int articulo, cliente, cantidad, monto;
                int conteo = dataGridView1.Rows.Count;

                for (int i = 0; i < conteo-1; i++)
                {
                    articulo = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    cliente = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    monto = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                    COTIZACIONES cotizaciones = new COTIZACIONES
                    {
                        Id_articulos = articulo,
                        Id_cliente = cliente,
                        Cantidad = cantidad,
                        Monto = monto
                    };

                    db.COTIZACIONES.Add(cotizaciones);
                    db.SaveChanges();
                }

                MessageBox.Show("Cotizacion guardada con exto!!", "COTIZACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear();

            }
            catch (Exception eo)
            {

                MessageBox.Show(eo.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Rows.Clear();
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                int articulo, cliente, cantidad, monto;
                int conteo = dataGridView1.Rows.Count;

                for (int i = 0; i < conteo; i++)
                {
                    articulo = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    cliente = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2]);
                    monto = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                    DETALLEFACTURAS factura = new DETALLEFACTURAS
                    {
                        Id_articulos = articulo,
                        Id_cliente = cliente,
                        Cantidad = cantidad,
                        Monto = monto
                    };

                    db.DETALLEFACTURAS.Add(factura);
                    db.SaveChanges();
                }
            }
            catch (Exception excepcion)
            {

                MessageBox.Show(excepcion.Message, "ERROR");
                dataGridView1.Rows.Clear();
            }
        }
    }
}
