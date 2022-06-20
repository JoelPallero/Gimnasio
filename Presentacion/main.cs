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

namespace Presentacion
{
    public partial class main : Form
    {
        #region Call of Class

        commonClass _commonClass = new commonClass();

        #endregion
        public main()
        {
            InitializeComponent();            
        }

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

        private void focusAsistencia()
        {
            focoAsistencia.Visible = true;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void focusRegistro()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = true;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void focusPagos()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = true;
            focoPlanes.Visible = false;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void focusPlanes()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = true;
            focoCaja.Visible = false;
            focoEmpleados.Visible = false;
        }
        private void focusCaja()
        {
            focoAsistencia.Visible = false;
            focoRegistro.Visible = false;
            focoPagos.Visible = false;
            focoPlanes.Visible = false;
            focoCaja.Visible = true;
            focoEmpleados.Visible = false;
        }
        private void focusEmpleados()
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
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            btnclose.ForeColor = Color.White;
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.ForeColor = Color.Red;
        }
        private void btnminimize_MouseHover(object sender, EventArgs e)
        {
            btnminimize.ForeColor = Color.White;
        }

        private void btnminimize_MouseLeave(object sender, EventArgs e)
        {
            btnminimize.ForeColor = Color.Red;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_commonClass.CajaAbierta == false) //Si la caja no está abierta, entonces aún no se abrió o ya se cerró
            {
                //deslogueamos la sesión abierta
                this.Hide();
                login frm = new login();
                frm.Show();
            }
            else
            {
                //Si la caja está abierta, no se puede cerrar sesión hasta cerrar la caja primero.
                cerrarCaja _cerrarCaja = new cerrarCaja();
                _cerrarCaja.Show();
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
        private void titleboxMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region Menu

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            CallOfForms(new asistencia());
            focusAsistencia();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CallOfForms(new registro());
            focusRegistro();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            CallOfForms(new pagos());
            focusPagos();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            CallOfForms(new planes());
            focusPlanes();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            if (_commonClass.CajaAbierta == false)
            {
                caja _caja = new caja();
                _caja.Show();
            }
            else
            {
                cerrarCaja _cerrarCaja = new cerrarCaja();
                _cerrarCaja.Show();
            }
            focusCaja();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CallOfForms(new empleados());
            focusEmpleados();
        }

        #endregion

    }
}