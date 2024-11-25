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
                MessageBox.Show("No se ha podido ingresar el usuario, intenta nuevamente", MessageBoxIcon.Error.ToString(), MessageBoxButtons.OK);



            }
            catch(Exception ex) {

                MessageBox.Show("No se ha podido ingresar el usuario, intenta nuevamente", MessageBoxIcon.Error.ToString(), MessageBoxButtons.OK);
                throw;
            
            }
        }
    }
}
