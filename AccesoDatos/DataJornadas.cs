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
    public class DataJornadas : DataConnection
    {
        #region Jornadas de Planes
        public DataTable GetJornadaPlan(Jornadas_Planes jornadas_Planes)
        {
            string query = @"select * from Jornadas_Planes 
                            where Plan_ID = @Plan_ID
                            and Estado = 'A'";

            SqlParameter plan_ID = new SqlParameter("@Plan_ID", jornadas_Planes.Plan_ID);
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(plan_ID);

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
                throw new Exception("Error al listar las jornadas de los planes.", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return dt;
        }
        public int AltaJornadaPlan(Jornadas_Planes jornadas_Planes)
        {
            int resultado = -1;

            //Hay que convertir los horarios antes de pasarlos
            //El campo de la bdd es de tipo Time. Por lo que solo admite horarios.
            //Para convertirlo solo vamos a utlilzar este método:


            string query = @"insert into Jornadas_Planes (Plan_ID, Dia, Desde_Hora, Hasta_Hora, Estado)
                                                    values (@Plan_ID, @Dia, @Desde_Hora, @Hasta_Hora, @Estado)"
            ;
            SqlParameter plan_ID = new SqlParameter("@Plan_ID", jornadas_Planes.Plan_ID);
            SqlParameter dia = new SqlParameter("@Dia", jornadas_Planes.Dia);
            SqlParameter desde_Hora = new SqlParameter("@Desde_Hora", jornadas_Planes.Desde_Hora);
            SqlParameter hasta_Hora = new SqlParameter("@Hasta_Hora", jornadas_Planes.Hasta_Hora);
            SqlParameter estado = new SqlParameter("@Estado", jornadas_Planes.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(plan_ID);
            cmd.Parameters.Add(dia);
            cmd.Parameters.Add(desde_Hora);
            cmd.Parameters.Add(hasta_Hora);
            cmd.Parameters.Add(estado);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar la jornada", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return resultado;
        }
        public int EditarJornadaPlan(Jornadas_Planes jornadas_Planes)
        {
            int resultado = -1;
            string query = @"update Jornadas_Planes set 
                            Dia = @Dia,
                            Desde_Hora = @Desde_Hora,
                            Hasta_Hora = @Hasta_Hora,
                            Estado = @Estado
                            where Jornada_Empleado_ID = @jornada";

            SqlParameter jornada = new SqlParameter("@jornada", jornadas_Planes.Jornada_Plan_ID);
            SqlParameter dia = new SqlParameter("@dia", jornadas_Planes.Dia);
            SqlParameter Desde_Hora = new SqlParameter("@Desde_Hora", jornadas_Planes.Desde_Hora);
            SqlParameter Hasta_Hora = new SqlParameter("@Hasta_Hora", jornadas_Planes.Hasta_Hora);
            SqlParameter Estado = new SqlParameter("@Estado", jornadas_Planes.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(jornada);
            cmd.Parameters.Add(dia);
            cmd.Parameters.Add(Desde_Hora);
            cmd.Parameters.Add(Hasta_Hora);
            cmd.Parameters.Add(Estado);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de actualizar datos de la jornada", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return resultado;
        }

        public int EliminarJornadaPlan(int jornadaID)
        {
            int resultado = -1;
            string query = @"update Jonadas_Planes set Estados = @Estado
                            where Jornada_Plan_ID = @Jornada_Plan_ID"
            ;

            SqlParameter estado = new SqlParameter("@Estado", "Baja");
            SqlParameter jornada_ID = new SqlParameter("@Jornada_Plan_ID", jornadaID);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(jornada_ID);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de editar datos de empleado", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return resultado;
        }
        #endregion

        #region Jornada de Empleados
        public int AltaJornadaEmpleados(Jornadas_Empleados jornadaEmpleado)
        {
            int resultado = -1;
            string query = @"insert into Jornadas_Empleados (Empleado_ID, Dia, Desde_Hora, Hasta_Hora, Estado)
                                                    values (@Empleado_ID, @Dia, @Desde_Hora, @Hasta_Hora, @Estado)"
            ;
            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", jornadaEmpleado.Empleado_ID);
            SqlParameter dia = new SqlParameter("@Dia", jornadaEmpleado.Dia);
            SqlParameter desde_Hora = new SqlParameter("@Desde_Hora", jornadaEmpleado.Desde_Hora);
            SqlParameter hasta_Hora = new SqlParameter("@Hasta_Hora", jornadaEmpleado.Hasta_Hora);
            SqlParameter estado = new SqlParameter("@Estado", jornadaEmpleado.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(empleado_ID);
            cmd.Parameters.Add(dia);
            cmd.Parameters.Add(desde_Hora);
            cmd.Parameters.Add(hasta_Hora);
            cmd.Parameters.Add(estado);

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
        public DataTable GetJornadaEmpleado(Jornadas_Empleados jornadas_Empleados)
        {
            string query = @"select * from Jornadas_Empleados 
                            where Empleado_ID = @Empleado_ID
                            and Estado = 'A'";

            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", jornadas_Empleados.Empleado_ID);
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(empleado_ID);

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
                throw new Exception("Error al listar las jornadas de los empleados.", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return dt;
        }
        public int EliminarJornadaEmpleado(int jornadaID)
        {
            int resultado = -1;
            string query = @"update Jonadas_Empleados set Estados = @Estado
                            where Jornada_Empleado_ID = @Jornada_Empleado_ID"
            ;

            SqlParameter estado = new SqlParameter("@Estado", "Baja");
            SqlParameter jornada_ID = new SqlParameter("@Jornada_Empleado_ID", jornadaID);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(jornada_ID);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de editar datos de empleado", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return resultado;
        }
        public int EditarJornadaEmpleado(Jornadas_Empleados jornadas_Empleados)
        {
            int resultado = -1;
            string query = @"update Jornadas_Empleados set 
                            Dia = @Dia,
                            Desde_Hora = @Desde_Hora,
                            Hasta_Hora = @Hasta_Hora,
                            Estado = @Estado
                            where Jornada_Empleado_ID = @jornada";

            SqlParameter jornada = new SqlParameter("@jornada", jornadas_Empleados.Jornada_Empleado_ID);
            SqlParameter dia = new SqlParameter("@dia", jornadas_Empleados.Dia);
            SqlParameter Desde_Hora = new SqlParameter("@Desde_Hora", jornadas_Empleados.Desde_Hora);
            SqlParameter Hasta_Hora = new SqlParameter("@Hasta_Hora", jornadas_Empleados.Hasta_Hora);
            SqlParameter Estado = new SqlParameter("@Estado", jornadas_Empleados.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(jornada);
            cmd.Parameters.Add(dia);
            cmd.Parameters.Add(Desde_Hora);
            cmd.Parameters.Add(Hasta_Hora);
            cmd.Parameters.Add(Estado);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de actualizar datos de la jornada", e);
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