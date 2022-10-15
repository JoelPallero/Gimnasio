using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DataTipoEmpleado : DataConnection
    {

        public DataSet BringTipoEmpleado()
        {
            string query = "exec sp2_cargar_tipo_empleado";

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
