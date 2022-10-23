using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Punto_de_Venta
{
    class ConexionSqlServer
    {
        //* simbolo universal para ue me traiga todas las carreras y en general todo todito
        // daa source =
        //persist security info true; Integrated Security true esto es para poder entrar con el sistema de autentificaion de windows
        //pINCHE ALYLIN

        /*<add name="ConexionHistorial2"
            connectionString="Data Source=LAPTOP-VLDIQG6S\SQLEXPRESS;Initial Catalog=HistorialMedicoRJcodeAdvanced; persist security info true; Integrated Security true"
            providerName="System.Data.SqlClient" />*/
        static private string CadenaConexion = @"Server=LAPTOP-VLDIQG6S\SQLEXPRESS; DataBase=ProyectoMAD; Integrated Security= true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
