using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Punto_de_Venta
{
    public partial class TicketReportScreen : Form
    {
        Procedures proc = new Procedures();
        public TicketReportScreen()
        {
            InitializeComponent();
            ListarCajasCombo();
            txtIdTicketReportRecibo.Enabled = false;
            btnConsultTicketReportRecibo.Enabled = false;
            btnReprintTicketRecibo.Enabled = false;
            txtIdTicketReportNota.Enabled = false;
            btnConsultTicketReportNota.Enabled = false;
            btnReprintTicketNota.Enabled = false;
        }

        private void btnConsultTicketReport2_Click(object sender, EventArgs e)
        {
            int caja = Int32.Parse(cbTicketReport.Text);
            DateTime fecha = DateTime.Parse(dtpTicketReport.Text);
            dataGridConsultaTicket.DataSource = proc.checarTicketFechaCaja(caja, fecha);
        }

        private void btnConsultTicketReport1_Click(object sender, EventArgs e)
        {
            string numTicket;

            numTicket = txtIdTicketReportRecibo.Text;
            int ticket;
            Int32.TryParse(numTicket, out ticket);
            dataGridTicketReport.DataSource = proc.ObtenerTicket(ticket);
        }

        private void txtIdTicketReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void ListarCajasCombo()
        {
            Procedures usuarioObj = new Procedures();
            cbTicketReport.DataSource = usuarioObj.ListarCajaComboSinFiltro();
            cbTicketReport.DisplayMember = "Numero de Caja"; //Nombre
            cbTicketReport.ValueMember = "Numero de Caja";//Valor real de l combox
        }

        private void TicketReportScreen_Load(object sender, EventArgs e)
        {

        }

        private void cbTicketReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpTicketReport_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbNota_Click(object sender, EventArgs e)
        {
            if (txtIdTicketReportNota.Enabled == false)
            {
                txtIdTicketReportNota.Enabled = true;
                btnConsultTicketReportNota.Enabled = true;
                btnReprintTicketNota.Enabled = true;
                cbRecibo.Enabled = false;

            }
            else if (txtIdTicketReportNota.Enabled == true)
            {
                txtIdTicketReportNota.Enabled = false;
                btnConsultTicketReportNota.Enabled = false;
                btnReprintTicketNota.Enabled = false;
                cbRecibo.Enabled = true;
                dataGridTicketReport.DataSource = proc.ObtenerNota(0);
                txtIdTicketReportNota.Text = "";
            }
        }

        private void cbRecibo_Click(object sender, EventArgs e)
        {
            if (txtIdTicketReportRecibo.Enabled == false)
            {
                txtIdTicketReportRecibo.Enabled = true;
                btnConsultTicketReportRecibo.Enabled = true;
                btnReprintTicketRecibo.Enabled = true;
                cbNota.Enabled = false;

            }
            else if (txtIdTicketReportRecibo.Enabled == true)
            {
                txtIdTicketReportRecibo.Enabled = false;
                btnConsultTicketReportRecibo.Enabled = false;
                btnReprintTicketRecibo.Enabled = false;
                cbNota.Enabled = true;
                dataGridTicketReport.DataSource = proc.ObtenerNota(0);
                txtIdTicketReportRecibo.Text = "";
            }
        }

        private void btnConsultTicketReportNota_Click(object sender, EventArgs e)
        {
            string numTicket;
            numTicket = txtIdTicketReportNota.Text;
            int ticket;
            Int32.TryParse(numTicket, out ticket);
            dataGridTicketReport.DataSource = proc.ObtenerNota(ticket);
        }

        private void btnReprintTicketRecibo_Click(object sender, EventArgs e)
        {
            if (dataGridTicketReport.Rows.Count == 0)
            {
                MessageBox.Show("Consulte un Recibo primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
;

        }

        private void btnReprintTicketNota_Click(object sender, EventArgs e)
        {
            if (dataGridTicketReport.Rows.Count == 0)
            {
                MessageBox.Show("Consulte una Nota de Credito Primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idNota = dataGridTicketReport.Rows[0].Cells["ID"].Value.ToString();
            string nombrePDF = "Nota de Credito" + idNota + ".pdf";
            FileStream fs = new FileStream(@nombrePDF, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //Definir la fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("AXXA", fuente) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Nota de Credito", fuente2) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("PRODUCTOS DE CONTROL AXXA, S.L", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Calle Janos. SantaClara", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("China, Nuevo León", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("67190", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("axxa@gmail.com", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("812 - 879 - 9540", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("No. Nota de Credito:", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(idNota, standarFont) { Alignment = Element.ALIGN_CENTER });
            string fechaNota = dataGridTicketReport.Rows[0].Cells["Fecha"].Value.ToString();
            string fechaNotaFinal = fechaNota.Substring(0, 9);
            doc.Add(new Paragraph("Fecha: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(fechaNotaFinal, standarFont) { Alignment = Element.ALIGN_CENTER });
            string ticketAsociado = dataGridTicketReport.Rows[0].Cells["Ticket Asociado"].Value.ToString();
            doc.Add(new Paragraph("Ticket relacionado: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(ticketAsociado, standarFont) { Alignment = Element.ALIGN_CENTER });
            //doc.Add(new Paragraph(ticketNota, standarFont) { Alignment = Element.ALIGN_CENTER });
            //AQUI PONER EL TICKETticketNota
            doc.Add(Chunk.NEWLINE);
            //Encabezado de columnas
            PdfPTable tblEjemplo = new PdfPTable(3);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell clNombre = new PdfPCell(new Phrase("Producto", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clCant = new PdfPCell(new Phrase("Cantidad", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCant.BorderWidth = 0;
            clCant.BorderWidthBottom = 0.75f;

            PdfPCell clSubtotal = new PdfPCell(new Phrase("Subtotal", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clSubtotal.BorderWidth = 0;
            clSubtotal.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clNombre);
            tblEjemplo.AddCell(clCant);
            tblEjemplo.AddCell(clSubtotal);

            float totalFloat = 0.0f;
            float totalFloatAux = 0.0f;
            //AQUI HACER UN CICLO PARA AGREGAR LOS PRODUCTOS
            foreach (DataGridViewRow fila in dataGridTicketReport.Rows)
            {
                string NombreProducto;
                string Subtotal;
                string UnidadesLlevar;

                NombreProducto = fila.Cells["Producto"].Value.ToString();
                Subtotal = fila.Cells["Subtotal"].Value.ToString();
                UnidadesLlevar = fila.Cells["Cantidad"].Value.ToString();

                totalFloat = float.Parse(Subtotal);
                totalFloatAux = totalFloat + totalFloatAux;

                clNombre = new PdfPCell(new Phrase(NombreProducto, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clNombre.BorderWidth = 0;

                clCant = new PdfPCell(new Phrase(UnidadesLlevar, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clCant.BorderWidth = 0;

                clSubtotal = new PdfPCell(new Phrase(Subtotal, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clSubtotal.BorderWidth = 0;

                tblEjemplo.AddCell(clNombre);
                tblEjemplo.AddCell(clCant);
                tblEjemplo.AddCell(clSubtotal);
            }



            doc.Add(tblEjemplo);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tblTotal = new PdfPTable(2);
            tblTotal.WidthPercentage = 100;
            string totalStr = totalFloatAux.ToString();
            PdfPCell clTotal = new PdfPCell(new Phrase("Total:", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotal.BorderWidth = 0;
            clTotal.BorderWidthBottom = 0;
            PdfPCell clTotalCant = new PdfPCell(new Phrase(totalStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotalCant.BorderWidth = 0;
            clTotalCant.BorderWidthBottom = 0;

            tblTotal.AddCell(clTotal);
            tblTotal.AddCell(clTotalCant);

            doc.Add(tblTotal);

            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("LAMENTAMOS LAS MOLESTIAS", standarFont) { Alignment = Element.ALIGN_CENTER });

            doc.Close();
            pw.Close();

            MessageBox.Show("Se imprimio la Nota de Credito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
