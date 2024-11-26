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
    public partial class Formulario4_Admin_ : Form
    {
        public Formulario4_Admin_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Formulario2_Registro_ formulario = new Formulario2_Registro_();
                formulario.Show();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarSeña_Click(object sender, EventArgs e)
        {
            try
            {
                // metodo para modificar seña (idreserva,nuevaseña)


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                //metodo de agregar mesa(cantidaddeasientos)

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {

        }
    }
}
