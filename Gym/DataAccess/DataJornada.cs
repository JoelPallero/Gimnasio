using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class DataJornada : DataConnection
    {

        public int CreatingJornadaUnica(Jornada _jornada)
        {
            int resultado = 0;

            string query = "insert into jornada (tipo_jornada) values (@tipo_jornada)";

            SqlParameter tipo_jornada = new SqlParameter("@tipo_jornada", _jornada.Tipo_Jornada);

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

        public int CreatingJornada(Jornada _jornada)
        {
            int resultado = 0;

            string query = "insert into jornada (lunes, martes, miercoles, jueves, viernes, sabado, tipo_jornada) " +
                "values (@lunes, @martes, @miercoles, @jueves, @viernes, @sabado, @tipo_jornada)";

            SqlParameter lunes = new SqlParameter("@lunes", _jornada.Lunes);
            SqlParameter martes = new SqlParameter("@martes", _jornada.Martes);
            SqlParameter miercoles = new SqlParameter("@miercoles", _jornada.Miercoles);
            SqlParameter jueves = new SqlParameter("@jueves", _jornada.Jueves);
            SqlParameter viernes = new SqlParameter("@viernes", _jornada.Viernes);
            SqlParameter sabado = new SqlParameter("@sabado", _jornada.Sabado);
            SqlParameter tipo_jornada = new SqlParameter("@tipo_jornada", _jornada.Tipo_Jornada);

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
