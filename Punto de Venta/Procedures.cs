﻿using System;
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
            return true;



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
            return true;
        }


        public DataTable ListarProductos() 
        {
              DataTable Datagrid = new DataTable();
              comando.Connection = conexion.AbrirConexion();
              comando.CommandText = "";
              return Datagrid;
        }
     

    }
}
