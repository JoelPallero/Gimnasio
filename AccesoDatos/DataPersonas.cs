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
                                                     Observaciones) 
                                                     
                                                     values (@Nombre, 
                                                             @Apellido, 
                                                             @Tipo_Documento_ID,
                                                             @Nro_documento, 
                                                             @Tipo_Sexo_ID,
                                                             @Nro_Telefono,
                                                             @Nro_Alternativo,
                                                             @Mail,
                                                             @Observaciones)"
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

    }
}
