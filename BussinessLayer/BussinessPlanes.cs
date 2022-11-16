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
    public class BussinessPlanes
    {
        private readonly DataPlanes _dataPlanes;
        public BussinessPlanes()
        {
            _dataPlanes = new DataPlanes();
        }
        public DataTable GetPlanes(Planes planes)
        {
            return _dataPlanes.GetPlanes(planes);
        }
        public Planes GetDatoPlan(Planes planes)
        {
            return _dataPlanes.GetDatoPlan(planes);
        }
        public int RegistrarNuevoPlan(Planes planes)
        {
            return _dataPlanes.RegistrarNuevoPlan(planes);
        }

        public int EditarCupoRestante(Planes planes)
        {
            return _dataPlanes.EditarCupoRestante(planes);
        }

        public DataSet GetPlanesActuales(Planes planes, string buscar)
        {
            return _dataPlanes.GetPlanesActuales(planes, buscar);
        }

        public Planes GetLastID(Planes planes)
        {
            return _dataPlanes.GetLastID(planes);
        }
    }
}