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
    public class DataAsistencia : DataConnection
    {
        public int PutAsistencia(Asistencias _asistencias)
        {
            //A lo largo de todas las clases de este proyecto, se van a observar 4 tipos distintos de métodos
            //que sirven para el CRUD.
            //Este es el primero.
            //Siempre que sea un método tipo INT, se deducirá, de ahora en adelanta, que es un create o insert
            //para la base de datos.
            /*Se crea una variable tipo entero, con valor -1 porque necesito que me devuelve un 0 al finalizar la gestión
             Si no me devuelve un 0, es porque la gestión no se llevó a cabo.
            */
            int resultado = -1;

            //Query que se va a ejecutar en la bdd. En esta caso SQL.
            string query = @"insert into Asistencias (Cliente_ID, Fecha, Estado, Empleado_ID, Plan_Asignado_ID) 
                            values (@Cliente_ID, @Fecha, @Estado, @Empleado_ID, @Plan_Asignado_ID)";
            /*
             Se utilizan parámetros por seguridad. Ya que con parametrizaciones, evitamos problemas de injection.
             */
            SqlParameter cliente_ID = new SqlParameter("@Cliente_ID", _asistencias.Cliente_ID);
            SqlParameter fecha = new SqlParameter("@Fecha", _asistencias.Fecha);
            SqlParameter estado = new SqlParameter("@Estado", _asistencias.Estado);
            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", _asistencias.Empleado_ID);
            SqlParameter plan_Asignado_ID = new SqlParameter("@Plan_Asignado_ID", _asistencias.Plan_Asignado_ID);

            /*Creamos un ojeto de tipo SQLCOMMAND que es con el que vamos a realizar la inserción de la quer a 
             la bdd sql.*/
            SqlCommand cmd = new SqlCommand(query , conexion);
            /* A este mismo comando creado, le agregamos los parámetros que creamos arriba*/
            cmd.Parameters.Add(cliente_ID);
            cmd.Parameters.Add(fecha);
            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(empleado_ID);
            cmd.Parameters.Add(plan_Asignado_ID);

            /*Acá encerramos toda la consulta en un try catch por cualquier error que nos de*/
            try
            {
                //primero abrimos la conexión
                OpenConnection();

                //luego enviamos la consulta y el resultado se lo asignamos a la variable
                //tiene que devolver un 0, siempre y cuando todo haya salido OK.
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //Por último, tenemos este finally. Que se va a ejecutar, haya o no una exceptión encontrada
                CloseConnection();

                //Y cerraremos también el commando que enviamos, para que no haya futuros erroes
                cmd.Dispose();
            }

            //por último devovlermos el entero que necesitamos
            return resultado;
        }

        public DataSet GetAsistenciasDiarias(string buscar)
        {
            string query;
            if (string.IsNullOrEmpty(buscar))
            {
                query = @"sp_get_Asistencias_diarias";
            }
            else
            {
                query = @"select Clientes.Cliente_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_documento, Planes.Nombre, Asistencias.Estado
                            from Asistencias
                            inner join Clientes
                            on Clientes.Cliente_ID = Asistencias.Cliente_ID
                            inner join Personas
                            on Clientes.Persona_ID = Personas.Persona_ID
                            inner join Planes_Asignados
                            on Asistencias.Plan_Asignado_ID = Planes_Asignados.Plan_Asignado_ID
                            inner join Planes
                            on Planes.Plan_ID = Planes_Asignados.Plan_ID
                            where Personas.Nombre like @Parametro
                            or Personas.Apellido like @Parametro
                            or Asistencias.Fecha like @Parametro
                            or Planes.Nombre like @Parametro"
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
                throw new Exception("Error al listar asistencias", e);
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