
namespace Gym
{
    partial class Empleados
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
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.chkJornadaEmpleados = new System.Windows.Forms.CheckBox();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbSexoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtAlternativoEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDocumentoEmpleado = new System.Windows.Forms.TextBox();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumentoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtObservacionesEmpleado = new System.Windows.Forms.TextBox();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtMailEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmEmpleado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.editarJornada = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClave = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            this.cmEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(439, 378);
            this.txtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(243, 27);
            this.txtBuscarEmpleado.TabIndex = 15;
            this.txtBuscarEmpleado.Text = "Buscar";
            this.txtBuscarEmpleado.Enter += new System.EventHandler(this.txtBuscarEmpleado_Enter);
            this.txtBuscarEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarEmpleado_KeyPress);
            this.txtBuscarEmpleado.Leave += new System.EventHandler(this.txtBuscarEmpleado_Leave);
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.chkJornadaEmpleados);
            this.gbEmpleado.Controls.Add(this.cmbEstados);
            this.gbEmpleado.Controls.Add(this.txtClave);
            this.gbEmpleado.Controls.Add(this.txtUsuario);
            this.gbEmpleado.Controls.Add(this.cmbSexoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtAlternativoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtTelefonoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtDocumentoEmpleado);
            this.gbEmpleado.Controls.Add(this.btnAltaEmpleado);
            this.gbEmpleado.Controls.Add(this.txtApellidoEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbTipoDocumentoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtObservacionesEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbTipoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtMailEmpleado);
            this.gbEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.gbEmpleado.Location = new System.Drawing.Point(16, 11);
            this.gbEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmpleado.Size = new System.Drawing.Size(666, 340);
            this.gbEmpleado.TabIndex = 62;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Datos de Empleado";
            // 
            // chkJornadaEmpleados
            // 
            this.chkJornadaEmpleados.AutoSize = true;
            this.chkJornadaEmpleados.Location = new System.Drawing.Point(336, 153);
            this.chkJornadaEmpleados.Name = "chkJornadaEmpleados";
            this.chkJornadaEmpleados.Size = new System.Drawing.Size(191, 24);
            this.chkJornadaEmpleados.TabIndex = 12;
            this.chkJornadaEmpleados.Text = "Agregar jornada laboral";
            this.chkJornadaEmpleados.UseVisualStyleBackColor = true;
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "Seleccionar Estado del empleado"});
            this.cmbEstados.Location = new System.Drawing.Point(336, 108);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(307, 28);
            this.cmbEstados.TabIndex = 11;
            this.cmbEstados.Tag = "Seleccionar estado del empleado";
            // 
            // txtClave
            // 
            this.txtClave.ForeColor = System.Drawing.Color.DimGray;
            this.txtClave.Location = new System.Drawing.Point(336, 71);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(307, 27);
            this.txtClave.TabIndex = 10;
            this.txtClave.Text = "Clave";
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(336, 34);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(307, 27);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // cmbSexoEmpleado
            // 
            this.cmbSexoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSexoEmpleado.FormattingEnabled = true;
            this.cmbSexoEmpleado.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoEmpleado.Location = new System.Drawing.Point(20, 144);
            this.cmbSexoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexoEmpleado.Name = "cmbSexoEmpleado";
            this.cmbSexoEmpleado.Size = new System.Drawing.Size(286, 28);
            this.cmbSexoEmpleado.TabIndex = 4;
            // 
            // txtAlternativoEmpleado
            // 
            this.txtAlternativoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtAlternativoEmpleado.Location = new System.Drawing.Point(20, 219);
            this.txtAlternativoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlternativoEmpleado.Name = "txtAlternativoEmpleado";
            this.txtAlternativoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtAlternativoEmpleado.TabIndex = 6;
            this.txtAlternativoEmpleado.Text = "Alternativo";
            this.txtAlternativoEmpleado.Enter += new System.EventHandler(this.txtAlternativoEmpleado_Enter);
            this.txtAlternativoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEmpleado_KeyPress);
            this.txtAlternativoEmpleado.Leave += new System.EventHandler(this.txtAlternativoEmpleado_Leave);
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(20, 183);
            this.txtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtTelefonoEmpleado.TabIndex = 5;
            this.txtTelefonoEmpleado.Text = "Teléfono";
            this.txtTelefonoEmpleado.Enter += new System.EventHandler(this.txtTelefonoEmpleado_Enter);
            this.txtTelefonoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEmpleado_KeyPress);
            this.txtTelefonoEmpleado.Leave += new System.EventHandler(this.txtTelefonoEmpleado_Leave);
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(95, 107);
            this.txtDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(211, 27);
            this.txtDocumentoEmpleado.TabIndex = 3;
            this.txtDocumentoEmpleado.Text = "Documento";
            this.txtDocumentoEmpleado.Enter += new System.EventHandler(this.txtDocumentoEmpleado_Enter);
            this.txtDocumentoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocumentoEmpleado_KeyPress);
            this.txtDocumentoEmpleado.Leave += new System.EventHandler(this.txtDocumentoEmpleado_Leave);
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(336, 281);
            this.btnAltaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(307, 41);
            this.btnAltaEmpleado.TabIndex = 14;
            this.btnAltaEmpleado.Text = "Guardar";
            this.btnAltaEmpleado.UseVisualStyleBackColor = false;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(20, 70);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtApellidoEmpleado.TabIndex = 1;
            this.txtApellidoEmpleado.Text = "Apellido";
            this.txtApellidoEmpleado.Enter += new System.EventHandler(this.txtApellidoEmpleado_Enter);
            this.txtApellidoEmpleado.Leave += new System.EventHandler(this.txtApellidoEmpleado_Leave);
            // 
            // cmbTipoDocumentoEmpleado
            // 
            this.cmbTipoDocumentoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoDocumentoEmpleado.FormattingEnabled = true;
            this.cmbTipoDocumentoEmpleado.Location = new System.Drawing.Point(20, 107);
            this.cmbTipoDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDocumentoEmpleado.Name = "cmbTipoDocumentoEmpleado";
            this.cmbTipoDocumentoEmpleado.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumentoEmpleado.TabIndex = 2;
            // 
            // txtObservacionesEmpleado
            // 
            this.txtObservacionesEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacionesEmpleado.Location = new System.Drawing.Point(336, 192);
            this.txtObservacionesEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesEmpleado.Multiline = true;
            this.txtObservacionesEmpleado.Name = "txtObservacionesEmpleado";
            this.txtObservacionesEmpleado.Size = new System.Drawing.Size(307, 85);
            this.txtObservacionesEmpleado.TabIndex = 13;
            this.txtObservacionesEmpleado.Text = "Observaciones y/o consideraciones";
            this.txtObservacionesEmpleado.Enter += new System.EventHandler(this.txtObservacionesEmpleado_Enter);
            this.txtObservacionesEmpleado.Leave += new System.EventHandler(this.txtObservacionesEmpleado_Leave);
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(20, 294);
            this.cmbTipoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(286, 28);
            this.cmbTipoEmpleado.TabIndex = 8;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // txtMailEmpleado
            // 
            this.txtMailEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtMailEmpleado.Location = new System.Drawing.Point(20, 255);
            this.txtMailEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMailEmpleado.Name = "txtMailEmpleado";
            this.txtMailEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtMailEmpleado.TabIndex = 7;
            this.txtMailEmpleado.Text = "Mail";
            this.txtMailEmpleado.Enter += new System.EventHandler(this.txtMailEmpleado_Enter);
            this.txtMailEmpleado.Leave += new System.EventHandler(this.txtMailEmpleado_Leave);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(20, 34);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtNombreEmpleado.TabIndex = 0;
            this.txtNombreEmpleado.Text = "Nombre";
            this.txtNombreEmpleado.Enter += new System.EventHandler(this.txtNombreEmpleado_Enter);
            this.txtNombreEmpleado.Leave += new System.EventHandler(this.txtNombreEmpleado_Leave);
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.AllowUserToAddRows = false;
            this.dtgvEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Persona_ID,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Tipo_Empleado,
            this.Estado});
            this.dtgvEmpleados.ContextMenuStrip = this.cmEmpleado;
            this.dtgvEmpleados.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvEmpleados.Location = new System.Drawing.Point(16, 409);
            this.dtgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvEmpleados.RowHeadersVisible = false;
            this.dtgvEmpleados.RowHeadersWidth = 51;
            this.dtgvEmpleados.RowTemplate.Height = 29;
            this.dtgvEmpleados.Size = new System.Drawing.Size(666, 230);
            this.dtgvEmpleados.TabIndex = 16;
            // 
            // Persona_ID
            // 
            this.Persona_ID.Frozen = true;
            this.Persona_ID.HeaderText = "ID de Persona";
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
            // Tipo_Empleado
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Empleado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tipo_Empleado.Frozen = true;
            this.Tipo_Empleado.HeaderText = "Empleado";
            this.Tipo_Empleado.MinimumWidth = 6;
            this.Tipo_Empleado.Name = "Tipo_Empleado";
            this.Tipo_Empleado.ReadOnly = true;
            this.Tipo_Empleado.Width = 130;
            // 
            // Estado
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 142;
            // 
            // cmEmpleado
            // 
            this.cmEmpleado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarEmpleado,
            this.editarJornada,
            this.editarClave});
            this.cmEmpleado.Name = "cmEmpleado";
            this.cmEmpleado.Size = new System.Drawing.Size(203, 76);
            this.cmEmpleado.Text = "Edición";
            // 
            // editarEmpleado
            // 
            this.editarEmpleado.Name = "editarEmpleado";
            this.editarEmpleado.Size = new System.Drawing.Size(202, 24);
            this.editarEmpleado.Text = "Editar Datos";
            this.editarEmpleado.Click += new System.EventHandler(this.editarEmpleado_Click);
            // 
            // editarJornada
            // 
            this.editarJornada.Name = "editarJornada";
            this.editarJornada.Size = new System.Drawing.Size(202, 24);
            this.editarJornada.Text = "Editar Jornadas";
            this.editarJornada.Click += new System.EventHandler(this.editarJornada_Click);
            // 
            // editarClave
            // 
            this.editarClave.Name = "editarClave";
            this.editarClave.Size = new System.Drawing.Size(202, 24);
            this.editarClave.Text = "Blanqueo de Clave";
            this.editarClave.Click += new System.EventHandler(this.editarClave_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.dtgvEmpleados);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.gbEmpleado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            this.cmEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoEmpleado;
        private System.Windows.Forms.TextBox txtObservacionesEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.TextBox txtMailEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtAlternativoEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDocumentoEmpleado;
        private System.Windows.Forms.ComboBox cmbSexoEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.ContextMenuStrip cmEmpleado;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem editarClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ToolStripMenuItem editarJornada;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.CheckBox chkJornadaEmpleados;
    }
}