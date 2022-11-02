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

namespace Gym
{
    public partial class MainJefe : Form
    {
        #region Instancias

        MetodosGenerales _metodosGenerales;
        Empleados empleados;

        #endregion

        #region Load
        public MainJefe()
        {
            InitializeComponent();
            _metodosGenerales = new MetodosGenerales();
            empleados = new Empleados();
        }

        private void MainJefe_Load(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Close();
        }

        #endregion


        #region Call of Forms

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
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //deslogueamos la sesión abierta
            Login frm = new Login();
            this.Hide();
            frm.Show();

            if (_metodosGenerales.CajaAbierta == false) //Si la caja no está abierta, entonces aún no se abrió o ya se cerró
            {
                
            }
            else
            {
                //Si la caja está abierta, no se puede cerrar sesión hasta cerrar la caja primero.

            }
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
            //bool formIncompleto = false;
            //empleados.FormIncompleto(formIncompleto);
            //if (!formIncompleto)
            //{
            //}

            CallOfForms(new Asistencias());
            FocusAsistencia();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            CallOfForms(new Clientes());
            FocusRegistro();
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            CallOfForms(new Pagos());
            FocusPagos();
        }

        private void BtnPlanes_Click(object sender, EventArgs e)
        {
            CallOfForms(new Planes());
            FocusPlanes();
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            CallOfForms(new Cajas());
            FocusCaja();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            
            CallOfForms(new Empleados());
            FocusEmpleados();
        }

        #endregion

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

    }
}
