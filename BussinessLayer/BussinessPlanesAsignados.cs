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
        public DataTable VerClasesQueTieneElCliente(Planes_Asignados planesAsignados)
        {
            return _dataPlanesAsignados.VerClasesQueTieneElCliente(planesAsignados);
        }

        public int AsginarPlanAlCliente(Planes_Asignados planes_Asignados)
        {
            return _dataPlanesAsignados.AsginarPlanAlCliente(planes_Asignados);
        }

        public int EliminarAsignacion(Planes_Asignados planes_Asignados, string nombrePlan)
        {
            return _dataPlanesAsignados.EliminarAsignacion(planes_Asignados, nombrePlan);
        }

        public DataSet BuscarPlanesAsignados(int Cliente_ID)
        {
            return _dataPlanesAsignados.BuscarPlanesAsignados(Cliente_ID);
        }

        public DataTable BuscarPlanesAsignadosParaPagar(int cliente_ID)
        {
            throw new NotImplementedException();
        }

        public bool BuscarDuplicidad(int idplan, int Cliente_ID)
        {
            var duplicidad = _dataPlanesAsignados.BuscarDuplicidad(idplan, Cliente_ID);
            return duplicidad;
        }
    }
}
