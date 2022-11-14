using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

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

        public bool BorrarEmpleados(int id)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("BorrarEmpleados", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }
        public bool ActualizarUsuarios(int id, string Nombre, string ApellidoP, string ApellidoM, string ClaveU, string Contra, string CURP, string Correo,
            DateTime FechaNac, DateTime FechaIngreso, int nomina)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ActualizarEmpleados", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", ApellidoP);
                cmd.Parameters.AddWithValue("@ApellidoM", ApellidoM);
                cmd.Parameters.AddWithValue("@ClaveU", ClaveU);
                cmd.Parameters.AddWithValue("@Contra", Contra);
                cmd.Parameters.AddWithValue("@FechaNac", FechaNac);
                cmd.Parameters.AddWithValue("@FechaIng", FechaIngreso);
                cmd.Parameters.AddWithValue("@Curp", CURP);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Nomina", nomina);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
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
                cmd.Parameters.AddWithValue("@ClaveU", user);
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
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable ListarCajero()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public bool InsertarEmpleados(string Nombre, string ApellidoPaterno, string ApellidoM, string claveU, string Contra,
            DateTime fechaNac, DateTime FechaIngreso, string curp, string email, int Nomina)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("sp_InsertarEmpleado", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoM", ApellidoM);
                cmd.Parameters.AddWithValue("@FechaNac", fechaNac);
                cmd.Parameters.AddWithValue("@NumeroNomina", Nomina);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CURP", curp.ToCharArray());
                cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                cmd.Parameters.AddWithValue("@ClaveUsuario", claveU);
                cmd.Parameters.AddWithValue("@Contraseña", Contra);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception ye)
            {
                MessageBox.Show(ye.ToString());
                return false;
            }
            return true;
        }

        public bool AltaDepartamentos(string NombreDepartamento, int claveDepartamento, string Devolucion)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
             try
            {
                int idAdmin = 1;
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("InsertarDepartamentos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreDepa",NombreDepartamento);
                cmd.Parameters.AddWithValue("@IdDepa", claveDepartamento);
                cmd.Parameters.AddWithValue("@Devolucion", Devolucion);
                cmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public bool LoginAdministrador(string user, string password, string tipo)
        {
            
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                
                SqlCommand cmd = new SqlCommand("ObtenerAdministradores", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClaveU", user);
                cmd.Parameters.AddWithValue("@Contra", password);
                //Cambiar el tipo de U a int, si jalaba solo era yo de pendejo 
                cmd.Parameters.AddWithValue("@TipoU", tipo);

                SqlDataReader readerAdmin = cmd.ExecuteReader();

                if (readerAdmin.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            //return true;
        }


        //public DataTable ListarProductos() 
        //{
        //      DataTable Datagrid = new DataTable();
        //      comando.Connection = conexion.AbrirConexion();
        //      comando.CommandText = ""; 
        //      conexion.CerrarConexion();
        //      return Datagrid;
             
        //}

        public DataTable ListarDepartamentos()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LeerDepartamentos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public bool ActualizarDepartamentos(string Nombre, string Devolucion, int idDepa)
        { 
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ActualizarDepartamentos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Devolucion", Devolucion);
                cmd.Parameters.AddWithValue("@IdDepa", idDepa);
               
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool BorrarDepartamentos(int idDepa)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("BorrarDepartamentos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", idDepa);
            
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool ActualizarProductos(int ID, string NombreProd, string descripcion, string uMedida, DateTime fechaCambio,
            int existencia, int ptReOrden, string Activo, float costo, float precioUnitario, int ClaveDepa)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ActualizarProductos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idP", ID);
                cmd.Parameters.AddWithValue("@NombreProducto", NombreProd);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@UnidadMedida", uMedida);
                cmd.Parameters.AddWithValue("@FechaCambio", fechaCambio);
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@ptReorden", ptReOrden);
                cmd.Parameters.AddWithValue("@Activo", Activo);
                cmd.Parameters.AddWithValue("@costo", costo);
                cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                cmd.Parameters.AddWithValue("@ClaveDeparmento", ClaveDepa   );

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool InsertarProductos(int CodigoProducto, string Nombre, string Descripcion, string UnidadMedida, DateTime fechaAlta, int existencia, int ptReorden, string activo,
        float costo, float preciounitario,int claveDepartamento)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                int idAdmin = 1;
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("InsertarProductos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
                cmd.Parameters.AddWithValue("@NombreProducto", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@UniMedida", UnidadMedida);
                cmd.Parameters.AddWithValue("@fechaAlta", fechaAlta);
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@ptReorden", ptReorden);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@Costo", costo);
                cmd.Parameters.AddWithValue("@PrecioUnitario", preciounitario);
                
                cmd.Parameters.AddWithValue("@ClaveDepartamento", claveDepartamento);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                //MessageBox.Show("El ID del producto no se puede repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // <-- Usar una vez acabado todo
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public DataTable ListarDepartamentosCb()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarDepartamentos"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarProductos"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public bool BajaProductos(int CodigoProducto)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
               
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("BajaProductos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigProduc", CodigoProducto);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public DataTable ListarInventario()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarInventario"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroExist(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_existenciaI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroDepaIn(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_DepartamentoI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroAgotado(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_agotadoI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroMerma(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_mermaI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool AltaCaja(int numCaja, string disponibilidad)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("CrearCajas", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", numCaja);
                cmd.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public bool EditarCaja(int numCaja, string disponibilidad)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("EditarCajas", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", numCaja);
                cmd.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public DataTable ListarCaja()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCaja"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool BajaCaja(int numCaja)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("bajaCajas", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idC", numCaja);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

    }
}
