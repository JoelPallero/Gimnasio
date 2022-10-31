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
    }
}
