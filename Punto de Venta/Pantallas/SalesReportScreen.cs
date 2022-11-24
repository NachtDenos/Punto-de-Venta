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
        Procedures proc = new Procedures();
        public SalesReportScreen()
        {
            InitializeComponent();
            dataGridSalesReport.DataSource = proc.listarRVenta();
            //dataGridSalesReport.Rows[0].Cells[0].Value = "09/09/2022";
            //dataGridSalesReport.Rows[0].Cells[1].Value = "Mariscos";
            //dataGridSalesReport.Rows[0].Cells[2].Value = "B412";
            //dataGridSalesReport.Rows[0].Cells[3].Value = "60.00";
            //dataGridSalesReport.Rows[0].Cells[4].Value = "30";
            //dataGridSalesReport.Rows[0].Cells[5].Value = "1,800.00";
            //dataGridSalesReport.Rows[0].Cells[6].Value = "0.00";
            //dataGridSalesReport.Rows[0].Cells[7].Value = "4123";
            //dataGridSalesReport.Rows[0].Cells[8].Value = "900.00";
        }

        private void btnFiltroFechaVentas_Click(object sender, EventArgs e)
        {
            DateTime fecha1Str = DateTime.Parse(dtpSalesReport1.Text);
            DateTime fecha2Str = DateTime.Parse(dtpSalesReport2.Text);
            dataGridSalesReport.DataSource = proc.listarVentaFecha(fecha1Str, fecha2Str);
        }

        private void txtVentaDepaReport_TextChanged(object sender, EventArgs e)
        {
            if (txtVentaDepaReport.Text != "")
            {
                dataGridSalesReport.DataSource = proc.listarVentaDepa(txtVentaDepaReport.Text);
            }
            else
            {
                dataGridSalesReport.DataSource = proc.listarRVenta();
            }
        }

        private void txtVentaCajaReport_TextChanged(object sender, EventArgs e)
        {
            if (txtVentaCajaReport.Text != "")
            {
                dataGridSalesReport.DataSource = proc.listarVentaCaja(txtVentaCajaReport.Text);
            }
            else
            {
                dataGridSalesReport.DataSource = proc.listarRVenta();
            }
        }

        private void txtVentaCajaReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void SalesReportScreen_Load(object sender, EventArgs e)
        {
            dataGridSalesReport.Columns["Precio Unitario"].DefaultCellStyle.Format = "C2";
            dataGridSalesReport.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            dataGridSalesReport.Columns["Venta"].DefaultCellStyle.Format = "C2";
            dataGridSalesReport.Columns["Utilidad"].DefaultCellStyle.Format = "C2";
        }
    }
}
