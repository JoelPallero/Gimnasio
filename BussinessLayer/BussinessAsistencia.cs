using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entities;

namespace BussinessLayer
{
    public class BussinessAsistencia
    {
        private readonly DataAsistencia _dataAsistencia;
        public BussinessAsistencia()
        {
            _dataAsistencia = new DataAsistencia();
        }

        public int PutAsistencia(Asistencias asistencias)
        {
            return _dataAsistencia.PutAsistencia(asistencias);
        }
    }
}
