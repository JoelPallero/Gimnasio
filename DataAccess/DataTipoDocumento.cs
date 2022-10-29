using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DataTipoDocumento : DataConnection
    {
        public DataSet BringTipoDocumento()
        {
            string query = "exec sp_cargar_tipo_document";

            SqlCommand cmd = new SqlCommand(query, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
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
            return ds;
        }
    }
}
