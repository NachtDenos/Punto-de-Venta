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
    public partial class departamentScreen : Form
    {
        public departamentScreen()
        {
            InitializeComponent();
            dataGridDepartament.Rows[0].Cells[0].Value = "D012409";
            dataGridDepartament.Rows[0].Cells[1].Value = "Mariscos";
            dataGridDepartament.Rows[0].Cells[2].Value = "Si";
        }
    }
}
