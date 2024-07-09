using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace TuNamespace.CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        OracleDataReader leer;
        DataTable tabla = new DataTable();
        OracleCommand comando = new OracleCommand();

        public DataTable BuscarProductos()
        {
            DataTable tabla = new DataTable();
            OracleConnection connection = null;
            OracleCommand comando = null;
            OracleDataReader reader = null;

            try
            {
                // Abre la conexión
                connection = conexion.AbrirConexion();

                // Inicializa el comando
                comando = new OracleCommand("productos_package.buscar_productos", connection);
                comando.CommandType = CommandType.StoredProcedure;

             
                // Parámetro de salida (cursor)
                comando.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                // Ejecuta el comando y obtiene el reader
                reader = comando.ExecuteReader();

                // Carga los datos del cursor en DataTable
                tabla.Load(reader);

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar buscar productos.", ex);
            }
            finally
            {
                // Cerrar recursos en caso de excepción o al finalizar
                if (reader != null)
                    reader.Close();

                if (comando != null)
                    comando.Dispose();

                if (connection != null)
                    conexion.CerrarConexion(); // Suponiendo que `conexion` tiene un método `CerrarConexion()` para cerrar la conexión
            }
        }


        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "productos_package.insertar_producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
            comando.Parameters.Add("p_descrip", OracleDbType.Varchar2).Value = desc;
            comando.Parameters.Add("p_marca", OracleDbType.Varchar2).Value = marca;
            comando.Parameters.Add("p_precio", OracleDbType.Double).Value = precio;
            comando.Parameters.Add("p_stock", OracleDbType.Int32).Value = stock;

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int id, string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "productos_package.actualizar_producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("p_id", OracleDbType.Int32).Value = id;
            comando.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = nombre;
            comando.Parameters.Add("p_descrip", OracleDbType.Varchar2).Value = desc;
            comando.Parameters.Add("p_marca", OracleDbType.Varchar2).Value = marca;
            comando.Parameters.Add("p_precio", OracleDbType.Double).Value = precio;
            comando.Parameters.Add("p_stock", OracleDbType.Int32).Value = stock;
          

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "productos_package.eliminar_producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("p_idpro", OracleDbType.Int32).Value = id;

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
