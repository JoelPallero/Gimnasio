using AccesoDatos;
using System;
using System.Collections.Generic;
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

        //public BussinessPlanes GetPlanAsignado(BussinessPlanes _planes)
        //{
        //    return _dataPlanes.GetPlanAsignado(_planes);
        //}
    }
}
