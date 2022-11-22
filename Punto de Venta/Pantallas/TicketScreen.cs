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
    public partial class ticketScreen : Form
    {
        public ticketScreen()
        {
            InitializeComponent();
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Prueba.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //Definir la fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("Hola soy un Ticket"));
            doc.Add(Chunk.NEWLINE);

            //Encabezado de columnas
            PdfPTable tblEjemplo = new PdfPTable(3);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell clNombre = new PdfPCell(new Phrase("Producto", standarFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clDesc = new PdfPCell(new Phrase("Descripcion", standarFont));
            clDesc.BorderWidth = 0;
            clDesc.BorderWidthBottom = 0.75f;

            PdfPCell clSubtotal = new PdfPCell(new Phrase("Subtotal", standarFont));
            clSubtotal.BorderWidth = 0;
            clSubtotal.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(clNombre);
            tblEjemplo.AddCell(clDesc);
            tblEjemplo.AddCell(clSubtotal);

            //AQUI HACER UN CICLO PARA AGREGAR LOS PRODUCTOS

            doc.Add(tblEjemplo);
            doc.Close();
            pw.Close();

            MessageBox.Show("Se imprimio el Ticket", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
