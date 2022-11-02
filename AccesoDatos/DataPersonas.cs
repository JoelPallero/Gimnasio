using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataPersonas : DataConnection
    {
        /*
         Acá vamos a realizar los ABM de todas las personas
         Sean empleados o clientes.
         
         */

        public int AltaPersona(Personas personas)
        {
            int resultado = -1;
            string query = @"Insert into Personas (Nombre, 
                                                     Apellido,   
                                                     Tipo_Documento_ID, 
                                                     Nro_documento,
                                                     Tipo_Sexo_ID, 
                                                     Nro_Telefono,
                                                     Nro_Alternativo,
                                                     Mail,
                                                     Observaciones,
                                                     Fecha_Alta) 
                                                     
                                                     values (@Nombre, 
                                                             @Apellido, 
                                                             @Tipo_Documento_ID,
                                                             @Nro_documento, 
                                                             @Tipo_Sexo_ID,
                                                             @Nro_Telefono,
                                                             @Nro_Alternativo,
                                                             @Mail,
                                                             @Observaciones,
                                                             @Fecha_Alta)"
            ;
            SqlParameter nombre = new SqlParameter("@Nombre", personas.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", personas.Apellido);
            SqlParameter tipo_Documento_ID = new SqlParameter("@Tipo_Documento_ID", personas.Tipo_Documento_ID);
            SqlParameter nro_documento = new SqlParameter("@Nro_documento", personas.Nro_documento);
            SqlParameter tipo_Sexo_ID = new SqlParameter("@Tipo_Sexo_ID", personas.Tipo_Sexo_ID);
            SqlParameter nro_Telefono = new SqlParameter("@Nro_Telefono", personas.Nro_Telefono);
            SqlParameter nro_Alternativo = new SqlParameter("@Nro_Alternativo", personas.Nro_Alternativo);
            SqlParameter mail = new SqlParameter("@Mail", personas.Mail);
            SqlParameter observaciones = new SqlParameter("@Observaciones", personas.Observaciones);
            SqlParameter fecha_Alta = new SqlParameter("@Fecha_Alta", personas.Fecha_Alta);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(tipo_Documento_ID);
            cmd.Parameters.Add(nro_documento);
            cmd.Parameters.Add(tipo_Sexo_ID);
            cmd.Parameters.Add(nro_Telefono);
            cmd.Parameters.Add(nro_Alternativo);
            cmd.Parameters.Add(mail);
            cmd.Parameters.Add(observaciones);
            cmd.Parameters.Add(fecha_Alta);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de registrar nueva Persona", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return resultado;
        }

        public int AltaJefe(Personas personas)
        {
            int resultado = -1;
            string query = @"Insert into Personas (Nombre, 
                                                     Apellido,   
                                                     Tipo_Documento_ID, 
                                                     Nro_documento,
                                                     Tipo_Sexo_ID, 
                                                     Nro_Telefono,
                                                     Mail,
                                                     Fecha_Alta) 
                                                     
                                                     values (@Nombre, 
                                                             @Apellido, 
                                                             @Tipo_Documento_ID,
                                                             @Nro_documento, 
                                                             @Tipo_Sexo_ID,
                                                             @Nro_Telefono,
                                                             @Mail,
                                                             @Fecha_Alta)"
            ;
            SqlParameter nombre = new SqlParameter("@Nombre", personas.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", personas.Apellido);
            SqlParameter tipo_Documento_ID = new SqlParameter("@Tipo_Documento_ID", personas.Tipo_Documento_ID);
            SqlParameter nro_documento = new SqlParameter("@Nro_documento", personas.Nro_documento);
            SqlParameter tipo_Sexo_ID = new SqlParameter("@Tipo_Sexo_ID", personas.Tipo_Sexo_ID);
            SqlParameter nro_Telefono = new SqlParameter("@Nro_Telefono", personas.Nro_Telefono);
            SqlParameter mail = new SqlParameter("@Mail", personas.Mail);
            SqlParameter fecha_Alta = new SqlParameter("@Fecha_Alta", personas.Fecha_Alta);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(tipo_Documento_ID);
            cmd.Parameters.Add(nro_documento);
            cmd.Parameters.Add(tipo_Sexo_ID);
            cmd.Parameters.Add(nro_Telefono);
            cmd.Parameters.Add(mail);
            cmd.Parameters.Add(fecha_Alta);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de registrar nueva Persona", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return resultado;
        }

        public int EditarPersona(Personas personas)
        {
            int resultado = -1;
            string orden = @"update Personas set Nombre = @Nombre, 
                                                     Apellido = @Apellido,   
                                                     Tipo_Documento_ID = @Tipo_Documento_ID,
                                                     Nro_documento = @Nro_documento, 
                                                     Tipo_Sexo_ID = @Tipo_Sexo_ID,
                                                     Nro_Telefono = @Nro_Telefono,
                                                     Nro_Alternativo = @Nro_Alternativo,
                                                     Mail = @Mail, 
                                                     Observaciones = @Observaciones
                                               Where Persona_ID = "+ personas.Persona_ID +""
            ;

            SqlParameter nombre = new SqlParameter("@Nombre", personas.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", personas.Apellido);
            SqlParameter tipo_Documento_ID = new SqlParameter("@Tipo_Documento_ID", personas.Tipo_Documento_ID);
            SqlParameter nro_documento = new SqlParameter("@Nro_documento", personas.Nro_documento);
            SqlParameter tipo_Sexo_ID = new SqlParameter("@Tipo_Sexo_ID", personas.Tipo_Sexo_ID);
            SqlParameter nro_Telefono = new SqlParameter("@Nro_Telefono", personas.Nro_Telefono);
            SqlParameter nro_Alternativo = new SqlParameter("@Nro_Alternativo", personas.Nro_Alternativo);
            SqlParameter mail = new SqlParameter("@Mail", personas.Mail);
            SqlParameter observaciones = new SqlParameter("@Observaciones", personas.Observaciones);

            SqlCommand cmd = new SqlCommand(orden, conexion);

            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(tipo_Documento_ID);
            cmd.Parameters.Add(nro_documento);
            cmd.Parameters.Add(tipo_Sexo_ID);
            cmd.Parameters.Add(nro_Telefono);
            cmd.Parameters.Add(nro_Alternativo);
            cmd.Parameters.Add(mail);
            cmd.Parameters.Add(observaciones);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Modificar Movimientos", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return resultado;
        }

        public Personas Get_Las_Id_Personas(Personas personas)
        {
            string query = @"sp_cargar_ultimo_ID_Personas";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    personas.Persona_ID = int.Parse(reader["Persona_ID"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo extraer el último ID registrado de Personas", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }

            return personas;
        }

        #region Consulta cliente único

        public Personas GetEmpleadoUnico(Personas personas)
        {
            string query = @"select *
                            From Personas
                            where Personas.Persona_ID = " + personas.Persona_ID + ""
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    personas.Nombre = reader["Nombre"].ToString();
                    personas.Apellido = reader["Apellido"].ToString();
                    personas.Tipo_Documento_ID = int.Parse(reader["Tipo_Documento_ID"].ToString());
                    personas.Nro_documento = reader["Nro_documento"].ToString();
                    personas.Tipo_Sexo_ID = int.Parse(reader["Tipo_Sexo_ID"].ToString());
                    personas.Nro_Telefono = reader["Nro_Telefono"].ToString();
                    personas.Nro_Alternativo = reader["Nro_Alternativo"].ToString();
                    personas.Mail = reader["Mail"].ToString();
                    personas.Observaciones = reader["Observaciones"].ToString();
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

            return personas;
        }

        #endregion

    }
}
