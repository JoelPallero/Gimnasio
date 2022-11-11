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

        //public DataPlanes GetPlanAsignado(DataPlanes )
        //{
        //    string query = @"select Planes.Nombre, Planes.Importe_Plan, Clientes.Cliente_ID
        //                    from Planes
        //                    inner join Planes_Asignados
        //                    on Planes_Asignados.Plan_ID = Planes.Plan_ID
        //                    inner join Clientes
        //                    on Clientes.Cliente_ID = Planes_Asignados.Cliente_ID
        //                    inner join Facturas_Clientes
        //                    on Facturas_Clientes.Plan_Asignado_ID = Planes_Asignados.Plan_Asignado_ID
        //                    where Clientes.Cliente_ID = @Cliente_ID"
        //    ;

        //    SqlParameter cliente_Id = new SqlParameter("@Cliente_ID", DataPersonas.Cliente_ID);


        //}

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
    }
}