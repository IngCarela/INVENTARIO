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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            INVENTARIODBEntitiesModelo db = new INVENTARIODBEntitiesModelo();

           var query= db.USUARIOS.Where(x => x.Usuario.Equals(textBox1.Text) && x.Contraseña.Equals(textBox2.Text)).FirstOrDefault();

            if (query !=null)
            {

                Principal p = new Principal();
                Factura factura = new Factura();
                
                p.Show();

                textBox1.Text = "";
                textBox2.Text = "";
                //MessageBox.Show("Exito!!!!");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalida");
            }

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoUsuario usuario = new NuevoUsuario();

            usuario.Show();
            this.Hide();
        }
    }
}
