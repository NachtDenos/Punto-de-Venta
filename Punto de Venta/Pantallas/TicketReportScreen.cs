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

            string idTickerStr = dataGridTicketReport.Rows[0].Cells["Num"].Value.ToString();
            string nameTicket = "TicketR " + idTickerStr + ".pdf";
            int IDVENTA = Int32.Parse(idTickerStr);
            FileStream fs = new FileStream(@nameTicket, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            //Definir la fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("AXXA", fuente) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Ticket", fuente2) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("PRODUCTOS DE CONTROL AXXA, S.L", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Calle Janos. SantaClara", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("China, Nuevo León", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("67190", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("axxa@gmail.com", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("812 - 879 - 9540", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("No. TICKET:", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(idTickerStr, standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Fecha: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            string fechaTicket = dataGridTicketReport.Rows[0].Cells["Fecha"].Value.ToString();
            string fechaTicketFinal = fechaTicket.Substring(0, 9);
            doc.Add(new Paragraph(fechaTicketFinal, standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            //Encabezado de columnas
            PdfPTable tblEjemplo = new PdfPTable(5);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell clNombre = new PdfPCell(new Phrase("Producto", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clCant = new PdfPCell(new Phrase("Cantidad", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCant.BorderWidth = 0;
            clCant.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio U.", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            PdfPCell clDesc = new PdfPCell(new Phrase("Descuento", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clDesc.BorderWidth = 0;
            clDesc.BorderWidthBottom = 0.75f;

            PdfPCell clSubtotal = new PdfPCell(new Phrase("Subtotal", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clSubtotal.BorderWidth = 0;
            clSubtotal.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clNombre);
            tblEjemplo.AddCell(clCant);
            tblEjemplo.AddCell(clPrecio);
            tblEjemplo.AddCell(clDesc);
            tblEjemplo.AddCell(clSubtotal);
            float totalFloat = 0.0f;
            float totalFloatAux = 0.0f;
            foreach (DataGridViewRow fila in dataGridTicketReport.Rows)
            {
                string NombreProducto;
                string Subtotal;
                string UnidadesLlevar;
                string PrecioU;
                string Discount;

                NombreProducto = fila.Cells["Producto"].Value.ToString();
                Subtotal = fila.Cells["Subtotal"].Value.ToString();
                UnidadesLlevar = fila.Cells["Se llevo"].Value.ToString();
                PrecioU = fila.Cells["Precio Unitario"].Value.ToString();
                Discount = fila.Cells["Descuento"].Value.ToString();

                totalFloat = float.Parse(Subtotal);
                totalFloatAux = totalFloat + totalFloatAux;

                clNombre = new PdfPCell(new Phrase(NombreProducto, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clNombre.BorderWidth = 0;

                clCant = new PdfPCell(new Phrase(UnidadesLlevar, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clCant.BorderWidth = 0;

                clPrecio = new PdfPCell(new Phrase(PrecioU, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clPrecio.BorderWidth = 0;

                clDesc = new PdfPCell(new Phrase(Discount, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clDesc.BorderWidth = 0;

                clSubtotal = new PdfPCell(new Phrase(Subtotal, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
                clSubtotal.BorderWidth = 0;

                tblEjemplo.AddCell(clNombre);
                tblEjemplo.AddCell(clCant);
                tblEjemplo.AddCell(clPrecio);
                tblEjemplo.AddCell(clDesc);
                tblEjemplo.AddCell(clSubtotal);
            }

            doc.Add(tblEjemplo);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tblTotal = new PdfPTable(2);
            tblTotal.WidthPercentage = 100;

            PdfPCell clTotal = new PdfPCell(new Phrase("Total:", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotal.BorderWidth = 0;
            clTotal.BorderWidthBottom = 0;
            string totalString = totalFloatAux.ToString();
            PdfPCell clTotalCant = new PdfPCell(new Phrase(totalString, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clTotalCant.BorderWidth = 0;
            clTotalCant.BorderWidthBottom = 0;

            tblTotal.AddCell(clTotal);
            tblTotal.AddCell(clTotalCant);

            doc.Add(tblTotal);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tblMetodoPago = new PdfPTable(2);
            tblMetodoPago.WidthPercentage = 100;

            PdfPCell clNombreMP = new PdfPCell(new Phrase("FORMAS DE PAGO", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            clNombreMP.BorderWidthBottom = 0;

            PdfPCell clCantMP = new PdfPCell(new Phrase("Cantidad Pagada", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            clCantMP.BorderWidthBottom = 0;

            int creditoFl, debitoFl, efectivoFl;
            int chequeFl, valeFl, otroFl;

            creditoFl = proc.obtenerMetodPago(IDVENTA, 0);
            debitoFl = proc.obtenerMetodPago(IDVENTA, 1);
            efectivoFl = proc.obtenerMetodPago(IDVENTA, 2);
            chequeFl = proc.obtenerMetodPago(IDVENTA, 3);
            valeFl = proc.obtenerMetodPago(IDVENTA, 4);
            otroFl = proc.obtenerMetodPago(IDVENTA, 5);

            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);
            clNombreMP = new PdfPCell(new Phrase("Tarjeta de Credito", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string creditoStr = creditoFl.ToString();
            clCantMP = new PdfPCell(new Phrase(creditoStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Tarjeta Debito", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string debitoStr = debitoFl.ToString();
            clCantMP = new PdfPCell(new Phrase(debitoStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Efectivo", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string efectivoStr = efectivoFl.ToString();
            clCantMP = new PdfPCell(new Phrase(efectivoStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Cheque", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string chequeStr = chequeFl.ToString();
            clCantMP = new PdfPCell(new Phrase(chequeStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Vales", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string valeStr = valeFl.ToString();
            clCantMP = new PdfPCell(new Phrase(valeStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            clNombreMP = new PdfPCell(new Phrase("Otro", standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clNombreMP.BorderWidth = 0;
            string otroStr = otroFl.ToString();
            clCantMP = new PdfPCell(new Phrase(otroStr, standarFont)) { HorizontalAlignment = Element.ALIGN_CENTER };
            clCantMP.BorderWidth = 0;
            tblMetodoPago.AddCell(clNombreMP);
            tblMetodoPago.AddCell(clCantMP);

            doc.Add(tblMetodoPago);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Caja:", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("1", standarFont) { Alignment = Element.ALIGN_CENTER });
            //CHECAR LO DE LA CAJA
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("GRACIAS POR TU COMPRA", standarFont) { Alignment = Element.ALIGN_CENTER });

            doc.Close();
            pw.Close();

            MessageBox.Show("Se imprimio el Ticket", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
