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

        public Empleados GetLastID(int personaJor, Empleados empleados)
        {
            return _dataEmpleados.GetLastID(personaJor, empleados);
        }

        public DataSet GetEmpleados(string buscar)
        {
            return _dataEmpleados.GetEmpleados(buscar);
        }

        public Empleados GetTipoEmpleado(Empleados empleados)
        {
            return _dataEmpleados.GetTipoEmpleado(empleados);
        }

        public int EditarEmpleado(Empleados empleados)
        {
            return _dataEmpleados.EditarEmpleado(empleados);
        }

        public Empleados VerificarClaveEnBdd(Tipos_Empleados _tiposEmpleados, Empleados _empleados)
        {
            return _dataEmpleados.VerificarClaveEnBdd(_tiposEmpleados, _empleados);
        }

        public int EditarClave(Empleados empleados)
        {
            return _dataEmpleados.EditarClave(empleados);
        }

        public DataTable GetEstadosEmpleados(Tipos_Empleados _tiposEmpleados)
        {
            return _dataEmpleados.GetEstadosEmpleados(_tiposEmpleados);
        }

        public Empleados GetEmpleadoID(Empleados empleados)
        {
            return _dataEmpleados.GetEmleadoID(empleados);
        }

        public Empleados GetLastEmpleado(int personaId, Empleados empleados)
        {
            return _dataEmpleados.GetLastEmpleado(personaId, empleados);
        }

        public bool ConsultarRegistrosLogin(bool primerLogueo)
        {
            bool resultado = _dataEmpleados.ConsultarRegistrosLogin(primerLogueo);
            return resultado;
        }
    }
}