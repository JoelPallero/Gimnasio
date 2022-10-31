using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataEmpleados : DataConnection
    {
        #region Alta de Empleados
        public int AltaEmpleadoSinClave(Empleados empleados)
        {
            int resultado = -1;
            string query = @"Insert into Empleados (Nombre, 
                                                     Apellido,   
                                                     Tipo_Documento_ID, 
                                                     Nro_documento,
                                                     Tipo_Sexo_ID, 
                                                     Nro_Telefono,
                                                     Nro_Alternativo,
                                                     Mail,
                                                     Observaciones, 
                                                     Tipo_Empleado_ID,
                                                     Estado_Empleado_ID) 
                                                     
                                                     values (@Nombre, 
                                                             @Apellido, 
                                                             @Tipo_Documento_ID,
                                                             @Nro_documento, 
                                                             @Tipo_Sexo_ID,
                                                             @Nro_Telefono,
                                                             @Nro_Alternativo,
                                                             @Mail,
                                                             @Observaciones,
                                                             @Tipo_Empleado_ID,
                                                             @Estado_Empleado_ID)"
            ;
            SqlParameter nombre = new SqlParameter("@Nombre", empleados.Nombre);
            SqlParameter apellido = new SqlParameter("@Apellido", empleados.Apellido);
            SqlParameter tipo_Documento_ID = new SqlParameter("@Tipo_Documento_ID", empleados.Tipo_Documento_ID);
            SqlParameter nro_documento = new SqlParameter("@Nro_documento", empleados.Nro_documento);
            SqlParameter tipo_Sexo_ID = new SqlParameter("@Tipo_Sexo_ID", empleados.Tipo_Sexo_ID);
            SqlParameter nro_Telefono = new SqlParameter("@Nro_Telefono", empleados.Nro_Telefono);
            SqlParameter nro_Alternativo = new SqlParameter("@Nro_Alternativo", empleados.Nro_Alternativo);
            SqlParameter mail = new SqlParameter("@Mail", empleados.Mail);
            SqlParameter observaciones = new SqlParameter("@Observaciones", empleados.Observaciones);
            SqlParameter tipo_Empleado_ID = new SqlParameter("@Tipo_Empleado_ID", empleados.Tipo_Empleado_ID);
            SqlParameter estado_Empleado_ID = new SqlParameter("@Estado_Empleado_ID", empleados.Estado_Empleado_ID);
            
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
            cmd.Parameters.Add(tipo_Empleado_ID);
            cmd.Parameters.Add(estado_Empleado_ID);

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
    }
}
