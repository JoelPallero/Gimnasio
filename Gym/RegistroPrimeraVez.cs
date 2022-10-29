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
    public partial class RegistroPrimeraVez : Form
    {
        public RegistroPrimeraVez()
        {
            InitializeComponent();
        }

        #region Variables

        private bool camposVacíos = true;

        #endregion

        #region Métodos encapsulados

        private void VerificarCampos()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    //verificamos si algún txt está vacío
                    if (!string.IsNullOrEmpty(txt.Text))
                    {
                        camposVacíos = true;
                    }
                    else
                    {
                        camposVacíos = false;
                        break;
                    }

                }
            }
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void lblCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerificarCampos();
            if (!camposVacíos)
            {
                DialogResult cancelar = MessageBox.Show("Faltan campos sin rellenar. ¿Seguro que quiere cancelar la operación? s" +
                                                        "En caso de seguir con el formulario, presione Cancelar. Caso contrario, presione Aceptar",
                                                        "Datos incompletos", MessageBoxButtons.OKCancel);
                if (cancelar == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
