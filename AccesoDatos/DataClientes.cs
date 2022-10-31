using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataClientes : DataConnection
    {


        public int AltaCliente(Clientes clientes)
        {
            int resultado = -1;
            string query = @"Insert into Clientes (Persona_ID,
                                                     Fecha_Alta,
                                                     Estado) 
                                                    
                                                     values (@Persona_ID,
                                                             @Fecha_Alta,
                                                             @Estado)"
            ;
            SqlParameter persona_ID = new SqlParameter("@Persona_ID", clientes.Persona_ID);
            SqlParameter Fecha_Alta = new SqlParameter("@Fecha_Alta", clientes.Fecha_Alta);
            SqlParameter Estado = new SqlParameter("@Estado", clientes.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(persona_ID);
            cmd.Parameters.Add(Fecha_Alta);
            cmd.Parameters.Add(Estado);

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
    }
}