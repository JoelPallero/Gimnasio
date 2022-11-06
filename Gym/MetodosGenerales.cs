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

        //Entidades
        private Personas _personas;
        private Entities.Empleados _empleados;
        private Jornadas_Empleados _jornadas_Empleados;

        //Capa de negocio
        private BussinessTipo _bussinessTipo;
        private BussinessEmpleados _bussinessEmpleados;
        private readonly BussinessPersonas _bussinessPersonas;
        private readonly Tipos_Empleados _tiposEmpleados;
        private readonly BussinessJornadas _bussinessJornadas;

        #endregion

        public MetodosGenerales()
        {
            _bussinessTipo = new BussinessTipo();
            _bussinessEmpleados = new BussinessEmpleados();
            _empleados = new Entities.Empleados();
            _bussinessPersonas = new BussinessPersonas();
            _personas = new Personas();
            _tiposEmpleados = new Tipos_Empleados();
            _jornadas_Empleados = new Jornadas_Empleados();
            _bussinessJornadas = new BussinessJornadas();
        }

        #region Variables
        //Esta variable me sirve para saber el id del empleado que tiene abierta
        //su sesión en el programa
        public int usuarioOpenID;
        public int personaOpenID;
        public string nombrePersona;
        public bool CargarJornada = false;
        public int empleadoID;
        public int personaID;

        //resto de variables
        public bool CajaAbierta = true;
        public DataTable DtTipos_Documentos = new DataTable();
        public DataTable DtTipos_Sexos = new DataTable();
        public DataTable DtTipos_Empleados = new DataTable();
        public DataTable DtEstados_Empleados = new DataTable();
        public DataTable DtJornadas = new DataTable();
        public int empleado_ID;
        public int persona_ID;
        public string apellidoNombrePersona;
        public string tipoNumDocumentoPersona;
        public string estadoPersonaPersona;


        #endregion

        #region Jornadas
        public void GetJornadaEmpleado()
        {
            DtJornadas = _bussinessJornadas.GetJornadaEmpleado(_jornadas_Empleados, empleadoID);
        }

        #endregion

        #region Planes

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
                                string Observaciones,
                                DateTime FechaAlta)
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
            _personas.Fecha_Alta = FechaAlta;
            _bussinessPersonas.AltaPersona(_personas);

            //Una vez registrada esta nueva persona, consulto su ID
            //Ya que el sistema lo necesita para, dar de alta al empleado
            //o al cliente.

            GetLastID();
        }

        public void AltaJefe(string Nombre,
                                string Apellido,
                                int Tipo_Documento_ID,
                                string Nro_documento,
                                int Tipo_Sexo_ID,
                                string Nro_Telefono,
                                string Mail,
                                DateTime FechaAlta)
        {
            _personas.Nombre = Nombre;
            _personas.Apellido = Apellido;
            _personas.Tipo_Documento_ID = Tipo_Documento_ID;
            _personas.Nro_documento = Nro_documento;
            _personas.Tipo_Sexo_ID = Tipo_Sexo_ID;
            _personas.Nro_Telefono = Nro_Telefono;
            _personas.Mail = Mail;
            _personas.Fecha_Alta = FechaAlta;

            //Una vez registrada esta nueva persona, consulto su ID
            //Ya que el sistema lo necesita para, dar de alta al empleado
            //o al cliente.

            GetLastID();
        }

        public void GetLastID()
        {
            _personas = _bussinessPersonas.Get_Last_Id_Persona(_personas);
            persona_ID = _personas.Persona_ID;
        }

        public void EditarPersona(int Persona_ID, string Nombre,
                                string Apellido,
                                int Tipo_Documento_ID,
                                string Nro_documento,
                                int Tipo_Sexo_ID,
                                string Nro_Telefono,
                                string Nro_Alternativo,
                                string Mail,
                                string Observaciones)
        {
            _personas.Persona_ID = Persona_ID;
            _personas.Nombre = Nombre;
            _personas.Apellido = Apellido;
            _personas.Tipo_Documento_ID = Tipo_Documento_ID;
            _personas.Nro_documento = Nro_documento;
            _personas.Tipo_Sexo_ID = Tipo_Sexo_ID;
            _personas.Nro_Telefono = Nro_Telefono;
            _personas.Nro_Alternativo = Nro_Alternativo;
            _personas.Mail = Mail;
            _personas.Observaciones = Observaciones;
            _bussinessPersonas.EditarPersona(_personas);
        }

        public void Get_Last_Id_Empleado()
        {
            _empleados = _bussinessEmpleados.GetLastID(_empleados);
            empleado_ID = _empleados.Empleado_ID;
        }

        public void GetPersona()
        {
            _personas = _bussinessPersonas.GetPersona(_personas);
            nombrePersona = _personas.Nombre;
            personaOpenID = _personas.Persona_ID;
        }

        #endregion

        public void GetEstadosEmpleados()
        {
            DtEstados_Empleados = _bussinessEmpleados.GetEstadosEmpleados(_tiposEmpleados);
        }

        #region Jornadas

        public void EliminarJornada(int jornadaID)
        {
            
        }

        #endregion

    }
}
