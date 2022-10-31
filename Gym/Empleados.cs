using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Empleados : Form
    {
        #region Instancias
        //entidades
        private Entities.Empleados _empleados;
        private Registros_Logs _registroLogs;
        private Jornadas_Empleados _jornadas_Empleados;
        private Restricciones _restricciones;
        private readonly MetodosGenerales _metodosGenerales;


        //Negocio
        private readonly BussinessEmpleados _bussinessEmpleados;
        private readonly BussinessJornadas _bussinessJornadas;

        #endregion

        #region variables

        private int check = 0; //conteo de chk seleccionados
        private String[] chkSelected = new string[6];
        private int chkConteo = 0;
        private bool camposObligatoriosVacios = true;
        private bool todosChk = false;
        private bool diasChk = false;
        private bool horariosOk = false;
        private bool contenidoErroneo = false;
        private string clave = string.Empty;
        private string desde;
        private string hasta;

        #endregion

        #region Load del form
        public Empleados()
        {
            InitializeComponent();
            _restricciones = new Restricciones();
            _metodosGenerales = new MetodosGenerales();
            _bussinessEmpleados = new BussinessEmpleados();
            _empleados = new Entities.Empleados();
            _jornadas_Empleados = new Jornadas_Empleados();
            _bussinessJornadas = new BussinessJornadas();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Tipos_Documentos();
            Tipos_Sexos();
            Tipos_Empleados();
        }

        #endregion

        #region Métodos Encapsulados

        private void DarAltaCompletaEmpleado()
        {
            AltaDatosEmpleado();
            CrearJornadaEmpleado();
            ResetControls();
        }

        private void TraerIdEmpleado()
        {
            //traer id último registro de empleado que se acaba de hacer
            _metodosGenerales.Bring_Last_ID();
            var ultimoId = new Entities.Empleados()
            {
                Empleado_ID = _metodosGenerales.empleado_ID
            };
        }

        private void AsignacionHoras()
        {
            int contadorDesde = desde.Length;
            int contadorHasta = hasta.Length;

            if (contadorDesde <= 5 && contadorHasta <= 5)
            {
                _jornadas_Empleados.Desde_Hora = desde;
                _jornadas_Empleados.Hasta_Hora = hasta;
            }
            else
            {
                MessageBox.Show("El campo de horas, está mal regitrado. Desde registrarse con este formato: ##:##", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CrearJornadaEmpleado()
        { 
            TraerIdEmpleado();
            _jornadas_Empleados.Empleado_ID = _metodosGenerales.empleado_ID;
            //Ahora tenemos 2 opciones.
            // 1 es que se haya seleccionado el check "todos"
            if (todosChk)
            {
                _jornadas_Empleados.Dia = "Todos";
                desde = txtDesdeLunes.Text.ToString();
                hasta = txtHastaLunes.Text.ToString();
                AsignacionHoras();
                _bussinessJornadas.AltaJornadaEmpleados(_jornadas_Empleados);
            }
            else
            {
                //Y la otra es que se hayan seleccionado varios dias
                //Vamos a verificar los checkbox que se hayan seleccionado
                foreach (Control chk in this.gbJornadaEmpleado.Controls)
                {
                    if (chk is CheckBox box)
                    {
                        CheckBox c;
                        c = box;
                        //Y luego de cada checkbox le asignamos el horario.
                        //Lunes
                        if (c.Checked)
                        {
                            if (c.Name.Contains("Lunes"))
                            {
                                _jornadas_Empleados.Dia = "Lunes";
                                desde = txtDesdeLunes.Text.ToString();
                                hasta = txtHastaLunes.Text.ToString();
                                AsignacionHoras();
                            }
                            //Martes
                            else if (c.Name.Contains("Martes"))
                            {
                                _jornadas_Empleados.Dia = "Martes";
                                desde = txtDesdeMartes.Text.ToString();
                                hasta = txtHastaMartes.Text.ToString();
                                AsignacionHoras();
                            }
                            //Miércoles
                            else if (c.Name.Contains("Miercoles"))
                            {
                                _jornadas_Empleados.Dia = "Miercoles";
                                desde = txtDesdeMiercoles.Text.ToString();
                                hasta = txtHastaMiercoles.Text.ToString();
                                AsignacionHoras();
                            }
                            //Jueves
                            else if (c.Name.Contains("Jueves"))
                            {
                                _jornadas_Empleados.Dia = "Jueves";
                                desde = txtDesdeJueves.Text.ToString();
                                hasta = txtHastaJueves.Text.ToString();
                                AsignacionHoras();
                            }
                            //Viernes
                            else if (c.Name.Contains("Viernes"))
                            {
                                _jornadas_Empleados.Dia = "Viernes";
                                desde = txtDesdeViernes.Text.ToString();
                                hasta = txtHastaViernes.Text.ToString();
                                AsignacionHoras();
                            }
                            //Sábado
                            else if (c.Name.Contains("Sabado"))
                            {
                                _jornadas_Empleados.Dia = "Sabado";
                                desde = txtDesdeSabado.Text.ToString();
                                hasta = txtHastaSabado.Text.ToString();
                                AsignacionHoras();
                            }
                            _bussinessJornadas.AltaJornadaEmpleados(_jornadas_Empleados);
                        }
                    }
                }
            }
        }
        private void AltaDatosEmpleado()
        {
            _empleados.Nombre = Convert.ToString(txtNombreEmpleado.Text);
            _empleados.Apellido = Convert.ToString(txtApellidoEmpleado.Text);
            _empleados.Tipo_Documento_ID = cmbTipoDocumentoEmpleado.SelectedIndex;
            _empleados.Nro_documento = Convert.ToString(txtDocumentoEmpleado.Text);
            _empleados.Tipo_Sexo_ID = cmbSexoEmpleado.SelectedIndex;
            _empleados.Nro_Telefono = Convert.ToString(txtTelefonoEmpleado.Text);

            if (txtAlternativoEmpleado.Text != "Alternativo")
            {
                _empleados.Nro_Alternativo = Convert.ToString(txtAlternativoEmpleado.Text);
            }
            else
            {
                _empleados.Nro_Alternativo = string.Empty;
            }

            if (txtMailEmpleado.Text != "Mail")
            {
                _empleados.Mail = Convert.ToString(txtMailEmpleado.Text);
            }
            else
            {
                _empleados.Mail = string.Empty;
            }

            if (txtObservacionesEmpleado.Text != "Observaciones y/o consideraciones")
            {
                _empleados.Observaciones = Convert.ToString(txtObservacionesEmpleado.Text);
            }
            else
            {
                _empleados.Observaciones = string.Empty;
            }

            _empleados.Tipo_Empleado_ID = cmbTipoEmpleado.SelectedIndex + 2;

            if (cmbTipoEmpleado.SelectedIndex == 0)
            {
                clave = (txtClave.Text).ToString();

                //Vamos a encriptar la clave con un código hash cuando corresponda
                GetHash(clave);
                _empleados.Clave = GetHashString(clave);
                _empleados.Usuario = txtUsuario.Text.ToString();
            }
            else
            {
                _empleados.Clave = string.Empty;
                _empleados.Usuario = string.Empty;
            }
            
            _bussinessEmpleados.AltaEmpleado(_empleados);
        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }


        private void Tipos_Documentos()
        {
            //llamo al método para traer los tipos de documentos y los asigno al combobox
            _metodosGenerales.Bring_Tipos_Documentos();
            cmbTipoDocumentoEmpleado.DataSource = _metodosGenerales.DtTipos_Documentos;
            cmbTipoDocumentoEmpleado.DisplayMember = "Tipo";
            cmbTipoDocumentoEmpleado.ValueMember = "Tipo_documento_ID";
        }

        private void Tipos_Sexos()
        {
            //llamo al método para traer los tipos de sexos y los asigno al combobox
            _metodosGenerales.Bring_Tipos_Sexos();
            cmbSexoEmpleado.DataSource = _metodosGenerales.DtTipos_Sexos;
            cmbSexoEmpleado.DisplayMember = "Sexo"; //Pero solo esta columna es la que muestro
            cmbSexoEmpleado.ValueMember = "Tipo_Sexo_ID";
        }

        private void Tipos_Empleados()
        {
            //llamo al método para traer los tipos de Empleados y los asigno al combobox
            _metodosGenerales.Bring_Tipos_Empleados();
            cmbTipoEmpleado.DataSource = _metodosGenerales.DtTipos_Empleados;
            cmbTipoEmpleado.DisplayMember = "Tipo"; //Pero solo esta columna es la que muestro
            cmbTipoEmpleado.ValueMember = "Tipo_Empleado_ID";
        }
        private void VerificarChk()
        {
            if (chkTodos.Checked == false)
            {
                //Si el chk que dice "Seleccionar todos" está seleccionad
                //Entonces todos los otros chk se van a seleccionar
                //Caso contrario, se les quitará el chkeck
                foreach (Control chk in this.gbJornadaEmpleado.Controls)
                {
                    if (chk is CheckBox box)
                    {
                        CheckBox c;
                        c = box;
                        //Deshabilito el check en cada checkbox
                        c.Checked = false;
                    }
                    else if (chk is TextBox txt)
                    {
                        TextBox t;
                        t = txt;
                        if (t.Name != "txtDesdeLunes" && t.Name != "txtHastaLunes")
                        {
                            //habilito cada textbox en este control
                            t.Enabled = true;
                        }
                    }
                }
                todosChk = false;
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
                    else if (chk is TextBox txt)
                    {
                        TextBox t;
                        t = txt;
                        if (t.Name != "txtDesdeLunes" && t.Name != "txtHastaLunes")
                        {
                            //habilito cada textbox en este control
                            t.Enabled = false;
                        }
                    }
                }
                todosChk = true;
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
        
        private void ValidarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtNombreEmpleado.Text) ||
                string.IsNullOrEmpty(txtApellidoEmpleado.Text) ||
                string.IsNullOrEmpty(txtDocumentoEmpleado.Text) ||
                string.IsNullOrEmpty(txtTelefonoEmpleado.Text))
            {
                camposObligatoriosVacios = true;
            }
            else
            {
                camposObligatoriosVacios = false;
            }
        }

        private void ValidarContenido()
        {
            foreach (Control txt in this.gbEmpleado.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "Nombre" ||
                        txt.Text == "Apellido" ||
                        txt.Text == "Documento" ||
                        txt.Text == "Teléfono")
                    {
                        MessageBox.Show("Existen campos sin completar. Por favor, rellene todos los campos obligatorios", "Campos obligatorios sin rellenar.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        contenidoErroneo = true;
                        break;
                    }
                    else
                    {
                        contenidoErroneo = false;
                    }
                }
            }
        }


        private void ResetControls()
        {
            //Primero los controles del groupbox de la jornada
            //quito los checked de todos los checkbox
            foreach (Control chk in this.gbJornadaEmpleado.Controls)
            {
                if (chk is CheckBox box)
                {
                    CheckBox c;
                    c = box;
                    c.Checked = false;
                }
            }
            foreach (Control txt in this.gbJornadaEmpleado.Controls)
            {
                if (txt is TextBox box)
                {
                    TextBox t;
                    t = box;
                    if (t.Name.Contains("Desde"))
                    {
                        t.Text = "Desde";
                    }
                    else if (t.Name.Contains("Hasta"))
                    {
                        t.Text = "Hasta";
                    }
                    t.ForeColor = Color.DimGray;
                }
                
            }

            //luego el groupbox general, lo volvemos al estado inicial.
            txtNombreEmpleado.Text = "Nombre";
            txtAlternativoEmpleado.Text = "Apellido";
            txtDocumentoEmpleado.Text = "Documento";
            txtTelefonoEmpleado.Text = "Teléfono";
            txtAlternativoEmpleado.Text = "Alternativo";
            txtMailEmpleado.Text = "Mail";
            txtObservacionesEmpleado.Text = "Observaciones y/o consideraciones";
            txtUsuario.Text = "Usuario";
            txtClave.Text = "Clave";
            cmbTipoDocumentoEmpleado.SelectedItem = 0;
            cmbSexoEmpleado.SelectedItem = 0;
            cmbTipoEmpleado.SelectedItem = 0;
            foreach (Control txt in this.gbEmpleado.Controls)
            {
                if (txt is TextBox box)
                {
                    txt.ForeColor = Color.DimGray;
                }
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


        #endregion

        #region Alta Empleado
        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            //y si el contenido es distinto al texto predeterminado
            ValidarContenido();

            if (!contenidoErroneo)
            {
                //Valido si hay campos obligatorios vacíos
                ValidarCamposVacios();

                if (!camposObligatoriosVacios)
                {
                    //Luego verificamos los CHK
                    VerificarChk();
                    //Primero verificamos si se seleccionaron todos los chk
                    //y su horario correspondiente.
                    if (!todosChk)
                    {
                        //En caso de que no se haya seleccionado ninguna jornada
                        //Se consultará si se desea dar el alta sin jornada.
                        DialogResult result = MessageBox.Show("No ha registrado la jornada. ¿Desea dar el alta de empleado sin jornada?", "Jornada no establecida", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DarAltaCompletaEmpleado();
                        }
                    }
                    else
                    {
                        DarAltaCompletaEmpleado();
                    }
                }
                else
                {
                    MessageBox.Show("Campos obligatorios sin completar. Por favor, complete todos los campos requeridos", "Campos vacios", MessageBoxButtons.OK);
                }
            }            
        }


        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            VerificarChk();
        }


        #endregion

        #region Eventos de Foco en Textbox

        private void txtNombreEmpleado_Enter(object sender, System.EventArgs e)
        {
            //Primero preguntams si el texto dice Nombre
            //Al principio siempre lo va a decir, porque así
            //inicializa el form. Por lo que lo vamos a vaciar
            //y cambiar el color de la letra.
            //En cso de que no diga literalmente Nombre
            //Se va a dejar como está, ya que puede ser
            //un texto que el usuraio escribió

            if (txtNombreEmpleado.Text == "Nombre")
            {
                txtNombreEmpleado.Text = string.Empty;
                txtNombreEmpleado.ForeColor = Color.Black;
            }
        }
        private void txtNombreEmpleado_Leave(object sender, System.EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtNombreEmpleado.Text))
            {
                txtNombreEmpleado.Text = "Nombre";
                txtNombreEmpleado.ForeColor = Color.DimGray;
            }
        }

        /*Así igual para los siguientes eventos dentro de esta región*/
        private void txtApellidoEmpleado_Enter(object sender, System.EventArgs e)
        {
            if (txtApellidoEmpleado.Text == "Apellido")
            {
                txtApellidoEmpleado.Text = string.Empty;
                txtApellidoEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtApellidoEmpleado_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoEmpleado.Text))
            {
                txtApellidoEmpleado.Text = "Apellido";
                txtApellidoEmpleado.ForeColor = Color.DimGray;
            }
        }
        private void txtDocumentoEmpleado_Enter(object sender, System.EventArgs e)
        {
            if (txtDocumentoEmpleado.Text == "Documento")
            {
                txtDocumentoEmpleado.Text = string.Empty;
                txtDocumentoEmpleado.ForeColor = Color.Black;
            }
        }
        private void txtDocumentoEmpleado_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentoEmpleado.Text))
            {
                txtDocumentoEmpleado.Text = "Documento";
                txtDocumentoEmpleado.ForeColor = Color.DimGray;
            }
        }
        private void txtTelefonoEmpleado_Enter(object sender, System.EventArgs e)
        {
            if (txtTelefonoEmpleado.Text == "Teléfono")
            {
                txtTelefonoEmpleado.Text = string.Empty;
                txtTelefonoEmpleado.ForeColor = Color.Black;
            }
        }
        private void txtTelefonoEmpleado_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefonoEmpleado.Text))
            {
                txtTelefonoEmpleado.Text = "Teléfono";
                txtTelefonoEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtAlternativoEmpleado_Enter(object sender, System.EventArgs e)
        {
            if (txtAlternativoEmpleado.Text == "Alternativo")
            {
                txtAlternativoEmpleado.Text = string.Empty;
                txtAlternativoEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtAlternativoEmpleado_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlternativoEmpleado.Text))
            {
                txtAlternativoEmpleado.Text = "Alternativo";
                txtAlternativoEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtMailEmpleado_Enter(object sender, System.EventArgs e)
        {
            if (txtMailEmpleado.Text == "Mail")
            {
                txtMailEmpleado.Text = string.Empty;
                txtMailEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtMailEmpleado_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailEmpleado.Text))
            {
                txtMailEmpleado.Text = "Mail";
                txtMailEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtObservacionesEmpleado_Enter(object sender, System.EventArgs e)
        {
            if (txtObservacionesEmpleado.Text == "Observaciones y/o consideraciones")
            {
                txtObservacionesEmpleado.Text = string.Empty;
                txtObservacionesEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtObservacionesEmpleado_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObservacionesEmpleado.Text))
            {
                txtObservacionesEmpleado.Text = "Observaciones y/o consideraciones";
                txtObservacionesEmpleado.ForeColor = Color.DimGray;
            }
        }
        private void txtBuscarEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text == "Buscar")
            {
                txtBuscarEmpleado.Text = string.Empty;
                txtBuscarEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtBuscarEmpleado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarEmpleado.Text))
            {
                txtBuscarEmpleado.Text = "Buscar";
                txtBuscarEmpleado.ForeColor = Color.DimGray;
            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.Black;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Clave")
            {
                txtClave.Text = string.Empty;
                txtClave.ForeColor = Color.Black;
            }
        }
        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                txtClave.Text = "Clave";
                txtClave.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #region Eventos KeyPress en Textbox

        private void txtNumDocumentoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtDocumentoEmpleado.Text;
            _restricciones.SoloNumeros(e, strTexto);
        }
        private void txtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtTelefonoEmpleado.Text;
            _restricciones.SoloNumeros(e, strTexto);
        }

        private void txtAlternativoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtAlternativoEmpleado.Text;
            _restricciones.SoloNumeros(e, strTexto);
        }

        #endregion

    }
}
