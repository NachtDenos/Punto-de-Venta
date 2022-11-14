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
            //dataGridProductSales.Rows[0].Cells[0].Value = "B312";
            //dataGridProductSales.Rows[0].Cells[1].Value = "Jamón";
            //dataGridCarritoSales.Rows[0].Cells[0].Value = "B412";
            //dataGridCarritoSales.Rows[0].Cells[1].Value = "Salmón";
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

        private void txtQuantitySales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        public bool onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return false;
            }
            return true;
        }

        private void txtQuantityDeleteSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            if (txtQuantitySales.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cant = txtQuantitySales.Text;
            int cantInt = Int32.Parse(cant);
            if (cantInt == 0)
            {
                MessageBox.Show("No se puede ingresar un valor en cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            if (txtQuantityDeleteSales.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cant = txtQuantityDeleteSales.Text;
            int cantInt = Int32.Parse(cant);
            if (cantInt == 0)
            {
                MessageBox.Show("No se puede ingresar un valor en cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
