using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataPlanesAsignados : DataConnection
    {
        public DataSet VerClasesQueTieneElCliente(Planes_Asignados planes_Asignados)
        {
            string query = @"select Planes.Nombre, Planes_Asignados.Plan_Asignado_ID
                            from Planes_Asignados
                            inner join Planes
                            on Planes_Asignados.Plan_ID = Planes.Plan_ID
                            where Planes_Asignados.Cliente_ID = @Cliente_ID"
            ;

            SqlParameter cliente_ID = new SqlParameter("@Cliente_ID", planes_Asignados.Cliente_ID);
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(cliente_ID);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return ds;
        }
    }
}
