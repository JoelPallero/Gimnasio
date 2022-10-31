using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class MetodosGenerales
    {
        #region Instancias
        private BussinessTipo _bussinessTipo;
        private BussinessEmpleados _bussinessEmpleados;
        private Entities.Empleados _empleados;

        #endregion

        public MetodosGenerales()
        {
            _bussinessTipo = new BussinessTipo();
            _bussinessEmpleados = new BussinessEmpleados();
            _empleados = new Entities.Empleados();
        }

        #region Variables
        /*tareas*/

        //Asignar el ID del usuario´con el login abierto para utilizarlo
        //como huella en los distintos registros.

        public bool CajaAbierta = true;

        public DataTable DtTipos_Documentos = new DataTable();
        public DataTable DtTipos_Sexos = new DataTable();
        public DataTable DtTipos_Empleados = new DataTable();
        public int empleado_ID;


        #endregion




        #region Tipos de documento

        // Traeremos los tipos de documento
        public void Bring_Tipos_Documentos()
        {
            DtTipos_Documentos = _bussinessTipo.BringTipoDocumento();
        }

        #endregion

        #region Tipos de sexo

        // Traeremos los tipos de sexo
        public void Bring_Tipos_Sexos()
        {
            //Asignamos los dato de ese método de negocios
            //a una table que hemos creado al principio
            DtTipos_Sexos = _bussinessTipo.BringTipoSexo();
        }


        #endregion


        #region Tipos de Empleados
        public void Bring_Tipos_Empleados()
        {
            //Asignamos los dato de ese método de negocios
            //a una table que hemos creado al principio
            DtTipos_Empleados = _bussinessTipo.BringTipoEmpleado();
        }

        #endregion

        #region Empleados

        public void Bring_Last_ID()
        {
            _empleados = _bussinessEmpleados.GetLastID(_empleados);
            empleado_ID = _empleados.Empleado_ID;
        }

        #endregion

    }
}
