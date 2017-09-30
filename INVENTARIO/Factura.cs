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
    public partial class Factura : Form
    {

        public Factura()
        {
            InitializeComponent();
        }

        INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();
        int indexRow = 0;
        //bool existe = false;
        int conteoFila = 0;

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNVENTARIODBDataSetCliente.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.iNVENTARIODBDataSetCliente.CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'iNVENTARIODBDataSetProductos.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.aRTICULOSTableAdapter.Fill(this.iNVENTARIODBDataSetProductos.ARTICULOS);

            var queryProducto = db.ARTICULOS.ToList();
            cbProducto.DataSource = queryProducto;

            cbProducto.ValueMember = "id_articulo";
            cbProducto.DisplayMember = "Articulo";


            cbCliente.DataSource = db.CLIENTES.ToList();

            cbCliente.ValueMember = "Id_cliente";
            cbCliente.DisplayMember = "Nombre";
        }

        private void btnACliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conteoFila == 0)
                {
                    int articulo, monto, cantidad, cliente;




                    articulo = Convert.ToInt32(cbProducto.SelectedValue);
                    monto = int.Parse(txtMonto.Text);
                    cantidad = int.Parse(txtCantidad.Text);
                    cliente = Convert.ToInt32(cbCliente.SelectedValue);



                    dataGridView1.Rows.Add(articulo, monto, cantidad, cliente);


                    txtCantidad.Text = txtMonto.Text = "";
                    txtCantidad.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Cuadro de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var query = db.DETALLEFACTURAS.Where(x => x.id_detalle == (int)cbProducto.SelectedValue).ToList();
            //DETALLEFACTURAS factura = new DETALLEFACTURAS();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(fila.Index);
            }

        }

        Bitmap bmp;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow ndr = dataGridView1.Rows[indexRow];
                int monto, cantidad, articulo, cliente;
                
                int conteo = dataGridView1.Rows.Count;

                

            for (int i = 0; i < conteo-1; i++)
            {
                articulo = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                monto = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                cliente = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                DETALLEFACTURAS dFactura = new DETALLEFACTURAS
                {
                    Id_articulos = articulo,
                    Monto = monto,
                    Cantidad = cantidad,
                    Id_cliente = cliente

                };

                db.DETALLEFACTURAS.Add(dFactura);
                db.SaveChanges();

                    string convertirArticulo;

                    
                    convertirArticulo = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                    
            }



                DialogResult dialogo = MessageBox.Show("Desea imprimir la factura", "FACTURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {

                    int altura = dataGridView1.Height;
                    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                    bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                    dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                    dataGridView1.Height = altura;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No ha imprimido la factura pero se ha guardado", "FACTURA");
                }

                dataGridView1.Rows.Clear();

            
        }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dataGridView1.Rows.Clear();
            }
}

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Registros registro = new Registros();

            registro.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
    }
