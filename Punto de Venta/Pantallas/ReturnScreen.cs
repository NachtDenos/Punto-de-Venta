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

namespace Punto_de_Venta
{
    public partial class ReturnScreen : Form
    {
        bool boton1 = false, boton2 = false;
        Procedures proc = new Procedures();
        int ticket;
        float CostProducto;
        int CodProducto;
        int Seregreso;
        DateTime laFecha;
        string motivo;
        string NombreProduc;
        int mermacion;
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
                Int32.TryParse(Regresa, out Seregreso);
                float.TryParse(subTotal, out CostProducto);
                Int32.TryParse(Merma, out mermacion);
                if (fila.Cells["Merma"].Value.ToString() == string.Empty)
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

            }
            
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
            onlyNumbers(sender, e);
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
                    string cod;
                    int codigo;
                    float subTotala;
                   
                    btnDeleteReturn.Enabled = true;
                    NombreProduc = dataGridReturn1.CurrentRow.Cells["Producto"].Value.ToString();
                    Subtotal = dataGridReturn1.CurrentRow.Cells["Subtotal"].Value.ToString();
                    cod = dataGridReturn1.CurrentRow.Cells["Codigo"].Value.ToString();

                    Int32.TryParse(cod, out codigo);
                    float.TryParse(Subtotal, out subTotala);
                    CodProducto = codigo;
                    CostProducto = subTotala;
                    buttonEnableEdit(e);
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
            string fecha;
            string devuelve;
            
            motivo = txtReturnReason.Text;
            fecha = DateTime.UtcNow.ToShortDateString();
            devuelve = txtQuantityReturn.Text;
            int dev;
            Int32.TryParse(devuelve, out dev);
            DateTime Fecha;
            DateTime.TryParse(fecha, out Fecha);
            laFecha = Fecha;
            if (boton1 == true)
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
            else if (boton2 == true)
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
                //var Tilin2LaSecuelta = proc.InsertarDevTemporalMerma();
                //foreach (DataGridViewRow FILA in dataGridReturn1.Rows)
                //{
                //    string recibo;
                //    float subtotal;
                //    string subtotaltxt;
                //    DateTime Fechesota;
                //    string precioUni;
                //    float precioU;
                //    int CANTLLEVAR;
                //    string descuento;
                //    float desc;
                //    precioUni = FILA.Cells["Recibo"].Value.ToString();
                //    CANTLLEVAR = (int)FILA.Cells["Fecha"].Value;
                //    subtotaltxt = FILA.Cells["Subtotal"].Value.ToString();
                //}
                //proc.GenerarNotaCredito(ticket, CostProducto, Fecha);
                //proc.GenerarDevolucion(CodProducto, dev, CostProducto, motivo);
                //proc.ActualizarProdSinMerma(dev, CodProducto);
            }
        }

        private void filterBtnticket_Click(object sender, EventArgs e)
        {
            string numTicket;
            
            numTicket = txtIdReturn.Text;
            Int32.TryParse(numTicket, out ticket);
            var Tilin2LaSecuela = proc.ObtenerTicket(ticket);
            dataGridReturn1.DataSource = proc.ObtenerTicket(ticket);
            btnAddReturn.Enabled = true;
        }

        private void ReturnScreen_Load(object sender, EventArgs e)
        {
            dataGridReturn2.DataSource = proc.TablaDevTemporal();
        }

        private void rbNoReturn_Click(object sender, EventArgs e)
        {
            boton2 = true;
            boton1 = false;
        }
    }
}
