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
        public WaytoPayScreen()
        {
            InitializeComponent();
            dataGridWayToPay.Rows[0].Cells[0].Value = "B312";
            dataGridWayToPay.Rows[0].Cells[1].Value = "Jamón";
            dataGridWayToPay.Rows[0].Cells[2].Value = "30.00";
            dataGridWayToPay.Rows[0].Cells[3].Value = "2";
            dataGridWayToPay.Rows[0].Cells[4].Value = "0.00";
            dataGridWayToPay.Rows[0].Cells[5].Value = "60.00";
            
        }

        private void btnPayPay_Click(object sender, EventArgs e)
        {
            this.Close();
            ticketScreen TheOtherForm = new ticketScreen();
            TheOtherForm.ShowDialog();   
        }


    }
}
