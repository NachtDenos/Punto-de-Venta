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
    public partial class SalesScreen : Form
    {
        public SalesScreen()
        {
            InitializeComponent();
        }

        private void btnQuickSearchSales_Click(object sender, EventArgs e)
        {
            QuickSearchScreen TheOtherForm = new QuickSearchScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnPaySales_Click(object sender, EventArgs e)
        {
            WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            TheOtherForm.ShowDialog();
        }
    }
}
