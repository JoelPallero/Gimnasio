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

        //public BussinessPlanes GetPlanAsignado(BussinessPlanes _planes)
        //{
        //    return _dataPlanes.GetPlanAsignado(_planes);
        //}
    }
}
