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
    public partial class EmployeesScreen : Form
    {
        public EmployeesScreen()
        {
            InitializeComponent();
            dataGridEmployees.Rows[0].Cells[0].Value = "Juan";
            dataGridEmployees.Rows[0].Cells[1].Value = "Pérez";
            dataGridEmployees.Rows[0].Cells[2].Value = "Martínez";
            dataGridEmployees.Rows[0].Cells[3].Value = "ROCE000131HNLDNDA9";
            dataGridEmployees.Rows[0].Cells[4].Value = "02/03/2002";
            dataGridEmployees.Rows[0].Cells[5].Value = "eeatienda2001@hotmail.com";
            dataGridEmployees.Rows[0].Cells[6].Value = "006756243534";
            dataGridEmployees.Rows[0].Cells[7].Value = "09/09/2022";
            dataGridEmployees.Rows[0].Cells[8].Value = "C117";
            dataGridEmployees.Rows[0].Cells[9].Value = "123";
        }

        private void buttonExitEmployees_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
