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
    public partial class DiscountsScreen : Form
    {
        public DiscountsScreen()
        {
            InitializeComponent();
          
        }

        private void txtDiscountDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnEditDiscounts_Click(object sender, EventArgs e)
        {
            if (txtDiscountDiscount.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }




        private void ListarProductos()
        {
            Procedures usuarioObj = new Procedures();
            cbProductDiscount.DataSource = usuarioObj.ListarProductosCb();
            cbProductDiscount.DisplayMember = "Nombre Producto";
            cbProductDiscount.ValueMember = "Codigo";//Valor real de l combox
        }


        private void addDiscountBtton_Click(object sender, EventArgs e)
        {
            Procedures proc = new Procedures();
            if (txtDiscountDiscount.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idProducto = Convert.ToInt32(cbProductDiscount.SelectedValue);

            string porcentajeTxt = txtDiscountDiscount.Text;
            int porcentaje;
            Int32.TryParse(porcentajeTxt, out porcentaje);
            DateTime fecha1 = DateTime.Parse(dtpInDiscounts.Text);
            DateTime fecha2 = DateTime.Parse(dtpOutDiscounts.Text);
            var tilin2 = proc.InsertarDescuentos(porcentaje, fecha1, fecha2, idProducto);
            if (tilin2)
            {
                MessageBox.Show("Inserccion exitosa", "Exito", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("No se inserto el descuento");
        }
        


        private void DiscountsScreen_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }
    }
}
