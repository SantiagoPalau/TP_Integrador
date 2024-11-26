using Entity;
using Mapper;
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
    public partial class Formulario3_Usuario_ : Form
    {
        public Formulario3_Usuario_()
        {
            InitializeComponent();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaEntity reserva = new ReservaEntity()
                {
                    CantidadComensales = Convert.ToInt32(txtComensales),
                    Horario = Convert.ToDateTime(cmbHorarios.SelectedValue),
                    // Mesa= getbyNumerodeMesa(comboboxdemesa)
                    Seña = Convert.ToDouble(txtSeñaReserva),
                    

                    // Cliente= getbyidcliente(variable del form 1)




                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
