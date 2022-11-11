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
    public class BussinessPlanesAsignados
    {
        private readonly DataPlanesAsignados _dataPlanesAsignados;
        public BussinessPlanesAsignados()
        {
            _dataPlanesAsignados = new DataPlanesAsignados();
        }
        public DataSet VerClasesQueTieneElCliente(Planes_Asignados planesAsignados)
        {
            return _dataPlanesAsignados.VerClasesQueTieneElCliente(planesAsignados);
        }

    }
}
