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
    public partial class DiscountsScreen : Form
    {
        public DiscountsScreen()
        {
            InitializeComponent();
            dataGridDiscounts.Rows[0].Cells[0].Value = "Agua Mineral 100ml";
            dataGridDiscounts.Rows[0].Cells[1].Value = "1";
            dataGridDiscounts.Rows[0].Cells[2].Value = "10%";
            dataGridDiscounts.Rows[0].Cells[3].Value = "08/09/2022";
            dataGridDiscounts.Rows[0].Cells[4].Value = "10/09/2022";
        }

        private void txtDiscountDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnEditDiscounts_Click(object sender, EventArgs e)
        {
            if (txtDiscountDiscount.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
