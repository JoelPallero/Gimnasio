
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
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.dtgvEmpleado = new System.Windows.Forms.DataGridView();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtAlternativoEmpleados = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleados = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).BeginInit();
            this.gbEmpleado.SuspendLayout();
            this.gbJornadaEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(440, 402);
            this.txtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(243, 27);
            this.txtBuscarEmpleado.TabIndex = 64;
            this.txtBuscarEmpleado.Text = "Buscar";
            // 
            // dtgvEmpleado
            // 
            this.dtgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleado.Location = new System.Drawing.Point(17, 436);
            this.dtgvEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmpleado.Name = "dtgvEmpleado";
            this.dtgvEmpleado.RowHeadersWidth = 51;
            this.dtgvEmpleado.RowTemplate.Height = 29;
            this.dtgvEmpleado.Size = new System.Drawing.Size(666, 205);
            this.dtgvEmpleado.TabIndex = 63;
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.cmbSexo);
            this.gbEmpleado.Controls.Add(this.txtAlternativoEmpleados);
            this.gbEmpleado.Controls.Add(this.txtTelefonoEmpleados);
            this.gbEmpleado.Controls.Add(this.txtDocument);
            this.gbEmpleado.Controls.Add(this.btnAltaEmpleado);
            this.gbEmpleado.Controls.Add(this.txtApellidoEmpleado);
            this.gbEmpleado.Controls.Add(this.gbJornadaEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbTipoDocumentoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtObservacionesEmpleado);
            this.gbEmpleado.Controls.Add(this.cmbTipoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtMailEmpleado);
            this.gbEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.gbEmpleado.Location = new System.Drawing.Point(17, 11);
            this.gbEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEmpleado.Size = new System.Drawing.Size(666, 386);
            this.gbEmpleado.TabIndex = 62;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Datos de Empleado";
            // 
            // cmbSexo
            // 
            this.cmbSexo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(17, 148);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(286, 28);
            this.cmbSexo.TabIndex = 72;
            this.cmbSexo.Text = "Sexo";
            // 
            // txtAlternativoEmpleados
            // 
            this.txtAlternativoEmpleados.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAlternativoEmpleados.Location = new System.Drawing.Point(17, 221);
            this.txtAlternativoEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlternativoEmpleados.Name = "txtAlternativoEmpleados";
            this.txtAlternativoEmpleados.Size = new System.Drawing.Size(286, 27);
            this.txtAlternativoEmpleados.TabIndex = 71;
            this.txtAlternativoEmpleados.Text = "Alternativo";
            // 
            // txtTelefonoEmpleados
            // 
            this.txtTelefonoEmpleados.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelefonoEmpleados.Location = new System.Drawing.Point(17, 182);
            this.txtTelefonoEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoEmpleados.Name = "txtTelefonoEmpleados";
            this.txtTelefonoEmpleados.Size = new System.Drawing.Size(286, 27);
            this.txtTelefonoEmpleados.TabIndex = 70;
            this.txtTelefonoEmpleados.Text = "Telefono";
            // 
            // txtDocument
            // 
            this.txtDocument.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDocument.Location = new System.Drawing.Point(92, 111);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(211, 27);
            this.txtDocument.TabIndex = 69;
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(333, 328);
            this.btnAltaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(307, 41);
            this.btnAltaEmpleado.TabIndex = 53;
            this.btnAltaEmpleado.Text = "Guardar";
            this.btnAltaEmpleado.UseVisualStyleBackColor = false;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.BtnSaveEmployee_Click);
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(17, 74);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtApellidoEmpleado.TabIndex = 68;
            this.txtApellidoEmpleado.Text = "Apellido";
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
            this.gbJornadaEmpleado.Location = new System.Drawing.Point(333, 71);
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
            this.chkTodos.TabIndex = 106;
            this.chkTodos.Text = "Seleccionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // txtHastaSabado
            // 
            this.txtHastaSabado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHastaSabado.Location = new System.Drawing.Point(215, 214);
            this.txtHastaSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaSabado.Name = "txtHastaSabado";
            this.txtHastaSabado.Size = new System.Drawing.Size(81, 27);
            this.txtHastaSabado.TabIndex = 105;
            this.txtHastaSabado.Text = "Hasta";
            // 
            // txtDesdeSabado
            // 
            this.txtDesdeSabado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesdeSabado.Location = new System.Drawing.Point(128, 214);
            this.txtDesdeSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeSabado.Name = "txtDesdeSabado";
            this.txtDesdeSabado.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeSabado.TabIndex = 104;
            this.txtDesdeSabado.Text = "Desde";
            // 
            // txtHastaViernes
            // 
            this.txtHastaViernes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHastaViernes.Location = new System.Drawing.Point(215, 184);
            this.txtHastaViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaViernes.Name = "txtHastaViernes";
            this.txtHastaViernes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaViernes.TabIndex = 103;
            this.txtHastaViernes.Text = "Hasta";
            // 
            // txtDesdeViernes
            // 
            this.txtDesdeViernes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesdeViernes.Location = new System.Drawing.Point(128, 184);
            this.txtDesdeViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeViernes.Name = "txtDesdeViernes";
            this.txtDesdeViernes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeViernes.TabIndex = 102;
            this.txtDesdeViernes.Text = "Desde";
            // 
            // txtHastaJueves
            // 
            this.txtHastaJueves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHastaJueves.Location = new System.Drawing.Point(215, 154);
            this.txtHastaJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaJueves.Name = "txtHastaJueves";
            this.txtHastaJueves.Size = new System.Drawing.Size(81, 27);
            this.txtHastaJueves.TabIndex = 101;
            this.txtHastaJueves.Text = "Hasta";
            // 
            // txtDesdeJueves
            // 
            this.txtDesdeJueves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesdeJueves.Location = new System.Drawing.Point(128, 154);
            this.txtDesdeJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeJueves.Name = "txtDesdeJueves";
            this.txtDesdeJueves.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeJueves.TabIndex = 100;
            this.txtDesdeJueves.Text = "Desde";
            // 
            // txtHastaMiercoles
            // 
            this.txtHastaMiercoles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHastaMiercoles.Location = new System.Drawing.Point(215, 124);
            this.txtHastaMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMiercoles.Name = "txtHastaMiercoles";
            this.txtHastaMiercoles.Size = new System.Drawing.Size(81, 27);
            this.txtHastaMiercoles.TabIndex = 99;
            this.txtHastaMiercoles.Text = "Hasta";
            // 
            // txtDesdeMiercoles
            // 
            this.txtDesdeMiercoles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesdeMiercoles.Location = new System.Drawing.Point(128, 124);
            this.txtDesdeMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMiercoles.Name = "txtDesdeMiercoles";
            this.txtDesdeMiercoles.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeMiercoles.TabIndex = 98;
            this.txtDesdeMiercoles.Text = "Desde";
            // 
            // txtHastaMartes
            // 
            this.txtHastaMartes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHastaMartes.Location = new System.Drawing.Point(215, 94);
            this.txtHastaMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMartes.Name = "txtHastaMartes";
            this.txtHastaMartes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaMartes.TabIndex = 97;
            this.txtHastaMartes.Text = "Hasta";
            // 
            // txtDesdeMartes
            // 
            this.txtDesdeMartes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesdeMartes.Location = new System.Drawing.Point(128, 94);
            this.txtDesdeMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMartes.Name = "txtDesdeMartes";
            this.txtDesdeMartes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeMartes.TabIndex = 96;
            this.txtDesdeMartes.Text = "Desde";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(10, 216);
            this.chkSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(82, 24);
            this.chkSabado.TabIndex = 95;
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
            this.chkViernes.TabIndex = 94;
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
            this.chkJueves.TabIndex = 93;
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
            this.chkMiercoles.TabIndex = 92;
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
            this.chkMartes.TabIndex = 91;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(10, 68);
            this.chkLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(68, 24);
            this.chkLunes.TabIndex = 90;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // txtHastaLunes
            // 
            this.txtHastaLunes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHastaLunes.Location = new System.Drawing.Point(215, 62);
            this.txtHastaLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaLunes.Name = "txtHastaLunes";
            this.txtHastaLunes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaLunes.TabIndex = 89;
            this.txtHastaLunes.Text = "Hasta";
            // 
            // txtDesdeLunes
            // 
            this.txtDesdeLunes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesdeLunes.Location = new System.Drawing.Point(128, 62);
            this.txtDesdeLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeLunes.Name = "txtDesdeLunes";
            this.txtDesdeLunes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeLunes.TabIndex = 88;
            this.txtDesdeLunes.Text = "Desde";
            // 
            // cmbTipoDocumentoEmpleado
            // 
            this.cmbTipoDocumentoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoDocumentoEmpleado.FormattingEnabled = true;
            this.cmbTipoDocumentoEmpleado.Location = new System.Drawing.Point(17, 111);
            this.cmbTipoDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDocumentoEmpleado.Name = "cmbTipoDocumentoEmpleado";
            this.cmbTipoDocumentoEmpleado.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumentoEmpleado.TabIndex = 65;
            this.cmbTipoDocumentoEmpleado.Text = "Tipo";
            // 
            // txtObservacionesEmpleado
            // 
            this.txtObservacionesEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtObservacionesEmpleado.Location = new System.Drawing.Point(17, 292);
            this.txtObservacionesEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesEmpleado.Multiline = true;
            this.txtObservacionesEmpleado.Name = "txtObservacionesEmpleado";
            this.txtObservacionesEmpleado.Size = new System.Drawing.Size(286, 76);
            this.txtObservacionesEmpleado.TabIndex = 64;
            this.txtObservacionesEmpleado.Text = "Observaciones y/o consideraciones";
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(333, 36);
            this.cmbTipoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(307, 28);
            this.cmbTipoEmpleado.TabIndex = 61;
            this.cmbTipoEmpleado.Text = "Tipo de empleado";
            // 
            // txtMailEmpleado
            // 
            this.txtMailEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMailEmpleado.Location = new System.Drawing.Point(17, 258);
            this.txtMailEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMailEmpleado.Name = "txtMailEmpleado";
            this.txtMailEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtMailEmpleado.TabIndex = 60;
            this.txtMailEmpleado.Text = "Mail";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(17, 38);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(286, 27);
            this.txtNombreEmpleado.TabIndex = 56;
            this.txtNombreEmpleado.Text = "Nombre";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.dtgvEmpleado);
            this.Controls.Add(this.gbEmpleado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Empleados";
            this.Text = "empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).EndInit();
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            this.gbJornadaEmpleado.ResumeLayout(false);
            this.gbJornadaEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.DataGridView dtgvEmpleado;
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
        private System.Windows.Forms.TextBox txtAlternativoEmpleados;
        private System.Windows.Forms.TextBox txtTelefonoEmpleados;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}