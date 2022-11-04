using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Jornadas : Form
    {
        #region Instancias
        //Entidades
        private Jornadas_Empleados _jornadas_Empleados;

        //Capa de Negocio
        private readonly BussinessJornadas _bussinessJornadas;

        //Clases internas
        private readonly MetodosGenerales _metodosGenerales;

        #endregion

        #region Variables
        private string desde;
        private string hasta;
        private bool todosChk = false;

        #endregion

        #region Load
        public Jornadas()
        {
            InitializeComponent();
            _bussinessJornadas = new BussinessJornadas();
            _jornadas_Empleados = new Jornadas_Empleados();
            _metodosGenerales = new MetodosGenerales();
        }

        private void Jornadas_Load(object sender, EventArgs e)
        {
            if (_metodosGenerales.CargarJornada)
            {
                cargarJornada();
                _metodosGenerales.CargarJornada = false;
            }
        }

        #endregion

        #region Métodos encapsulados

        private void cargarJornada()
        {

            if (_metodosGenerales.DtJornadas.Rows.Count > 0)
            {
                foreach (DataRow dr in _metodosGenerales.DtJornadas.Rows)
                {
                    //Vamos a switchear cada vuelta para que vaya
                    //colocando los datos cada vuelta donde corresponda.
                    switch (dr[2].ToString())
                    {
                        case "Todos":
                            chkTodos.Checked = true;
                            txtDesdeLunes.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaLunes.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            VerificarChk();
                            break;
                        case "Lunes":
                            txtDesdeLunes.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaLunes.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            chkLunes.Checked = true;
                            break;
                        case "Martes":
                            txtDesdeMartes.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaMartes.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            chkMartes.Checked = true;
                            break;
                        case "Miercoles":
                            txtDesdeMiercoles.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaMiercoles.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            chkMiercoles.Checked = true;
                            break;
                        case "Jueves":
                            txtDesdeJueves.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaJueves.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            chkJueves.Checked = true;
                            break;
                        case "Viernes":
                            txtDesdeViernes.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaViernes.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            chkViernes.Checked = true;
                            break;
                        case "Sabado":
                            txtDesdeSabado.Text = _jornadas_Empleados.Desde_Hora.ToString();
                            txtHastaSabado.Text = _jornadas_Empleados.Hasta_Hora.ToString();
                            chkSabado.Checked = true;
                            break;
                    }
                }
            }
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
        private void TraerIdEmpleado()
        {
            //traer id último registro de empleado que se acaba de hacer
            _metodosGenerales.Get_Last_Id_Empleado();
            var ultimoId = new Entities.Empleados()
            {
                Empleado_ID = _metodosGenerales.empleado_ID
            };
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
                            desde = string.Empty;
                            hasta = string.Empty;
                        }
                    }
                }
            }
        }

        #endregion

        #region Focus TextBox

        //Lunes
        private void txtDesdeLunes_Enter(object sender, EventArgs e)
        {
            if (txtDesdeLunes.Text == "Desde")
            {
                txtDesdeLunes.Text = string.Empty;
                txtDesdeLunes.ForeColor = Color.Black;
            }
        }
        private void txtDesdeLunes_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtDesdeLunes.Text))
            {
                txtDesdeLunes.Text = "Desde";
                txtDesdeLunes.ForeColor = Color.DimGray;
            }
        }
        private void txtHastaLunes_Enter(object sender, EventArgs e)
        {
            if (txtHastaLunes.Text == "Hasta")
            {
                txtHastaLunes.Text = string.Empty;
                txtHastaLunes.ForeColor = Color.Black;
            }
        }
        private void txtHastaLunes_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtHastaLunes.Text))
            {
                txtHastaLunes.Text = "Hasta";
                txtHastaLunes.ForeColor = Color.DimGray;
            }
        }

        //Martes
        private void txtDesdeMartes_Enter(object sender, EventArgs e)
        {
            if (txtDesdeMartes.Text == "Desde")
            {
                txtDesdeMartes.Text = string.Empty;
                txtDesdeMartes.ForeColor = Color.Black;
            }
        }
        private void txtDesdeMartes_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtDesdeMartes.Text))
            {
                txtDesdeMartes.Text = "Desde";
                txtDesdeMartes.ForeColor = Color.DimGray;
            }
        }
        private void txtHastaMartes_Enter(object sender, EventArgs e)
        {
            if (txtHastaMartes.Text == "Hasta")
            {
                txtHastaMartes.Text = string.Empty;
                txtHastaMartes.ForeColor = Color.Black;
            }
        }
        private void txtHastaMartes_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtHastaMartes.Text))
            {
                txtHastaMartes.Text = "Hasta";
                txtHastaMartes.ForeColor = Color.DimGray;
            }
        }

        //Miércoles
        private void txtDesdeMiercoles_Enter(object sender, EventArgs e)
        {
            if (txtDesdeMiercoles.Text == "Desde")
            {
                txtDesdeMiercoles.Text = string.Empty;
                txtDesdeMiercoles.ForeColor = Color.Black;
            }
        }
        private void txtDesdeMiercoles_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtDesdeMiercoles.Text))
            {
                txtDesdeMiercoles.Text = "Desde";
                txtDesdeMiercoles.ForeColor = Color.DimGray;
            }
        }
        private void txtHastaMiercoles_Enter(object sender, EventArgs e)
        {
            if (txtHastaMiercoles.Text == "Hasta")
            {
                txtHastaMiercoles.Text = string.Empty;
                txtHastaMiercoles.ForeColor = Color.Black;
            }
        }
        private void txtHastaMiercoles_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtHastaMiercoles.Text))
            {
                txtHastaMiercoles.Text = "Hasta";
                txtHastaMiercoles.ForeColor = Color.DimGray;
            }
        }

        //Jueves
        private void txtDesdeJueves_Enter(object sender, EventArgs e)
        {
            if (txtDesdeJueves.Text == "Desde")
            {
                txtDesdeJueves.Text = string.Empty;
                txtDesdeJueves.ForeColor = Color.Black;
            }
        }
        private void txtDesdeJueves_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtDesdeJueves.Text))
            {
                txtDesdeJueves.Text = "Desde";
                txtDesdeJueves.ForeColor = Color.DimGray;
            }
        }
        private void txtHastaJueves_Enter(object sender, EventArgs e)
        {
            if (txtHastaJueves.Text == "Hasta")
            {
                txtHastaJueves.Text = string.Empty;
                txtHastaJueves.ForeColor = Color.Black;
            }
        }
        private void txtHastaJueves_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtHastaJueves.Text))
            {
                txtHastaJueves.Text = "Hasta";
                txtHastaJueves.ForeColor = Color.DimGray;
            }
        }

        //Viernes
        private void txtDesdeViernes_Enter(object sender, EventArgs e)
        {
            if (txtDesdeViernes.Text == "Desde")
            {
                txtDesdeViernes.Text = string.Empty;
                txtDesdeViernes.ForeColor = Color.Black;
            }
        }
        private void txtDesdeViernes_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtDesdeViernes.Text))
            {
                txtDesdeViernes.Text = "Desde";
                txtDesdeViernes.ForeColor = Color.DimGray;
            }
        }
        private void txtHastaViernes_Enter(object sender, EventArgs e)
        {
            if (txtHastaViernes.Text == "Hasta")
            {
                txtHastaViernes.Text = string.Empty;
                txtHastaViernes.ForeColor = Color.Black;
            }
        }
        private void txtHastaViernes_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtHastaViernes.Text))
            {
                txtHastaViernes.Text = "Hasta";
                txtHastaViernes.ForeColor = Color.DimGray;
            }
        }

        //Sábado
        private void txtDesdeSabado_Enter(object sender, EventArgs e)
        {
            if (txtDesdeSabado.Text == "Desde")
            {
                txtDesdeSabado.Text = string.Empty;
                txtDesdeSabado.ForeColor = Color.Black;
            }
        }
        private void txtDesdeSabado_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtDesdeSabado.Text))
            {
                txtDesdeSabado.Text = "Desde";
                txtDesdeSabado.ForeColor = Color.DimGray;
            }
        }
        private void txtHastaSabado_Enter(object sender, EventArgs e)
        {
            if (txtHastaSabado.Text == "Hasta")
            {
                txtHastaSabado.Text = string.Empty;
                txtHastaSabado.ForeColor = Color.Black;
            }
        }
        private void txtHastaSabado_Leave(object sender, EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtHastaSabado.Text))
            {
                txtHastaSabado.Text = "Hasta";
                txtHastaSabado.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #region Clicks

        private void chkTodos_Click(object sender, EventArgs e)
        {
            VerificarChk();
        }

        private void lblCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnAltaJornada_Click(object sender, EventArgs e)
        {
            CrearJornadaEmpleado();
        }

        #endregion

        #region Arrastrar Form

        //Se importan archivos DLL para poder realizar la captura de la acción del mouse
        //y poder arrastrar los formularios desde donde se realiza la captura

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Jornadas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void chkLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                chkLunes.Checked = false;
            }
            else if (!chkLunes.Checked)
            {
                chkLunes.Checked = true;
            }
            else
            {
                chkLunes.Checked = false;
            }
        }

        private void chkMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                chkMartes.Checked = false;
            }
            else if (!chkMartes.Checked)
            {
                chkMartes.Checked = true;
            }
            else
            {
                chkMartes.Checked = false;
            }
        }

        private void chkMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                chkMiercoles.Checked = false;
            }
            else if (!chkMiercoles.Checked)
            {
                chkMiercoles.Checked = true;
            }
            else
            {
                chkMiercoles.Checked = false;
            }
        }

        private void chkJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                chkJueves.Checked = false;
            }
            else if (!chkJueves.Checked)
            {
                chkJueves.Checked = true;
            }
            else
            {
                chkJueves.Checked = false;
            }
        }

        private void chkViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                chkViernes.Checked = false;
            }
            else if (!chkViernes.Checked)
            {
                chkViernes.Checked = true;
            }
            else
            {
                chkViernes.Checked = false;
            }
        }

        private void chkSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                chkSabado.Checked = false;
            }
            else if (!chkSabado.Checked)
            {
                chkSabado.Checked = true;
            }
            else
            {
                chkSabado.Checked = false;
            }
        }
    }
}