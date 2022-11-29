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
        bool bandera;
        string nombreCajeroAux;
        int cajeroIdAux;
        string NombreProducto;
        string NombreProductoEliminar;
        int Caja;
        bool itExists;
        bool cantidadBien;
        float catnAllevarFinal;
        float cantCarritoEliminar;
        string Precio;
        string PrecioNUEVO;
        string PrecioAEliminar;
        float PrecioInicial;
        string laCaja;
        int CantAmultiplicar;
        float precioLbl = 0.0f;
        float precioLblAux = 0.0f;
        float UltimoPrecio;

        string AllevarFinal;
        
        float precioTotallbl;
        string precioUnitGridProduct;
        float totalLblFinal;
        float totalLblFinalAux;

        float AllevarflotanteGrid;
        float allevarCantActualizadaCarrito;

        string precioUnitarioCarrito;
        public SalesScreen()
        {
            InitializeComponent();
            dataGridProductSales.DataSource = proc.productoSales();
            btnAddSales.Enabled = false;
            btnDeleteSales.Enabled = false;
            txtQuantitySales.Enabled = false;
            //dataGridProductSales.Rows[0].Cells[0].Value = "B312";
            //dataGridProductSales.Rows[0].Cells[1].Value = "Jamón";
            //dataGridCarritoSales.Rows[0].Cells[0].Value = "B412";
            //dataGridCarritoSales.Rows[0].Cells[1].Value = "Salmón";
        }

        public SalesScreen(string txt, string caja, string nombreCajeroActual, int idCajeroActual)
        {
            InitializeComponent();
            dataGridProductSales.DataSource = proc.productoSales();
            btnAddSales.Enabled = false;
            txtQuantitySales.Enabled = false;
            btnDeleteSales.Enabled = false;
            txtQuantityDeleteSales.Enabled = false;
            string prueba = txt;
            string prueba2 = caja;

            laCaja = prueba2;
            fecha = prueba;
            nombreCajeroAux = nombreCajeroActual;
            cajeroIdAux = idCajeroActual;
            Int32.TryParse(prueba2, out Caja);
        }

        private void btnQuickSearchSales_Click(object sender, EventArgs e)
        {
            QuickSearchScreen TheOtherForm = new QuickSearchScreen();
            TheOtherForm.ShowDialog();
        }

        private void btnPaySales_Click(object sender, EventArgs e)
        {
            if (precioLbl.ToString() == "$00.00")
            {
                
                MessageBox.Show("No ha agregado nada al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridCarritoSales.Rows.Count == 0)
            {
                
                MessageBox.Show("No ha agregado nada al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow fila in dataGridCarritoSales.Rows)
            {
                string cantiStocActualStr = fila.Cells["Stock"].Value.ToString();
                float cantiStockActual = float.Parse(cantiStocActualStr);
                string cantiLlevarStr = fila.Cells["A llevar"].Value.ToString();
                float cantiLlevar = float.Parse(cantiLlevarStr);
                if (cantiStockActual < cantiLlevar)
                {
                    cantidadBien = false;
                    break;
                }
                else
                {
                    cantidadBien = true;
                }
            }

            if (cantidadBien == false)
            {
                MessageBox.Show("No puede comprar mas productos de los que hay en el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            WaytoPayScreen TheOtherForm = new WaytoPayScreen(totalLblFinal.ToString(), label7.Text.ToString(), fecha, laCaja, nombreCajeroAux, cajeroIdAux);
            TheOtherForm.ShowDialog();

            var limpia = proc.limpiarVentaTemporal();
            label7.Text = "";
            label7.Text += "$ ";
            label7.Text += "00.00";
            txtQuantityDeleteSales.Text = "";
            txtQuantitySales.Text = "";
            txtNumberSales.Text = "";
            txtNameSales.Text = "";
            totalLblFinalAux = 0;
            totalLblFinal = 0;
            
            dataGridCarritoSales.DataSource = proc.ListarCarrito();
            //precioLbl = 0.0f;
            //precioLblAux = 0.0f;
            //label7.Text = "";
            //label7.Text += "$ ";
            //label7.Text += totalLblFinal.ToString("N2");
        }
        
        private void txtQuantitySales_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtQuantitySales.Text);
            //onlyNumbers(sender, e);
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
            onePoint(e, txtQuantityDeleteSales.Text);
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
            float cantInt = float.Parse(cant);
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
           
            float.TryParse(CantidadAllevarLbl, out catnAllevarFinal);
            DateTime unaFecha = DateTime.Parse(fecha);
            numCod = txtNumberSales.Text;

            //CATALGOS VENTAS DEVOLUCIONES Y REPORTES Y YA LUEGO UNO POR UNo
            //o hacmeos un variable global o arreglamos la clase
            

            
            if (dataGridCarritoSales.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridCarritoSales.Rows)
                {
                    if (NombreProducto == fila.Cells["Producto"].Value.ToString())
                    {
                        PrecioNUEVO = fila.Cells["Precio"].Value.ToString();
                        itExists = true;
                        break;
                    }
                    else 
                        itExists = false;
                   // NombreProducto = fila.Cells["Producto"].Value.ToString();
                }
            }

            if (itExists == true)
            {
                MessageBox.Show("Este producto ya esta en el carrito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var actual = proc.ActualizarCarrito(NombreProducto, catnAllevarFinal);
                if (actual)
                {
                    dataGridCarritoSales.DataSource = proc.ListarCarrito();

                    float auxInt = float.Parse(txtQuantitySales.Text);
                    float cantidadNueva = (float)auxInt;
                    float agregar;
                    float.TryParse(PrecioNUEVO, out agregar);
                    precioLbl = (agregar * cantidadNueva);
                    precioLblAux = precioLbl + precioLblAux;
                    precioLbl = precioLblAux;

                    string cantLlevar;
                    float cantallevarenflotante;
                    cantLlevar = txtQuantitySales.Text;
                    float.TryParse(cantLlevar, out cantallevarenflotante);

                    float precioParseado;
                    float.TryParse(precioUnitGridProduct, out precioParseado);
                    totalLblFinalAux = precioParseado * cantallevarenflotante;
                    totalLblFinal = totalLblFinalAux + totalLblFinal;
                    label7.Text = "";
                    label7.Text += "$ ";
                    label7.Text += totalLblFinal.ToString("N2");
                    //UltimoPrecio = precioLbl;
                    txtQuantitySales.Text = "";
                }
               
            }
            else if (itExists == false)
            {
                    var InsertData = proc.AgregarCarrito(CodProd, NombreProducto, Caja, unaFecha, catnAllevarFinal);
                if (InsertData)
                {
                    string cantLlevar;
                    float cantallevarenflotante;
                    cantLlevar = txtQuantitySales.Text;
                    float.TryParse(cantLlevar, out cantallevarenflotante);
                    dataGridCarritoSales.DataSource = proc.ListarCarrito();
                    label7.Text = "";
                    label7.Text += "$ ";
                    // precioLbl = precioLbl + UltimoPrecio;
                    float precioParseado;
                    float.TryParse(precioUnitGridProduct, out precioParseado);
                    totalLblFinalAux = precioParseado * cantallevarenflotante;
                    totalLblFinal = totalLblFinalAux + totalLblFinal;
                    precioLblAux = precioLbl + precioLblAux;
                    precioLbl = precioLblAux;
                    label7.Text += totalLblFinal.ToString("N2");    /*precioLbl.ToString().;*/

                    foreach (DataGridViewRow fila in dataGridCarritoSales.Rows)
                    {
                        if (fila.Cells["Porcentaje Descuento"].Value.ToString() == string.Empty)
                        {
                            
                        }
                        else
                        {
                            string codigoStr = fila.Cells["Codigo"].Value.ToString();
                            int codigoAct = Int32.Parse(codigoStr);
                            DateTime fechaAct = DateTime.Parse(fecha); 
                            var fechasValidas = proc.checarFechasDescuento(codigoAct, fechaAct);
                        }
                    }
                    dataGridCarritoSales.DataSource = proc.ListarCarrito();

                }
                else
                    MessageBox.Show("Ocurrio un error al momento de agregar al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtQuantitySales.Text = "";
                dataGridCarritoSales.DataSource = proc.ListarCarrito();
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
            float cantInt = float.Parse(cant);
            if (cantInt == 0)
            {
                MessageBox.Show("No se puede ingresar un valor en cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float eliminarCant = cantCarritoEliminar - cantInt;
            if (eliminarCant < 0)
            {
                MessageBox.Show("La cantidad a eliminar o regresar no coincide", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (eliminarCant == 0)
            {
                proc.EliminarProductoCarrito(NombreProductoEliminar, cantInt);
                MessageBox.Show("Producto Eliminado", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridCarritoSales.DataSource = proc.ListarCarrito();

                float auxInt = float.Parse(txtQuantityDeleteSales.Text);
                precioLbl = 0;
                //ver si puedo usar el datagrid click para obtener la cant y precio
                float auxInt2 = float.Parse(txtQuantityDeleteSales.Text);
                float cantidadEliminar = (float)auxInt2;
                float restar;
                float.TryParse(PrecioAEliminar, out restar);
                precioLblAux = (restar * cantidadEliminar);
                precioLblAux = precioLblAux - precioLbl;
                precioLbl = precioLblAux;
                totalLblFinal = totalLblFinal - precioLbl;
                precioLbl = 0;

                label7.Text = "";
                label7.Text += "$ ";
                label7.Text += totalLblFinal.ToString("N2");
                btnDeleteSales.Enabled = false;
                txtQuantityDeleteSales.Enabled = false;
                txtQuantityDeleteSales.Text = "";
                dataGridCarritoSales.ClearSelection();
                return;
            }
            else
            {
                MessageBox.Show("Cantidad Actualizada", "Entendido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                proc.EliminarCantidadProductoCarrito(NombreProductoEliminar, cantInt);
                dataGridCarritoSales.DataSource = proc.ListarCarrito();
                precioLbl = 0;
                float auxInt = float.Parse(txtQuantityDeleteSales.Text);
                float cantidadEliminar = (float)auxInt;  //checar el procedure miado 
                float restar;
                float.TryParse(PrecioAEliminar, out restar);
                precioLblAux = (restar * cantidadEliminar);
                precioLblAux = precioLblAux - precioLbl;
                precioLbl = precioLblAux;
                totalLblFinal = totalLblFinal - precioLbl;
                precioLbl = 0;
                //float precioTotalLblAux;
                //float auxPrecioTotal;
                //float Allevarflotante;
                //float laUprecio;
                //string textTextboxeliminar;
                //textTextboxeliminar = txtQuantityDeleteSales.Text;
                //float temp;
                //float.TryParse(textTextboxeliminar, out temp);

                ////voy por platano
                //float.TryParse(AllevarFinal, out Allevarflotante);
                //float.TryParse(precioUnitarioCarrito, out laUprecio);
                //allevarCantActualizadaCarrito = AllevarflotanteGrid - temp;
                //precioTotalLblAux = laUprecio * allevarCantActualizadaCarrito;
                //auxPrecioTotal = precioTotalLblAux + precioTotallbl;
                //auxPrecioTotal = totalLblFinal - auxPrecioTotal;
                ////Ocupamos otro aux
                //totalLblFinal = totalLblFinal - auxPrecioTotal;

                label7.Text = "";
                label7.Text += "$ ";
                label7.Text += totalLblFinal.ToString("N2");
            }
            btnDeleteSales.Enabled = false;
            txtQuantityDeleteSales.Enabled = false;
            txtQuantityDeleteSales.Text = "";
            dataGridCarritoSales.ClearSelection();
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
                    precioUnitGridProduct = dataGridProductSales.Rows[e.RowIndex].Cells["Precio Unitario"].Value.ToString();
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

        private void dataGridCarritoSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridCarritoSales.AllowUserToOrderColumns = false;

            try{
                if (dataGridCarritoSales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                 {
                    dataGridCarritoSales.CurrentRow.Selected = true;
                    txtQuantitySales.Enabled = false;
                    txtQuantityDeleteSales.Enabled = true;
                    string aLllevar;

                    //dataGridProductSales.CurrentRow.Selected = true;
                    //btnAddSales.Enabled = true;
                    //txtQuantitySales.Enabled = true;
                    //VentasTemp instancia = new VentasTemp();
                    aLllevar = dataGridCarritoSales.Rows[e.RowIndex].Cells["A llevar"].Value.ToString();
                    AllevarFinal = dataGridCarritoSales.Rows[e.RowIndex].Cells["A llevar"].Value.ToString();
                    string textoenTextBox;
                    float temp;
                    float.TryParse(AllevarFinal, out AllevarflotanteGrid);

                   

                    float.TryParse(aLllevar, out cantCarritoEliminar);

                    NombreProductoEliminar = dataGridCarritoSales.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    PrecioAEliminar = dataGridCarritoSales.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                    precioUnitarioCarrito = dataGridCarritoSales.Rows[e.RowIndex].Cells["Precio"].Value.ToString();

                    float.TryParse(Precio, out PrecioInicial);
                    btnDeleteSales.Enabled = true;
                    txtQuantityDeleteSales.Enabled = true;
                    //instancia.NombreProd = dataGridProductSales.Rows[e.RowIndex].Cells["Nombre Producto"].Value.ToString();
                    //NombreProducto = instancia.NombreProd;
                    //instancia.CodProducto = dataGridProductSales.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    //int codigo;
                    //Int32.TryParse(instancia.CodProducto, out codigo);
                    //CodProd = codigo;
                }
                }
                catch (Exception ArgumentOutOfRangeException)
                {

                }
            
        }

        //private void dataGridCarritoSales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    string aLllevar2;
        //    aLllevar2 = dataGridCarritoSales.Rows[e.RowIndex].Cells["A llevar"].Value.ToString();
        //    NombreProducto = dataGridCarritoSales.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
        //    Precio = dataGridCarritoSales.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
        //    float.TryParse(aLllevar2, out catnAllevarFinal);
        //    float cantFinalDec = (float)catnAllevarFinal;
        //   // float.TryParse(catnAllevarFinal, out cantFinalDec);
        //    float.TryParse(Precio, out PrecioInicial);
        //    precioLbl = (PrecioInicial * cantFinalDec);
        //    UltimoPrecio = precioLbl;
        //    aLllevar2 = "";
        //    NombreProducto = "";
        //    Precio = "";
        //}

        private void onePoint(KeyPressEventArgs e, String cadena)
        {
            int cont = 0;
            String caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if (caracter == ".")
                {
                    cont++;
                }
            }
            if (cont == 0)
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
            private void txtQuantitySales_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
