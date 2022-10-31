using BussinessLayer;
using Entities;
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
        private readonly BussinessPersonas _bussinessPersonas;
        private Personas _personas;
        private Entities.Empleados _empleados;

        #endregion

        public MetodosGenerales()
        {
            _bussinessTipo = new BussinessTipo();
            _bussinessEmpleados = new BussinessEmpleados();
            _empleados = new Entities.Empleados();
            _bussinessPersonas = new BussinessPersonas();
            _personas = new Personas();
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
        public int persona_ID;


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

        #region Personas

        public void AltaPersona(string Nombre,
                                string Apellido,
                                int Tipo_Documento_ID,
                                string Nro_documento,
                                int Tipo_Sexo_ID,
                                string Nro_Telefono,
                                string Nro_Alternativo,
                                string Mail,
                                string Observaciones)
        {
            _personas.Nombre = Nombre;
            _personas.Apellido = Apellido;
            _personas.Tipo_Documento_ID = Tipo_Documento_ID;
            _personas.Nro_documento = Nro_documento;
            _personas.Tipo_Sexo_ID = Tipo_Sexo_ID;
            _personas.Nro_Telefono = Nro_Telefono;
            _personas.Nro_Alternativo = Nro_Alternativo;
            _personas.Mail = Mail;
            _personas.Observaciones = Observaciones;
            _bussinessPersonas.AltaPersona(_personas);

            //Una vez registrada esta nueva persona, consulto su ID
            //Ya que el sistema lo necesita para, dar de alta al empleado
            //o al cliente.
            _personas = _bussinessPersonas.Get_Last_Id_Persona(_personas);
            persona_ID = _personas.Persona_ID;

        }

        public void Get_Last_Id_Empleado()
        {
            _empleados = _bussinessEmpleados.GetLastID(_empleados);
            empleado_ID = _empleados.Empleado_ID;
        }

        #endregion

    }
}
