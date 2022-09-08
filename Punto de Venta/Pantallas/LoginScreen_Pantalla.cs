using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Punto_de_Venta.DatabaseBool;


namespace Punto_de_Venta
{
    public partial class LoginScreenWnD : Form
    {
        string UserTextHolder;
        string PasswordTextHolder;
        int indexBox;
        bool selection = false;
        
        public LoginScreenWnD()
        {
            InitializeComponent();
        }
        int dummy = -1;
        private void LoginScreenWnd_Load(object sender, EventArgs e)
        { 
            //borrar esta cosa
            if (IsSQl == true) //It seems to work
            {
                MessageBox.Show("JAJAJ ESTE PENDEJO", "Me la pelas");
                dummy = -1;
            }
            UserTextHolder = " John Doe ";
            PasswordTextHolder = "123456";
            UserNameSQLSideTextBox.Text = UserTextHolder;
            //Crear un label dinamico que aparezca cuando pase el mouse o el textbox este seleccionado 
            PassawordUSRsql.Text = PasswordTextHolder;
        }

        private void LoginScreenWnD_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = comboBoxUser.SelectedIndex;
            selection = true;
        }

        private void LoginSQLbutton_Click(object sender, EventArgs e)
        {
            
            if (selection == false)
                MessageBox.Show("No seleccionó su puesto", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(indexBox == 0)
                {
                    Pantallas.MainMenuAdmin TheOtherForm = new Pantallas.MainMenuAdmin();
                    this.Hide();
                    TheOtherForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    Pantallas.CashRegisterToUseWND theRegisterToUse = new Pantallas.CashRegisterToUseWND();
                    this.Hide();
                    theRegisterToUse.ShowDialog();
                    this.Show();
                }
            }
        }
    }
}
