using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataJornadas : DataConnection
    {
        #region Jornadas de Planes

        #endregion

        #region Jornada de Empleados
        public int AltaJornadaEmpleados(Jornadas_Empleados jornadaEmpleado)
        {
            int resultado = -1;
            string query = @"insert into Jornadas_Empleados (Empleado_ID, Dia, Desde_Hora, Hasta_Hora)
                                                    values (@Empleado_ID, @Dia, @Desde_Hora, @Hasta_Hora)"
            ;
            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", jornadaEmpleado.Empleado_ID);
            SqlParameter dia = new SqlParameter("@Dia", jornadaEmpleado.Dia);
            SqlParameter desde_Hora = new SqlParameter("@Desde_Hora", jornadaEmpleado.Desde_Hora);
            SqlParameter hasta_Hora = new SqlParameter("@Hasta_Hora", jornadaEmpleado.Hasta_Hora);
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(empleado_ID);
            cmd.Parameters.Add(dia);
            cmd.Parameters.Add(desde_Hora);
            cmd.Parameters.Add(hasta_Hora);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar Empleado sin clave", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return resultado;
        }

        #endregion

    }
}
