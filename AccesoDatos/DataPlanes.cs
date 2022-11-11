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
    public class DataPlanes : DataConnection
    {
        public DataTable GetPlanes(Planes planes)
        {
            string query = "sp_cargar_planes";

            SqlCommand cmd = new SqlCommand(query, conexion);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar tipos de documentos", e);
            }
            finally
            {
                conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
        public Planes GetDatoPlan(Planes planes)
        {
            string query = @"select Plan_ID, Importe_Plan, 
                                    Cupo_Total,
                                    Cupo_Restante
                                from Planes
                                where Estado = 'A'
                                and Plan_ID = @Plan_ID";

            SqlParameter plan_ID = new SqlParameter("@Plan_ID", planes.Plan_ID);
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(plan_ID);

            try
            {
                OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    planes.Plan_ID = int.Parse(reader["Plan_ID"].ToString());
                    planes.Importe_Plan = int.Parse(reader["Importe_Plan"].ToString());
                    if (string.IsNullOrEmpty(reader["Cupo_Total"].ToString()))
                    {
                        planes.Cupo_Total = 0;
                    }
                    else
                    {
                        planes.Cupo_Total = int.Parse(reader["Cupo_Total"].ToString());
                    }
                    if (string.IsNullOrEmpty(reader["Cupo_Restante"].ToString()))
                    {
                        planes.Cupo_Restante = 0;
                    }
                    else
                    {
                        planes.Cupo_Restante = int.Parse(reader["Cupo_Restante"].ToString());
                    }
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
            return planes;
        }
        public int RegistrarNuevoPlan(Planes planes)
        {
            int resultado = -1;
            string query = @"insert into Planes (Nombre,
                                                Importe_Plan,
                                                Duracion,
                                                Fecha_Inicio,
                                                Fecha_Alta_Plan,
                                                Cupo_Total,
                                                Estado,
                                                Persona_ID,
                                                Empleado_ID,
                                                Cupo_Restante)
                                        values (@Nombre, 
                                                @Importe_Plan, 
                                                @Duracion, 
                                                @Fecha_Inicio, 
                                                @Fecha_Alta_Plan, 
                                                @Cupo_Total, 
                                                @Estado, 
                                                @Persona_ID,
                                                @Empleado_ID,
                                                @Cupo_Restante)"
            ;

            SqlParameter nombre = new SqlParameter("@Nombre", planes.Nombre);
            SqlParameter importe_Plan = new SqlParameter("@Importe_Plan", planes.Importe_Plan);
            SqlParameter duracion = new SqlParameter("@Duracion", planes.Duracion);
            SqlParameter fecha_Inicio = new SqlParameter("@Fecha_Inicio", planes.Fecha_Inicio);
            SqlParameter fecha_Alta_Plan = new SqlParameter("@Fecha_Alta_Plan", planes.Fecha_Alta_Plan);
            SqlParameter cupo_Total = new SqlParameter("@Cupo_Total", planes.Cupo_Total);
            SqlParameter estado = new SqlParameter("@Estado", planes.Estado);
            SqlParameter persona_ID = new SqlParameter("@Persona_ID", planes.Persona_ID);
            SqlParameter cupo_Restante = new SqlParameter("@Cupo_Restante", planes.Cupo_Restante);
            SqlParameter empleado_ID = new SqlParameter("@Empleado_ID", planes.Empleado_ID);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(importe_Plan);
            cmd.Parameters.Add(duracion);
            cmd.Parameters.Add(fecha_Inicio);
            cmd.Parameters.Add(fecha_Alta_Plan);
            cmd.Parameters.Add(cupo_Total);
            cmd.Parameters.Add(estado);
            cmd.Parameters.Add(persona_ID);
            cmd.Parameters.Add(cupo_Restante);
            cmd.Parameters.Add(empleado_ID);

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
    }
}