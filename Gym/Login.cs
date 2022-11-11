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
        private readonly BussinessRegistrosLogs _bussinessRegistrosLogs;

        //Capa de entidades
        private readonly Entities.Empleados _empleados;
        private readonly Tipos_Empleados _tiposEmpleados;
        private readonly Personas _personas = new Personas();
        private readonly Entities.Registros_Logs _registros_Logs;

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
            _bussinessRegistrosLogs = new BussinessRegistrosLogs();
            _registros_Logs = new Registros_Logs();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            btnIngresar.Focus();
            CerrarForms();
        }

        #endregion

        #region Variables

        private string clave = string.Empty;
        private int idEmpleadoLogin;
        private int idLastLogin;
        private bool mainJefe;


        #endregion

        #region Métodos encapsulados

        private void CerrarForms()
        {
            MainForm frm = new MainForm(mainJefe, idEmpleadoLogin, idLastLogin);
            frm.Close();
        }

        //Encriptamiento de clave
        private void EncriptarClaveClave()
        {
            //Encriptamos la clave con un HASH256
            //Y la asignamos al campo de la entidad correspondiente
            clave = EncriptamientoSHA256.GetSHA256(txtClave.Text.ToString());
        }

        private void RegistrarLogin()
        {
            _registros_Logs.Empleado_ID = idEmpleadoLogin;
            _registros_Logs.Fecha_LogIn = DateTime.Now;
            _bussinessRegistrosLogs.RegistrarLogin(_registros_Logs);
            _registros_Logs.Empleado_ID = idEmpleadoLogin;
            _bussinessRegistrosLogs.GetLastLogID(_registros_Logs);
            idLastLogin = _registros_Logs.Registro_Log_ID;
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
            //correspondiente si es Jefe o si es usuario
            
            EncriptarClaveClave();
            
            //asigno la clave a una variable, sin encriptarla (xq cuando traigo
            //la clave de la bdd, esta viene encriptada. Si yo encripto la clave
            //enciptada, la comparación siempre va a ser falsa)
            string usuario = txtUsuario.Text.ToString();

            _empleados.Usuario = txtUsuario.Text.ToString();
            _empleados.Clave = clave;
            _bussinessEmplados.VerificarClaveEnBdd(_tiposEmpleados, _empleados);

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
                    idEmpleadoLogin = _empleados.Empleado_ID;

                    //Si mainJefe es true, entonces se habilitan todos los botones
                    //del formulario principal que se va a abrir a continuación,
                    //sino, hay un botón que no se habilita xq no tienen los permisos
                    //correspondientes, cada uno de los usuarios del programa.
                    if (_tiposEmpleados.Tipo == "Jefe")
                    {
                        mainJefe = true;
                    }
                    else
                    {
                        mainJefe = false;
                    }
                    RegistrarLogin();
                    MainForm mj = new MainForm(mainJefe, idEmpleadoLogin, idLastLogin);
                    mj.Show();
                    this.Hide();
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
                MessageBox.Show("No hay usuario ni clave para los datos registrados. " +
                            "En caso de no ser usuario, deberá solicitar un perfil con el administrador correspondiente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar_Click(sender, e);
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar_Click(sender, e);
            }
        }

        #endregion

        //MessageBox.Show("Se encontró el perfil", "Prueba");
        //MessageBox.Show("No se encontró el perfil", "Prueba fallida");
    }
}