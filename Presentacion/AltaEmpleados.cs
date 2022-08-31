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

namespace Presentacion
{
    public partial class AltaEmpleados : Form
    {
        #region llamada a las entidades
        empleados _empleado;
        login_empleado _login_Empleado;
        jornada _jornada;
        Tipo_Documento _tipo_documento;
        tipo_empleado _tipo_empleado;
        

        #endregion
        public AltaEmpleados()
        {
            InitializeComponent();
            _empleado = new empleados();
            _login_Empleado = new login_empleado();
            _jornada = new jornada();
            _tipo_documento = new Tipo_Documento();
            _tipo_empleado = new tipo_empleado();
        }

        #region Encapsulamiento de Métodos generales

        private void All()
        {
            foreach (CheckBox item in gbJournalTIme.Controls)
            {

            }
        }

        private void CrearLogin()
        {
            _login_Empleado.usuario = txtDocument.Text;
            _login_Empleado.clave = "emp" + txtDocument.Text;
            _login_Empleado.estado_login = 1; //1 es vigente y 2 es baja (dado de baja del sistema)

            
        }

        #endregion

        #region Save Empleado
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {

            //Primero necesito crear el login
            //Sin el ID del login, no puedo registrar
            //nada por la restricción del not null.

            CrearLogin();

            //Crear la jornada asignada al empleado

            //luego guardar el resto de datos.

            _empleado.nombre = txtName.Text;
            _empleado.tipo_documento_id = cmbTipoDocumento.SelectedIndex + 1;
            _empleado.num_dni = txtDocument.Text;
            _empleado.telefono = txtPhone.Text;
            if (!string.IsNullOrEmpty(txtAlternative.Text))
            {
                _empleado.alternativo = txtAlternative.Text;
            }
            if (!string.IsNullOrEmpty(txtcomments.Text))
            {
                _empleado.observaciones = txtcomments.Text;
            }
            _empleado.mail = txtMail.Text;
            _empleado.tipo_empleado_id = cmbTipoEmployee.SelectedIndex;
        }


        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            All();
        }

        #endregion


    }
}
