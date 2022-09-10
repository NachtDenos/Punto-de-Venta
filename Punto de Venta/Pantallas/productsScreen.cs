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
    public partial class productsScreen : Form
    {
        public productsScreen()
        {
            InitializeComponent();
            dataGridProduct.Rows[0].Cells[0].Value = "B312";
            dataGridProduct.Rows[0].Cells[1].Value = "Pescado importado";
            dataGridProduct.Rows[0].Cells[2].Value = "Mariscos";
            dataGridProduct.Rows[0].Cells[3].Value = "Kilogramo";
            dataGridProduct.Rows[0].Cells[4].Value = "50.00";
            dataGridProduct.Rows[0].Cells[5].Value = "60.00";
            dataGridProduct.Rows[0].Cells[6].Value = "09/09/2022";
            dataGridProduct.Rows[0].Cells[7].Value = "50";
            dataGridProduct.Rows[0].Cells[8].Value = "10";
            dataGridProduct.Rows[0].Cells[9].Value = "No aplica";
            dataGridProduct.Rows[0].Cells[10].Value = "Si";
        }
    }
}
