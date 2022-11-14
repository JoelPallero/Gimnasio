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
    public class DataCaja : DataConnection
    {
        #region Caja

        public DataSet ConsultarSaldos(Detalles_Cajas _detalles_Cajas)
        {
            string query = @"select sum(Importe_Ingreso) as Ingreso, sum(Importe_Egreso) as Egreso, sum(Importe_Ingreso - Importe_Egreso) as Total
                            From Detalles_Cajas
                            where Caja_ID = @Caja_ID"
            ;
            SqlParameter caja_ID = new SqlParameter("@Caja_ID", _detalles_Cajas.Caja_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(caja_ID);

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return ds;
        }
        public int AbrirCaja(Cajas caja)
        {
            int resultado = -1;
            string query = @"insert into Cajas values(@Empleado_ID,
                                                      @Fecha, 
                                                      @Importe_Inicial)"
            ;

            SqlParameter empleado_Id = new SqlParameter("@Empleado_ID", caja.Empleado_ID);
            SqlParameter fecha = new SqlParameter("@Empleado_ID", caja.Fecha);
            SqlParameter importe_Inicial = new SqlParameter("@Importe_Inicial", caja.Importe_Inicial);
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            
            cmd.Parameters.Add(empleado_Id);
            cmd.Parameters.Add(fecha);
            cmd.Parameters.Add(importe_Inicial);

            try
            {
                OpenConnection();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return resultado;
        }
        public Cajas ConsultarIDCajaAbierta(Cajas caja)
        {
            string query = @"sp_Get_Las_Caja_ID";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    caja.Caja_ID = int.Parse(reader["Caja_ID"].ToString());
                }
                reader.Close();
                cmd.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
                cmd.Dispose();
            }
            return caja;
        }

        public DataSet GetCajas(string buscar)
        {
            string query;
            if (string.IsNullOrEmpty(buscar))
            {
                 query = @"sp_get_cajas";
            }
            else
            {
                query = @"select Cajas.Caja_ID, Cajas.Fecha, Cajas.Importe_Inicial, Cajas.Importe_Final, Personas.Nombre
                        from Cajas
                        inner join Empleados
                        on Empleados.Empleado_ID = Cajas.Empleado_ID
                        inner join Personas
                        on Empleados.Persona_ID = Personas.Persona_ID
                        where Cajas.Caja_ID like @Parametro
                        or Cajas.Fecha like @Parametro
                        or Cajas.Importe_Inicial like @Parametro
                        or Cajas.Importe_Final like @Parametro
                        or Personas.Nombre like @Parametro
                        order by Cajas.Fecha desc"
                ;                
            }
            SqlCommand cmd = new SqlCommand(query, conexion)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Parametro",
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

        #endregion

        #region Detalles de Caja

        #endregion

        #region Cuotas de facturación

        #endregion
    }
}
