using BussinessLayer;
using Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym
{
    public partial class Login : Form
    {
        #region Instancias
        //Capa de negocio
        private readonly BussinessEmpleados _bussinessEmplados;

        //Capa de entidades
        private readonly Entities.Empleados _empleados;
        private readonly Tipos_Empleados _tiposEmpleados;
        private readonly Personas _personas = new Personas();

        //Clases internas de la capa
        private readonly MetodosGenerales _metodosGenerales;

        #endregion

        #region Load
        public Login()
        {
            InitializeComponent();
            _bussinessEmplados = new BussinessEmpleados();
            _empleados = new Entities.Empleados();
            _tiposEmpleados = new Tipos_Empleados();
            _metodosGenerales = new MetodosGenerales();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            btnIngresar.Focus();
            CerrarForms();
        }

        #endregion

        #region Variables

        private string clave = string.Empty;

        #endregion

        #region Métodos encapsulados

        private void CerrarForms()
        {
            MainJefe frm = new MainJefe();
            frm.Close();
            MainUsuarios frmU = new MainUsuarios();
            frmU.Close();
        }

        //Encriptamiento de clave
        private void EncriptarClaveClave()
        {
            //Encriptamos la clave con un HASH256
            //Y la asignamos al campo de la entidad correspondiente
            clave = EncriptamientoSHA256.GetSHA256(txtClave.Text.ToString());
        }

        #endregion

        #region Eventos KeyPress

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

        #region Eventos Click

        private void lblGenerarPrimerUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroPrimeraVez registroPrimeraVez = new RegistroPrimeraVez();
            registroPrimeraVez.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Vamos a verificar primero si existe la clave en el sistema.
            //en caso de existir, entonces se va a abrir la pantalla
            //correspondiente si es Jefe o si es un empleado (usuario)
            EncriptarClaveClave();
            string usuario = txtUsuario.Text.ToString();
            _empleados.Usuario = txtUsuario.Text.ToString();
            _bussinessEmplados.VerificarClaveEnBdd(clave, _tiposEmpleados, _empleados);

            //una vez traidos los datos, los comparamos con los que tenemos en
            //cada variable. Si son idénticas, entonces, ya puede verificarse
            //el acceso al programa
            if (_empleados.Clave == clave && _empleados.Usuario == usuario)
            {
                //Verificamos si es de un jefe o usuario,
                //para que el programa abra la parte correspondiente

                if (_tiposEmpleados.Estado == "Activo" && _tiposEmpleados.Acceso_Clave == "Y")
                {
                    //Vamos a traer los datos del empleado que abrió sesión
                    _metodosGenerales.usuarioOpenID = _empleados.Empleado_ID;
                    _metodosGenerales.personaOpenID = _empleados.Persona_ID;


                    switch (_tiposEmpleados.Tipo)
                    {
                        case "Admin":

                            break;
                        case "Jefe":
                            //Perfil de jefe
                            MainJefe mj = new MainJefe();
                            mj.Show();
                            this.Hide();
                            break;
                        case "Usuario":
                            //Perfil de usuario común
                            MainUsuarios mu = new MainUsuarios();
                            mu.Show();
                            this.Hide();
                            break;
                        default:
                            //Y si por las dudas se cuela un perfil no deseado, se rechaza
                            MessageBox.Show("Su estado actual no le permite acceder al programa. " +
                                            "Por favor, comuníquese con su administrador " +
                                            "para que haga la modificación de manera manual", "Advertencia",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else
                {
                    //Cualquier otro estado no tiene la autorización correspondiente (vacaciones, carpeta médica)
                    //Para acceder deberá solicitar permiso al jefe, y el mismo deberá cambiar el estado del empleado
                    MessageBox.Show("Su estado actual no le permite acceder al programa. " +
                                            "Por favor, comuníquese con su administrador " +
                                            "para que haga la modificación de manera manual", "Advertencia",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay usuario ni clave para los datos registrado. " +
                            "En caso de no ser usuario, deberá solicitar un perfil con el administrador correspondiente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        //MessageBox.Show("Se encontró el perfil", "Prueba");
        //MessageBox.Show("No se encontró el perfil", "Prueba fallida");
    }
}