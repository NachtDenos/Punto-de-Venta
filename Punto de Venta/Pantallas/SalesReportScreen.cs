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
    public partial class SalesReportScreen : Form
    {
        public SalesReportScreen()
        {
            InitializeComponent();
            dataGridSalesReport.Rows[0].Cells[0].Value = "09/09/2022";
            dataGridSalesReport.Rows[0].Cells[1].Value = "Mariscos";
            dataGridSalesReport.Rows[0].Cells[2].Value = "B412";
            dataGridSalesReport.Rows[0].Cells[3].Value = "60.00";
            dataGridSalesReport.Rows[0].Cells[4].Value = "30";
            dataGridSalesReport.Rows[0].Cells[5].Value = "1,800.00";
            dataGridSalesReport.Rows[0].Cells[6].Value = "0.00";
            dataGridSalesReport.Rows[0].Cells[7].Value = "4123";
            dataGridSalesReport.Rows[0].Cells[8].Value = "900.00";
        }


    }
}
