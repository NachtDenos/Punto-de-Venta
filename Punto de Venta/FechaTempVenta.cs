using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_de_Venta.Pantallas;


namespace Punto_de_Venta
{
    class FechaTempVenta : Punto_de_Venta.Pantallas.CashRegisterToUseWND
    {


        public string fecha
        {
            get
            {
                string Fecha = dtpCajaCobro.Text;
                return Fecha;
            }
            set
            {
                fecha = dtpCajaCobro.Text;
            }
        }
    }
}
