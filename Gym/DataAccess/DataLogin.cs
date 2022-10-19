using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DataLogin : DataConnection
    {
        public int CreatingLogin(Login_empleado _login)
        {
            int resultado = -1;

            string query = @"insert into login_empleado (usuario, clave, estado_login)
                                 values (@usuario, HASHBYTES('SHA2_512', @clave), @estado_login)";

            SqlParameter usuario = new SqlParameter("@usuario", _login.usuario);
            SqlParameter clave = new SqlParameter("@clave", _login.clave);
            SqlParameter estado_login = new SqlParameter("@estado_login", _login.estado_login);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(usuario);
            cmd.Parameters.Add(clave);
            cmd.Parameters.Add(estado_login);

            //Método para crear un Login nuevo.
            try
            {
                conexion.Open();                

                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Error al crear nuevo login", e);
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }

            return resultado;
        }


        //Vamos a traer el último id del loguin registrado recientemente
        public Login_empleado ConsultarLogin(Login_empleado _login_Empleado)
        {
            string query = @"select id from login_empleado where id = 
                                (select max(id) from login_empleado)";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _login_Empleado.id = int.Parse(reader["id"].ToString());                    
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al consultar login", e); ;
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }

            return _login_Empleado;
        }
    }
}