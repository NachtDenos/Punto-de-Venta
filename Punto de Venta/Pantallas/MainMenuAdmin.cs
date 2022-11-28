using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta.Pantallas
{
    public partial class MainMenuAdmin : Form
    {
        Procedures proc = new Procedures();
        public MainMenuAdmin()
        {
            InitializeComponent();
            dataGridViewReorder.DataSource = proc.listarPuntoReorden();
            //dataGridViewReorder.Rows[0].Cells[0].Value = "Ciel 1L";
            //dataGridViewReorder.Rows[0].Cells[1].Value = "25";
        }

        
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //meter un Form dentro de otro Form
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeesScreen());
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new productsScreen());
        }

        private void buttonDepartaments_Click(object sender, EventArgs e)
        {
            openChildForm(new departamentScreen());
        }

        private void buttonReportSells_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesReportScreen());
        }

        private void buttonInventary_Click(object sender, EventArgs e)
        {
            openChildForm(new InventaryScreen());
        }

        private void buttonReportSeller_Click(object sender, EventArgs e)
        {
            openChildForm(new SellerReportScreen());
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            openChildForm(new TicketReportScreen());
        }

        private void buttonDevolutions_Click(object sender, EventArgs e)
        {
            openChildForm(new ReturnScreen());
            
        }

        private void buttonBoxes_Click(object sender, EventArgs e)
        {
            openChildForm(new CashRegisterScreen());
        }

        private void buttonDiscounts_Click(object sender, EventArgs e)
        {
            openChildForm(new DiscountsScreen());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReorderProd_Click(object sender, EventArgs e)
        {
            var reorder = proc.reordenarProductos();
            if (reorder)
                MessageBox.Show("Productos reordenados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudieron reordenar los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridViewReorder.DataSource = proc.listarPuntoReorden();
        }
    }
}
