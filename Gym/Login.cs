using System;
using System.Windows.Forms;

namespace Gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PrimerLogueo();
        }

        #region Variables

        private bool primerUsuario = false;

        #endregion

        #region Métodos encapsulados
        private void PrimerLogueo()
        {
            //Verificar si hay algún logín previo de JEFE (si o si).
            //Me devuelve en booleano la respuesta.

            /*Acá verifico si hay un login de jefe ya*/

            //vamos a realizar una acción distinta.
            if (primerUsuario)
            {
                lblGenerarPrimerUsuario.Visible = true;
            }
            else
            {
                lblGenerarPrimerUsuario.Visible = false;
            }
        }

        #endregion


        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void lblGenerarPrimerUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroPrimeraVez registroPrimeraVez = new RegistroPrimeraVez();
            registroPrimeraVez.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
