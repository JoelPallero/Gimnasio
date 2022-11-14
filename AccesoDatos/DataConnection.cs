using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataConnection
    {
        /*
         Esta clase, es de la que van a heredar todas las clases de este proyecto o capa de datos.
        Ya que acá se encuentra la cadena de conexión a la base de datos, y los métodos para abrir y cerrar la conexión a la misma.
         */
        public SqlConnection conexion;
        public string CadenaDeConexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=gym;Data Source=DESKTOP-94J33F0";
        public DataConnection()
        {
            conexion = new SqlConnection(CadenaDeConexion);
        }

        #region Apertura y cierre de conexioón
        public void OpenConnection()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de conectar con la base de datos", e);
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión con la base de datos", e);
            }
        }

        #endregion
    }
}
