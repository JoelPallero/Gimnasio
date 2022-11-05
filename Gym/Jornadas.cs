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
        private int check;
        private int contador = 0;
        private string formatoHora = "El formato de la hora es este: hh:mm";

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
            switch (check)
            {
                case 0:
                    ActivarTodoChk();
                    break;
                case 1:
                    ChkDias();
                    break;
                case 2:
                    ChkDias();
                    break;
                case 3:
                    ChkDias();
                    break;
                case 4:
                    ChkDias();
                    break;
                case 5:
                    ChkDias();
                    break;
                case 6:
                    ChkDias();
                    break;
            }
            contador = 0;
        }

        #region Trash
        //private void ActivarTextbox()
        //{
        //    //Vamos a recorrer los controles
        //    foreach (Control ctrl in gbJornadaEmpleado.Controls)
        //    {
        //        //Primero encuentro los checkbox
        //        if (ctrl is CheckBox chk)
        //        {
        //            CheckBox c;
        //            c = chk;
        //            //Por cada chk que no sea Lunes o Todos (el primer chk)
        //            if (!c.Name.Contains("Lunes") && !c.Name.Contains("Todos"))
        //            {
        //                //voy a recorrer los textbox
        //                foreach (Control txt in gbJornadaEmpleado.Controls)
        //                {
        //                    if (txt is TextBox box)
        //                    {
        //                        TextBox t;
        //                        t = box;
        //                        //Por cada textbox que sea diferente a Lunes
        //                        if (!t.Name.Contains("Lunes"))
        //                        {
        //                            //Voy a habilitarlo o dehabilitarlo en caso de que el chk
        //                            //
        //                            if (t.Name.Contains(c.Text) && c.Checked && !todosChk)
        //                            {
        //                                t.Enabled = true;
        //                            }
        //                            else
        //                            {

        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}


        #endregion

        private void ChkDias()
        {
            RevisarTodosChk();
            if (chkTodos.Checked)
            {
                chkTodos.Checked = false;
                todosChk = false;
            }
            else
            {
                if (contador > 5 && !chkTodos.Checked)
                {
                    ActivarTodoChk();
                }
            }
        }
        private void ActivarTodoChk()
        {
            if (!chkTodos.Checked && contador < 7 && !todosChk)
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
                todosChk = true;
            }
            else
            {
                if (todosChk)
                {
                    //Si el chk que dice "Seleccionar todos" está seleccionado
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
                    }
                    todosChk = true;
                }
            }
        }
        private void RevisarTodosChk()
        {
            foreach (Control chk in this.gbJornadaEmpleado.Controls)
            {
                if (chk is CheckBox box)
                {
                    CheckBox c;
                    c = box;
                    if (c.Checked)
                    {
                        contador++;
                    }
                }
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
            check = 0;
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
        private void chkLunes_Click(object sender, EventArgs e)
        {
            check = 1;
            VerificarChk();
        }

        private void chkMartes_Click(object sender, EventArgs e)
        {
            check = 2;
            VerificarChk();
        }

        private void chkMiercoles_Click(object sender, EventArgs e)
        {
            check = 3;
            VerificarChk();
        }

        private void chkJueves_Click(object sender, EventArgs e)
        {
            check = 4;
            VerificarChk();
        }

        private void chkViernes_Click(object sender, EventArgs e)
        {
            check = 5;
            VerificarChk();
        }

        private void chkSabado_Click(object sender, EventArgs e)
        {
            check = 6;
            VerificarChk();
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

        private void txtDesdeLunes_MouseHover(object sender, EventArgs e)
        {
            ttFormatoHora.Show(formatoHora, txtDesdeLunes);
        }
    }
}