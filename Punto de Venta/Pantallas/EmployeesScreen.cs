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
    public partial class EmployeesScreen : Form
    {
        public EmployeesScreen()
        {
            InitializeComponent();
        }

        private void buttonExitEmployees_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
