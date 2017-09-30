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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();

            USUARIOS usuario = new USUARIOS
            {
                Usuario = txtUsuario.Text,
                Contraseña = txtContraseña.Text,
                Id_tipoU =cbTipo.SelectedIndex
            };

            if (txtUsuario.Text=="" && txtContraseña.Text=="")
            {
                MessageBox.Show("Usuario o Contraseña vacios");
            }
            db.USUARIOS.Add(usuario);
            db.SaveChanges();

            MessageBox.Show("Usuario insertado con exito");
            txtUsuario.Text = txtContraseña.Text = "";
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();

            formulario.Show();
            this.Hide();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNVENTARIODBDataSet.TIPOSDEUSUARIOS' Puede moverla o quitarla según sea necesario.
            this.tIPOSDEUSUARIOSTableAdapter.Fill(this.iNVENTARIODBDataSet.TIPOSDEUSUARIOS);

            //INVENTARIODBEntities db = new INVENTARIODBEntities();


            //cbTipo.DataSource = db.TIPOSDEUSUARIOS.ToList();

            ////cbTipo.DisplayMember = "Nombre";
            ////cbTipo.ValueMember = "Id";
            //cbTipo.DataBindings
        }
    }
}
