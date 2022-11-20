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
    public partial class SalesScreen : Form
    {
        Procedures proc = new Procedures();
        int CodProd;
        string fecha;
        string NombreProducto;
        int Caja;
        bool itExists;
        int catnAllevarFinal;
        public SalesScreen()
        {
            InitializeComponent();
            dataGridProductSales.DataSource = proc.productoSales();
            btnAddSales.Enabled = false;
            txtQuantitySales.Enabled = false;
            //dataGridProductSales.Rows[0].Cells[0].Value = "B312";
            //dataGridProductSales.Rows[0].Cells[1].Value = "Jamón";
            //dataGridCarritoSales.Rows[0].Cells[0].Value = "B412";
            //dataGridCarritoSales.Rows[0].Cells[1].Value = "Salmón";
        }

        public SalesScreen(string txt, string caja)
        {
            InitializeComponent();
            dataGridProductSales.DataSource = proc.productoSales();
            btnAddSales.Enabled = false;
            txtQuantitySales.Enabled = false;
            string prueba = txt;
            string prueba2 = caja;
            fecha = prueba;
            Int32.TryParse(prueba2, out Caja);
        }

        private void btnQuickSearchSales_Click(object sender, EventArgs e)
        {
            QuickSearchScreen TheOtherForm = new QuickSearchScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnPaySales_Click(object sender, EventArgs e)
        {
            WaytoPayScreen TheOtherForm = new WaytoPayScreen();
            TheOtherForm.ShowDialog();
        }

        private void txtQuantitySales_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantityDeleteSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            Procedures proc = new Procedures();
            if (txtQuantitySales.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cant = txtQuantitySales.Text;
            int cantInt = Int32.Parse(cant);
            if (cantInt == 0)
            {
                MessageBox.Show("No se puede ingresar un valor en cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           // txtQuantitySales.Text = "";
            txtQuantitySales.Enabled = false;
            btnAddSales.Enabled = false;
            dataGridProductSales.ClearSelection();
            VentasTemp INSTANCIA = new VentasTemp();
            string numCod;
            string numCaja;
            string CantidadAllevarLbl = txtQuantitySales.Text;
           
            Int32.TryParse(CantidadAllevarLbl, out catnAllevarFinal);
            DateTime unaFecha = DateTime.Parse(fecha);
            numCod = txtNumberSales.Text;

            //CATALGOS VENTAS DEVOLUCIONES Y REPORTES Y YA LUEGO UNO POR UNo
            //o hacmeos un variable global o arreglamos la clase
            

            //AHI VENGO DOLRODE NUEZ
            if (dataGridCarritoSales.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridCarritoSales.Rows)
                {
                    if (NombreProducto == fila.Cells["Producto"].Value.ToString())
                    {
                        MessageBox.Show("Error este producto ya existe");
                        itExists = true;
                        break;
                    }
                    else 
                        itExists = false;
                   // NombreProducto = fila.Cells["Producto"].Value.ToString();
                }
            }

            //for (int i = 1; i < dataGridCarritoSales.Rows.Count; i++)
            //{
            //    for (int j = 1; j < dataGridProductSales.Columns.Count; j++)
            //    {
            //        if (dataGridProductSales.Rows[i].Cells[j].Value.ToString() == NombreProducto)
            //        {
            //            MessageBox.Show("Este producto ya esta en el carrito");
            //            NombreProducto = "";
            //            itExists = true;
            //            break;
                        
            //        }
            //    }
            //}
            //foreach (DataGridViewRow row in dataGridCarritoSales.Rows)
            //{   
            //    if (row.Cells[row])
            //    {

            //    }
            //}
            if (itExists == true)
            {
                MessageBox.Show("Este producto ya esta en el carrito", "Actualizando");
                 var actual = proc.ActualizarCarrito(NombreProducto, catnAllevarFinal);
                if (actual)
                {
                    MessageBox.Show("Actualizacion exitosa", "Actualizado");
                    dataGridCarritoSales.DataSource = proc.ListarCarrito();
                }
               
            }
            else if (itExists == false)
            {
                    var InsertData = proc.AgregarCarrito(CodProd, NombreProducto, Caja, unaFecha, catnAllevarFinal);
                if (InsertData)
                {
                    MessageBox.Show("Exito");
                    dataGridCarritoSales.DataSource = proc.ListarCarrito();
                }
                else
                    MessageBox.Show("Puñetas");


            }
           
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            if (txtQuantityDeleteSales.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cant = txtQuantityDeleteSales.Text;
            int cantInt = Int32.Parse(cant);
            if (cantInt == 0)
            {
                MessageBox.Show("No se puede ingresar un valor en cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtNumberSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void dataGridProductSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridProductSales.AllowUserToOrderColumns = false;
            try
            {
                if (dataGridProductSales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridProductSales.CurrentRow.Selected = true;
                    btnAddSales.Enabled = true;
                    txtQuantitySales.Enabled = true;
                    VentasTemp instancia = new VentasTemp();

                    instancia.NombreProd = dataGridProductSales.Rows[e.RowIndex].Cells["Nombre Producto"].Value.ToString();
                    NombreProducto = instancia.NombreProd;
                    instancia.CodProducto = dataGridProductSales.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    int codigo;
                    Int32.TryParse(instancia.CodProducto, out codigo);
                    CodProd = codigo;

                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {

            }
        }
        //Hacer que lo que seleccione al datagrid sea lo que se meta a la tabla temporal,
        //Ya sabes como es el datgriceelclick, obtener lo seleccionado de esa celda y con eso nada mas le decimos que cuanta cantidad y ya
        private void btnFilterSales_Click(object sender, EventArgs e)
        {
            if (txtNameSales.Text != "" && txtNumberSales.Text != "")
            {
                int filtro = Int32.Parse(txtNumberSales.Text);
                dataGridProductSales.DataSource = proc.filtroSelectProduct(filtro, txtNameSales.Text);
            }
            else if (txtNumberSales.Text == "" && txtNameSales.Text != "")
            {
                dataGridProductSales.DataSource = proc.filtroSelectProduct(txtNameSales.Text);
            }
            else if (txtNumberSales.Text != "" && txtNameSales.Text == "")
            {
                int filtro = Int32.Parse(txtNumberSales.Text);
                dataGridProductSales.DataSource = proc.filtroSelectProduct(filtro);
            }
            else
            {
                dataGridProductSales.DataSource = proc.productoSales();
            }
        }
    }
}
