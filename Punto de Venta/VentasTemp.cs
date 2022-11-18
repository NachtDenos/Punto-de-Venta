using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_de_Venta.Pantallas;

namespace Punto_de_Venta
{
    public class VentasTemp : Punto_de_Venta.Pantallas.CashierMainScreen
    {
        Pantallas.CashRegisterToUseWND cajaAUsar = new Pantallas.CashRegisterToUseWND();
        public string CodProducto { get; set; }
        public string NombreProd { get; set; }
        public string PrecioProducto { get; set; }
        public string CantProducto { get; set; }
        public string Caja {
            get
            {
                return labelIdCashRegister.Text;
            }

            set
            {
                labelIdCashRegister.Text = "0";
            }


        }

        public string fecha
        {
            get
            {
                string fechita = labelDate.Text;
                return fechita;
            }
            set
            {
                fecha = cajaAUsar.dtpCajaCobro.Text;
            }
        }

    }
}
