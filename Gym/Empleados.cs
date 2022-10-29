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

namespace Gym
{
    public partial class Empleados : Form
    {
        #region llamada a las entidades
        //entidades
        private Entities.Empleados _empleados;
        private Registros_Logs _registroLogs;
        private Jornadas_Empleados _jornadas_Empleados;
        private Tipos_Documentos _tipos_documentos;
        private Tipos_Empleados _tipos_Empleados;
        private Restricciones _restricciones;

        //Negocio

        //private LoginBussinessLayer _loginBussinessLayer;
        //private JornadaBusiness _jornadaBusiness;
        //private Tipo_EmpleadoBusiness _tipo_EmpleadoBusiness;
        //private Tipo_documentoBusiness _tipoDocumentoBusiness;
        private DataSet DsTipoEmpleados;
        private DataSet DsTipoDocumento;


        #endregion

        #region variables

        int check = 0; //conteo de chk seleccionados
        String[] chkSelected = new string[6];
        int chkConteo = 0;

        #endregion
        public Empleados()
        {
            InitializeComponent();
            //_loginBussinessLayer = new();
            //_jornadaBusiness = new();
            //_tipo_EmpleadoBusiness = new();
            //_tipoDocumentoBusiness = new();
            //_registroLogs = new();
            //_tipos_documentos = new();
            //_empleados = new();
            //DsTipoEmpleados = new();
            //DsTipoDocumento = new();

            //Inicializo los campos que necesito traer de la bdd
            CargarTipoEmpleado();
            CargarTipoDocumento();

        }

        #region Encapsulamiento de Métodos generales

        private void All()
        {
            if (chkTodos.Checked == false)
            {
                foreach (Control chk in this.gbJornadaEmpleado.Controls)
                {
                    if (chk is CheckBox box)
                    {
                        CheckBox c;
                        c = box;
                        c.Checked = false;

                    }
                }
            }
            else
            {
                foreach (Control chk in this.gbJornadaEmpleado.Controls)
                {
                    if (chk is CheckBox box)
                    {
                        CheckBox c;
                        c = box;
                        c.Checked = true;
                    }
                }
            }
        }

        private void DeshabilitarTxt()
        {
            foreach (Control txt in this.gbJornadaEmpleado.Controls)
            {
                if (txt is TextBox box && txt != txtDesdeLunes && txt != txtHastaLunes)
                {
                    TextBox t;
                    t = box;
                    t.Enabled = false;
                }
            }
        }

        private void HabilitarTxt()
        {
            foreach (Control txt in this.gbJornadaEmpleado.Controls)
            {
                if (txt is TextBox box)
                {
                    TextBox t;
                    t = box;
                    t.Enabled = true;
                }
            }
        }
        private void CrearLogin()
        {
            //_login_Empleado = new Login_empleado
            //{
            //    usuario = txtDocument.Text,
            //    clave = "emp" + txtDocument.Text,
            //    estado_login = 1 //1 es vigente y 2 es baja (dado de baja del sistema)
            //};

            //_loginBussinessLayer.SaveLogin(_login_Empleado);

            ////Ahora traemos el id de este login creado

            //_loginBussinessLayer.ShowLastLogin(_login_Empleado);


        }


        private void RevisarChk()
        {
            foreach (Control chk in this.gbJornadaEmpleado.Controls)
            {
                if (chk is CheckBox box)
                {
                    CheckBox c;
                    c = box;
                    if (c.Checked)
                    {
                        check++;
                    }
                }
            }

            if (check == 0)
            {
                MessageBox.Show("No ha seleccionado los días. En caso de no ser específico, puede elegir 'Seleccionar todos'.", "Opciones sin seleccionar", MessageBoxButtons.OK);
            }
        }

        //private void CrearJornada()
        //{
        //    _jornada = new Jornada();
        //    if (chkTodos.Checked)
        //    {
        //        //voy a recorrer todos los textbox del control que los tiene
        //        //y ahí voy a verificar si hay horarios. Todos pueden ser null en la bdd
        //        //así que no importa si no tienen datos.
        //        bool empty = true;
        //        foreach (Control txt in this.gbJornadaEmpleado.Controls)
        //        {
        //            if (txt is TextBox box)
        //            {
        //                TextBox t;
        //                t = box;
        //                if (string.IsNullOrEmpty(t.Text))
        //                {
        //                    empty = true;
        //                }
        //                else
        //                {
        //                    empty = false;
        //                }
        //            }
        //        }

        //        if (empty)
        //        {
        //            _jornada.Tipo_Jornada = 3;
        //        }
        //        else
        //        {
        //            _jornada.Todos = txtDesdeLunes.Text + "a" + txtHastaLunes.Text;
        //            _jornada.Tipo_Jornada = 3;
        //        }
        //        _jornadaBusiness.CreateJornadaAll(_jornada);
        //    }
        //    else
        //    {
        //        bool txtVacio = true;
        //        foreach (Control txt in this.gbJornadaEmpleado.Controls)
        //        {
        //            if (txt is TextBox box)
        //            {
        //                TextBox t;
        //                t = box;
        //                if (string.IsNullOrEmpty(t.Text))
        //                {
        //                    txtVacio = true;
        //                }
        //                else
        //                {
        //                    txtVacio = false;
        //                }
        //            }
        //        }

        //        if (txtVacio)
        //        {
        //            MessageBox.Show("Si ha seleccionado varios días, es necesario que indique los horarios.", "Datos incompletos", MessageBoxButtons.OK);
        //        }
        //        else
        //        {
        //            foreach (Control chk in this.gbJornadaEmpleado.Controls)
        //            {
        //                if (chk is CheckBox box)
        //                {
        //                    CheckBox c;
        //                    c = box;
        //                    if (c.Checked)
        //                    {
        //                        chkSelected[chkConteo] = c.Text;
        //                        chkConteo++;
        //                    }
        //                }
        //            }
        //            if (chkConteo == 0)
        //            {
        //                MessageBox.Show("No ha seleccionado los días. En caso de no ser específico, puede elegir 'Seleccionar todos'.", "Opciones sin seleccionar", MessageBoxButtons.OK);
        //            }
        //            else
        //            {
        //                for (int i = 0; i < chkConteo; i++)
        //                {
        //                    switch (chkSelected[i])
        //                    {
        //                        case "Lunes":
        //                            if (chkSelected[i] == chkLunes.Text
        //                                && !string.IsNullOrEmpty(txtDesdeLunes.Text)
        //                                && !string.IsNullOrEmpty(txtHastaLunes.Text))
        //                            {
        //                                _jornada.Lunes = txtDesdeLunes.Text + " a " + txtHastaLunes.Text;
        //                            }
        //                            else
        //                            {
        //                                _jornada.Lunes = "-";
        //                            }
        //                            break;
        //                        case "Martes":
        //                            if (chkSelected[i] == chkMartes.Text
        //                                && !string.IsNullOrEmpty(txtDesdeMartes.Text)
        //                                && !string.IsNullOrEmpty(txtHastaMartes.Text))
        //                            {
        //                                _jornada.Martes = txtDesdeMartes.Text + " a " + txtHastaMartes.Text;
        //                            }
        //                            else
        //                            {
        //                                _jornada.Martes = "-";
        //                            }
        //                            break;
        //                        case "Miércoles":
        //                            if (chkSelected[i] == chkMiercoles.Text
        //                                && !string.IsNullOrEmpty(txtDesdeMiercoles.Text)
        //                                && !string.IsNullOrEmpty(txtHastaMiercoles.Text))
        //                            {
        //                                _jornada.Miercoles = txtDesdeMiercoles.Text + " a " + txtHastaMiercoles.Text;
        //                            }
        //                            else
        //                            {
        //                                _jornada.Miercoles = "-";
        //                            }
        //                            break;
        //                        case "Jueves":
        //                            if (chkSelected[i] == chkJueves.Text
        //                                && !string.IsNullOrEmpty(txtDesdeJueves.Text)
        //                                && !string.IsNullOrEmpty(txtHastaJueves.Text))
        //                            {
        //                                _jornada.Jueves = txtDesdeJueves.Text + " a " + txtHastaJueves.Text;
        //                            }
        //                            else
        //                            {
        //                                _jornada.Jueves = "-";
        //                            }
        //                            break;
        //                        case "Viernes":
        //                            if (chkSelected[i] == chkViernes.Text
        //                                && !string.IsNullOrEmpty(txtDesdeViernes.Text)
        //                                && !string.IsNullOrEmpty(txtHastaViernes.Text))
        //                            {
        //                                _jornada.Viernes = txtDesdeViernes.Text + " a " + txtHastaViernes.Text;
        //                            }
        //                            else
        //                            {
        //                                _jornada.Viernes = "-";
        //                            }
        //                            break;
        //                        case "Sábado":
        //                            if (chkSelected[i] == chkSabado.Text
        //                                && !string.IsNullOrEmpty(txtDesdeSabado.Text)
        //                                && !string.IsNullOrEmpty(txtHastaSabado.Text))
        //                            {
        //                                _jornada.Sabado = txtDesdeSabado.Text + " a " + txtHastaSabado.Text;
        //                            }
        //                            else
        //                            {
        //                                _jornada.Sabado = "-";
        //                            }
        //                            break;
        //                    }
        //                }
        //                _jornadaBusiness.CreateJornada(_jornada);
        //            }
        //        }                
        //    }            
        //}

        private void CargarTipoEmpleado()
        {
            //_tipo_empleado = new();
            //DsTipoEmpleados = _tipo_EmpleadoBusiness.BringTipo();

            //if (DsTipoEmpleados.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow dr in DsTipoEmpleados.Tables[0].Rows)
            //    {
            //        CmbTipoEmpleado.Items.Add(dr[1].ToString());
            //    }
            //}
        }

        private void CargarTipoDocumento()
        {
            //DsTipoDocumento = _tipoDocumentoBusiness.BringTipoDocumento();

            //if (DsTipoDocumento.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow dr in DsTipoDocumento.Tables[0].Rows)
            //    {
            //        cmbTipoDocumentoEmpleado.Items.Add(dr[1].ToString());
            //    }
            //}
        }



        #endregion

        #region Save Empleado
        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            ////Primero necesito crear las tablas que necesitamos
            ////para luego utilizarlas como claves foráneas en la tabla empleados

            ////claves foráneas
            //CrearLogin();
            //_empleado.login_id = _login_Empleado.id;

            ////Creamos y traemos el id del último login y lo asignamos
            //RevisarChk();

            //if (check > 0)
            //{
            //    CrearJornada();


            //    //luego guardar el resto de datos.

            //    _empleado.nombre = txtNombreEmpleado.Text;
            //    _empleado.tipo_documento_id = cmbTipoDocumentoEmpleado.SelectedIndex++;
            //    _empleado.num_dni = txtDocument.Text;
            //    _empleado.telefono = txtTelefonoEmpleados.Text;

            //    if (!string.IsNullOrEmpty(txtAlternativoEmpleados.Text))
            //    {
            //        _empleado.alternativo = txtAlternativoEmpleados.Text;
            //    }

            //    _empleado.mail = txtMailEmpleado.Text;

            //    if (!string.IsNullOrEmpty(txtObservacionesEmpleado.Text))
            //    {
            //        _empleado.observaciones = txtObservacionesEmpleado.Text;
            //    }

            //    _empleado.tipo_empleado_id = cmbTipoEmpleado.SelectedIndex++;
            //    _empleado.estado_empleado_id = 1; //Siempre va a ser 1 al dar el alta.
            //    _empleado.jornada_id = _jornada.Id;
            //}
        }


        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            All();
        }


        #endregion

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtDocument.Text;
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
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

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
    }
}
