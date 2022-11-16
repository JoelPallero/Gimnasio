﻿
namespace Gym
{
    partial class Asistencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.gbClienteAsistencia = new System.Windows.Forms.GroupBox();
            this.cmbClaseDelCliente = new System.Windows.Forms.ComboBox();
            this.lblPlanActual = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnGuardarAsistencia = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNro_documento = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtBuscarAsistencias = new System.Windows.Forms.TextBox();
            this.gbAsignarPlan = new System.Windows.Forms.GroupBox();
            this.lblVerJornadas = new System.Windows.Forms.LinkLabel();
            this.lblCuposTotales = new System.Windows.Forms.Label();
            this.lblCuposRestantes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCostoMensual = new System.Windows.Forms.Label();
            this.cmbPlanesActivos = new System.Windows.Forms.ComboBox();
            this.btnAsignarPlan = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.dtgvAsistencias = new System.Windows.Forms.DataGridView();
            this.Persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbClienteAsistencia.SuspendLayout();
            this.gbAsignarPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCliente.Location = new System.Drawing.Point(23, 30);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(256, 25);
            this.txtBuscarCliente.TabIndex = 0;
            this.txtBuscarCliente.Text = "DNI";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.txtBuscarCliente_Enter);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.txtBuscarCliente_Leave);
            // 
            // gbClienteAsistencia
            // 
            this.gbClienteAsistencia.Controls.Add(this.cmbClaseDelCliente);
            this.gbClienteAsistencia.Controls.Add(this.txtBuscarCliente);
            this.gbClienteAsistencia.Controls.Add(this.lblPlanActual);
            this.gbClienteAsistencia.Controls.Add(this.btnPago);
            this.gbClienteAsistencia.Controls.Add(this.btnGuardarAsistencia);
            this.gbClienteAsistencia.Controls.Add(this.lblTelefono);
            this.gbClienteAsistencia.Controls.Add(this.lblMail);
            this.gbClienteAsistencia.Controls.Add(this.lblNro_documento);
            this.gbClienteAsistencia.Controls.Add(this.lblNombreCliente);
            this.gbClienteAsistencia.Location = new System.Drawing.Point(12, 11);
            this.gbClienteAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClienteAsistencia.Name = "gbClienteAsistencia";
            this.gbClienteAsistencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClienteAsistencia.Size = new System.Drawing.Size(676, 185);
            this.gbClienteAsistencia.TabIndex = 3;
            this.gbClienteAsistencia.TabStop = false;
            this.gbClienteAsistencia.Text = "Asistencia de clientes";
            // 
            // cmbClaseDelCliente
            // 
            this.cmbClaseDelCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaseDelCliente.FormattingEnabled = true;
            this.cmbClaseDelCliente.Location = new System.Drawing.Point(287, 28);
            this.cmbClaseDelCliente.Name = "cmbClaseDelCliente";
            this.cmbClaseDelCliente.Size = new System.Drawing.Size(173, 28);
            this.cmbClaseDelCliente.TabIndex = 19;
            // 
            // lblPlanActual
            // 
            this.lblPlanActual.AutoSize = true;
            this.lblPlanActual.Location = new System.Drawing.Point(319, 100);
            this.lblPlanActual.Name = "lblPlanActual";
            this.lblPlanActual.Size = new System.Drawing.Size(117, 20);
            this.lblPlanActual.TabIndex = 18;
            this.lblPlanActual.Text = "Clases Actuales: ";
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPago.Location = new System.Drawing.Point(323, 132);
            this.btnPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(115, 33);
            this.btnPago.TabIndex = 15;
            this.btnPago.Text = "Realizar Pago";
            this.btnPago.UseVisualStyleBackColor = false;
            // 
            // btnGuardarAsistencia
            // 
            this.btnGuardarAsistencia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnGuardarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarAsistencia.Location = new System.Drawing.Point(479, 25);
            this.btnGuardarAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            this.btnGuardarAsistencia.Size = new System.Drawing.Size(173, 33);
            this.btnGuardarAsistencia.TabIndex = 14;
            this.btnGuardarAsistencia.Text = "Confirmar Asistencia";
            this.btnGuardarAsistencia.UseVisualStyleBackColor = false;
            this.btnGuardarAsistencia.Click += new System.EventHandler(this.btnGuardarAsistencia_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 132);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 20);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(319, 70);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 20);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail: ";
            // 
            // lblNro_documento
            // 
            this.lblNro_documento.AutoSize = true;
            this.lblNro_documento.Location = new System.Drawing.Point(23, 100);
            this.lblNro_documento.Name = "lblNro_documento";
            this.lblNro_documento.Size = new System.Drawing.Size(42, 20);
            this.lblNro_documento.TabIndex = 9;
            this.lblNro_documento.Text = "DNI: ";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(23, 70);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(71, 20);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre: ";
            // 
            // txtBuscarAsistencias
            // 
            this.txtBuscarAsistencias.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarAsistencias.Location = new System.Drawing.Point(12, 322);
            this.txtBuscarAsistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarAsistencias.Name = "txtBuscarAsistencias";
            this.txtBuscarAsistencias.Size = new System.Drawing.Size(296, 27);
            this.txtBuscarAsistencias.TabIndex = 6;
            this.txtBuscarAsistencias.Text = "Buscar";
            this.txtBuscarAsistencias.Enter += new System.EventHandler(this.txtBuscarAsistencias_Enter);
            this.txtBuscarAsistencias.Leave += new System.EventHandler(this.txtBuscarAsistencias_Leave);
            // 
            // gbAsignarPlan
            // 
            this.gbAsignarPlan.Controls.Add(this.lblVerJornadas);
            this.gbAsignarPlan.Controls.Add(this.lblCuposTotales);
            this.gbAsignarPlan.Controls.Add(this.lblCuposRestantes);
            this.gbAsignarPlan.Controls.Add(this.label12);
            this.gbAsignarPlan.Controls.Add(this.lblCostoMensual);
            this.gbAsignarPlan.Controls.Add(this.cmbPlanesActivos);
            this.gbAsignarPlan.Controls.Add(this.btnAsignarPlan);
            this.gbAsignarPlan.Controls.Add(this.label20);
            this.gbAsignarPlan.Location = new System.Drawing.Point(12, 200);
            this.gbAsignarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAsignarPlan.Name = "gbAsignarPlan";
            this.gbAsignarPlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAsignarPlan.Size = new System.Drawing.Size(676, 104);
            this.gbAsignarPlan.TabIndex = 7;
            this.gbAsignarPlan.TabStop = false;
            this.gbAsignarPlan.Text = "Datos de Planes";
            // 
            // lblVerJornadas
            // 
            this.lblVerJornadas.AutoSize = true;
            this.lblVerJornadas.Location = new System.Drawing.Point(325, 58);
            this.lblVerJornadas.Name = "lblVerJornadas";
            this.lblVerJornadas.Size = new System.Drawing.Size(91, 20);
            this.lblVerJornadas.TabIndex = 33;
            this.lblVerJornadas.TabStop = true;
            this.lblVerJornadas.Text = "Ver jornadas";
            this.lblVerJornadas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVerJornadas_LinkClicked);
            // 
            // lblCuposTotales
            // 
            this.lblCuposTotales.AutoSize = true;
            this.lblCuposTotales.Location = new System.Drawing.Point(283, 58);
            this.lblCuposTotales.Name = "lblCuposTotales";
            this.lblCuposTotales.Size = new System.Drawing.Size(25, 20);
            this.lblCuposTotales.TabIndex = 22;
            this.lblCuposTotales.Text = "10";
            // 
            // lblCuposRestantes
            // 
            this.lblCuposRestantes.AutoSize = true;
            this.lblCuposRestantes.Location = new System.Drawing.Point(252, 58);
            this.lblCuposRestantes.Name = "lblCuposRestantes";
            this.lblCuposRestantes.Size = new System.Drawing.Size(25, 20);
            this.lblCuposRestantes.TabIndex = 21;
            this.lblCuposRestantes.Text = "10";
            this.lblCuposRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Planes disponibles";
            // 
            // lblCostoMensual
            // 
            this.lblCostoMensual.AutoSize = true;
            this.lblCostoMensual.Location = new System.Drawing.Point(256, 22);
            this.lblCostoMensual.Name = "lblCostoMensual";
            this.lblCostoMensual.Size = new System.Drawing.Size(121, 20);
            this.lblCostoMensual.TabIndex = 17;
            this.lblCostoMensual.Text = "Costo mensual: $";
            // 
            // cmbPlanesActivos
            // 
            this.cmbPlanesActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanesActivos.FormattingEnabled = true;
            this.cmbPlanesActivos.Location = new System.Drawing.Point(23, 54);
            this.cmbPlanesActivos.Name = "cmbPlanesActivos";
            this.cmbPlanesActivos.Size = new System.Drawing.Size(216, 28);
            this.cmbPlanesActivos.TabIndex = 16;
            this.cmbPlanesActivos.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanesActivos_SelectionChangeCommitted);
            // 
            // btnAsignarPlan
            // 
            this.btnAsignarPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAsignarPlan.FlatAppearance.BorderSize = 0;
            this.btnAsignarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarPlan.Location = new System.Drawing.Point(479, 48);
            this.btnAsignarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPlan.Name = "btnAsignarPlan";
            this.btnAsignarPlan.Size = new System.Drawing.Size(173, 40);
            this.btnAsignarPlan.TabIndex = 7;
            this.btnAsignarPlan.Text = "Asignar Plan";
            this.btnAsignarPlan.UseVisualStyleBackColor = false;
            this.btnAsignarPlan.Click += new System.EventHandler(this.btnAsignarPlan_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(273, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "/";
            // 
            // dtgvAsistencias
            // 
            this.dtgvAsistencias.AllowUserToAddRows = false;
            this.dtgvAsistencias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Persona_ID,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Tipo_Empleado,
            this.Estado});
            this.dtgvAsistencias.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvAsistencias.Location = new System.Drawing.Point(12, 353);
            this.dtgvAsistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvAsistencias.Name = "dtgvAsistencias";
            this.dtgvAsistencias.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAsistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvAsistencias.RowHeadersVisible = false;
            this.dtgvAsistencias.RowHeadersWidth = 51;
            this.dtgvAsistencias.RowTemplate.Height = 29;
            this.dtgvAsistencias.Size = new System.Drawing.Size(676, 286);
            this.dtgvAsistencias.TabIndex = 17;
            // 
            // Persona_ID
            // 
            this.Persona_ID.Frozen = true;
            this.Persona_ID.HeaderText = "Cliente ID";
            this.Persona_ID.MinimumWidth = 6;
            this.Persona_ID.Name = "Persona_ID";
            this.Persona_ID.ReadOnly = true;
            this.Persona_ID.Visible = false;
            this.Persona_ID.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 140;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle3;
            this.Apellido.Frozen = true;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 130;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle4;
            this.Documento.Frozen = true;
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 130;
            // 
            // Tipo_Empleado
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Empleado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tipo_Empleado.Frozen = true;
            this.Tipo_Empleado.HeaderText = "Clase";
            this.Tipo_Empleado.MinimumWidth = 6;
            this.Tipo_Empleado.Name = "Tipo_Empleado";
            this.Tipo_Empleado.ReadOnly = true;
            this.Tipo_Empleado.Width = 130;
            // 
            // Estado
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado.HeaderText = "Asistencia";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.Width = 142;
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.dtgvAsistencias);
            this.Controls.Add(this.gbAsignarPlan);
            this.Controls.Add(this.txtBuscarAsistencias);
            this.Controls.Add(this.gbClienteAsistencia);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Asistencias";
            this.Text = "asistencia";
            this.gbClienteAsistencia.ResumeLayout(false);
            this.gbClienteAsistencia.PerformLayout();
            this.gbAsignarPlan.ResumeLayout(false);
            this.gbAsignarPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.GroupBox gbClienteAsistencia;
        private System.Windows.Forms.TextBox txtBuscarAsistencias;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNro_documento;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.Label lblPlanActual;
        private System.Windows.Forms.GroupBox gbAsignarPlan;
        private System.Windows.Forms.Label lblCuposTotales;
        private System.Windows.Forms.Label lblCuposRestantes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCostoMensual;
        private System.Windows.Forms.ComboBox cmbPlanesActivos;
        private System.Windows.Forms.Button btnAsignarPlan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbClaseDelCliente;
        private System.Windows.Forms.LinkLabel lblVerJornadas;
        private System.Windows.Forms.DataGridView dtgvAsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}