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
        Procedures proc = new Procedures();
        public SellerReportScreen()
        {
            InitializeComponent();
            dataGridSellerReport.DataSource = proc.listarRCajero();
            //dataGridSellerReport.Rows[0].Cells[0].Value = "09/09/2022"; //
            //dataGridSellerReport.Rows[0].Cells[1].Value = "Juan"; //Juan
            //dataGridSellerReport.Rows[0].Cells[2].Value = "Mariscos";
            //dataGridSellerReport.Rows[0].Cells[3].Value = "13";
            //dataGridSellerReport.Rows[0].Cells[4].Value = "10.00";
            //dataGridSellerReport.Rows[0].Cells[5].Value = "20.00";
        }

        private void txtCasherReport_TextChanged(object sender, EventArgs e)
        {
            if (txtCasherReport.Text != "")
            {
                dataGridSellerReport.DataSource = proc.listarRCajeroCajero(txtCasherReport.Text);
            }
            else
            {
                dataGridSellerReport.DataSource = proc.listarRCajero();
            }
        }

        private void txtDepaCasherReport_TextChanged(object sender, EventArgs e)
        {
            if (txtDepaCasherReport.Text != "")
            {
                dataGridSellerReport.DataSource = proc.listarRCajeroDepa(txtDepaCasherReport.Text);
            }
            else
            {
                dataGridSellerReport.DataSource = proc.listarRCajero();
            }
        }

        private void btnFiltroFechaCajeros_Click(object sender, EventArgs e)
        {
            DateTime fecha1Str = DateTime.Parse(dtpSellerReport1.Text);
            DateTime fecha2Str = DateTime.Parse(dtpSellerReport2.Text);
            dataGridSellerReport.DataSource = proc.listarRCajeroFecha(fecha1Str, fecha2Str);
        }

        private void SellerReportScreen_Load(object sender, EventArgs e)
        {
            dataGridSellerReport.Columns["Suma Venta"].DefaultCellStyle.Format = "C2";
            dataGridSellerReport.Columns["Utilidad"].DefaultCellStyle.Format = "C2";
        }
    }
}
