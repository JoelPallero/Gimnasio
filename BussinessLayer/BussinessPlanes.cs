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

        public DataTable GetPlanesParaAsistencia(Planes planes, string diaDeLaSemana)
        {
            DataTable dt = _dataPlanes.GetPlanesParaAsistencia(planes, diaDeLaSemana);
            return dt;
        }

        public DataTable GetPlanesConFecha(Planes planes, string diaDeLaSemana, string fecha)
        {
            DataTable dt = _dataPlanes.GetPlanesConFecha(planes, diaDeLaSemana, fecha);
            return dt;
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

        public DataTable GetAlumnoPorClase(Planes planes, string diaDeLaSemana)
        {
            return _dataPlanes.GetAlumnoPorClase(planes, diaDeLaSemana);
        }

        public DataTable GetAlumnoPresentes(Planes planes, string fechaPresente)
        {
            return _dataPlanes.GetAlumnoPresentes(planes, fechaPresente);
        }
    }
}