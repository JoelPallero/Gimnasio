using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataRegistrosLogs : DataConnection
    {
        public int RegistrarLogin(Registros_Logs _registrosLogs)
        {
            int resultado = -1;
            string query = @"insert into Registros_Logs (Empleado_ID, Fecha_LogIn)
                                            values (@Empleado_ID, @Fecha_Login)";

            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", _registrosLogs.Empleado_ID);
            SqlParameter fecha_LogIn = new SqlParameter("@Fecha_LogIn", _registrosLogs.Fecha_LogIn);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(empleado_ID);
            cmd.Parameters.Add(fecha_LogIn);

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

        public Registros_Logs GetLastLogID(Registros_Logs _registrosLogs)
        {
            string query = @"sp_last_Login";

            //SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", _registrosLogs.Empleado_ID);
            SqlCommand cmd = new SqlCommand(query, conexion);
            //cmd.Parameters.Add(empleado_ID);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _registrosLogs.Registro_Log_ID = int.Parse(reader["Registro_Log_ID"].ToString());
                }
                reader.Close();
                cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo traer el último registro de login", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return _registrosLogs;
        }
        public int RegistrarLogOut(Registros_Logs _registrosLogs)
        {
            int resultado = -1;
            string query = @"update Registros_Logs set 
                            Fecha_LogOut = @Fecha_LogOut 
                            where Empleado_ID = @Empleado_ID
                            and Registro_Log_ID = @Registro_Log_ID";

            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", _registrosLogs.Empleado_ID);
            SqlParameter fecha_LogOut = new SqlParameter("@Fecha_LogOut", _registrosLogs.Fecha_LogOut);
            SqlParameter registro_Log_ID = new SqlParameter("@Registro_Log_ID", _registrosLogs.Registro_Log_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(empleado_ID);
            cmd.Parameters.Add(fecha_LogOut);
            cmd.Parameters.Add(registro_Log_ID);

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