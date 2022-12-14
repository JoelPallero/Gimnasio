﻿using Entities;
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
        public SaldosActualizados ConsultarSaldos(Detalles_Cajas _detalles_Cajas, SaldosActualizados saldos)
        {
            /*Vamos a realizar la consulta correspondiente, siempre con la parametrización*/
            string query = @"sp_Calcular_Importes @Caja_ID";

            SqlParameter caja_ID = new SqlParameter("@Caja_ID", _detalles_Cajas.Caja_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(caja_ID);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    saldos.Importe_Inicial = decimal.Parse(reader["Importe_Apertura"].ToString());
                    saldos.Importe_Ingreso = decimal.Parse(reader["Importe_Ingreso"].ToString());
                    saldos.Importe_Egreso = decimal.Parse(reader["Importe_Egreso"].ToString());
                    saldos.Total = decimal.Parse(reader["Total"].ToString()) + saldos.Importe_Inicial;
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

            return saldos;
        }

        public int CerrarCaja(Cajas caja)
        {
            int resultado = -1;
            string query = @"sp_Cerrar_Caja @Empleado_ID_Cierre, @Fecha_Cierre, @Importe_Cierre, @Caja_ID, @Caja_Abierta";

            SqlParameter estado = new SqlParameter("@Empleado_ID_Cierre", caja.Empleado_ID_Cierre);
            SqlParameter fecha_Cierre = new SqlParameter("@Fecha_Cierre", caja.Fecha_Cierre);
            SqlParameter Importe_Cierre = new SqlParameter("@Importe_Cierre", caja.Importe_Cierre);
            SqlParameter caja_ID = new SqlParameter("@Caja_ID", caja.Caja_ID);
            SqlParameter caja_Abierta = new SqlParameter("@Caja_Abierta", caja.Caja_Abierta);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(fecha_Cierre);
            cmd.Parameters.Add(Importe_Cierre);
            cmd.Parameters.Add(caja_ID);
            cmd.Parameters.Add(caja_Abierta);

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

        public Cajas GetLastCajaID(Cajas caja)
        {
            string query = "exec sp_Get_Last_Caja_ID";

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
            bool cajaAbierta = false;

            string query = @"select Caja_Abierta from Cajas where Caja_ID = (select max(Caja_ID) from Cajas)";
           
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //Si el importe aparece, significa que la ultima caja abierta
                    //está cerrada
                    bool resultado = Convert.ToBoolean(reader["Caja_Abierta"]);
                    if (resultado)
                    {
                        cajaAbierta = true;
                    }
                    else
                    {
                        cajaAbierta = false;
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
            string query = @"exec sp_abrir_caja @Empleado_ID_Apertura, @Fecha, @Importe_Apertura, @Caja_Abierta";

            SqlParameter empleado_Id = new SqlParameter("@Empleado_ID_Apertura", caja.Empleado_ID_Apertura);
            SqlParameter fecha = new SqlParameter("@Fecha", caja.Fecha_Apertura);
            SqlParameter importe_Apertura = new SqlParameter("@Importe_Apertura", caja.Importe_Apertura);
            SqlParameter caja_Abierta = new SqlParameter("@Caja_Abierta", caja.Caja_Abierta);
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            
            cmd.Parameters.Add(empleado_Id);
            cmd.Parameters.Add(fecha);
            cmd.Parameters.Add(importe_Apertura);
            cmd.Parameters.Add(caja_Abierta);

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
            string query = @"select max(Caja_ID) as Caja_ID from Cajas";

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
                query = @"sp_GetCajas_Y_Detalles @Parametro";                
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
    }
}