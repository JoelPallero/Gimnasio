using BussinessLayer;
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
    public partial class Planes : Form
    {
        #region Instancias
        //Capa de negocio
        private readonly BussinessPersonas _bussinesPersonas;
        private readonly BussinessPlanes _bussinessPlanes;
        private readonly BussinessClientes _bussinesClientes;
        private readonly BussinessAsistencia _bussinessAsistencia;
        private readonly BussinessPlanesAsignados _bussinesPlanesAsignados;

        //Entities
        private readonly Entities.Clientes _clientes;
        private readonly Entities.Planes _planes;
        private readonly Entities.Asistencias _asistencias;
        private readonly Entities.Planes_Asignados _planesAsignados;
        private Personas _personas;


        //Clases internas
        private readonly MetodosGenerales _metodosGenerales;
        private readonly Restricciones _restricciones;

        #endregion

        #region Variables
        private int personaLogueada;
        private string buscar;
        private DataSet DsClienteAsistencia;
        private DataSet DsPlanesAsignados;
        private DataTable DsProfesores;
        private DataTable DtPlanes;
        private bool camposVacios;
        private int cliente_ID;
        private int planSeleccionado;

        #endregion

        #region Loading
        public Planes(int idPersonaLog)
        {
            InitializeComponent();
            personaLogueada = idPersonaLog;

            _bussinessPlanes = new BussinessPlanes();
            _bussinesClientes = new BussinessClientes();
            _bussinesPersonas = new BussinessPersonas();
            _bussinessAsistencia = new BussinessAsistencia();
            _planesAsignados = new Entities.Planes_Asignados();
            _bussinesPlanesAsignados = new BussinessPlanesAsignados();

            _personas = new Personas();
            _planes = new Entities.Planes();
            _clientes = new Entities.Clientes();
            _asistencias = new Entities.Asistencias();

            _restricciones = new Restricciones();
            _metodosGenerales = new MetodosGenerales();

            BuscarPlanes();
            BuscarProfesores();
            btnAsignarPlan.Enabled = false;
        }

        #endregion

        #region Encapsulamiento

        private void BuscarProfesores()
        {
            DsProfesores = _bussinesPersonas.BuscarProfesores(_personas);
            cmbProfesores.DataSource = DsProfesores;
            cmbProfesores.DisplayMember = "Nombre";
            cmbProfesores.ValueMember = "Persona_ID";
        }

        private void BuscarPlanes()
        {
            DtPlanes = _bussinessPlanes.GetPlanes(_planes);
            cmbPlanesActivos.DataSource = DtPlanes;
            cmbPlanesActivos.DisplayMember = "Nombre";
            cmbPlanesActivos.ValueMember = "Plan_ID";
        }
        private void BuscarDatosCliente()
        {
            DsClienteAsistencia = _bussinesClientes.BuscarClienteAsistencia(buscar);
            AcomodarDatos();
        }

        private void AcomodarDatos()
        {
            if (DsClienteAsistencia.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DsClienteAsistencia.Tables[0].Rows)
                {
                    cliente_ID = int.Parse(dr[1].ToString());
                    lblNombre.Text += dr[2].ToString() + " " + dr[3].ToString();
                    lblDocumento.Text += dr[4].ToString();
                    lblTelefono.Text += dr[5].ToString();
                    lblMail.Text += dr[6].ToString();
                    break;
                }
                int i = 0;
                foreach (DataRow dr in DsClienteAsistencia.Tables[0].Rows)
                {
                    lblPlanesCliente.Text += dr[7].ToString();
                    i++;
                    if ((i + 1) <= DsClienteAsistencia.Tables[0].Rows.Count)
                    {
                        lblPlanesCliente.Text += ", ";
                    }
                }
                camposVacios = false;
                btnAsignarPlan.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay clientes con el documento ingresado. " +
                    "Por favor, intente de nuevo, o haga primero el registro del cliente.",
                    "Datos no encontrados");
            }
        }
        private void MostrarCliente()
        {
            _bussinesPersonas.GetPersonaPlan(buscar, _personas);
            AcomodarDatos();
        }

        private void AsigarlePlanAlCliente()
        {
            _planesAsignados.Plan_Asignado_ID = Convert.ToInt32(cmbPlanesActivos.SelectedValue);
            _planesAsignados.Empleado_ID = personaLogueada;
            _planesAsignados.Cliente_ID = cliente_ID;
            _planesAsignados.Fecha_Inicio = DateTime.Now;
            _planesAsignados.Estado = "A";
            _bussinesPlanesAsignados.AsginarPlanAlCliente(_planesAsignados);
        }

        private void RevisarCamposVacios()
        {
            foreach (Control ctrl in gpDatosPlan.Controls)
            {
                if (ctrl is TextBox box)
                {
                    TextBox t;
                    t = box;
                    if (string.IsNullOrEmpty(t.Text))
                    {
                        camposVacios = true;
                        break;
                    }
                }
            }
        }

        private void RegistrarNuevoPlan()
        {
            _planes.Persona_ID = personaLogueada;
            _planes.Nombre = txtNombrePlan.Text;
            _planes.Importe_Plan = Convert.ToDecimal(txtImporte.Text);
            _planes.Empleado_ID = Convert.ToInt32(cmbProfesores.SelectedValue);
            _planes.Duracion = Convert.ToInt32(txtDuracion.Text);
            _planes.Cupo_Total = Convert.ToInt32(txtCupoTotal.Text);
            _planes.Cupo_Restante = Convert.ToInt32(txtCupoTotal.Text);
            _planes.Fecha_Inicio = dtpFechaInicio.Value;
            _planes.Fecha_Alta_Plan = DateTime.Now;
            _planes.Estado = "A";
            _bussinessPlanes.RegistrarNuevoPlan(_planes);
            
            //Una vez dado de alta, actualizamos la lista.

        }

        #endregion

        #region Eventos Keypress
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscar = txtBuscarCliente.Text;
            _restricciones.SoloNumeros(e, buscar);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(buscar))
                {
                    MostrarCliente();
                }
            }
        }

        #endregion

        #region Alta de Planes

        private void btnAltaPlan_Click(object sender, EventArgs e)
        {
            RevisarCamposVacios();
            if (camposVacios)
            {
                MessageBox.Show("Para registrar un nuevo plan, no deben haber campos vacíos", 
                    "Campos incompletos");
            }
            else
            {
                if (cmbProfesores.Items.Count > 0)
                {
                    //Guardamos el plan
                    RegistrarNuevoPlan();
                }
                else
                {
                    DialogResult result = MessageBox.Show("No hay profesores para la clase. ¿Es un plan libre? Eliga 'Si' para dar de alta sin profesor particular.", "Alta de Plan", MessageBoxButtons.YesNo);
                    if (result == DialogResult.OK)
                    {
                        RegistrarNuevoPlan();
                    }
                }
            }
        }

        #endregion

        #region Focus Textbox
        private void txtBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text == "DNI")
            {
                txtBuscarCliente.Text = string.Empty;
                txtBuscarCliente.ForeColor = Color.Black;
            }
        }

        private void txtBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarCliente.Text))
            {
                txtBuscarCliente.Text = "DNI";
                txtBuscarCliente.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #region Asignación de planes a un cliente
        private void btnAsignarPlan_Click(object sender, EventArgs e)
        {
            if (camposVacios)
            {
                MessageBox.Show("No hay cliente seleccionado para asignarle un plan." +
                    "Por favor, busque el cliente primero, y luego asigne el plan.");
            }
            else
            {
                //Asignarle el plan.
                AsigarlePlanAlCliente();
            }
        }

        #endregion
    }
}