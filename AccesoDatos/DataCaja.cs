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
        /*Acá encontramos otro de los tipos de métodos para el CRUD con sql.
         Este es te dipo DATASET porque necesitamos hacer un estilo de matriz
        para poder luego acomodar los datos de este dataset en un datagridview 
        para que se puedan visualizar los datos encuadrados y ordenados*/
        public DataSet ConsultarSaldos(Detalles_Cajas _detalles_Cajas)
        {
            /*Vamos a realizar la consulta correspondiente, siempre con la parametrización*/
            string query = @"select sum(Importe_Ingreso) as Ingreso, sum(Importe_Egreso) as Egreso, sum(Importe_Ingreso - Importe_Egreso) as Total
                            From Detalles_Cajas
                            where Caja_ID = @Caja_ID"
            ;

            SqlParameter caja_ID = new SqlParameter("@Caja_ID", _detalles_Cajas.Caja_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(caja_ID);

            /*Vamos a crear un nuevo objeto tipo DataAdapter y otro tipo DataSet
             * El primero es para poder adaptar al DS los datos tal cual los solicitamos*/
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            try
            {
                /*Acá cambia ligeramente por el tipo de adaptación que debemos hacer
                 Como siempre abrimos la conexión*/
                OpenConnection();
                //ejecutamos el comando
                cmd.ExecuteNonQuery();
                /*Y el resultado se lo entregamos al DA
                 El cual luego, lo va a adaptar en el dataset*/
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
            // por último, retornamos el dataset.
            return ds;
        }

        public Cajas GetLastCajaID(Cajas caja)
        {
            string query = "sp_Get_Last_Caja_ID";

            SqlCommand cmd = new SqlCommand(query, conexion);
            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["Caja_ID"].ToString()))
                    {
                        caja.Caja_ID = int.Parse(reader["Caja_ID"].ToString());
                    }
                    else
                    {
                        caja.Caja_ID = -1;
                    }
                }
                reader.Close();
                cmd.ExecuteNonQuery();
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

        public bool CajaAbierta(DateTime Fecha)
        {
            bool cajaAbierta = true;

            string query = @"if exists (select max(Importe_Final) from Cajas 
                                where Importe_Final != null or Importe_Final != 0 
                                and Fecha = @Fecha)
                            begin
                                select max(Importe_Final) as Resultado from Cajas 
                                where Importe_Final != null or Importe_Final != 0 
                                and Fecha = @Fecha)
                            end"
            ;

            SqlParameter fecha = new SqlParameter("@Fecha", Fecha);
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(fecha);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //Si el importe aparece, significa que la ultima caja abierta
                    //está cerrada
                    if (reader["Resultado"].ToString() != null)
                    {
                        cajaAbierta = false;
                    }
                    else
                    {
                        cajaAbierta = true;
                    }
                }
                reader.Close();
                cmd.ExecuteNonQuery();
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
            return cajaAbierta;
        }

        public int AbrirCaja(Cajas caja)
        {
            /*Este método es tipo int. Ya lo vimos antes.*/
            int resultado = -1;
            string query = @"insert into Cajas values(@Empleado_ID_Apertura,
                                                      @Fecha, 
                                                      @Importe_Inicial)"
            ;

            SqlParameter empleado_Id = new SqlParameter("@Empleado_ID_Apertura", caja.Empleado_ID_Apertura);
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
            /*Siempre que el método sea un objeto de la entidad, solo vamos a poder traer 1 entidad por consulta
             Por lo que, al no ser muchos datos o una lista. Lo único que traemos acá es la consulta de 1 tabla
            Y solo 1 dato por propiedad de la entidad*/
            string query = @"sp_Get_Last_Caja_ID";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                /*Creamos un SQLDATAREADER que sirve para verificar si la consulta arroja resultados o no
                 En caso de que si, y se puedan verificar, se los asignamos a la propiedad correspondiente. 
                En este caso, hemos solicitado 1 solo ID.*/
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    caja.Caja_ID = int.Parse(reader["Caja_ID"].ToString());
                }
                
                //cerramos el reader y lo ejecutamos con el comando
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
            //devolvemos el objeto.
            return caja;
        }

        public DataSet GetDetallesCajas(string buscar)
        {
            /*Acá hay otro DataSet
             Este lo creamos de tal forma que podamos recibir un argumento que va a servir como parámetro de búsqueda
            Sería básicamente una manera de filtrar datos.
            Quitando eso, es lo mismo que el primero con un DataSet por lo que no cambia dsp de la query*/
            string query;
            if (string.IsNullOrEmpty(buscar))
            {
                 query = @"sp_get_cajas";
            }
            else
            {
                query = @"select Cajas.Caja_ID, Cajas.Fecha, Cajas.Importe_Inicial, Cajas.Importe_Final,
                            Detalles_Cajas.Importe_Ingreso, Detalles_Cajas.Importe_Egreso, Detalles_Cajas.Motivo, 
                            Personas.Apellido
                        from Detalles_Cajas
                        inner join Cajas
                            on Cajas.Caja_ID = Detalles_Cajas.Caja_ID
                        inner join Empleados
                            on Empleados.Empleado_ID = Detalles_Cajas.Empleado_ID
                        inner join Personas
                            on Personas.Persona_ID = Empleados.Persona_ID
                        where Cajas.Caja_ID like @Parametro 
                            or Cajas.Fecha like @Parametro
                            or Detalles_Cajas.Fecha = @Parametro
                            or Personas.Apellido like @Parametro
                            or Detalles_Cajas.Motivo like @Parametro
                        order by Fecha asc"
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
