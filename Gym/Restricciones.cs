using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public class Restricciones
    {
        //Vamos a encapsular las restricciones de cada textbox
        //para que sean comunes a todas las plantillas y solo
        //se acceda a la clase.

        #region Variables globales

        #endregion


        //Solo se pueden ingresar números
        public void SoloNumeros(KeyPressEventArgs e, string strTexto)
        {
            //Solo se teclean los digitos
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //con esto se desactivan todas las otras teclas no contempladas en las líneas anteriores
                e.Handled = true;
            }
        }

        public void Horarios(KeyPressEventArgs e)
        {
            //Solo se teclean los digitos, los : y las teclas de retroceso, o controles.
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == 58 || e.KeyChar == (char)Keys.Back )
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
