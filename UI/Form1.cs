using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity();
                cliente.DNI = Convert.ToInt32(txtDNI.Text);
                cliente.Usuario = txtUsuario.Text;
                cliente.Contraseña = txtContraseña.Text;
                //metodo de buscar usuario por DNI y setear en capa data el resto de datos que no son seteados aca
                if (cliente.Admin == true)
                {
                    // si es cuenta admin abre el formulario de administracion de las cuentas admin
                    Formulario4_Admin_ formulario4_Admin = new Formulario4_Admin_();
                    formulario4_Admin.Show();
                    this.Close();
                }
                else
                {
                    // si es cuenta usuario abre el formulario de administracion de las cuentas usuario

                    Formulario3_Usuario_ formulario3 = new Formulario3_Usuario_();
                    formulario3.Show();
                    this.Close();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se ha podido ingresar el usuario, intenta nuevamente");
                throw;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Formulario2_Registro_ FormularioRegistro = new Formulario2_Registro_();


                FormularioRegistro.Show();


                this.Close();


            }
            catch (Exception ex) { throw; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
