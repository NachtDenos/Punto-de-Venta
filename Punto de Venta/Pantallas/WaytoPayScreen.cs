﻿using System;
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
    public partial class WaytoPayScreen : Form
    {
        Procedures proc = new Procedures();
        string numeroCaja;
        bool bandera;
        float montodePago;
        int metPago;
        float total;
        float totalaux;
        bool Credito = false;
        string Cred;
        bool Debito = false;
        string Deb;
        bool Efectivo = false;
        string Efec;
        bool Cheques = false;
        string Cheq;
        bool Vales = false;
        string val;
        bool otro = false;
        string otr;
        string Fecha;
        string FreakingCash;
        int CantidadMetodosActivos;
        float monto1;
        float monto2;
        int MetodoPago1de2;
        int MetodoPago2de2;
        DateTime fechaa;
        //public WaytoPayScreen()
        //{
        //    InitializeComponent();
        //    txtCreditCardPay.Enabled = false;
        //    txtCashPay.Enabled = false;
        //    txtVoucherPay.Enabled = false;
        //    txtDebitCardPay.Enabled = false;
        //    txtCheckPay.Enabled = false;
        //    txtOtherPay.Enabled = false;
        //    //dataGridWayToPay.Rows[0].Cells[0].Value = "B312";
        //    //dataGridWayToPay.Rows[0].Cells[1].Value = "Jamón";
        //    //dataGridWayToPay.Rows[0].Cells[2].Value = "30.00";
        //    //dataGridWayToPay.Rows[0].Cells[3].Value = "2";
        //    //dataGridWayToPay.Rows[0].Cells[4].Value = "0.00";
        //    //dataGridWayToPay.Rows[0].Cells[5].Value = "60.00";

        //}
        public WaytoPayScreen(string Total, string lblPapito, string fecha, string NumCaja)
        {
            InitializeComponent();
            txtCreditCardPay.Enabled = false;
            txtCashPay.Enabled = false;
            txtVoucherPay.Enabled = false;
            txtDebitCardPay.Enabled = false;
            
            totalblwaytopay.Text = lblPapito;
            txtCheckPay.Enabled = false;
            txtOtherPay.Enabled = false;
            Fecha = fecha;
            FreakingCash = NumCaja;
            //dataGridWayToPay.Rows[0].Cells[0].Value = "B312";
            //dataGridWayToPay.Rows[0].Cells[1].Value = "Jamón";
            //dataGridWayToPay.Rows[0].Cells[2].Value = "30.00";
            //dataGridWayToPay.Rows[0].Cells[3].Value = "2";
            //dataGridWayToPay.Rows[0].Cells[4].Value = "0.00";
            //dataGridWayToPay.Rows[0].Cells[5].Value = "60.00";

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
        #region NUMEROS
        private void txtCreditCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCreditCardPay.Text);
           // onlyNumbers(sender, e);
        }
        private void txtCashPay_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  onlyNumbers(sender, e);
            onePoint(e, txtCashPay.Text);
        }
        private void txtVoucherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtVoucherPay.Text);
           // onlyNumbers(sender, e);
        }
        private void txtDebitCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //onlyNumbers(sender, e);
            onePoint(e, txtDebitCardPay.Text);
        }
        private void txtCheckPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCheckPay.Text);
            //onlyNumbers(sender, e);
        }
        private void txtOtherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtOtherPay.Text);
           // onlyNumbers(sender, e);
        }
        #endregion NUMEROS

        #region MetodosDePago
        private void rbCreditCardPay_Click(object sender, EventArgs e)
        {
            if (txtCreditCardPay.Enabled == false)
            {
                txtCreditCardPay.Enabled = true;
                Credito = true;
            }
            else if (txtCreditCardPay.Enabled == true)
                txtCreditCardPay.Enabled = false;
        }
        private void rbCashPay_Click(object sender, EventArgs e)
        {
            if (txtCashPay.Enabled == false)
            {
                txtCashPay.Enabled = true;
                Efectivo = true;
            }
            else if (txtCashPay.Enabled == true)
                txtCashPay.Enabled = false;
        }
        private void rbVouchersPay_Click(object sender, EventArgs e)
        {
            if (txtVoucherPay.Enabled == false)
            {
                txtVoucherPay.Enabled = true;
                Vales = true;
            }
            else if (txtVoucherPay.Enabled == true)
                txtVoucherPay.Enabled = false;
        }
        private void rbDebitCardPay_Click(object sender, EventArgs e)
        {
            if (txtDebitCardPay.Enabled == false)
            {
                txtDebitCardPay.Enabled = true;
                Debito = true;
            }
            else if (txtDebitCardPay.Enabled == true)
                txtDebitCardPay.Enabled = false;
        }
        private void rbCheckPay_Click(object sender, EventArgs e)
        {
            if (txtCheckPay.Enabled == false)
            {
                txtCheckPay.Enabled = true;
                Cheques = true;
            }
            else if (txtCheckPay.Enabled == true)
                txtCheckPay.Enabled = false;
        }
        private void rbOtherPay_Click(object sender, EventArgs e)
        {
            if (txtOtherPay.Enabled == false)
            {
                txtOtherPay.Enabled = true;
                otro = true;
            }
            else if (txtOtherPay.Enabled == true)
                txtOtherPay.Enabled = false;
        }
        #endregion MetodosDePago

        #region FuncionesForms
        private void WaytoPayScreen_Load(object sender, EventArgs e)
        {
            dataGridWayToPay.DataSource = proc.ListarCarritoCompraPagar();
            dataGridWayToPay.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dataGridWayToPay.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            if (dataGridWayToPay.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridWayToPay.Rows)
                {
                    fila.Cells["Precio"].Value.ToString();
                  
                    string totalstring;
                    float subtotal;
                    string precioUni;
                    float precioU;
                    int CANTLLEVAR;
                    string descuento;
                    float desc;
                      precioUni = fila.Cells["Precio"].Value.ToString();
                      CANTLLEVAR = (int)fila.Cells["A llevar"].Value;
                      
                    if (fila.Cells["Descuento"].Value.ToString() == string.Empty)
                    {
                        fila.Cells["Descuento"].Value = "0";
                        float.TryParse(precioUni, out precioU);
                        subtotal = precioU * CANTLLEVAR;
                        fila.Cells["Subtotal"].Value = subtotal;
                    }
                    else
                    {
                        
                        descuento = fila.Cells["Descuento"].Value.ToString();
                        float.TryParse(descuento, out desc);
                        desc = desc / 100.00f;
                        float.TryParse(precioUni, out precioU);
                        precioU = precioU * desc;
                        subtotal = precioU * CANTLLEVAR;
                        fila.Cells["Subtotal"].Value = subtotal;
                    }
                    total = subtotal;
                    totalaux = total + totalaux;
                    total = totalaux;
                    
                }
                finalPaylbl.Text = "$ ";
                finalPaylbl.Text += total.ToString("N2");
                //dataGridWayToPay.Rows.Insert(0,"TOTALLLL");
            }     
        }

        private void btnPayPay_Click(object sender, EventArgs e)
        {
            if (Debito == true)
            {
                float num;
                Deb = txtDebitCardPay.Text;
                float.TryParse(Deb, out num);
                if (num - total == 0)
                {
                    MessageBox.Show("Correcto procede a pagar");
                    montodePago = num;
                }
                metPago = 1;
                CantidadMetodosActivos = 1;
            }
            else if (Credito == true)
            {
                Cred = txtCreditCardPay.Text;
                float num;
                float.TryParse(Cred, out num);
                if (num - total == 0)
                {
                    MessageBox.Show("Correcto procede a pagar");
                }
            }
            else if(Efectivo == true)
            {
                Efec = txtCashPay.Text;
                float num;
                float.TryParse(Efec, out num);
                if (num - total == 0)
                {
                    MessageBox.Show("Correcto procede a pagar");
                }
            }
            else if (Cheques == true)
            {
                Cheq = txtCheckPay.Text;
               
                float num;
                float.TryParse(Cheq, out num);
                if (num - total == 0)
                {
                    MessageBox.Show("Correcto procede a pagar");
                }
            }
            else if (Vales == true)
            {
                val = txtVoucherPay.Text;

                float num;
                float.TryParse(val, out num);
                if (num - total == 0)
                {
                    MessageBox.Show("Correcto procede a pagar");
                }
            }
            else if (otro == true)
            {
                otr = txtOtherPay.Text;
                float num;
                float.TryParse(otr, out num);
                if (num - total == 0)
                {
                    MessageBox.Show("Correcto procede a pagar");
                }
            }
            else if(Debito == true && Credito == true)
            {
                Deb = txtDebitCardPay.Text;
                Cred = txtCreditCardPay.Text;
                float num;
                float num2;
                float.TryParse(Deb, out num);
                float.TryParse(Cred, out num2);
                monto1 = num;
                monto2 = num;
                MetodoPago1de2 = 0;
                MetodoPago2de2 = 1;  
                CantidadMetodosActivos = 2;
            }
            else if (Efectivo == true && Credito == true)
            {

            }
            else if (Vales == true && Cheques == true)
            {

            }
            else if (otro == true && Efectivo == true)
            {

            }
            else if (otro == true && Efectivo == true && Debito == true && Credito && true && Vales == true && Cheques == true)
            {

            }
            else if (otro == true &&  Debito == true && Credito && true && Vales == true && Cheques == true)
            {

            }
            else if (otro == true && Credito == true && Vales == true && Cheques == true)
            {

            }
            else if (otro == true && Credito == true && Vales == true && Cheques == true)
            {

            }
            fechaa = DateTime.Parse(Fecha);
            string NombreProd;
            string Cajero = "Kevin";
            string CajaNumeroGenVenta;
            int CajaNumeroGenVentaid;
            CajaNumeroGenVenta = FreakingCash;
            Int32.TryParse(CajaNumeroGenVenta,out  CajaNumeroGenVentaid);
            float Total;
            float.TryParse(totalblwaytopay.Text, out Total);
            //ahi vengo voy  A CENAR Y VERQUE PEDO CON COMO HACERLE, PQ SIENTO QUE LO OCUPAMOS Y NO
             proc.GenerarVenta(fechaa, CajaNumeroGenVentaid, 102.0f, Total, Cajero, 0);
            foreach (DataGridViewRow fila in dataGridWayToPay.Rows)
            {
                string CajeroNombre;
                int CajerId = 0;
                string NombreProducto;
                string Subtotal;
                string UnidadesLlevar;
                string PrecioU;
                string Discount;
                float disNum;


                NombreProducto = fila.Cells["Producto"].Value.ToString();
                Subtotal = fila.Cells["Subtotal"].Value.ToString();
                UnidadesLlevar = fila.Cells["A llevar"].Value.ToString();
                PrecioU = fila.Cells["Precio"].Value.ToString();

                float subFlot;
                float.TryParse(Subtotal, out subFlot);
                int MontoFinal;
                string MontoF = finalPaylbl.Text;
                Int32.TryParse(MontoF, out MontoFinal);

                int NumCaja;
                string CAJANUM;
                CAJANUM = FreakingCash;
                Int32.TryParse(CAJANUM, out NumCaja);
                string Persona = "Kevin";
                float PrecioUniDis;
                float Costo;
                string costoStingDtg;
                costoStingDtg = fila.Cells["Costo"].Value.ToString();
                float PrecioUni;
                
                //float.TryParse(PrecioU,out PrecioUni);
                float Utilidad;
                float UtilidadAux;
                float PrecioUniAux;
                int UnidadesVendidas; Int32.TryParse(UnidadesLlevar, out UnidadesVendidas);
                if (fila.Cells["Descuento"].Value.ToString() == "0")
                {
                    fila.Cells["Descuento"].Value = "0";
                    float.TryParse(PrecioU, out PrecioUni);
                    subFlot = PrecioUni * UnidadesVendidas;
                    float.TryParse(costoStingDtg,out Costo);
                    UtilidadAux = PrecioUni - Costo;
                    Utilidad = UtilidadAux;
                    //fila.Cells["Subtotal"].Value = subtotal;
                }
                else
                {

                    Discount = fila.Cells["Descuento"].Value.ToString();
                    float.TryParse(Discount, out disNum);
                    disNum = disNum / 100.00f;
                    float.TryParse(PrecioU, out PrecioUni);
                    float.TryParse(PrecioU, out PrecioUniAux);
                    float.TryParse(costoStingDtg, out Costo);
                    
                    PrecioUniDis = PrecioUni * disNum;
                    PrecioUni = PrecioUniAux;
                    subFlot = PrecioUni * UnidadesVendidas;
                    UtilidadAux = PrecioUni - Costo - PrecioUniDis;
                    Utilidad = UtilidadAux;
                   // fila.Cells["Subtotal"].Value = subtotal;
                }
                proc.GenerarVentaDetalle(0,NombreProducto,UnidadesVendidas, subFlot, PrecioUni, Utilidad);
                
                //proc.RealizarVentas(total, NombreProducto, fechaa, subFlot, montodePago
                //    , MontoFinal, metPago, 0, NumCaja, Persona, UnidadesVendidas, PrecioUni, 105.5f);
            }
            for (int i = 0; i < CantidadMetodosActivos; i++)
            {
                proc.GenerarTicketDB(0, monto1, 0);
                //proc.GenerarTicketDB(0, monto2, 1);
            }
            this.Close();
            ticketScreen TheOtherForm = new ticketScreen();
            TheOtherForm.ShowDialog();
        }

        #endregion FuncionesForms
    }
}
