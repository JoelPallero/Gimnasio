using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataAsistencia : DataConnection
    {

        public int PutAsistencia(Asistencias _asistencias)
        {
            int resultado = -1;
            string query = @"insert into Asistencias (Cliente_ID, Fecha, Estado, Empleado_ID) 
                            values (@Cliente_ID, @Fecha, @Estado, @Empleado_ID)";

            SqlParameter cliente_ID = new SqlParameter("@Cliente_ID", _asistencias.Cliente_ID);
            SqlParameter fecha = new SqlParameter("@Fecha", _asistencias.Fecha);
            SqlParameter estado = new SqlParameter("@Estado", _asistencias.Estado);
            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", _asistencias.Empleado_ID);

            SqlCommand cmd = new SqlCommand(query , conexion);

            cmd.Parameters.Add(cliente_ID);
            cmd.Parameters.Add(fecha);
            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(empleado_ID);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return resultado;
        }
    }
}
