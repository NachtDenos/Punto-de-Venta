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
        bool boton1 = false, boton2 = false;
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
            CreditNoteScreen TheOtherForm = new CreditNoteScreen();
            TheOtherForm.ShowDialog();
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
                    dataGridReturn2.CurrentRow.Selected = true;
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
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {

        }

        private void rbNoReturn_Click(object sender, EventArgs e)
        {
            boton2 = true;
        }
    }
}
