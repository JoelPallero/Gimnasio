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
    public class DataEmpleados : DataConnection
    {
        #region Alta de Empleados
        public int AltaEmpleado(Empleados empleados)
        {
            int resultado = -1;
            string query = @"Insert into Empleados (Persona_ID,
                                                     Usuario,
                                                     Clave,
                                                     Tipo_Empleado_ID,
                                                     Estado_Empleado_ID) 
                                                    
                                                     values (@Persona_ID,
                                                             @Usuario,
                                                             @Clave,
                                                             @Tipo_Empleado_ID,
                                                             @Estado_Empleado_ID)"
            ;
            SqlParameter persona_ID = new SqlParameter("@Persona_ID", empleados.Persona_ID);
            SqlParameter usuario = new SqlParameter("@Usuario", empleados.Usuario);
            SqlParameter clave = new SqlParameter("@Clave", empleados.Clave);
            SqlParameter tipo_Empleado_ID = new SqlParameter("@Tipo_Empleado_ID", empleados.Tipo_Empleado_ID);
            SqlParameter estado_Empleado_ID = new SqlParameter("@Estado_Empleado_ID", empleados.Estado_Empleado_ID);
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(persona_ID);
            cmd.Parameters.Add(usuario);
            cmd.Parameters.Add(clave);
            cmd.Parameters.Add(tipo_Empleado_ID);
            cmd.Parameters.Add(estado_Empleado_ID);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de registrar nuevo empleado", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return resultado;
        }

        #endregion

        #region Consultas de ID

        public Empleados GetLastID(Empleados empleados)
        {
            string query = @"sp_cargar_ultimo_ID";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    empleados.Empleado_ID = int.Parse(reader["Empleado_ID"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo realizar el cálculo requerido", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return empleados;
        }

        #endregion

        #region Traer Empleados Registrados en la bdd

        public DataSet GetEmpleados(string buscar)
        {
            //Solicitamos la lista de TODOS los empleados
            string getEmpleados;
            if (string.IsNullOrEmpty(buscar))
            {
                getEmpleados = @"sp_Cargar_Empleados_Desc";
            }
            else
            {
                getEmpleados = @"SELECT Personas.Persona_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_Documento, 
	                                   Tipos_Empleados.Tipo, 
                                       Estados_Empleados.Estado

                                FROM Personas

                                INNER JOIN Empleados
                                ON Personas.Persona_ID = Empleados.Persona_ID

                                INNER JOIN Tipos_Empleados
                                ON Empleados.Tipo_Empleado_ID = Tipos_Empleados.Tipo_Empleado_ID

                                INNER JOIN Estados_Empleados
                                ON Empleados.Estado_Empleado_ID = Estados_Empleados.Estado_Empleado_ID
                        
                                where Personas.Persona_ID LIKE @query 
                                    or Personas.Nombre LIKE @query 
                                    or Personas.Apellido LIKE @query
                                    or Personas.Nro_Documento LIKE @query
                                    or Tipos_Empleados.Tipo LIKE @query
                                    or Estados_Empleados.Estado LIKE @query

                                Order by Personas.Fecha_Alta desc"
                ;
            }

            SqlCommand cmd = new SqlCommand(getEmpleados, conexion)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@query",
                SqlDbType = SqlDbType.NVarChar,
                Value = string.Format("%{0}%", buscar)
            });

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Movimientos", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return ds;
        }


        public Empleados GetTipoEmpleado(Empleados empleados)
        {
            string query = @"select Tipo_Empleado_ID, Usuario, Clave 
                            from Empleados 
                            where Persona_ID = '" + empleados.Persona_ID + "'"
            ;
            
            
            
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    empleados.Tipo_Empleado_ID = int.Parse(reader["Tipo_Empleado_ID"].ToString());
                    empleados.Usuario = (reader["Usuario"].ToString());
                    empleados.Clave = (reader["Clave"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo realizar el cálculo requerido", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return empleados;
        }

        public int EditarEmpleado(Empleados empleados)
        {
            int resultado = -1;
            string orden = @"update Empleados set Usuario = @Usuario, 
                                                     Clave = @Clave,   
                                                     Tipo_Empleado_ID = @Tipo_Empleado_ID
                                               Where Persona_ID = " + empleados.Persona_ID + ""
            ;

            SqlParameter usuario = new SqlParameter("@Usuario", empleados.Usuario);
            SqlParameter clave = new SqlParameter("@Clave", empleados.Clave);
            SqlParameter tipo_Empleado_ID = new SqlParameter("@Tipo_Empleado_ID", empleados.Tipo_Empleado_ID);
            
            SqlCommand cmd = new SqlCommand(orden, conexion);

            cmd.Parameters.Add(usuario);
            cmd.Parameters.Add(clave);
            cmd.Parameters.Add(tipo_Empleado_ID);

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

        #region Sesión de Usuarios

        public Empleados VerificarClaveEnBdd(string clave, Tipos_Empleados _tiposEmpleados, Empleados _empleados)
        {
            string query = @"select Empleados.Usuario, Empleados.Clave, 
                                    Tipos_Empleados.Tipo, Tipos_Empleados.Acceso_Clave, Tipos_Empleados.Estado
                            from Empleados
                            inner join Tipos_Empleados
                            on Empleados.Tipo_Empleado_ID = Tipos_Empleados.Tipo_Empleado_ID
                            where Empleados.Usuario =  '" + _empleados.Usuario + "' and Empleados.Clave = '" + clave + "'"

            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _tiposEmpleados.Estado = Convert.ToString(reader["Estado"]);
                    _tiposEmpleados.Acceso_Clave = Convert.ToString(reader["Acceso_Clave"]);
                    _tiposEmpleados.Tipo = Convert.ToString(reader["Tipo"]);
                    _empleados.Clave = Convert.ToString(reader["Clave"]);
                    _empleados.Usuario = Convert.ToString(reader["Usuario"]);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de verificar datos", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return _empleados;
        }

        #endregion
    }
}
