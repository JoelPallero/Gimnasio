
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbSexoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtAlternativoEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDocumentoEmpleado = new System.Windows.Forms.TextBox();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.gbJornadaEmpleado = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.txtHastaSabado = new System.Windows.Forms.TextBox();
            this.txtDesdeSabado = new System.Windows.Forms.TextBox();
            this.txtHastaViernes = new System.Windows.Forms.TextBox();
            this.txtDesdeViernes = new System.Windows.Forms.TextBox();
            this.txtHastaJueves = new System.Windows.Forms.TextBox();
            this.txtDesdeJueves = new System.Windows.Forms.TextBox();
            this.txtHastaMiercoles = new System.Windows.Forms.TextBox();
            this.txtDesdeMiercoles = new System.Windows.Forms.TextBox();
            this.txtHastaMartes = new System.Windows.Forms.TextBox();
            this.txtDesdeMartes = new System.Windows.Forms.TextBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.txtHastaLunes = new System.Windows.Forms.TextBox();
            this.txtDesdeLunes = new System.Windows.Forms.TextBox();
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
            this.editarEstadoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.editarJornadaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.blanqueoClaveEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEmpleado.SuspendLayout();
            this.gbJornadaEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            this.cmEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(439, 440);
            this.txtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(243, 27);
            this.txtBuscarEmpleado.TabIndex = 64;
            this.txtBuscarEmpleado.Text = "Buscar";
            this.txtBuscarEmpleado.Enter += new System.EventHandler(this.txtBuscarEmpleado_Enter);
            this.txtBuscarEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarEmpleado_KeyPress);
            this.txtBuscarEmpleado.Leave += new System.EventHandler(this.txtBuscarEmpleado_Leave);
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.txtClave);
            this.gbEmpleado.Controls.Add(this.txtUsuario);
            this.gbEmpleado.Controls.Add(this.cmbSexoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtAlternativoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtTelefonoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtDocumentoEmpleado);
            this.gbEmpleado.Controls.Add(this.btnAltaEmpleado);
            this.gbEmpleado.Controls.Add(this.txtApellidoEmpleado);
            this.gbEmpleado.Controls.Add(this.gbJornadaEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbTipoDocumentoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtObservacionesEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbTipoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtMailEmpleado);
            this.gbEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.gbEmpleado.Location = new System.Drawing.Point(16, 11);
            this.gbEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmpleado.Size = new System.Drawing.Size(666, 415);
            this.gbEmpleado.TabIndex = 62;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Datos de Empleado";
            // 
            // txtClave
            // 
            this.txtClave.ForeColor = System.Drawing.Color.DimGray;
            this.txtClave.Location = new System.Drawing.Point(336, 70);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(307, 27);
            this.txtClave.TabIndex = 73;
            this.txtClave.Text = "Clave";
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(336, 34);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(307, 27);
            this.txtUsuario.TabIndex = 7;
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
            this.cmbSexoEmpleado.TabIndex = 72;
            // 
            // txtAlternativoEmpleado
            // 
            this.txtAlternativoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtAlternativoEmpleado.Location = new System.Drawing.Point(20, 217);
            this.txtAlternativoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlternativoEmpleado.Name = "txtAlternativoEmpleado";
            this.txtAlternativoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtAlternativoEmpleado.TabIndex = 4;
            this.txtAlternativoEmpleado.Text = "Alternativo";
            this.txtAlternativoEmpleado.Enter += new System.EventHandler(this.txtAlternativoEmpleado_Enter);
            this.txtAlternativoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEmpleado_KeyPress);
            this.txtAlternativoEmpleado.Leave += new System.EventHandler(this.txtAlternativoEmpleado_Leave);
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(20, 178);
            this.txtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtTelefonoEmpleado.TabIndex = 3;
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
            this.txtDocumentoEmpleado.TabIndex = 2;
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
            this.btnAltaEmpleado.Location = new System.Drawing.Point(336, 357);
            this.btnAltaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(307, 41);
            this.btnAltaEmpleado.TabIndex = 28;
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
            // gbJornadaEmpleado
            // 
            this.gbJornadaEmpleado.Controls.Add(this.chkTodos);
            this.gbJornadaEmpleado.Controls.Add(this.txtHastaSabado);
            this.gbJornadaEmpleado.Controls.Add(this.txtDesdeSabado);
            this.gbJornadaEmpleado.Controls.Add(this.txtHastaViernes);
            this.gbJornadaEmpleado.Controls.Add(this.txtDesdeViernes);
            this.gbJornadaEmpleado.Controls.Add(this.txtHastaJueves);
            this.gbJornadaEmpleado.Controls.Add(this.txtDesdeJueves);
            this.gbJornadaEmpleado.Controls.Add(this.txtHastaMiercoles);
            this.gbJornadaEmpleado.Controls.Add(this.txtDesdeMiercoles);
            this.gbJornadaEmpleado.Controls.Add(this.txtHastaMartes);
            this.gbJornadaEmpleado.Controls.Add(this.txtDesdeMartes);
            this.gbJornadaEmpleado.Controls.Add(this.chkSabado);
            this.gbJornadaEmpleado.Controls.Add(this.chkViernes);
            this.gbJornadaEmpleado.Controls.Add(this.chkJueves);
            this.gbJornadaEmpleado.Controls.Add(this.chkMiercoles);
            this.gbJornadaEmpleado.Controls.Add(this.chkMartes);
            this.gbJornadaEmpleado.Controls.Add(this.chkLunes);
            this.gbJornadaEmpleado.Controls.Add(this.txtHastaLunes);
            this.gbJornadaEmpleado.Controls.Add(this.txtDesdeLunes);
            this.gbJornadaEmpleado.Location = new System.Drawing.Point(336, 102);
            this.gbJornadaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbJornadaEmpleado.Name = "gbJornadaEmpleado";
            this.gbJornadaEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbJornadaEmpleado.Size = new System.Drawing.Size(307, 249);
            this.gbJornadaEmpleado.TabIndex = 67;
            this.gbJornadaEmpleado.TabStop = false;
            this.gbJornadaEmpleado.Text = "Días y horarios";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(10, 29);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(149, 24);
            this.chkTodos.TabIndex = 9;
            this.chkTodos.Text = "Seleccionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // txtHastaSabado
            // 
            this.txtHastaSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaSabado.Location = new System.Drawing.Point(215, 214);
            this.txtHastaSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaSabado.MaxLength = 5;
            this.txtHastaSabado.Name = "txtHastaSabado";
            this.txtHastaSabado.Size = new System.Drawing.Size(81, 27);
            this.txtHastaSabado.TabIndex = 27;
            this.txtHastaSabado.Text = "Hasta";
            // 
            // txtDesdeSabado
            // 
            this.txtDesdeSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeSabado.Location = new System.Drawing.Point(128, 214);
            this.txtDesdeSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeSabado.MaxLength = 5;
            this.txtDesdeSabado.Name = "txtDesdeSabado";
            this.txtDesdeSabado.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeSabado.TabIndex = 26;
            this.txtDesdeSabado.Text = "Desde";
            // 
            // txtHastaViernes
            // 
            this.txtHastaViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaViernes.Location = new System.Drawing.Point(215, 184);
            this.txtHastaViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaViernes.MaxLength = 5;
            this.txtHastaViernes.Name = "txtHastaViernes";
            this.txtHastaViernes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaViernes.TabIndex = 24;
            this.txtHastaViernes.Text = "Hasta";
            // 
            // txtDesdeViernes
            // 
            this.txtDesdeViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeViernes.Location = new System.Drawing.Point(128, 184);
            this.txtDesdeViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeViernes.MaxLength = 5;
            this.txtDesdeViernes.Name = "txtDesdeViernes";
            this.txtDesdeViernes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeViernes.TabIndex = 23;
            this.txtDesdeViernes.Text = "Desde";
            // 
            // txtHastaJueves
            // 
            this.txtHastaJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaJueves.Location = new System.Drawing.Point(215, 154);
            this.txtHastaJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaJueves.MaxLength = 5;
            this.txtHastaJueves.Name = "txtHastaJueves";
            this.txtHastaJueves.Size = new System.Drawing.Size(81, 27);
            this.txtHastaJueves.TabIndex = 21;
            this.txtHastaJueves.Text = "Hasta";
            // 
            // txtDesdeJueves
            // 
            this.txtDesdeJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeJueves.Location = new System.Drawing.Point(128, 154);
            this.txtDesdeJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeJueves.MaxLength = 5;
            this.txtDesdeJueves.Name = "txtDesdeJueves";
            this.txtDesdeJueves.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeJueves.TabIndex = 20;
            this.txtDesdeJueves.Text = "Desde";
            // 
            // txtHastaMiercoles
            // 
            this.txtHastaMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMiercoles.Location = new System.Drawing.Point(215, 124);
            this.txtHastaMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMiercoles.MaxLength = 5;
            this.txtHastaMiercoles.Name = "txtHastaMiercoles";
            this.txtHastaMiercoles.Size = new System.Drawing.Size(81, 27);
            this.txtHastaMiercoles.TabIndex = 18;
            this.txtHastaMiercoles.Text = "Hasta";
            // 
            // txtDesdeMiercoles
            // 
            this.txtDesdeMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMiercoles.Location = new System.Drawing.Point(128, 124);
            this.txtDesdeMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMiercoles.MaxLength = 5;
            this.txtDesdeMiercoles.Name = "txtDesdeMiercoles";
            this.txtDesdeMiercoles.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeMiercoles.TabIndex = 17;
            this.txtDesdeMiercoles.Text = "Desde";
            // 
            // txtHastaMartes
            // 
            this.txtHastaMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMartes.Location = new System.Drawing.Point(215, 94);
            this.txtHastaMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMartes.MaxLength = 5;
            this.txtHastaMartes.Name = "txtHastaMartes";
            this.txtHastaMartes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaMartes.TabIndex = 15;
            this.txtHastaMartes.Text = "Hasta";
            // 
            // txtDesdeMartes
            // 
            this.txtDesdeMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMartes.Location = new System.Drawing.Point(128, 94);
            this.txtDesdeMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMartes.MaxLength = 5;
            this.txtDesdeMartes.Name = "txtDesdeMartes";
            this.txtDesdeMartes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeMartes.TabIndex = 14;
            this.txtDesdeMartes.Text = "Desde";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(10, 216);
            this.chkSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(82, 24);
            this.chkSabado.TabIndex = 25;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(10, 186);
            this.chkViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(79, 24);
            this.chkViernes.TabIndex = 22;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(10, 156);
            this.chkJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(73, 24);
            this.chkJueves.TabIndex = 19;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(10, 126);
            this.chkMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(95, 24);
            this.chkMiercoles.TabIndex = 16;
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(10, 96);
            this.chkMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(76, 24);
            this.chkMartes.TabIndex = 13;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(10, 64);
            this.chkLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(68, 24);
            this.chkLunes.TabIndex = 10;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // txtHastaLunes
            // 
            this.txtHastaLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaLunes.Location = new System.Drawing.Point(215, 62);
            this.txtHastaLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaLunes.MaxLength = 5;
            this.txtHastaLunes.Name = "txtHastaLunes";
            this.txtHastaLunes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaLunes.TabIndex = 12;
            this.txtHastaLunes.Text = "Hasta";
            // 
            // txtDesdeLunes
            // 
            this.txtDesdeLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeLunes.Location = new System.Drawing.Point(128, 62);
            this.txtDesdeLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeLunes.MaxLength = 5;
            this.txtDesdeLunes.Name = "txtDesdeLunes";
            this.txtDesdeLunes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeLunes.TabIndex = 11;
            this.txtDesdeLunes.Text = "Desde";
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
            this.cmbTipoDocumentoEmpleado.TabIndex = 65;
            // 
            // txtObservacionesEmpleado
            // 
            this.txtObservacionesEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacionesEmpleado.Location = new System.Drawing.Point(20, 322);
            this.txtObservacionesEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesEmpleado.Multiline = true;
            this.txtObservacionesEmpleado.Name = "txtObservacionesEmpleado";
            this.txtObservacionesEmpleado.Size = new System.Drawing.Size(286, 76);
            this.txtObservacionesEmpleado.TabIndex = 6;
            this.txtObservacionesEmpleado.Text = "Observaciones y/o consideraciones";
            this.txtObservacionesEmpleado.Enter += new System.EventHandler(this.txtObservacionesEmpleado_Enter);
            this.txtObservacionesEmpleado.Leave += new System.EventHandler(this.txtObservacionesEmpleado_Leave);
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(20, 288);
            this.cmbTipoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(286, 28);
            this.cmbTipoEmpleado.TabIndex = 61;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // txtMailEmpleado
            // 
            this.txtMailEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtMailEmpleado.Location = new System.Drawing.Point(20, 254);
            this.txtMailEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMailEmpleado.Name = "txtMailEmpleado";
            this.txtMailEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtMailEmpleado.TabIndex = 5;
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
            this.dtgvEmpleados.Location = new System.Drawing.Point(16, 471);
            this.dtgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvEmpleados.RowHeadersVisible = false;
            this.dtgvEmpleados.RowHeadersWidth = 51;
            this.dtgvEmpleados.RowTemplate.Height = 29;
            this.dtgvEmpleados.Size = new System.Drawing.Size(666, 168);
            this.dtgvEmpleados.TabIndex = 65;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle16;
            this.Documento.Frozen = true;
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 130;
            // 
            // Tipo_Empleado
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Empleado.DefaultCellStyle = dataGridViewCellStyle17;
            this.Tipo_Empleado.Frozen = true;
            this.Tipo_Empleado.HeaderText = "Empleado";
            this.Tipo_Empleado.MinimumWidth = 6;
            this.Tipo_Empleado.Name = "Tipo_Empleado";
            this.Tipo_Empleado.ReadOnly = true;
            this.Tipo_Empleado.Width = 130;
            // 
            // Estado
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle18;
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
            this.editarEstadoEmpleado,
            this.editarJornadaEmpleado,
            this.blanqueoClaveEmpleado});
            this.cmEmpleado.Name = "cmEmpleado";
            this.cmEmpleado.Size = new System.Drawing.Size(203, 100);
            this.cmEmpleado.Text = "Edición";
            // 
            // editarEmpleado
            // 
            this.editarEmpleado.Name = "editarEmpleado";
            this.editarEmpleado.Size = new System.Drawing.Size(202, 24);
            this.editarEmpleado.Text = "Editar Datos";
            this.editarEmpleado.Click += new System.EventHandler(this.editarEmpleado_Click);
            // 
            // editarEstadoEmpleado
            // 
            this.editarEstadoEmpleado.Name = "editarEstadoEmpleado";
            this.editarEstadoEmpleado.Size = new System.Drawing.Size(202, 24);
            this.editarEstadoEmpleado.Text = "Editar Estado";
            // 
            // editarJornadaEmpleado
            // 
            this.editarJornadaEmpleado.Name = "editarJornadaEmpleado";
            this.editarJornadaEmpleado.Size = new System.Drawing.Size(202, 24);
            this.editarJornadaEmpleado.Text = "Editar Jornada";
            // 
            // blanqueoClaveEmpleado
            // 
            this.blanqueoClaveEmpleado.Name = "blanqueoClaveEmpleado";
            this.blanqueoClaveEmpleado.Size = new System.Drawing.Size(202, 24);
            this.blanqueoClaveEmpleado.Text = "Blanqueo de Clave";
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
            this.gbJornadaEmpleado.ResumeLayout(false);
            this.gbJornadaEmpleado.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbJornadaEmpleado;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.TextBox txtHastaSabado;
        private System.Windows.Forms.TextBox txtDesdeSabado;
        private System.Windows.Forms.TextBox txtHastaViernes;
        private System.Windows.Forms.TextBox txtDesdeViernes;
        private System.Windows.Forms.TextBox txtHastaJueves;
        private System.Windows.Forms.TextBox txtDesdeJueves;
        private System.Windows.Forms.TextBox txtHastaMiercoles;
        private System.Windows.Forms.TextBox txtDesdeMiercoles;
        private System.Windows.Forms.TextBox txtHastaMartes;
        private System.Windows.Forms.TextBox txtDesdeMartes;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.TextBox txtHastaLunes;
        private System.Windows.Forms.TextBox txtDesdeLunes;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtAlternativoEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDocumentoEmpleado;
        private System.Windows.Forms.ComboBox cmbSexoEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.ContextMenuStrip cmEmpleado;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem editarEstadoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem editarJornadaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem blanqueoClaveEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtClave;
    }
}