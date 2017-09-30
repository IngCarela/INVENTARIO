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

    public partial class Registros : Form
    {
        INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();

        public Registros()
        {
            InitializeComponent();
        }


        private void Registros_Load(object sender, EventArgs e)
        {

            txtBusqueda.Focus();
            dataGridView1.DataSource = db.Factura_View.ToList();
            
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {

            txtBusqueda.Focus();

            int convertir;
            

            if (int.TryParse(txtBusqueda.Text,out convertir))
            {
                dataGridView1.DataSource = db.DETALLEFACTURAS.Where(x => x.id_detalle.Equals(convertir)).ToList();
                
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                var detalle = fila.DataBoundItem as DETALLEFACTURAS;

                db.DETALLEFACTURAS.Remove(detalle);
                db.SaveChanges();

                if (detalle !=null)
                {
                    MessageBox.Show("Factura eliminada con exito", "Eliminar factura", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }
    }
}
