using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Punto_de_Venta
{
    class Procedures
    {
        private ConexionSqlServer conexion = new ConexionSqlServer();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerFilas;
        public DataTable GetUsers()
        {
            DataTable tablita = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SelectUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tablita.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tablita;
        }

        public bool Login(string user, string password, string puesto)
        {
            
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("SelectUsuarios", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreU", user);
                cmd.Parameters.AddWithValue("@Contraseña", password);
                cmd.Parameters.AddWithValue("@TipoU", puesto);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else 
                    return false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return true;
        }

    }
}
