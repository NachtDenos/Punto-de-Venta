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
        public CashRegisterScreen()
        {
            InitializeComponent();
            dataGridCashRegister.Rows[0].Cells[0].Value = "1";
            dataGridCashRegister.Rows[0].Cells[1].Value = "Si";
        }
    }
}
