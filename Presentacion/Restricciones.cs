using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Restricciones
    {
        //Vamos a encapsular las restricciones de cada textbox
        //para que sean comunes a todas las plantillas y solo
        //se acceda a la clase.

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

            //prohibir caracteres especiales
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (strTexto.Contains("/") ||
                         strTexto.Contains("*") ||
                         strTexto.Contains("-"))
                {
                    e.Handled = true;
                }
                else if (strTexto.Contains(",")
                    || strTexto.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }

            //simbolos tambien
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            // no puede haber espacios en blanco
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                //con esto se desactivan todas las otras teclas no contempladas en las líneas anteriores
                e.Handled = true;
            }
        }

        //realizar el método con variables globales para que quede guardada en las variables
        //los datos del usuario que tiene la sesión iniciada en este programa.
        //
    }
}