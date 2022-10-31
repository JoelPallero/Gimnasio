using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessTipo
    {
        #region Tipos de documentos

        private DataTipos _dataTipos;
        public BussinessTipo()
        {
            _dataTipos = new DataTipos();
        }

        public DataTable BringTipoDocumento()
        {
            return _dataTipos.BringTipoDocumento();
        }

        #endregion

        #region Tipos de Sexo
        public DataTable BringTipoSexo()
        {
            return _dataTipos.BringTipoSexo();
        }

        public DataTable BringTipoEmpleado()
        {
            return _dataTipos.BringTipoEmpleado();
        }

        #endregion

        #region Tipos de Empleados

        #endregion

    }
}
