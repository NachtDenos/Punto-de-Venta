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
    public partial class departamentScreen : Form
    {
        Procedures proc = new Procedures();
        public departamentScreen()
        {
            InitializeComponent();
            //dataGridDepartament.Rows[0].Cells[0].Value = "D012409";
            //dataGridDepartament.Rows[0].Cells[1].Value = "Mariscos";
            //dataGridDepartament.Rows[0].Cells[2].Value = "Si";
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {
            int id;
            string idTexto = txtIdDepartament.Text;
            Int32.TryParse(idTexto, out id);
           var aja = proc.AltaDepartamentos(txtNameDepartament.Text, id,cbDevolutionDepartament.Text);
            if (aja == true)
            {
                MessageBox.Show("Se inserto ");
            }
        }
    }
}
