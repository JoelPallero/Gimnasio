using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Planes : Form
    {
        #region Instancias
        //Capa de negocio
        private readonly BussinessPersonas _bussinesPersonas;
        private readonly BussinessPlanes _bussinessPlanes;

        //Entidades
        private Entities.Planes _planes;
        private Entities.Clientes _clientes;
        private Planes_Asignados _planes_Asignados;
        private Personas _personas;


        //Clases internas
        private readonly MetodosGenerales _metodosGenerales;
        private readonly Restricciones _restricciones;

        #endregion

        #region Loading
        public Planes(int idPersonaLog)
        {
            InitializeComponent();
            personaLogueada = idPersonaLog;
            _bussinesPersonas = new BussinessPersonas();
            _bussinessPlanes = new BussinessPlanes();
            _planes = new Entities.Planes();
            _clientes = new Entities.Clientes();
            _planes_Asignados = new Planes_Asignados();
            _metodosGenerales = new MetodosGenerales();
            _restricciones = new Restricciones();
            _personas = new Personas();
        }

        #endregion

        #region Variables
        private int personaLogueada;
        private string buscar;

        #endregion

        #region Encapsulamiento

        #endregion

        #region Eventos Keypress

        #endregion

        #region Alta de Planes

        #endregion

        #region Asignación de planes a un cliente

        #endregion

        private void MostrarCliente()
        {

        }
        private void TxtDatoClientePlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar = txtBuscarCliente.Text;
                if (!string.IsNullOrEmpty(buscar))
                {
                    _bussinesPersonas.GetPersonaPlan(buscar, _personas);
                    MostrarCliente();
                    //_bussinessPlanes.GetPlanAsignado(_planes);

                }
            }
        }
    }
}
