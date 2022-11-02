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
    public class DataClientes : DataConnection
    {
        public int AltaCliente(Clientes clientes)
        {
            int resultado = -1;
            string query = @"Insert into Clientes (Persona_ID,
                                                     Estado) 
                                                    
                                                     values (@Persona_ID,
                                                             @Estado)"
            ;
            SqlParameter persona_ID = new SqlParameter("@Persona_ID", clientes.Persona_ID);
            SqlParameter Estado = new SqlParameter("@Estado", clientes.Estado);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(persona_ID);
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

        public DataSet GetClientes(string buscar)
        {
            string getClientes;
            if (string.IsNullOrEmpty(buscar))
            {
                getClientes = @"sp_Cargar_Clientes_Desc";
            }
            else
            {
                getClientes = @"SELECT Personas.Persona_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_Documento, Personas.Nro_telefono, Clientes.Estado
                                FROM Personas
                                INNER JOIN Clientes
                                ON Personas.Persona_ID=Clientes.Persona_ID
                                where Personas.Persona_ID LIKE @query 
                                    or Personas.Nombre LIKE @query 
                                    or Personas.Apellido LIKE @query
                                    or Personas.Nro_Documento LIKE @query
                                    or Clientes.Estado LIKE @query
                                Order by Personas.Fecha_Alta desc"
                ;
            }

            SqlCommand cmd = new SqlCommand(getClientes, conexion)
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


    }
}