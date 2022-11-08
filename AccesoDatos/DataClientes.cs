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
                getClientes = @"SELECT Clientes.Cliente_ID, Personas.Persona_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_Documento, Personas.Nro_telefono, Clientes.Estado
                                FROM Personas
                                INNER JOIN Clientes
                                ON Personas.Persona_ID=Clientes.Persona_ID
                                where Personas.Nombre LIKE @query 
                                    or Personas.Apellido LIKE @query
                                    or Personas.Nro_Documento LIKE @query
                                    or Clientes.Estado LIKE @query
                                and Estado = 'Activo'
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
                throw new Exception("Error al listar Clientes", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return ds;
        }

        public Clientes GetCliente(Clientes clientes)
        {
            string query = @"select * from Clientes where Cliente_ID = @Cliente_ID";

            SqlParameter clienteID = new SqlParameter("@Cliente_ID", clientes.Cliente_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(clienteID);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    clientes.Cliente_ID = int.Parse(reader["Cliente_ID"].ToString());
                    clientes.Persona_ID = int.Parse(reader["Persona_ID"].ToString());
                    clientes.Estado = reader["Estado"].ToString();
                }
                reader.Close();
                cmd.ExecuteReader();
            }
            catch (Exception e )
            {
                throw new Exception ("No se pudo traer los datos del cliente", e);
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return clientes;
        }

        public int BajaCliente(Clientes clientes)
        {
            int resultado = -1;
            string query = @"Update Clientes set Estado = @Estado where Cliente_ID = @Cliente_ID";
            SqlParameter estado = new SqlParameter("@Estado", clientes.Estado);
            SqlParameter cliente_ID = new SqlParameter("@Cliente_ID", clientes.Cliente_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(cliente_ID);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de editar datos del cliente", e);
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