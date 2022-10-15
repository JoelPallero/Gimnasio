using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DataJornada : DataConnection
    {

        public int CreatingJornadaUnica(jornada _jornada)
        {
            int resultado = 0;

            string query = "insert into jornada (tipo_jornada) values (@tipo_jornada)";

            SqlParameter tipo_jornada = new SqlParameter("@tipo_jornada", _jornada.tipo_jornada);

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.Add(tipo_jornada);


            try
            {
                conexion.Open();

                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear nueva jornada", e);
            }

            finally
            {
                conexion.Close();
                cmd.Dispose();
            }

            return resultado;
        }

        public int CreatingJornada(jornada _jornada)
        {
            int resultado = 0;

            string query = "insert into jornada (lunes, martes, miercoles, jueves, viernes, sabado, tipo_jornada) " +
                "values (@lunes, @martes, @miercoles, @jueves, @viernes, @sabado, @tipo_jornada)";

            SqlParameter lunes = new SqlParameter("@lunes", _jornada.lunes);
            SqlParameter martes = new SqlParameter("@martes", _jornada.martes);
            SqlParameter miercoles = new SqlParameter("@miercoles", _jornada.miercoles);
            SqlParameter jueves = new SqlParameter("@jueves", _jornada.jueves);
            SqlParameter viernes = new SqlParameter("@viernes", _jornada.viernes);
            SqlParameter sabado = new SqlParameter("@sabado", _jornada.sabado);
            SqlParameter tipo_jornada = new SqlParameter("@tipo_jornada", _jornada.tipo_jornada);

            SqlCommand cmd = new SqlCommand(query, conexion);
            
            cmd.Parameters.Add(lunes);
            cmd.Parameters.Add(martes);
            cmd.Parameters.Add(miercoles);
            cmd.Parameters.Add(jueves);
            cmd.Parameters.Add(viernes);
            cmd.Parameters.Add(sabado);
            cmd.Parameters.Add(tipo_jornada);

            try
            {
                conexion.Open();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear nueva jornada", e);
            }

            finally
            {
                conexion.Close();
                cmd.Dispose();
            }

            return resultado;            
        }
    }
}
