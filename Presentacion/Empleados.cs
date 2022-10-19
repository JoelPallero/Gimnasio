using Bussiness;
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
    public partial class Empleados : Form
    {
        #region llamada a las entidades
        //entidades
        Empleado _empleado;
        Login_empleado _login_Empleado;
        Jornada _jornada;
        Tipo_Documento _tipo_documento;
        Tipo_empleado _tipo_empleado;
        Restricciones _restricciones;

        //Negocio

        private LoginBussinessLayer _loginBussinessLayer;
        private JornadaBusiness _jornadaBusiness;
        private Tipo_EmpleadoBusiness _tipo_EmpleadoBusiness;
        private Tipo_documentoBusiness _tipoDocumentoBusiness;
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
            _loginBussinessLayer = new();
            _jornadaBusiness = new();
            _tipo_EmpleadoBusiness = new();
            _tipoDocumentoBusiness = new();
            _tipo_empleado = new();
            _tipo_documento = new();
            _empleado = new();
            DsTipoEmpleados = new();
            DsTipoDocumento = new();

            //Inicializo los campos que necesito traer de la bdd
            CargarTipoEmpleado();
            CargarTipoDocumento();

        }

        #region Encapsulamiento de Métodos generales

        private void All()
        {
            if (ChkTodos.Checked == false)
            {
                foreach (Control chk in this.GbJornadaEmpleado.Controls)
                {
                    if (chk is CheckBox box)
                    {
                        CheckBox c;
                        c = box;
                        c.Checked = false;
                        HabilitarTxt();
                    }
                }
            }
            else
            {
                foreach (Control chk in this.GbJornadaEmpleado.Controls)
                {
                    if (chk is CheckBox box)
                    {
                        CheckBox c;
                        c = box;
                        c.Checked = true;
                        DeshabilitarTxt();
                    }
                }
            }
        }

        private void DeshabilitarTxt()
        {
            foreach (Control txt in this.GbJornadaEmpleado.Controls)
            {
                if (txt is TextBox box && txt != TxtDesdeLunes && txt != TxtHastaLunes)
                {
                    TextBox t;
                    t = box;
                    t.Enabled = false;
                }
            }
        }

        private void HabilitarTxt()
        {
            foreach (Control txt in this.GbJornadaEmpleado.Controls)
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
            _login_Empleado = new Login_empleado
            {
                usuario = txtDocument.Text,
                clave = "emp" + txtDocument.Text,
                estado_login = 1 //1 es vigente y 2 es baja (dado de baja del sistema)
            };

            _loginBussinessLayer.SaveLogin(_login_Empleado);

            //Ahora traemos el id de este login creado

            _loginBussinessLayer.ShowLastLogin(_login_Empleado);

            
        }


        private void RevisarChk()
        {
            foreach (Control chk in this.GbJornadaEmpleado.Controls)
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
                MessageBox.Show("No ha seleccionado los días. En caso de no ser específico, puede elegir 'Seleccionar todos'.","Opciones sin seleccionar",MessageBoxButtons.OK);
            }
        }

        private void CrearJornada()
        {
            _jornada = new Jornada();
            if (ChkTodos.Checked)
            {
                //voy a recorrer todos los textbox del control que los tiene
                //y ahí voy a verificar si hay horarios. Todos pueden ser null en la bdd
                //así que no importa si no tienen datos.
                bool empty = true;
                foreach (Control txt in this.GbJornadaEmpleado.Controls)
                {
                    if (txt is TextBox box)
                    {
                        TextBox t;
                        t = box;
                        if (string.IsNullOrEmpty(t.Text))
                        {
                            empty = true;
                        }
                        else
                        {
                            empty = false;
                        }
                    }
                }

                if (empty)
                {
                    _jornada.Tipo_Jornada = 3;
                }
                else
                {
                    _jornada.Todos = TxtDesdeLunes.Text + "a" + TxtHastaLunes.Text;
                    _jornada.Tipo_Jornada = 3;
                }
                _jornadaBusiness.CreateJornadaAll(_jornada);
            }
            else
            {
                bool txtVacio = true;
                foreach (Control txt in this.GbJornadaEmpleado.Controls)
                {
                    if (txt is TextBox box)
                    {
                        TextBox t;
                        t = box;
                        if (string.IsNullOrEmpty(t.Text))
                        {
                            txtVacio = true;
                        }
                        else
                        {
                            txtVacio = false;
                        }
                    }
                }

                if (txtVacio)
                {
                    MessageBox.Show("Si ha seleccionado varios días, es necesario que indique los horarios.", "Datos incompletos", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (Control chk in this.GbJornadaEmpleado.Controls)
                    {
                        if (chk is CheckBox box)
                        {
                            CheckBox c;
                            c = box;
                            if (c.Checked)
                            {
                                chkSelected[chkConteo] = c.Text;
                                chkConteo++;
                            }
                        }
                    }
                    if (chkConteo == 0)
                    {
                        MessageBox.Show("No ha seleccionado los días. En caso de no ser específico, puede elegir 'Seleccionar todos'.", "Opciones sin seleccionar", MessageBoxButtons.OK);
                    }
                    else
                    {
                        for (int i = 0; i < chkConteo; i++)
                        {
                            switch (chkSelected[i])
                            {
                                case "Lunes":
                                    if (chkSelected[i] == ChkLunes.Text
                                        && !string.IsNullOrEmpty(TxtDesdeLunes.Text)
                                        && !string.IsNullOrEmpty(TxtHastaLunes.Text))
                                    {
                                        _jornada.Lunes = TxtDesdeLunes.Text + " a " + TxtHastaLunes.Text;
                                    }
                                    else
                                    {
                                        _jornada.Lunes = "-";
                                    }
                                    break;
                                case "Martes":
                                    if (chkSelected[i] == ChkMartes.Text
                                        && !string.IsNullOrEmpty(TxtDesdeMartes.Text)
                                        && !string.IsNullOrEmpty(TxtHastaMartes.Text))
                                    {
                                        _jornada.Martes = TxtDesdeMartes.Text + " a " + TxtHastaMartes.Text;
                                    }
                                    else
                                    {
                                        _jornada.Martes = "-";
                                    }
                                    break;
                                case "Miércoles":
                                    if (chkSelected[i] == ChkMiercoles.Text
                                        && !string.IsNullOrEmpty(TxtDesdeMiercoles.Text)
                                        && !string.IsNullOrEmpty(TxtHastaMiercoles.Text))
                                    {
                                        _jornada.Miercoles = TxtDesdeMiercoles.Text + " a " + TxtHastaMiercoles.Text;
                                    }
                                    else
                                    {
                                        _jornada.Miercoles = "-";
                                    }
                                    break;
                                case "Jueves":
                                    if (chkSelected[i] == ChkJueves.Text
                                        && !string.IsNullOrEmpty(TxtDesdeJueves.Text)
                                        && !string.IsNullOrEmpty(TxtHastaJueves.Text))
                                    {
                                        _jornada.Jueves = TxtDesdeJueves.Text + " a " + TxtHastaJueves.Text;
                                    }
                                    else
                                    {
                                        _jornada.Jueves = "-";
                                    }
                                    break;
                                case "Viernes":
                                    if (chkSelected[i] == ChkViernes.Text
                                        && !string.IsNullOrEmpty(TxtDesdeViernes.Text)
                                        && !string.IsNullOrEmpty(TxtHastaViernes.Text))
                                    {
                                        _jornada.Viernes = TxtDesdeViernes.Text + " a " + TxtHastaViernes.Text;
                                    }
                                    else
                                    {
                                        _jornada.Viernes = "-";
                                    }
                                    break;
                                case "Sábado":
                                    if (chkSelected[i] == ChkSabado.Text
                                        && !string.IsNullOrEmpty(TxtDesdeSabado.Text)
                                        && !string.IsNullOrEmpty(TxtHastaSabado.Text))
                                    {
                                        _jornada.Sabado = TxtDesdeSabado.Text + " a " + TxtHastaSabado.Text;
                                    }
                                    else
                                    {
                                        _jornada.Sabado = "-";
                                    }
                                    break;
                            }
                        }
                        _jornadaBusiness.CreateJornada(_jornada);
                    }
                }                
            }            
        }

        private void CargarTipoEmpleado()
        {
            _tipo_empleado = new();
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
            //Primero necesito crear las tablas que necesitamos
            //para luego utilizarlas como claves foráneas en la tabla empleados

            //claves foráneas
            CrearLogin();
            _empleado.login_id = _login_Empleado.id;

            //Creamos y traemos el id del último login y lo asignamos
            RevisarChk();

            if (check > 0)
            {
                CrearJornada();


                //luego guardar el resto de datos.

                _empleado.nombre = TxtNombreEmpleado.Text;
                _empleado.tipo_documento_id = cmbTipoDocumentoEmpleado.SelectedIndex++;
                _empleado.num_dni = TxtDocument.Text;
                _empleado.telefono = TxtTelefonoEmpleado.Text;

                if (!string.IsNullOrEmpty(TxtAlternativoEmpleado.Text))
                {
                    _empleado.alternativo = TxtAlternativoEmpleado.Text;
                }

                _empleado.mail = TxtMailEmpleado.Text;

                if (!string.IsNullOrEmpty(TxtObservacionesEmpleado.Text))
                {
                    _empleado.observaciones = TxtObservacionesEmpleado.Text;
                }

                _empleado.tipo_empleado_id = CmbTipoEmpleado.SelectedIndex++;
                _empleado.estado_empleado_id = 1; //Siempre va a ser 1 al dar el alta.
                _empleado.jornada_id = _jornada.Id;
            }
        }


        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            All();
        }


        #endregion

        private void TxtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            string documento = TxtDocument.Text;
            _restricciones.SoloNumeros(sender, e, documento);
        }
    }
}
