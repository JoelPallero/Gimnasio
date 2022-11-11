using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entities;
using BussinessLayer;

namespace Gym
{
    public partial class MainForm : Form
    {
        #region Instancias

        //Clases internas
        MetodosGenerales _metodosGenerales;

        //Capa de Negocio
        private readonly BussinessPersonas _bussinessPersonas;
        private readonly BussinessRegistrosLogs _bussinesRegistrosLogs;

        //Entidades
        private Personas _personas;
        private readonly Entities.Empleados _empleados;
        private readonly Entities.Registros_Logs _registrosLogs;


        #endregion

        #region Variables
        private bool sesionJefeOn;
        private int personaLogueada;
        private int idRegistroLogin;

        #endregion

        #region Load
        public MainForm(bool mainJefe, int idPersonaLogin, int idLastLogin)
        {
            InitializeComponent();
            
            //inicializo los componentes del formulario, 
            //pero también todas las instancias de cada clase
            //que necesito utilizar a lo largo del form.
            _metodosGenerales = new MetodosGenerales();
            _personas = new Personas();
            _empleados = new Entities.Empleados();
            _bussinessPersonas = new BussinessPersonas();
            _bussinesRegistrosLogs = new BussinessRegistrosLogs();
            _registrosLogs = new Registros_Logs();

            //Estos argumentos que recibe el form, son los
            //que me dicen si el jefe es quien se logueó
            //y el Id de la persona que se logueó, para
            //poder utilizarlo luego.
            personaLogueada = idPersonaLogin;
            idRegistroLogin = idLastLogin;
            sesionJefeOn = mainJefe;
            if (sesionJefeOn)
            {
                btnConfiguracion.Visible = true;
            }
            else
            {
                btnConfiguracion.Visible = false;
            }
        }

        private void MainJefe_Load(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Close();
            AsignarNombre();
        }

        #endregion

        #region Metodos encapsulados

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //Registramos el logout en la bdd
            _registrosLogs.Empleado_ID = personaLogueada;
            _registrosLogs.Fecha_LogOut = DateTime.Now;
            _registrosLogs.Registro_Log_ID = idRegistroLogin;
            _bussinesRegistrosLogs.RegistrarLogOut(_registrosLogs);

            //deslogueamos la sesión abierta
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }
        private void AsignarNombre()
        {
            _metodosGenerales.GetPersona();
            lblBienvenido.Text = "Bienvenido " + _metodosGenerales.nombrePersona.ToString() + "!";
        }

        private void CallOfForms(object Hijo)
        {
            if (this.windowboxMain.Controls.Count > 0)
            {
                this.windowboxMain.Controls.RemoveAt(0);
            }

            Form formularioHijo = Hijo as Form;
            formularioHijo.TopLevel = false;
            this.windowboxMain.Controls.Add(formularioHijo);
            this.windowboxMain.Tag = formularioHijo;
            formularioHijo.Show();
        }

        #endregion

        #region Foco Menu

        private void FocusAsistencia()
        {
            focoAsistencia.Visible = true;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void FocusRegistro()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = true;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void FocusPagos()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = true;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void FocusPlanes()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = true;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void FocusCaja()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = true;
            focoEmpleados.Visible = false;
        }
        private void FocusEmpleados()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = true;
        }
        #endregion

        #region Cerrar y minimizar
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Arrastrar Form

        /* No he logrado encapsularlo en una clase separada*/

        //Se importan archivos DLL para poder realizar la captura de la acción del mouse
        //y poder arrastrar los formularios desde donde se realiza la captura

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleboxMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region Menu

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            CallOfForms(new Asistencias(personaLogueada));
            FocusAsistencia();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            CallOfForms(new Clientes(personaLogueada));
            FocusRegistro();
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            CallOfForms(new Pagos(personaLogueada));
            FocusPagos();
        }

        private void BtnPlanes_Click(object sender, EventArgs e)
        {
            CallOfForms(new Planes(personaLogueada));
            FocusPlanes();
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            CallOfForms(new Cajas(personaLogueada));
            FocusCaja();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            
            CallOfForms(new Empleados(personaLogueada));
            FocusEmpleados();
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            CallOfForms(new Configuracion(personaLogueada));
            FocusAsistencia();
        }

        #endregion
    }
}