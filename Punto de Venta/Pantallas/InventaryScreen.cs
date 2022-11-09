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
    public partial class InventaryScreen : Form
    {
        public InventaryScreen()
        {
            InitializeComponent();
            dataGridInventary.Rows[0].Cells[0].Value = "Mariscos";
            dataGridInventary.Rows[0].Cells[1].Value = "Salmón";
            dataGridInventary.Rows[0].Cells[2].Value = "kilogramos";
            dataGridInventary.Rows[0].Cells[3].Value = "50.00";
            dataGridInventary.Rows[0].Cells[4].Value = "60.00";
            dataGridInventary.Rows[0].Cells[5].Value = "15";
            dataGridInventary.Rows[0].Cells[6].Value = "40";
            dataGridInventary.Rows[0].Cells[7].Value = "0";
        }

        private void txtInventaryExiste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
