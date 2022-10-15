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
    public partial class AltaEmpleados : Form
    {
        #region llamada a las entidades
        //entidades
        empleados _empleado;
        login_empleado _login_Empleado;
        jornada _jornada;
        Tipo_Documento _tipo_documento;
        tipo_empleado _tipo_empleado;

        //Negocio

        private loginBussinessLayer _loginBussinessLayer;
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
        public AltaEmpleados()
        {
            InitializeComponent();
            _loginBussinessLayer = new loginBussinessLayer();
            _jornadaBusiness = new JornadaBusiness();
            _tipo_EmpleadoBusiness = new Tipo_EmpleadoBusiness();
            _tipoDocumentoBusiness = new Tipo_documentoBusiness();
            _tipo_empleado = new tipo_empleado();
            _tipo_documento = new Tipo_Documento();
            DsTipoEmpleados = new DataSet();
            DsTipoDocumento = new DataSet();

            //Inicializo los campos que necesito traer de la bdd
            CargarTipoEmpleado();
            CargarTipoDocumento();

        }

        #region Encapsulamiento de Métodos generales

        private void All()
        {
            if (chkAll.Checked == false)
            {
                foreach (Control chk in this.gbJournalTIme.Controls)
                {
                    if (chk is CheckBox)
                    {
                        CheckBox c;
                        c = (CheckBox)chk;
                        c.Checked = false;
                        habilitarTxt();
                    }
                }
            }
            else
            {
                foreach (Control chk in this.gbJournalTIme.Controls)
                {
                    if (chk is CheckBox)
                    {
                        CheckBox c;
                        c = (CheckBox)chk;
                        c.Checked = true;
                        deshabilitarTxt();
                    }
                }
            }
        }

        private void deshabilitarTxt()
        {
            foreach (Control txt in this.gbJournalTIme.Controls)
            {
                if (txt is TextBox && txt != txtFromMonday && txt != txtToMonday)
                {
                    TextBox t;
                    t = (TextBox)txt;
                    t.Enabled = false;
                }
            }
        }

        private void habilitarTxt()
        {
            foreach (Control txt in this.gbJournalTIme.Controls)
            {
                if (txt is TextBox)
                {
                    TextBox t;
                    t = (TextBox)txt;
                    t.Enabled = true;
                }
            }
        }
        private void CrearLogin()
        {
            _login_Empleado = new login_empleado();
            _login_Empleado.usuario = txtDocument.Text;
            _login_Empleado.clave = "emp" + txtDocument.Text;
            _login_Empleado.estado_login = 1; //1 es vigente y 2 es baja (dado de baja del sistema)

            _loginBussinessLayer.SaveLogin(_login_Empleado);

            //Ahora traemos el id de este login creado

            _loginBussinessLayer.ShowLastLogin(_login_Empleado);

            
        }


        private void RevisarChk()
        {
            foreach (Control chk in this.gbJournalTIme.Controls)
            {
                if (chk is CheckBox)
                {
                    CheckBox c;
                    c = (CheckBox)chk;
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

        private void crearJornada()
        {
            _jornada = new jornada();
            if (chkAll.Checked)
            {
                //voy a recorrer todos los textbox del control que los tiene
                //y ahí voy a verificar si hay horarios. Todos pueden ser null en la bdd
                //así que no importa si no tienen datos.
                bool empty = true;
                foreach (Control txt in this.gbJournalTIme.Controls)
                {
                    if (txt is TextBox)
                    {
                        TextBox t;
                        t = (TextBox)txt;
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
                    _jornada.tipo_jornada = 3;
                }
                else
                {
                    _jornada.todos = txtFromMonday.Text + "a" + txtToMonday.Text;
                    _jornada.tipo_jornada = 3;
                }
                _jornadaBusiness.CreateJornadaAll(_jornada);
            }
            else
            {
                bool txtVacio = true;
                foreach (Control txt in this.gbJournalTIme.Controls)
                {
                    if (txt is TextBox)
                    {
                        TextBox t;
                        t = (TextBox)txt;
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
                    foreach (Control chk in this.gbJournalTIme.Controls)
                    {
                        if (chk is CheckBox)
                        {
                            CheckBox c;
                            c = (CheckBox)chk;
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
                                    if (chkSelected[i] == chkMonday.Text
                                        && !string.IsNullOrEmpty(txtFromMonday.Text)
                                        && !string.IsNullOrEmpty(txtToMonday.Text))
                                    {
                                        _jornada.lunes = txtFromMonday.Text + " a " + txtToMonday.Text;
                                    }
                                    else
                                    {
                                        _jornada.lunes = "-";
                                    }
                                    break;
                                case "Martes":
                                    if (chkSelected[i] == chkTuesday.Text
                                        && !string.IsNullOrEmpty(txtFromTuesday.Text)
                                        && !string.IsNullOrEmpty(txtToTuesday.Text))
                                    {
                                        _jornada.martes = txtFromTuesday.Text + " a " + txtToTuesday.Text;
                                    }
                                    else
                                    {
                                        _jornada.martes = "-";
                                    }
                                    break;
                                case "Miércoles":
                                    if (chkSelected[i] == chkWednesday.Text
                                        && !string.IsNullOrEmpty(txtFromWednesday.Text)
                                        && !string.IsNullOrEmpty(txtToWednesday.Text))
                                    {
                                        _jornada.miercoles = txtFromWednesday.Text + " a " + txtToWednesday.Text;
                                    }
                                    else
                                    {
                                        _jornada.miercoles = "-";
                                    }
                                    break;
                                case "Jueves":
                                    if (chkSelected[i] == chkThursday.Text
                                        && !string.IsNullOrEmpty(txtFromThursday.Text)
                                        && !string.IsNullOrEmpty(txtToThursday.Text))
                                    {
                                        _jornada.jueves = txtFromThursday.Text + " a " + txtToThursday.Text;
                                    }
                                    else
                                    {
                                        _jornada.jueves = "-";
                                    }
                                    break;
                                case "Viernes":
                                    if (chkSelected[i] == chkFriday.Text
                                        && !string.IsNullOrEmpty(txtFromFriday.Text)
                                        && !string.IsNullOrEmpty(txtToFriday.Text))
                                    {
                                        _jornada.viernes = txtFromFriday.Text + " a " + txtToFriday.Text;
                                    }
                                    else
                                    {
                                        _jornada.viernes = "-";
                                    }
                                    break;
                                case "Sábado":
                                    if (chkSelected[i] == chkSaturday.Text
                                        && !string.IsNullOrEmpty(txtFromSaturday.Text)
                                        && !string.IsNullOrEmpty(txtToSaturday.Text))
                                    {
                                        _jornada.sabado = txtFromSaturday.Text + " a " + txtToSaturday.Text;
                                    }
                                    else
                                    {
                                        _jornada.sabado = "-";
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
            _tipo_empleado = new tipo_empleado();
            DsTipoEmpleados = _tipo_EmpleadoBusiness.BringTipo();

            if (DsTipoEmpleados.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DsTipoEmpleados.Tables[0].Rows)
                {
                    cmbTipoEmployee.Items.Add(dr[1].ToString());
                }
            }
        }

        private void CargarTipoDocumento()
        {
            DsTipoDocumento = _tipoDocumentoBusiness.BringTipoDocumento();

            if (DsTipoDocumento.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DsTipoDocumento.Tables[0].Rows)
                {
                    cmbTipoDocumento.Items.Add(dr[1].ToString());
                }
            }
        }

        

        #endregion

        #region Save Empleado
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            _empleado = new empleados();
            //Primero necesito crear las tablas que necesitamos
            //para luego utilizarlas como claves foráneas en la tabla empleados

            //claves foráneas
            CrearLogin();
            _empleado.login_id = _login_Empleado.id;

            //Creamos y traemos el id del último login y lo asignamos
            RevisarChk();

            if (check > 0)
            {
                crearJornada();


                //luego guardar el resto de datos.

                _empleado.nombre = txtName.Text;
                _empleado.tipo_documento_id = cmbTipoDocumento.SelectedIndex++;
                _empleado.num_dni = txtDocument.Text;
                _empleado.telefono = txtPhone.Text;

                if (!string.IsNullOrEmpty(txtAlternative.Text))
                {
                    _empleado.alternativo = txtAlternative.Text;
                }

                _empleado.mail = txtMail.Text;

                if (!string.IsNullOrEmpty(txtcomments.Text))
                {
                    _empleado.observaciones = txtcomments.Text;
                }

                _empleado.tipo_empleado_id = cmbTipoEmployee.SelectedIndex++;
                _empleado.estado_empleado_id = 1; //Siempre va a ser 1 al dar el alta.
                _empleado.jornada_id = _jornada.id;
            }
        }


        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            All();
        }


        #endregion

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (txtDocument.Text.Contains("/") ||
                         txtDocument.Text.Contains("*") ||
                         txtDocument.Text.Contains("-"))
                {
                    e.Handled = true;
                }
                else if (txtDocument.Text.Contains(",") 
                    || txtDocument.Text.Contains("."))
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
