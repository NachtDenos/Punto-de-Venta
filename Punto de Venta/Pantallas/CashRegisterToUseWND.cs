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
    public partial class CashRegisterToUseWND : Form
    {
        int ComboBoxIndex;
        bool IsSelected;
        public CashRegisterToUseWND()
        {
            InitializeComponent();
            ListarCajasCombo();
            RegisterToUseCB.Text = "Seleccionar";
        }

        private void CloseRegisterToUserWnd_Click(object sender, EventArgs e)
        {
            //var dialog = new DialogResult();
            this.Close();
            //dialog = MessageBox.Show("")
        }

        private void RegisterToUseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxIndex = RegisterToUseCB.SelectedIndex;
            IsSelected = true;
        }

        private void GoToSellerScreenbUTTN_Click(object sender, EventArgs e)
        {
            
            if (IsSelected == false)
            {
                MessageBox.Show("No ha seleccionado una caja en la cual cobrar", "Elija una caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (IsSelected == true)
            {
                CashierMainScreen formu = new CashierMainScreen();
                formu.labelIdCashRegister.Text = "234";
                Pantallas.CashierMainScreen cashierMainScreen = new Pantallas.CashierMainScreen();
                this.Hide();
                cashierMainScreen.ShowDialog();
                this.Show();
            }

        }
        private void ListarCajasCombo()
        {
            Procedures usuarioObj = new Procedures();
            RegisterToUseCB.DataSource = usuarioObj.ListarCajaCombo();
            RegisterToUseCB.DisplayMember = "Numero de Caja";
            RegisterToUseCB.ValueMember = "Numero de Caja";//Valor real de l combox
        }

    }
}
