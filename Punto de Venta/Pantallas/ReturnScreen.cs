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
    public partial class ReturnScreen : Form
    {
        public ReturnScreen()
        {
            InitializeComponent();
            dataGridReturn1.Rows[0].Cells[0].Value = "Salmón";
            dataGridReturn1.Rows[0].Cells[1].Value = "2";
            dataGridReturn1.Rows[0].Cells[2].Value = "120.00";
            dataGridReturn2.Rows[0].Cells[0].Value = "Jamón";
            dataGridReturn2.Rows[0].Cells[1].Value = "3";
            dataGridReturn2.Rows[0].Cells[2].Value = "90.00";
        }

        private void btnOkReturn_Click(object sender, EventArgs e)
        {
            CreditNoteScreen TheOtherForm = new CreditNoteScreen();
            TheOtherForm.ShowDialog();
        }
    }
}
