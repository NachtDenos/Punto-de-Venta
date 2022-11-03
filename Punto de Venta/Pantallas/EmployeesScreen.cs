using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Punto_de_Venta
{
    public partial class EmployeesScreen : Form
    {
        Procedures proc = new Procedures();
        public EmployeesScreen()
        {
            InitializeComponent();
            //dataGridEmployees.Rows[0].Cells[0].Value = "Juan";
            //dataGridEmployees.Rows[0].Cells[1].Value = "Pérez";
            //dataGridEmployees.Rows[0].Cells[2].Value = "Martínez";
            //dataGridEmployees.Rows[0].Cells[3].Value = "ROCE000131HNLDNDA9";
            //dataGridEmployees.Rows[0].Cells[4].Value = "02/03/2002";
            //dataGridEmployees.Rows[0].Cells[5].Value = "eeatienda2001@hotmail.com";
            //dataGridEmployees.Rows[0].Cells[6].Value = "006756243534";
            //dataGridEmployees.Rows[0].Cells[7].Value = "09/09/2022";
            //dataGridEmployees.Rows[0].Cells[8].Value = "C117";
            //dataGridEmployees.Rows[0].Cells[9].Value = "123";
        }

        private void buttonExitEmployees_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            //Validacion de espacios vacios
            if (txtNameEmployees.TextLength == 0 || txtLastName1Employees.TextLength == 0 || txtLastName2Employees.TextLength == 0 ||
                txtPassEmployees.TextLength == 0 || txtPayrollEmployees.TextLength == 0 || txtCurpEmployees.TextLength == 0 || txtEmailEmployees.TextLength == 0
                || txtIdEmployees.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string Nomina = txtPayrollEmployees.Text;
            int nomina;
            Int32.TryParse(Nomina,out nomina);
            DateTime fechaN = DateTime.Parse(dtpBirth.Text);
            DateTime fechaI = DateTime.Parse(dtpJoinBusiness.Text);
            var result = proc.InsertarEmpleados(txtNameEmployees.Text,txtLastName1Employees.Text, txtLastName2Employees.Text, txtIdEmployees.Text, txtPassEmployees.Text, fechaN, fechaI, txtCurpEmployees.Text, txtEmailEmployees.Text, nomina);
            if (result == true)
            {
                MessageBox.Show("Inserccion Realizada con Exito", "Exito");
                dataGridEmployees.DataSource = proc.ListarCajero();
            }
            else
                MessageBox.Show("No se realizo la inserccion", "Error");
            dataGridEmployees.DataSource = proc.ListarCajero();
        }

        private void SearchBtton_Click(object sender, EventArgs e)
        {
            
            dataGridEmployees.DataSource = proc.ListarCajero();
        }

        int idCajeroSeleccionado;
        private void btnEditEmployees_Click(object sender, EventArgs e)
        {
            //Validacion de espacios vacios
            if (txtNameEmployees.TextLength == 0 || txtLastName1Employees.TextLength == 0 || txtLastName2Employees.TextLength == 0 ||
                txtPassEmployees.TextLength == 0 || txtPayrollEmployees.TextLength == 0 || txtCurpEmployees.TextLength == 0 || txtEmailEmployees.TextLength == 0
                || txtIdEmployees.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime fechaN = DateTime.Parse(dtpBirth.Text);
            DateTime fechaI = DateTime.Parse(dtpJoinBusiness.Text);
            string Nomina = txtPayrollEmployees.Text;
            int nomina;
            Int32.TryParse(Nomina, out nomina);
            var pepe = proc.ActualizarUsuarios(idCajeroSeleccionado, txtNameEmployees.Text, txtLastName1Employees.Text, txtLastName2Employees.Text, txtIdEmployees.Text, txtPassEmployees.Text,
                txtCurpEmployees.Text, txtEmailEmployees.Text, fechaN, fechaI, nomina);
            if (pepe == true)
            {
                MessageBox.Show("Actualizacion Realizada con exito");
                dataGridEmployees.DataSource = proc.ListarCajero();
            }
            else
            {
                MessageBox.Show("NO SE REALIZO LA ACTUALIZACION", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //if (dataGridEmployees.SelectedRows.Count > 0)
            //{
            //    string IdEmpleadoyUsuario;
            //    int eseId;
            //    IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            //    Int32.TryParse(IdEmpleadoyUsuario, out eseId);
            //}
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una Fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void EmployeesScreen_Load(object sender, EventArgs e)
        {
            
            dataGridEmployees.DataSource = proc.ListarCajero();
        }

        private void dataGridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridEmployees.AllowUserToOrderColumns = false;
            try
            {
                if (dataGridEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridEmployees.CurrentRow.Selected = true;

                    string IdEmpleadoyUsuario;
                    int eseId;
                    IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                    Int32.TryParse(IdEmpleadoyUsuario, out eseId);
                    idCajeroSeleccionado = eseId;
                    txtNameEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    txtLastName1Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Paterno"].Value.ToString();
                    txtLastName2Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Materno"].Value.ToString();
                    txtIdEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Clave de Usuario"].Value.ToString();
                    txtEmailEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    txtPayrollEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nomina"].Value.ToString();
                    txtPassEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                    txtCurpEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["CURP"].Value.ToString();
                    dtpBirth.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString();
                    dtpJoinBusiness.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha de Ingreso"].Value.ToString();
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {
                
                //MessageBox.Show("SELECCIONA UNA PUTA CELDA NO LA PUTA COLUMNA");
            }
            //if (dataGridEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    dataGridEmployees.CurrentRow.Selected = true;

            //    string IdEmpleadoyUsuario;
            //    int eseId;
            //    IdEmpleadoyUsuario = dataGridEmployees.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            //    Int32.TryParse(IdEmpleadoyUsuario, out eseId);
            //    idCajeroSeleccionado = eseId;
            //    txtNameEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            //    txtLastName1Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Paterno"].Value.ToString();
            //    txtLastName2Employees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Apellido Materno"].Value.ToString();
            //    txtIdEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Clave de Usuario"].Value.ToString();
            //    txtEmailEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            //    txtPayrollEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Nomina"].Value.ToString();
            //    txtPassEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            //    txtCurpEmployees.Text = dataGridEmployees.Rows[e.RowIndex].Cells["CURP"].Value.ToString();
            //    dtpBirth.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString();
            //    dtpJoinBusiness.Text = dataGridEmployees.Rows[e.RowIndex].Cells["Fecha de Ingreso"].Value.ToString();
            //}
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            var AR_152 = proc.BorrarEmpleados(idCajeroSeleccionado);
            if (AR_152 == true)
            {
                MessageBox.Show("Se elimino el empleado con exito", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameEmployees.Text = "";
                txtLastName1Employees.Text = "";
                txtLastName2Employees.Text = "";
                txtIdEmployees.Text = "";
                txtEmailEmployees.Text = "";
                txtPayrollEmployees.Text = "";
                txtPassEmployees.Text = "";
                txtCurpEmployees.Text = "";
                dtpBirth.Text = "";
                dtpJoinBusiness.Text = "";
                dataGridEmployees.DataSource = proc.ListarCajero();
                //NO TENGO IDEA
           
            }
            else
            {
                MessageBox.Show("NO se elimino el empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridEmployees.DataSource = proc.ListarCajero();
            }
        }
    }
}
