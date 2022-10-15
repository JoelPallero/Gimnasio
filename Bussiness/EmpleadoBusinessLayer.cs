using Entities;
using System.Data;
using DataAccess;

namespace Bussiness
{
    public class EmpleadosBusinessLayer
    {
        private readonly DataEmpleado _dataEmpleado;

        public EmpleadosBusinessLayer()
        {
            _dataEmpleado = new DataEmpleado();
        }
        //public empleados CreatingEmployee(empleados _empleado)
        //{
        //    if (_empleado.id == 0)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}
    }
}
