using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessJornadas
    {
        #region Instancias
        private readonly DataJornadas _dataJornadas;

        #endregion

        public BussinessJornadas()
        {
            _dataJornadas = new DataJornadas();
        }

        #region Jornada de planes

        public DataTable GetJornadaPlan(Jornadas_Planes jornadas_Planes)
        {
            return _dataJornadas.GetJornadaPlan(jornadas_Planes);
        }

        public int AltaJornadaPlan(Jornadas_Planes jornadas_Planes)
        {
            return _dataJornadas.AltaJornadaPlan(jornadas_Planes);
        }

        public int EditarJornadaPlan(Jornadas_Planes jornadas_Planes)
        {
            return _dataJornadas.EditarJornadaPlan(jornadas_Planes);
        }
        public int EliminarJornadaPlan(int jornadaID)
        {
            return _dataJornadas.EliminarJornadaPlan(jornadaID);
        }

        #endregion

        #region Jornadas de Empleados

        public int AltaJornadaEmpleados(Jornadas_Empleados jornadaEmpleado)
        {
            return _dataJornadas.AltaJornadaEmpleados(jornadaEmpleado);
        }

        public DataTable GetJornadaEmpleado(Jornadas_Empleados jornadas_Empleados)
        {
            return _dataJornadas.GetJornadaEmpleado(jornadas_Empleados);
        }
        public int EliminarJornadaEmpleado(int JornadaID)
        {
            return _dataJornadas.EliminarJornadaEmpleado(JornadaID);
        }

        public int EditarJornadaEmpleado(Jornadas_Empleados jornadas_Empleados)
        {
            return _dataJornadas.EditarJornadaEmpleado(jornadas_Empleados);
        }

        #endregion

        #region General


        #endregion
    }
}
