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
    public partial class WaytoPayScreen : Form
    {
        Procedures proc = new Procedures();
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
        public WaytoPayScreen(string Total, string lblPapito)
        {
            InitializeComponent();
            txtCreditCardPay.Enabled = false;
            txtCashPay.Enabled = false;
            txtVoucherPay.Enabled = false;
            txtDebitCardPay.Enabled = false;
            
            totalblwaytopay.Text = lblPapito;
            txtCheckPay.Enabled = false;
            txtOtherPay.Enabled = false;
            //dataGridWayToPay.Rows[0].Cells[0].Value = "B312";
            //dataGridWayToPay.Rows[0].Cells[1].Value = "Jamón";
            //dataGridWayToPay.Rows[0].Cells[2].Value = "30.00";
            //dataGridWayToPay.Rows[0].Cells[3].Value = "2";
            //dataGridWayToPay.Rows[0].Cells[4].Value = "0.00";
            //dataGridWayToPay.Rows[0].Cells[5].Value = "60.00";

        }
        private void btnPayPay_Click(object sender, EventArgs e)
        {

            this.Close();
            ticketScreen TheOtherForm = new ticketScreen();
            TheOtherForm.ShowDialog();   
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
            onlyNumbers(sender, e);
        }
        private void txtCashPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }
        private void txtVoucherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }
        private void txtDebitCardPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }
        private void txtCheckPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }
        private void txtOtherPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }
        #endregion NUMEROS

        #region MetodosDePago
        private void rbCreditCardPay_Click(object sender, EventArgs e)
        {
            if (txtCreditCardPay.Enabled == false)
                txtCreditCardPay.Enabled = true;
            else if(txtCreditCardPay.Enabled == true)
                txtCreditCardPay.Enabled = false;
        }
        private void rbCashPay_Click(object sender, EventArgs e)
        {
            if (txtCashPay.Enabled == false)
                txtCashPay.Enabled = true;
            else if (txtCashPay.Enabled == true)
                txtCashPay.Enabled = false;
        }
        private void rbVouchersPay_Click(object sender, EventArgs e)
        {
            if (txtVoucherPay.Enabled == false)
                txtVoucherPay.Enabled = true;
            else if (txtVoucherPay.Enabled == true)
                txtVoucherPay.Enabled = false;
        }
        private void rbDebitCardPay_Click(object sender, EventArgs e)
        {
            if (txtDebitCardPay.Enabled == false)
                txtDebitCardPay.Enabled = true;
            else if (txtDebitCardPay.Enabled == true)
                txtDebitCardPay.Enabled = false;
        }
        private void rbCheckPay_Click(object sender, EventArgs e)
        {
            if (txtCheckPay.Enabled == false)
                txtCheckPay.Enabled = true;
            else if (txtCheckPay.Enabled == true)
                txtCheckPay.Enabled = false;
        }
        private void rbOtherPay_Click(object sender, EventArgs e)
        {
            if (txtOtherPay.Enabled == false)
                txtOtherPay.Enabled = true;
            else if (txtOtherPay.Enabled == true)
                txtOtherPay.Enabled = false;
        }
        #endregion MetodosDePago

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
                }
                //dataGridWayToPay.Rows.Insert(0,"TOTALLLL");
            }     
        }


    }
}
