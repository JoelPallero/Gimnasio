using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Tipo_documentoBusiness
    {
        private DataTipoDocumento _dataTipoDocumento;
        public Tipo_documentoBusiness()
        {
            _dataTipoDocumento = new DataTipoDocumento();
        }

        public DataSet BringTipoDocumento()
        {
            return _dataTipoDocumento.BringTipoDocumento();
        }
    }
}
