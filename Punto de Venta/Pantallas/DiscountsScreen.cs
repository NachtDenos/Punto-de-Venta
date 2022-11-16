﻿using System;
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
        Procedures proc = new Procedures();
        int idDescuentoSeleccionado;
        public DiscountsScreen()
        {
            InitializeComponent();
            btnEditDiscounts.Enabled = false;
            DeleteDiscountBtton.Enabled = false;
          
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

        private void ListaDescuentosGrid()
        {
            Procedures gridDesc = new Procedures();
            dataGridDiscounts.DataSource = gridDesc.ListarDescuentos();      
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
                MessageBox.Show("Inserccion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se realizo la inserccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ListaDescuentosGrid();
        }
        


        private void DiscountsScreen_Load(object sender, EventArgs e)
        {
            ListarProductos();
            ListaDescuentosGrid();
        }

        private void DeleteDiscountBtton_Click(object sender, EventArgs e)
        {
            var deleteDescuento = proc.BorrarDescuento(idDescuentoSeleccionado);
            if (deleteDescuento == true)
            {
                MessageBox.Show("Se elimino el descuento con exito", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscountDiscount.Text = "";
                dataGridDiscounts.DataSource = proc.ListarDescuentos();

            }
            else
            {
                MessageBox.Show("NO se elimino el descuento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridDiscounts.DataSource = proc.ListarDescuentos();
            }
            btnEditDiscounts.Enabled = false;
            DeleteDiscountBtton.Enabled = false;
            addDiscountBtton.Enabled = true;
            dataGridDiscounts.ClearSelection();
        }

        private void dataGridDiscounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridDiscounts.AllowUserToOrderColumns = false;
            try
            {
                if (dataGridDiscounts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridDiscounts.CurrentRow.Selected = true;

                    string idDiscount;
                    int eseId;
                    idDiscount = dataGridDiscounts.CurrentRow.Cells["Id Descuento"].Value.ToString();
                    Int32.TryParse(idDiscount, out eseId);
                    idDescuentoSeleccionado = eseId;
                    btnEditDiscounts.Enabled = true;
                    DeleteDiscountBtton.Enabled = true;
                    addDiscountBtton.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
            }
        }
    }
}
