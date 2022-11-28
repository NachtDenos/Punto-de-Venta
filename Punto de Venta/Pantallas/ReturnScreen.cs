using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Punto_de_Venta
{
    public partial class ReturnScreen : Form
    {
        bool boton1 = false, boton2 = false;
        Procedures proc = new Procedures();
        int ticket;
        string ticketNota;
        float CostProducto;
        int CodProducto;
        int Aeliminar;
        float Seregreso;
        bool Bandera;
        string cod;
        bool bandera; 
        DateTime laFecha;
        string motivo;
        string NombreProduc;
        int mermacion;
        string comparacionTabla2;
        string UnidadesComparacionValid;
        bool itExists;
        string mermaValidacion;
        public ReturnScreen()
        {
            InitializeComponent();
            btnAddReturn.Enabled = false;
            btnDeleteReturn.Enabled = false;
            //dataGridReturn1.Rows[0].Cells[0].Value = "Salmón";
            //dataGridReturn1.Rows[0].Cells[1].Value = "2";
            //dataGridReturn1.Rows[0].Cells[2].Value = "120.00";
            //dataGridReturn2.Rows[0].Cells[0].Value = "Jamón";
            //dataGridReturn2.Rows[0].Cells[1].Value = "3";
            //dataGridReturn2.Rows[0].Cells[2].Value = "90.00";
        }

        private void btnOkReturn_Click(object sender, EventArgs e)
        {
            ticketNota = ticket.ToString();
            proc.GenerarNotaCredito(ticket, CostProducto, laFecha);
            foreach (DataGridViewRow fila in dataGridReturn2.Rows)
            {

                string CajeroNombre;
                int CajerId = 0;
                string NumRecibo;
                string codigo;
                string Regresa;
                string PrecioU;
                string subTotal;
                string Merma;
                float disNum;
                string NombreProduc;
                NombreProduc = fila.Cells["Producto"].Value.ToString();
                NumRecibo = fila.Cells["Recibo"].Value.ToString();
                codigo = fila.Cells["Codigo"].Value.ToString();
                Regresa = fila.Cells["Devuelve"].Value.ToString();
                subTotal = fila.Cells["Subtotal"].Value.ToString();
                Merma = fila.Cells["Merma"].Value.ToString();

                Int32.TryParse(NumRecibo, out ticket);
                Int32.TryParse(codigo, out CodProducto);
                float.TryParse(Regresa, out Seregreso);
                float.TryParse(subTotal, out CostProducto);
                Int32.TryParse(Merma, out mermacion);
                if (fila.Cells["Merma"].Value.ToString() == "0")
                {
                    fila.Cells["Merma"].Value = "0";
                    proc.GenerarDevolucion(CodProducto, Seregreso, CostProducto, motivo, NombreProduc);
                    proc.ActualizarProdSinMerma(Seregreso, CodProducto);
                    //fila.Cells["Subtotal"].Value = subtotal;
                }
                else
                {
                    proc.GenerarDevolucion(CodProducto, Seregreso, CostProducto, motivo, NombreProduc);
                    proc.ActualizarProdMerma(Seregreso, CodProducto);
                }
                //if (fila.Cells["Merma"].Value.ToString() == "0")
                //{
                //    fila.Cells["Merma"].Value = "0";
                //    proc.GenerarDevolucion(CodProducto, Seregreso, CostProducto, motivo, NombreProduc);
                //    proc.ActualizarProdSinMerma(Seregreso, CodProducto);
                //}




            }

            if (MessageBox.Show("¿Quiere imprimir la nota de credito?", "Nota De Credito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imprimirNotaCredito();
            }
            MessageBox.Show("Devolucion realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            proc.limpiarGridDevolucion();
            dataGridReturn2.DataSource = proc.TablaDevTemporal();
            //CreditNoteScreen TheOtherForm = new CreditNoteScreen();
            //TheOtherForm.ShowDialog();
        }

        private void txtIdReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        public bool onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return false;
            }
            return true;
        }

        private void txtQuantityReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCantidadBorrar.Text);
        }

        private void dataGridReturn1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridReturn1.AllowUserToOrderColumns = false;
                if (dataGridReturn1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridReturn1.CurrentRow.Selected = true;
                    string Subtotal;
                   
                    int codigo;
                    string took;
                    float subTotala;
                   
                    btnDeleteReturn.Enabled = true;
                    NombreProduc = dataGridReturn1.CurrentRow.Cells["Producto"].Value.ToString();
                    Subtotal = dataGridReturn1.CurrentRow.Cells["Subtotal"].Value.ToString();
                    cod = dataGridReturn1.CurrentRow.Cells["Codigo"].Value.ToString();
                    took = dataGridReturn1.CurrentRow.Cells["Se llevo"].Value.ToString();
                    UnidadesComparacionValid = took;
                    Int32.TryParse(cod, out codigo);
                    float.TryParse(Subtotal, out subTotala);
                    CodProducto = codigo;
                    CostProducto = subTotala;
                    buttonEnableEdit(e);
                    btnAddReturn.Enabled = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {

            }
        }

        private void dataGridReturn2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridReturn2.AllowUserToOrderColumns = false;
                if (dataGridReturn2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string cod;
                    string regresa;
                    regresa = dataGridReturn2.CurrentRow.Cells["Devuelve"].Value.ToString();
                    
                    cod = dataGridReturn2.CurrentRow.Cells["Codigo"].Value.ToString();
                    mermaValidacion = dataGridReturn2.CurrentRow.Cells["Merma"].Value.ToString();
                    Int32.TryParse(cod, out CodProducto);
                    Int32.TryParse(regresa, out Aeliminar);
                    btnDeleteReturn.Enabled = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {

            }
        }

        private void buttonEnableEdit(DataGridViewCellEventArgs e)
        {
            if (dataGridReturn1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && boton1 == true)
                btnAddReturn.Enabled = true;
            else if(dataGridReturn1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && boton2 == true)
                btnAddReturn.Enabled = true;
        }

        private void rbYesReturn_Click(object sender, EventArgs e)
        {
            boton1 = true;
            boton2 = false;
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            float validacion;
            float.TryParse(UnidadesComparacionValid, out validacion);
            string REGRESA;
            float elim;
            REGRESA = txtQuantityReturn.Text;
            float.TryParse(REGRESA, out elim);

            if (elim > validacion)
            {
                MessageBox.Show("No se puede regresar mas productos de los que se compraron", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string fecha;
            string devuelve;
            btnOkReturn.Enabled = false;
            motivo = txtReturnReason.Text;
            fecha = DateTime.UtcNow.ToShortDateString();
            devuelve = txtQuantityReturn.Text;
            if (txtQuantityReturn.Text == "" && txtReturnReason.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float dev;
            float.TryParse(devuelve, out dev);
            DateTime Fecha;
            DateTime.TryParse(fecha, out Fecha);
            laFecha = Fecha;
            
            foreach (DataGridViewRow FILITA in dataGridReturn2.Rows)
            {
                string codcod;
                string cantQUEQUIERENDEVOLVER;
                cantQUEQUIERENDEVOLVER = txtQuantityReturn.Text;
                codcod = FILITA.Cells["Codigo"].Value.ToString();
                string cantDevolver;
                cantDevolver = FILITA.Cells["Devuelve"].Value.ToString();
                comparacionTabla2 = FILITA.Cells["Devuelve"].Value.ToString();
                if (cod == codcod)
                {
                    float num1;
                    float num2;
                    float numFinalComparacionFInalfinal;
                    if (cantDevolver == UnidadesComparacionValid)
                    {
                        MessageBox.Show("CTM VILLA ERES UN NYE");
                        return;
                    }
                    float.TryParse(cantDevolver, out num1);
                    float.TryParse(cantQUEQUIERENDEVOLVER, out num2);
                    float.TryParse(UnidadesComparacionValid, out numFinalComparacionFInalfinal);
                    if (num2 + num1 > numFinalComparacionFInalfinal)
                    {
                        cantQUEQUIERENDEVOLVER = "";
                        MessageBox.Show("REGRESATE PINCHE ANIMAL ESTUPIDO DIOTA PQ PUTAS QUIERES LLEVARTE MAS DE LO QUE PUEDES PGAR A VERDAD PINCHE ANIMAL INCULTO");
                        return;
                    }
                }
            }
            if (dataGridReturn1.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridReturn2.Rows)
                {
                    if (NombreProduc == fila.Cells["Producto"].Value.ToString())
                    {
                        //PrecioNUEVO = fila.Cells["Precio"].Value.ToString();
                        itExists = true;
                        break;
                    }
                    else
                        itExists = false;
                    // NombreProducto = fila.Cells["Producto"].Value.ToString();
                }
            }
            string cantextBox;
            float cantProc;
            cantextBox = txtQuantityReturn.Text;
            float.TryParse(cantextBox, out cantProc);
            if (boton1 == true && itExists == true)
            {
                var existeyMerma = proc.ActualizarDevolucionTemporalMerma(CodProducto, cantProc);
                if (existeyMerma == true)
                {
                    MessageBox.Show("Actualizacion exitosa");
                    dataGridReturn2.DataSource = proc.TablaDevTemporal();
                }
            }
            if (boton2 == true && itExists == true)
            {
                var existeyMerma = proc.ActualizarDevolucionTemporalSinMerma(CodProducto, cantProc);
                if (existeyMerma == true)
                {
                    MessageBox.Show("Actualizacion exitosa");
                    dataGridReturn2.DataSource = proc.TablaDevTemporal();
                }
            }


            if (boton1 == true && itExists == false)
            {
                var Tilin2LaSecuelta = proc.InsertarDevTemporalMerma(CodProducto, ticket, Fecha, dev, CostProducto, dev, NombreProduc);
                if (Tilin2LaSecuelta)
                {
                    dataGridReturn2.DataSource = proc.TablaDevTemporal();
                }
                // dataGridReturn2.Columns["Nombre"].ValueType.ToString() = NombreProducto;
                //proc.GenerarNotaCredito(ticket, CostProducto, Fecha);
                //proc.GenerarDevolucion(CodProducto, dev, CostProducto, motivo);
            }
            else if (boton2 == true && itExists == false)
            {
                var Tilin2LaSecuelta2 = proc.InsertarDevTemporalSinMerma(CodProducto, ticket, Fecha, dev, CostProducto, NombreProduc);
                if (Tilin2LaSecuelta2)
                {
                    dataGridReturn2.DataSource = proc.TablaDevTemporal();
                    if (dataGridReturn2.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow fila in dataGridReturn2.Rows)
                        {
                            if (fila.Cells["Merma"].Value.ToString() == string.Empty)
                            {
                                fila.Cells["Merma"].Value = "0";

                            }
                        }
                    }
                }
               
            }
            btnOkReturn.Enabled = true;
            btnAddReturn.Enabled = false;
            dataGridReturn1.ClearSelection();
        }

        private void filterBtnticket_Click(object sender, EventArgs e)
        {
            string numTicket;
            
            numTicket = txtIdReturn.Text;
            Int32.TryParse(numTicket, out ticket);
            var Tilin2LaSecuela = proc.ObtenerTicket(ticket);
            dataGridReturn1.DataSource = proc.ObtenerTicket(ticket);
        }

        private void ReturnScreen_Load(object sender, EventArgs e)
        {
            dataGridReturn2.DataSource = proc.limpiarGridDevolucion();
            dataGridReturn2.DataSource = proc.TablaDevTemporal();
        }

        private void rbNoReturn_Click(object sender, EventArgs e)
        {
            boton2 = true;
            boton1 = false;
        }

        private void btnDeleteReturn_Click(object sender, EventArgs e)
        {
            float validacion;
            float.TryParse(UnidadesComparacionValid, out validacion);
            string elimina;
            float elim;
            elimina = txtCantidadBorrar.Text;
            float.TryParse(elimina, out elim);
            
            if (elim > validacion)
            {
                MessageBox.Show("No se puede regresar mas productos de los que se compraron", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float parseoMerma;
            float.TryParse(mermaValidacion,out parseoMerma);
            if (parseoMerma > 0)
            {
                proc.EliminarProductoDevolucion(CodProducto, elim);
                proc.EliminarProductoDevolucionMerma(CodProducto, elim);

                dataGridReturn2.DataSource = proc.TablaDevTemporal();
            }
            else
            {
                proc.EliminarProductoDevolucion(CodProducto, elim);
                dataGridReturn2.DataSource = proc.TablaDevTemporal();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imprimirNotaCredito()
        {
            FileStream fs = new FileStream(@"NotaDeCredito.pdf", FileMode.Create);
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
            //AQUI PONER EL NUMERO DE TICKET
            string fechaNota = laFecha.ToString();
            doc.Add(new Paragraph("Fecha: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(fechaNota, standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("Ticket relacionado: ", standarFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(ticketNota, standarFont) { Alignment = Element.ALIGN_CENTER });
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
            foreach (DataGridViewRow fila in dataGridReturn2.Rows)
            {
                string NombreProducto;
                string Subtotal;
                string UnidadesLlevar;

                NombreProducto = fila.Cells["Producto"].Value.ToString();
                Subtotal = fila.Cells["Subtotal"].Value.ToString();
                UnidadesLlevar = fila.Cells["Devuelve"].Value.ToString();
                
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

        private void onePoint(KeyPressEventArgs e, String cadena)
        {
            int cont = 0;
            String caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if (caracter == ".")
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                bandera = true;
                if (e.KeyChar.ToString().Equals(".") && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }


    }
}
