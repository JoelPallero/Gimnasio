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
    public partial class Cajas : Form
    {
        #region Instancias
        //Clases internas
        private readonly MetodosGenerales _metodosGenerales;
        private readonly Restricciones _restricciones;

        //Capa negocio
        private readonly BussinessCaja _bussinessCaja;

        //Entidades
        private readonly Entities.Cajas _caja;
        private readonly Entities.Detalles_Cajas _detalles_Cajas;


        #endregion

        #region Variables
        private int personaLogueada;
        private decimal ingreso;
        private decimal egreso;
        private DataSet DsSaldosActuales;
        private DataSet DsCajas;
        private int idCajaAbierta;
        private string buscar;


        #endregion

        public Cajas(int idPersonaLog)
        {
            InitializeComponent();
            _restricciones = new Restricciones();
            _metodosGenerales = new MetodosGenerales();
            _bussinessCaja = new BussinessCaja();
            _caja = new Entities.Cajas();
            _detalles_Cajas = new Entities.Detalles_Cajas();
            personaLogueada = idPersonaLog;
            ActualizacionDeImportes();
            GetCajas();
        }

        #region Encapsulamientos

        private void TotalMomentaneo(decimal egreso, decimal ingreso)
        {
            lblTotalMomentaneo.Text = (ingreso - egreso).ToString();
        }

        private void ActualizacionDeImportes()
        {
            _detalles_Cajas.Caja_ID = idCajaAbierta;
            DsSaldosActuales = _bussinessCaja.ConsultarSaldos(_detalles_Cajas);
            if (DsSaldosActuales.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DsSaldosActuales.Tables[0].Rows)
                {
                    lblIngresos.Text = dr[0].ToString();
                    lblEgresos.Text = dr[1].ToString();
                    lblTotalMomentaneo.Text = dr[2].ToString();
                    break;
                }
            }
            TotalMomentaneo(egreso, ingreso);
        }

        private void GetCajas()
        {
            DsCajas = _bussinessCaja.GetCajas(buscar);

            dtgvCajas.Rows.Clear();
            //Vacío el textbox para resetear en caso de búsqueda específica
            buscar = string.Empty;

            //Y acá traigo los datos
            //Pregunto si el dataset tiene datos, preguntando si tiene filas
            if (DsCajas.Tables[0].Rows.Count > 0)
            {
                //Y por cada fila que haya en el dataset
                foreach (DataRow dr in DsCajas.Tables[0].Rows)
                {
                    dtgvCajas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4]);
                }
            }
        }

        #endregion

        private void txtImporteEfectivo_Click(object sender, EventArgs e)
        {
            _caja.Importe_Inicial = Convert.ToDecimal(txtImporteEfectivo.Text);
            _caja.Empleado_ID = personaLogueada;
            _caja.Fecha = DateTime.Now;
            _bussinessCaja.AbrirCaja(_caja);
            _bussinessCaja.ConsultarIDCajaAbierta(_caja);
            idCajaAbierta = _caja.Caja_ID;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string importe = txtImporteEfectivo.Text;
            _restricciones.SoloNumeros(e, importe);
        }

        private void txtBuscarCajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscar = txtBuscarCajas.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                GetCajas();
            }
        }
    }
}
