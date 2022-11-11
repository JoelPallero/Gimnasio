using BussinessLayer;
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
    public partial class Asistencias : Form
    {
        #region Instancias
        //Capa de negocio
        private readonly BussinessClientes _bussinesClientes;
        private readonly BussinessPlanes _bussinessPlanes;
        private readonly BussinessAsistencia _bussinessAsistencia;

        //Entities
        private readonly Entities.Clientes _clientes;
        private readonly Entities.Planes _planes;
        private readonly Entities.Asistencias _asistencias;

        //clases internas

        #endregion

        #region Variables 

        private int idEmpleadoLogin;
        private string buscar;
        private DataSet DsClienteAsistencia;
        private DataTable DtPlanes;
        private bool camposVacios = true;
        private int cliente_ID;

        #endregion

        #region Loading
        public Asistencias(int idPersonaLog)
        {
            InitializeComponent();
            idEmpleadoLogin = idPersonaLog;
            _clientes = new Entities.Clientes();
            _bussinesClientes = new BussinessClientes();
            _bussinessPlanes = new BussinessPlanes();
            _bussinessAsistencia = new BussinessAsistencia();
            _planes = new Entities.Planes();
            _asistencias = new Entities.Asistencias();
            BuscarPlanes();
        }

        #endregion

        #region Métodos encapsulados

        private void BuscarPlanes()
        {
            DtPlanes = _bussinessPlanes.GetPlanes(_planes);
            cmbPlanesActivos.DataSource = DtPlanes;
            cmbPlanesActivos.DisplayMember = "Nombre";
            cmbPlanesActivos.ValueMember = "Plan_ID";
        }
        private void BuscarDatosAlumno()
        {
            DsClienteAsistencia = _bussinesClientes.BuscarClienteAsistencia(buscar);
            DateTime fechaAhora = DateTime.Now;
            _bussinesClientes.VerClaseQueToca(fechaAhora);
            AcomodarDatos();
        }

        private void AcomodarDatos()
        {
            if (DsClienteAsistencia.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DsClienteAsistencia.Tables[0].Rows)
                {
                    cliente_ID = int.Parse(dr[1].ToString());
                    lblNombreCliente.Text += dr[2].ToString() + " " + dr[3].ToString();
                    lblNro_documento.Text += dr[4].ToString();
                    lblTelefono.Text += dr[5].ToString();
                    lblMail.Text += dr[6].ToString();
                    break;
                }
                //int i = 0;
                //foreach (DataRow dr in DsClienteAsistencia.Tables[0].Rows)
                //{
                //    lblPlanActual.Text += dr[7].ToString();
                //    i++;
                //    if ((i + 1) <= DsClienteAsistencia.Tables[0].Rows.Count)
                //    {
                //        lblPlanActual.Text += ", ";
                //    }
                //}
                camposVacios = false;
            }
            else
            {
                MessageBox.Show("No hay clientes con el documento ingresado. Por favor, intente de nuevo!",
                    "Datos no encontrados");
            }
        }
        private void ColocarAsistencia()
        {
            _asistencias.Cliente_ID = cliente_ID;
            _asistencias.Fecha = DateTime.Now;
            _asistencias.Estado = "P";
            _asistencias.Empleado_ID = idEmpleadoLogin;
            _bussinessAsistencia.PutAsistencia(_asistencias);
        }

        #endregion

        #region Eventos
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (camposVacios)
                {
                    buscar = txtBuscarCliente.Text;
                    BuscarDatosAlumno();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Tiene un cliente cargado. ¿Quiere interrumpir la gestión y buscar un cliente nuevo?",
                        "Gestión en proceso", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        buscar = txtBuscarCliente.Text;
                        BuscarDatosAlumno();
                    }
                }
            }
        }
        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            if (camposVacios)
            {
                MessageBox.Show("No hay cliente seleccionado para marcar asistencia. Primero," +
                    "ingrese el nro de documento del cliente para realizar la búsqueda y luego" +
                    "colocar la asistencia.",
                           "Sin datos", MessageBoxButtons.OKCancel);
            }
            else
            {
                ColocarAsistencia();
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

        private void txtBuscarAsistencias_Enter(object sender, EventArgs e)
        {
            if (txtBuscarAsistencias.Text == "Buscar")
            {
                txtBuscarAsistencias.Text = string.Empty;
                txtBuscarAsistencias.ForeColor = Color.Black;
            }
        }

        private void txtBuscarAsistencias_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarAsistencias.Text))
            {
                txtBuscarAsistencias.Text = "Buscar";
                txtBuscarAsistencias.ForeColor = Color.DimGray;
            }
        }
        #endregion


    }
}
