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
    public partial class SellerReportScreen : Form
    {
        public SellerReportScreen()
        {
            InitializeComponent();
            dataGridSellerReport.Rows[0].Cells[0].Value = "09/09/2022"; //
            dataGridSellerReport.Rows[0].Cells[1].Value = "Juan"; //Juan
            dataGridSellerReport.Rows[0].Cells[2].Value = "Mariscos";
            dataGridSellerReport.Rows[0].Cells[3].Value = "13";
            dataGridSellerReport.Rows[0].Cells[4].Value = "10.00";
            dataGridSellerReport.Rows[0].Cells[5].Value = "20.00";
        }
    }
}
