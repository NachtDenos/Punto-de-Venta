using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class TicketReportScreen : Form
    {
        public TicketReportScreen()
        {
            InitializeComponent();
            ListarCajasCombo();
        }

        private void btnConsultTicketReport2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultTicketReport1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdTicketReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void ListarCajasCombo()
        {
            Procedures usuarioObj = new Procedures();
            cbTicketReport.DataSource = usuarioObj.ListarCajaCombo();
            cbTicketReport.DisplayMember = "Numero de Caja"; //Nombre
            cbTicketReport.ValueMember = "Numero de Caja";//Valor real de l combox
        }
    }
}
