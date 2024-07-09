using Oracle.ManagedDataAccess.Client;
using System;

namespace TuNamespace.CapaDatos
{
    public class CD_Conexion
    {
        private OracleConnection Conexion = new OracleConnection("User Id=SYSTEM;Password=123;Data Source=XE");

        public OracleConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión a la base de datos.", ex);
            }
        }

        public OracleConnection CerrarConexion()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión a la base de datos.", ex);
            }
        }
    }
}
