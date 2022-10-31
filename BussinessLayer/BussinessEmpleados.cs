using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessEmpleados
    {
        private readonly DataEmpleados _dataEmpleados;
        public BussinessEmpleados()
        {
            _dataEmpleados = new DataEmpleados();
        }

        public int AltaEmpleado(Empleados empleados)
        {
            return _dataEmpleados.AltaEmpleado(empleados);
        }

        public Empleados GetLastID(Empleados empleados)
        {
            return _dataEmpleados.GetLastID(empleados);
        }
    }
}
