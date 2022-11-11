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
    //NOTAS: LO DE FECHA DE CAMBIO NO SE SI CAMBIARLO, AHORITA LO VEMOS
    public partial class productsScreen : Form
    {
        int indexBox, indexBox2;
        bool selection = false;
        bool selection2 = false;
        bool bandera;
        int productSelection;
        public productsScreen()
        {
            InitializeComponent();
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            //dataGridProduct.Rows[0].Cells[0].Value = "B312";
            //dataGridProduct.Rows[0].Cells[1].Value = "Salmón";
            //dataGridProduct.Rows[0].Cells[2].Value = "Pescado importado";
            //dataGridProduct.Rows[0].Cells[3].Value = "Mariscos";
            //dataGridProduct.Rows[0].Cells[4].Value = "Kilogramo";
            //dataGridProduct.Rows[0].Cells[5].Value = "50.00";
            //dataGridProduct.Rows[0].Cells[6].Value = "60.00";
            //dataGridProduct.Rows[0].Cells[7].Value = "09/09/2022";
            //dataGridProduct.Rows[0].Cells[8].Value = "50";
            //dataGridProduct.Rows[0].Cells[9].Value = "10";
            //dataGridProduct.Rows[0].Cells[10].Value = "No aplica";
            //dataGridProduct.Rows[0].Cells[11].Value = "Si";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtIdProduct.TextLength == 0 || txtNameProduct.TextLength == 0 || txtDesProduct.TextLength == 0 ||
                txtCostProduct.TextLength == 0 || txtPriceProduct.TextLength == 0 || txtExistenceProduct.TextLength == 0 || txtReOrdProduct.TextLength == 0
                || txtActiveProduct.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateValidFuture(dtpDateProduct.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection == false || selection2 == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione un campo de Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(selection2 == false)
                    MessageBox.Show("Seleccione una Unidad de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Para solo usar dos decimales en costo
            string id = txtIdProduct.Text;
            int CodProducto;
            Int32.TryParse(id, out CodProducto);          
            string exiss = txtExistenceProduct.Text;
            int exxistencia;
            Int32.TryParse(exiss, out exxistencia);

            string ptReOrden = txtReOrdProduct.Text;
            int reOrder;
            Int32.TryParse(ptReOrden, out reOrder);

            
            //string ptReOrden = txtReOrdProduct.Text;
            //int reOrder;
            //Int32.TryParse(ptReOrden, out reOrder);

            string cost = txtCostProduct.Text;

            float costTemp = Convert.ToSingle(cost);
            string costDecimal = costTemp.ToString("0.##");
            float costFloat = Convert.ToSingle(costDecimal);
            //Para precio
            string prec = txtCostProduct.Text;
            float precTemp = Convert.ToSingle(prec);
            string precDecimal = precTemp.ToString("0.##");
            float precFloat = Convert.ToSingle(precDecimal);
            Procedures proc = new Procedures();
            int ajajaja = Convert.ToInt32(cbDepartamentProduct.SelectedValue);
            DateTime fechaAlta = DateTime.Parse(dtpDateProduct.Text);
            //DateTime fechaCambio = DateTime.Parse(dtpChangeDateProduct.Text);
            var Variable = proc.InsertarProductos(CodProducto, txtNameProduct.Text, txtDesProduct.Text, cbMeasureProduct.Text,fechaAlta, 
                exxistencia, reOrder, txtActiveProduct.Text, costFloat, precFloat, ajajaja);
        }

        private void txtIdProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtExistenceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtCostProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCostProduct.Text);
        }

        private void txtReOrdProduct_KeyPress(object sender, KeyPressEventArgs e)
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
        private bool dateValidFuture(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            if (fecha > hoy)
            {
                return false;
            }
            return true;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (txtIdProduct.TextLength == 0 || txtNameProduct.TextLength == 0 || txtDesProduct.TextLength == 0 ||
                txtCostProduct.TextLength == 0 || txtPriceProduct.TextLength == 0 || txtExistenceProduct.TextLength == 0 || txtReOrdProduct.TextLength == 0
                || txtActiveProduct.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateValidFuture(dtpDateProduct.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection == false || selection2 == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione un campo de Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection2 == false)
                    MessageBox.Show("Seleccione una Unidad de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Para solo usar dos decimales en costo
            string cost = txtCostProduct.Text;
            float costTemp = Convert.ToSingle(cost);
            string costDecimal = costTemp.ToString("0.##");
            float costFloat = Convert.ToSingle(costDecimal);
            //Para precio
            string prec = txtCostProduct.Text;
            float precTemp = Convert.ToSingle(prec);
            string precDecimal = precTemp.ToString("0.##");
            float precFloat = Convert.ToSingle(precDecimal);
            Procedures proc = new Procedures();

            string id = txtIdProduct.Text;
            int CodProducto;
            Int32.TryParse(id, out CodProducto);
            string exiss = txtExistenceProduct.Text;
            int exxistencia;
            Int32.TryParse(exiss, out exxistencia);

            string ptReOrden = txtReOrdProduct.Text;
            int reOrder;
            Int32.TryParse(ptReOrden, out reOrder);
            DateTime fechaCambio = DateTime.Parse(dtpDateProduct.Text);
            int Arsene = Convert.ToInt32(cbDepartamentProduct.SelectedValue);
            var LaGuerraDeLasGalaxias = proc.ActualizarProductos(txtNameProduct.Text, txtDesProduct.Text, cbMeasureProduct.Text, fechaCambio, exxistencia, reOrder, txtActiveProduct.Text, costFloat, precFloat, Arsene); ;
            if (LaGuerraDeLasGalaxias)
            {
                MessageBox.Show("Actualizacion de producto exitosa", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ACTUALIZACION FALLIDA", "NO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //proc.InsertarProductos(CodProducto, txtNameProduct.Text, txtDesProduct.Text, cbMeasureProduct.Text, fechaAlta,
            //    exxistencia, reOrder, txtActiveProduct.Text, costFloat, precFloat, ajajaja);

        }

        private void cbDepartamentProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = cbDepartamentProduct.SelectedIndex;
            selection = true;
        }

        private void cbMeasureProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox2 = cbMeasureProduct.SelectedIndex;
            selection2 = true;
        }

        private void txtPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtPriceProduct.Text);
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridProduct.AllowUserToOrderColumns = false;
                if (dataGridProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string idProductoData;
                    int eseId;
                    idProductoData = dataGridProduct.CurrentRow.Cells["Codigo"].Value.ToString();
                    Int32.TryParse(idProductoData, out eseId);
                    productSelection = eseId;
                    txtIdProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    txtNameProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Nombre Producto"].Value.ToString();
                    txtDesProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Descripción"].Value.ToString();
                  //  txtIdEmployees.Text = dataGridProduct.Rows[e.RowIndex].Cells["Clave de Usuario"].Value.ToString();
                  //  txtEmailEmployees.Text = dataGridProduct.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                  //  txtPayrollEmployees.Text = dataGridProduct.Rows[e.RowIndex].Cells["Nomina"].Value.ToString();
                  //  txtPassEmployees.Text = dataGridProduct.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                  //  txtCurpEmployees.Text = dataGridProduct.Rows[e.RowIndex].Cells["CURP"].Value.ToString();
                  //  dtpBirth.Text = dataGridProduct.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString();
                  //  dtpJoinBusiness.Text = dataGridProduct.Rows[e.RowIndex].Cells["Fecha de Ingreso"].Value.ToString();
                    dataGridProduct.CurrentRow.Selected = true;
                    dtpChangeDateProduct.Enabled = true;
                    dtpDateProduct.Enabled = false;
                    btnEditProduct.Enabled = true;
                    btnDeleteProduct.Enabled = true;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {

            }
        }

        private void onePoint(KeyPressEventArgs e, String cadena)
        {
            int cont = 0;
            String caracter = "";
            for(int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if(caracter == ".")
                {
                    cont++;
                }
            }
            if(cont == 0)
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

        private void productsScreen_Load(object sender, EventArgs e)
        {
            Procedures instancia = new Procedures();
            ListarDepartamentos();
            dataGridProduct.DataSource = instancia.ListarProductos();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Procedures proc = new Procedures();
            var eliminado = proc.BajaProductos(productSelection);
            if(eliminado == true)
            {
                MessageBox.Show("Se elimino el producto con exito", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("NO se elimino el producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Lorem ipsum, tulius alterus aerrebius maximus
        private void ListarDepartamentos()
        {
            Procedures usuarioObj = new Procedures();
            cbDepartamentProduct.DataSource = usuarioObj.ListarDepartamentosCb();
            cbDepartamentProduct.DisplayMember = "nombreDep";
            cbDepartamentProduct.ValueMember = "idDepa";//Valor real de l combox
        }
    }
}
