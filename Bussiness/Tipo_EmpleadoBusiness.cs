using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Tipo_EmpleadoBusiness
    {
        private DataTipoEmpleado _dataTipoEmpleado;


        public Tipo_EmpleadoBusiness()
        {
            _dataTipoEmpleado = new DataTipoEmpleado();
        }

        public DataSet BringTipo()
        {
            return _dataTipoEmpleado.BringTipoEmpleado();
        }
    }
}
