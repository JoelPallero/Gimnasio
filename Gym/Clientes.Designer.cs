
namespace Gym
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dtgvCliente = new System.Windows.Forms.DataGridView();
            this.Cliente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verPlanesAsignados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAsignarPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPlanAsignado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarDatosCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNumDocumentoCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.txtObservacionesCliente = new System.Windows.Forms.TextBox();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.txtAlternativoCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).BeginInit();
            this.cmClientes.SuspendLayout();
            this.gbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCliente.Location = new System.Drawing.Point(486, 265);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(197, 27);
            this.txtBuscarCliente.TabIndex = 10;
            this.txtBuscarCliente.Text = "Buscar";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.txtBuscarCliente_Enter);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.txtBuscarCliente_Leave);
            // 
            // dtgvCliente
            // 
            this.dtgvCliente.AllowUserToAddRows = false;
            this.dtgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_ID,
            this.Persona_ID,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Telefono,
            this.Estado});
            this.dtgvCliente.ContextMenuStrip = this.cmClientes;
            this.dtgvCliente.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvCliente.Location = new System.Drawing.Point(17, 298);
            this.dtgvCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCliente.Name = "dtgvCliente";
            this.dtgvCliente.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvCliente.RowHeadersVisible = false;
            this.dtgvCliente.RowHeadersWidth = 51;
            this.dtgvCliente.RowTemplate.Height = 29;
            this.dtgvCliente.Size = new System.Drawing.Size(666, 340);
            this.dtgvCliente.TabIndex = 60;
            // 
            // Cliente_ID
            // 
            this.Cliente_ID.Frozen = true;
            this.Cliente_ID.HeaderText = "Cliente ID";
            this.Cliente_ID.MinimumWidth = 6;
            this.Cliente_ID.Name = "Cliente_ID";
            this.Cliente_ID.ReadOnly = true;
            this.Cliente_ID.Visible = false;
            this.Cliente_ID.Width = 125;
            // 
            // Persona_ID
            // 
            this.Persona_ID.Frozen = true;
            this.Persona_ID.HeaderText = "Persona ID";
            this.Persona_ID.MinimumWidth = 6;
            this.Persona_ID.Name = "Persona_ID";
            this.Persona_ID.ReadOnly = true;
            this.Persona_ID.Visible = false;
            this.Persona_ID.Width = 125;
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
            this.Nombre.Width = 130;
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
            // Telefono
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle5;
            this.Telefono.Frozen = true;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 130;
            // 
            // Estado
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 142;
            // 
            // cmClientes
            // 
            this.cmClientes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPlanesAsignados,
            this.toolStripSeparator2,
            this.btnAsignarPlan,
            this.editarPlanAsignado,
            this.btnEditarDatosCliente,
            this.toolStripSeparator1,
            this.btnEliminarCliente});
            this.cmClientes.Name = "cmEmpleado";
            this.cmClientes.Size = new System.Drawing.Size(217, 164);
            this.cmClientes.Text = "Edición";
            // 
            // verPlanesAsignados
            // 
            this.verPlanesAsignados.Name = "verPlanesAsignados";
            this.verPlanesAsignados.Size = new System.Drawing.Size(216, 24);
            this.verPlanesAsignados.Text = "Ver Planes de Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // btnAsignarPlan
            // 
            this.btnAsignarPlan.Name = "btnAsignarPlan";
            this.btnAsignarPlan.Size = new System.Drawing.Size(216, 24);
            this.btnAsignarPlan.Text = "Asignar Plan";
            // 
            // editarPlanAsignado
            // 
            this.editarPlanAsignado.Name = "editarPlanAsignado";
            this.editarPlanAsignado.Size = new System.Drawing.Size(216, 24);
            this.editarPlanAsignado.Text = "Editar Plan Mensual";
            // 
            // btnEditarDatosCliente
            // 
            this.btnEditarDatosCliente.Name = "btnEditarDatosCliente";
            this.btnEditarDatosCliente.Size = new System.Drawing.Size(216, 24);
            this.btnEditarDatosCliente.Text = "Editar Datos";
            this.btnEditarDatosCliente.Click += new System.EventHandler(this.btnEditarDatosCliente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(216, 24);
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.cmbEstado);
            this.gbClientes.Controls.Add(this.txtNombreCliente);
            this.gbClientes.Controls.Add(this.cmbSexo);
            this.gbClientes.Controls.Add(this.txtApellidoCliente);
            this.gbClientes.Controls.Add(this.txtNumDocumentoCliente);
            this.gbClientes.Controls.Add(this.cmbTipoDocumentoCliente);
            this.gbClientes.Controls.Add(this.txtObservacionesCliente);
            this.gbClientes.Controls.Add(this.txtMailCliente);
            this.gbClientes.Controls.Add(this.txtAlternativoCliente);
            this.gbClientes.Controls.Add(this.txtTelefonoCliente);
            this.gbClientes.Controls.Add(this.btnAltaCliente);
            this.gbClientes.Location = new System.Drawing.Point(17, 9);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClientes.Size = new System.Drawing.Size(666, 250);
            this.gbClientes.TabIndex = 59;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Datos Personales";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(348, 65);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(286, 28);
            this.cmbEstado.TabIndex = 10;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.Location = new System.Drawing.Point(28, 29);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(286, 27);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.Text = "Nombre";
            this.txtNombreCliente.Enter += new System.EventHandler(this.txtNombreCliente_Enter);
            this.txtNombreCliente.Leave += new System.EventHandler(this.txtNombreCliente_Leave);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.ForeColor = System.Drawing.Color.Black;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(28, 138);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(286, 28);
            this.cmbSexo.TabIndex = 4;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoCliente.Location = new System.Drawing.Point(28, 65);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtApellidoCliente.TabIndex = 2;
            this.txtApellidoCliente.Text = "Apellido";
            this.txtApellidoCliente.Enter += new System.EventHandler(this.txtApellidoCliente_Enter);
            this.txtApellidoCliente.Leave += new System.EventHandler(this.txtApellidoCliente_Leave);
            // 
            // txtNumDocumentoCliente
            // 
            this.txtNumDocumentoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumDocumentoCliente.Location = new System.Drawing.Point(103, 102);
            this.txtNumDocumentoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumDocumentoCliente.Name = "txtNumDocumentoCliente";
            this.txtNumDocumentoCliente.Size = new System.Drawing.Size(211, 27);
            this.txtNumDocumentoCliente.TabIndex = 3;
            this.txtNumDocumentoCliente.Text = "N° documento";
            this.txtNumDocumentoCliente.Enter += new System.EventHandler(this.txtNumDocumentoCliente_Enter);
            this.txtNumDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocumentoCliente_KeyPress);
            this.txtNumDocumentoCliente.Leave += new System.EventHandler(this.txtNumDocumentoCliente_Leave);
            // 
            // cmbTipoDocumentoCliente
            // 
            this.cmbTipoDocumentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDocumentoCliente.FormattingEnabled = true;
            this.cmbTipoDocumentoCliente.Location = new System.Drawing.Point(28, 102);
            this.cmbTipoDocumentoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDocumentoCliente.Name = "cmbTipoDocumentoCliente";
            this.cmbTipoDocumentoCliente.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumentoCliente.TabIndex = 0;
            // 
            // txtObservacionesCliente
            // 
            this.txtObservacionesCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacionesCliente.Location = new System.Drawing.Point(348, 102);
            this.txtObservacionesCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesCliente.MaxLength = 200;
            this.txtObservacionesCliente.Multiline = true;
            this.txtObservacionesCliente.Name = "txtObservacionesCliente";
            this.txtObservacionesCliente.Size = new System.Drawing.Size(286, 64);
            this.txtObservacionesCliente.TabIndex = 8;
            this.txtObservacionesCliente.Text = "Observaciones y/o consideraciones";
            this.txtObservacionesCliente.Enter += new System.EventHandler(this.txtObservacionesCliente_Enter);
            this.txtObservacionesCliente.Leave += new System.EventHandler(this.txtObservacionesCliente_Leave);
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtMailCliente.Location = new System.Drawing.Point(348, 29);
            this.txtMailCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(286, 27);
            this.txtMailCliente.TabIndex = 7;
            this.txtMailCliente.Text = "Mail";
            this.txtMailCliente.Enter += new System.EventHandler(this.txtMailCliente_Enter);
            this.txtMailCliente.Leave += new System.EventHandler(this.txtMailCliente_Leave);
            // 
            // txtAlternativoCliente
            // 
            this.txtAlternativoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtAlternativoCliente.Location = new System.Drawing.Point(28, 209);
            this.txtAlternativoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlternativoCliente.Name = "txtAlternativoCliente";
            this.txtAlternativoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtAlternativoCliente.TabIndex = 6;
            this.txtAlternativoCliente.Text = "Alternativo";
            this.txtAlternativoCliente.Enter += new System.EventHandler(this.txtAlternativoCliente_Enter);
            this.txtAlternativoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlternativoCliente_KeyPress);
            this.txtAlternativoCliente.Leave += new System.EventHandler(this.txtAlternativoCliente_Leave);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(28, 174);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtTelefonoCliente.TabIndex = 5;
            this.txtTelefonoCliente.Text = "Teléfono";
            this.txtTelefonoCliente.Enter += new System.EventHandler(this.txtTelefonoCliente_Enter);
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            this.txtTelefonoCliente.Leave += new System.EventHandler(this.txtTelefonoCliente_Leave);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaCliente.FlatAppearance.BorderSize = 0;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaCliente.Location = new System.Drawing.Point(348, 174);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(286, 62);
            this.btnAltaCliente.TabIndex = 9;
            this.btnAltaCliente.Text = "Aceptar";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dtgvCliente);
            this.Controls.Add(this.gbClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).EndInit();
            this.cmClientes.ResumeLayout(false);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dtgvCliente;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.TextBox txtNumDocumentoCliente;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoCliente;
        private System.Windows.Forms.TextBox txtObservacionesCliente;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.TextBox txtAlternativoCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.ContextMenuStrip cmClientes;
        private System.Windows.Forms.ToolStripMenuItem btnEditarDatosCliente;
        private System.Windows.Forms.ToolStripMenuItem editarPlanAsignado;
        private System.Windows.Forms.ToolStripMenuItem btnAsignarPlan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ToolStripMenuItem verPlanesAsignados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}