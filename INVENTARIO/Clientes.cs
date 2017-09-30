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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }


        INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();
        //INVENTARIODBEntities db = new INVENTARIODBEntities();
        int indexRow;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
          
            
                CLIENTES clientes = new CLIENTES
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text
                };

                db.CLIENTES.Add(clientes);
                db.SaveChanges();

                if (txtNombre.Text == "" && txtDireccion.Text == "")
                {
                    MessageBox.Show("Nombre o Direccion estan vacios");
                }

                MessageBox.Show("Cliente insertado con exito!!!!");
                txtNombre.Text = txtDireccion.Text = "";
                txtNombre.Focus();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.CLIENTES.ToList();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var query = db.CLIENTES.Where(x => x.Nombre.StartsWith(txtBusqueda.Text));

            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDireccion.Text = row.Cells[2].Value.ToString();

           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow ndr = dataGridView1.Rows[indexRow];


            ndr.Cells[1].Value = txtNombre.Text;
            ndr.Cells[2].Value = txtDireccion.Text;
           

            CLIENTES cliente = new CLIENTES();
          
            var query = (from a in db.CLIENTES
                       where a.Id_cliente== cliente.Id_cliente
                       select a).FirstOrDefault();
            
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            
            db.SaveChanges();

            if (true)
            {
                MessageBox.Show("Cliente actualizado con exito!!!");
            }

            if (txtNombre.Text == "" && txtDireccion.Text == "")
            {
                MessageBox.Show("Nombre o Direccion estan vacios");
            }

            txtNombre.Text = txtDireccion.Text = "";
            txtNombre.Focus();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var clientes = row.DataBoundItem as CLIENTES;
                db.CLIENTES.Remove(clientes);
                db.SaveChanges();

                if (clientes!=null)
                {
                    MessageBox.Show("Cliente eliminado");
                }
            }
            
            }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


