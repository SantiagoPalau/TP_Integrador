using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Formulario2_Registro_ : Form
    {
        public Formulario2_Registro_()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 FormularioIngreso = new Form1();
                FormularioIngreso.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity()
                {
                    DNI = Convert.ToInt32(txtDNIaRegistrar.Text),
                    Direccion = txtDireccionaRegistrar.Text,
                    Apellido = txtApellidoaRegistrar.Text,
                    Telefono = txtTelefonoaRegistrar.Text,
                    Contraseña = txtContraseña.Text,
                    Admin=false,
                    Nombre = txtNombreaRegistrar.Text,
                    Usuario = txtRegistroUsuario.Text,


                };
                //Metodo de ingresar cliente a la base de datos
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
