using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DataLogin : DataConnection
    {
        public void CreatingLogin(login_empleado _login)
        {
            try
            {
                conexion.Open();
                string query = @"insert into login_empleado (usuario, clave, estado_login)
                                 values (@usuario, @clave, @estado_login)";

                SqlParameter usuario = new SqlParameter("@usuario", _login.usuario);
                SqlParameter clave = new SqlParameter("@clave", _login.clave);
                SqlParameter estado_login = new SqlParameter("@estado_login", _login.estado_login);

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(usuario);
                command.Parameters.Add(clave);
                command.Parameters.Add(estado_login);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Error al crear nuevo login", e);
            }
            finally
            {
                conexion.Close();
            }
        }

        //public void ConsultingLogin
    }
}
