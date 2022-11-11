using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataTipos : DataConnection
    {

        /* 
          Desde esta clase vamos a tratar todos las entidades "Tipo"
          Ya que son 3 y hacen la misma rutina en cuanto al ABM.
         */

        #region Tipos de Documento
        public DataTable BringTipoDocumento()
        {
            string query = "sp_cargar_tipos_documentos";

            SqlCommand cmd = new SqlCommand(query, conexion);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar tipos de documentos", e);
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }

        #endregion

        #region Tipos de Sexo

        public DataTable BringTipoSexo()
        {
            string query = "sp_cargar_tipos_sexos";

            SqlCommand cmd = new SqlCommand(query, conexion);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar tipos de sexos", e);
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }

        #endregion

        #region Tipos de Empleados

        public DataTable BringTipoEmpleado()
        {
            string query = "sp_cargar_tipos_empleados";

            SqlCommand cmd = new SqlCommand(query, conexion);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar tipo de empleados", e);
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }

        #endregion
    }
}