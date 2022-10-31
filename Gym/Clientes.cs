﻿using BussinessLayer;
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
    public partial class Clientes : Form
    {
        #region Instancias

        private readonly Restricciones _restricciones;
        private readonly MetodosGenerales _metodosGenerales;

        #endregion

        #region Load del formulario
        public Clientes()
        {
            InitializeComponent();
            _restricciones = new Restricciones();
            _metodosGenerales = new MetodosGenerales();
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            Tipos_Documentos();
            Tipos_Sexos();
        }

        #endregion

        #region Variables

        private int caracteresRestantes = 200;

        #endregion

        #region Métodos Encapsulados

        private void Tipos_Documentos()
        {
            //llamo al método para traer los tipos de documentos y los asigno al combobox
            _metodosGenerales.Bring_Tipos_Documentos();
            cmbTipoDocumentoCliente.DataSource = _metodosGenerales.DtTipos_Documentos;
            cmbTipoDocumentoCliente.DisplayMember = "Tipo";
            cmbTipoDocumentoCliente.ValueMember = "Tipo_documento_ID";
        }

        private void Tipos_Sexos()
        {
            //llamo al método para traer los tipos de sexos y los asigno al combobox
            _metodosGenerales.Bring_Tipos_Sexos();
            cmbSexo.DataSource = _metodosGenerales.DtTipos_Documentos;
            cmbSexo.DisplayMember = "Sexo"; //Pero solo esta columna es la que muestro
            cmbSexo.ValueMember = "Tipo_Sexo_ID";
        }

        #endregion

        #region Eventos de Foco en Textbox

        private void txtNombreCliente_Enter(object sender, System.EventArgs e)
        {
            //Primero preguntams si el texto dice Nombre
            //Al principio siempre lo va a decir, porque así
            //inicializa el form. Por lo que lo vamos a vaciar
            //y cambiar el color de la letra.
            //En cso de que no diga literalmente Nombre
            //Se va a dejar como está, ya que puede ser
            //un texto que el usuraio escribió

            if (txtNombreCliente.Text == "Nombre")
            {
                txtNombreCliente.Text = string.Empty;
                txtNombreCliente.ForeColor = Color.Black;
            }
        }
        private void txtNombreCliente_Leave(object sender, System.EventArgs e)
        {
            //Por el lado contrario, cuando se quita el foco 
            //del control, lo volvemos a su estado y color inicial

            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                txtNombreCliente.Text = "Nombre";
                txtNombreCliente.ForeColor = Color.DimGray;
            }
        }

        /*Así igual para los siguientes eventos dentro de esta región*/
        private void txtApellidoCliente_Enter(object sender, System.EventArgs e)
        {
            if (txtApellidoCliente.Text == "Apellido")
            {
                txtApellidoCliente.Text = string.Empty;
                txtApellidoCliente.ForeColor = Color.Black;
            }
        }

        private void txtApellidoCliente_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                txtApellidoCliente.Text = "Apellido";
                txtApellidoCliente.ForeColor = Color.DimGray;
            }
        }
        private void txtNumDocumentoCliente_Enter(object sender, System.EventArgs e)
        {
            if (txtNumDocumentoCliente.Text == "N° documento")
            {
                txtNumDocumentoCliente.Text = string.Empty;
                txtNumDocumentoCliente.ForeColor = Color.Black;
            }
        }
        private void txtNumDocumentoCliente_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumDocumentoCliente.Text))
            {
                txtNumDocumentoCliente.Text = "N° documento";
                txtNumDocumentoCliente.ForeColor = Color.DimGray;
            }
        }
        private void txtTelefonoCliente_Enter(object sender, System.EventArgs e)
        {
            if (txtTelefonoCliente.Text == "Teléfono")
            {
                txtTelefonoCliente.Text = string.Empty;
                txtTelefonoCliente.ForeColor = Color.Black;
            }
        }
        private void txtTelefonoCliente_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefonoCliente.Text))
            {
                txtTelefonoCliente.Text = "Teléfono";
                txtTelefonoCliente.ForeColor = Color.DimGray;
            }
        }

        private void txtAlternativoCliente_Enter(object sender, System.EventArgs e)
        {
            if (txtAlternativoCliente.Text == "Alternativo")
            {
                txtAlternativoCliente.Text = string.Empty;
                txtAlternativoCliente.ForeColor = Color.Black;
            }
        }

        private void txtAlternativoCliente_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlternativoCliente.Text))
            {
                txtAlternativoCliente.Text = "Alternativo";
                txtAlternativoCliente.ForeColor = Color.DimGray;
            }
        }

        private void txtMailCliente_Enter(object sender, System.EventArgs e)
        {
            if (txtMailCliente.Text == "Mail")
            {
                txtMailCliente.Text = string.Empty;
                txtMailCliente.ForeColor = Color.Black;
            }
        }

        private void txtMailCliente_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailCliente.Text))
            {
                txtMailCliente.Text = "Mail";
                txtMailCliente.ForeColor = Color.DimGray;
            }
        }

        private void txtObservacionesCliente_Enter(object sender, System.EventArgs e)
        {
            if (txtObservacionesCliente.Text == "Observaciones y/o consideraciones")
            {
                txtObservacionesCliente.Text = string.Empty;
                txtObservacionesCliente.ForeColor = Color.Black;
            }
        }

        private void txtObservacionesCliente_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObservacionesCliente.Text))
            {
                txtObservacionesCliente.Text = "Observaciones y/o consideraciones";
                txtObservacionesCliente.ForeColor = Color.DimGray;
            }
        }
        private void txtBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text == "Buscar")
            {
                txtBuscarCliente.Text = string.Empty;
                txtBuscarCliente.ForeColor = Color.Black;
            }
        }

        private void txtBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarCliente.Text))
            {
                txtBuscarCliente.Text = "Buscar";
                txtBuscarCliente.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #region Eventos KeyPress en Textbox

        private void txtNumDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtNumDocumentoCliente.Text;
            _restricciones.SoloNumeros(e, strTexto);
        }
        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtTelefonoCliente.Text;
            _restricciones.SoloNumeros(e, strTexto);
        }

        private void txtAlternativoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTexto = txtAlternativoCliente.Text;
            _restricciones.SoloNumeros(e, strTexto);
        }

        #endregion
    }
}