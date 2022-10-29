using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessTipos_Documentos
    {
        private DataTipos_Documentos _dataTipos_Documento;
        public BussinessTipos_Documentos()
        {
            _dataTipos_Documento = new DataTipos_Documentos();
        }

        public DataSet BringTipoDocumento()
        {
            return _dataTipos_Documento.BringTipoDocumento();
        }
    }
}
