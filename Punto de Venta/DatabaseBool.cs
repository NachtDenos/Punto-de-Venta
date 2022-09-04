using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_Venta
{
    static class DatabaseBool
    {
        public static bool IsSQl;

        public static bool IsSQL
        {
            get
            {
                return IsSQl =  true;
            }

            set
            {
                IsSQl = false;
            }
        }
    }
}
