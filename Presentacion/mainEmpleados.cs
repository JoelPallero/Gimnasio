using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class mainEmpleados : Form
    {
        #region Call of Class

        commonClass _commonClass = new commonClass();

        #endregion
        public mainEmpleados()
        {
            InitializeComponent();
        }

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

        #endregion

        #region Menu Buttons
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
            CallOfForms(new planesEmpleado());
            focusPlanes();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            CallOfForms(new caja());
            focusCaja();
        }

        #endregion

        #region Form Buttons

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
