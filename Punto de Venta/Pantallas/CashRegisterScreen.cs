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
    public partial class CashRegisterScreen : Form
    {
        int indexBox;
        bool selection = false;
        public CashRegisterScreen()
        {
            InitializeComponent();
            dataGridCashRegister.Rows[0].Cells[0].Value = "1";
            dataGridCashRegister.Rows[0].Cells[1].Value = "Si";
        }

        private void txtIdCashRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnAddCashResgister_Click(object sender, EventArgs e)
        {
            if (txtIdCashRegister.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selection == false)
                MessageBox.Show("No seleccionó la disponibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (indexBox == 1)
                {
                }
                if (indexBox == 0)
                {
                }
            }
        }

        private void btnEditCashRegister_Click(object sender, EventArgs e)
        {
            if (txtIdCashRegister.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selection == false)
                MessageBox.Show("No seleccionó la disponibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (indexBox == 1)
                {
                }
                if (indexBox == 0)
                {
                }
            }
        }
    }
}
