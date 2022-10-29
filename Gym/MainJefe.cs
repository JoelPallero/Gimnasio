using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class MainJefe : Form
    {
        #region Call of Class

        MetodosGenerales _metodosGenerales = new MetodosGenerales();

        #endregion
        public MainJefe()
        {
            InitializeComponent();
        }

        #region Variables

        private bool menuConfigAbierto = false;

        #endregion

        #region Call of Forms

        private void CallOfForms(object Hijo)
        {
            if (this.windowbox.Controls.Count > 0)
            {
                this.windowbox.Controls.RemoveAt(0);
            }

            Form formularioHijo = Hijo as Form;
            formularioHijo.TopLevel = false;
            this.windowbox.Controls.Add(formularioHijo);
            this.windowbox.Tag = formularioHijo;
            formularioHijo.Show();
        }

        #endregion

        #region Foco Menu

        private void focusAsistencia()
        {
            focoAsistencia.Visible = true;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
        }
        private void focusRegistro()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = true;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
        }
        private void focusPagos()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = true;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
        }
        private void focusPlanes()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = true;
            focoCaja.Visible = false;
        }
        private void focusCaja()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = true;
        }

        private void quitarFoco()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
        }
        #endregion

        #region Menu Buttons
        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            CallOfForms(new Asistencias());
            focusAsistencia();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CallOfForms(new Clientes());
            focusRegistro();
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            CallOfForms(new Pagos());
            focusPagos();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            CallOfForms(new Planes());
            focusPlanes();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            CallOfForms(new Cajas());
            focusCaja();
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (!menuConfigAbierto)
            {
                CallOfForms(new Configuracion());
                quitarFoco();
                QuitarMenuConfig();
            }
        }

        private void QuitarMenuConfig()
        {
            if (menuConfigAbierto)
            {
                menuConfigAbierto = false;
            }
            else
            {
                menuConfigAbierto = true;
            }
        }

        #endregion

        #region Form Buttons

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_metodosGenerales.CajaAbierta == false) //Si la caja no está abierta, entonces aún no se abrió o ya se cerró
            {
                //deslogueamos la sesión abierta
                this.Close();
                Login frm = new Login();
                frm.Show();
            }
            else
            {
                //Si la caja está abierta, no se puede cerrar sesión hasta cerrar la caja primero.
                Cajas _caja = new Cajas();
                _caja.Show();
            }
        }
        #endregion

        #region Arrastrar Form

        //Se importan archivos DLL para poder realizar la captura de la acción del mouse
        //y poder arrastrar los formularios desde donde se realiza la captura

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlebox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

    }
}