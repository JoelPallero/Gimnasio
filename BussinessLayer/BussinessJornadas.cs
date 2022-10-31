using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
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

        #endregion

        #region Jornadas de Empleados

        public int AltaJornadaEmpleados(Jornadas_Empleados jornadaEmpleado)
        {
            return _dataJornadas.AltaJornadaEmpleados(jornadaEmpleado);
        }

        #endregion
    }
}
