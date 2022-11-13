
namespace Gym
{
    partial class Planes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPlanes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarJornadaPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GbModificarPlan = new System.Windows.Forms.GroupBox();
            this.lblVerJornadas = new System.Windows.Forms.LinkLabel();
            this.lblCuposTotales = new System.Windows.Forms.Label();
            this.lblCuposRestantes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCostoMensual = new System.Windows.Forms.Label();
            this.cmbPlanesActivos = new System.Windows.Forms.ComboBox();
            this.btnAsignarPlan = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblPlanesCliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GbJornadaPlanes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gpDatosPlan = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCupoTotal = new System.Windows.Forms.TextBox();
            this.txtNombrePlan = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.cmbProfesores = new System.Windows.Forms.ComboBox();
            this.btnAltaPlan = new System.Windows.Forms.Button();
            this.TxtBuscarPlan = new System.Windows.Forms.TextBox();
            this.dtgvPlanes = new System.Windows.Forms.DataGridView();
            this.Persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_horarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPlanes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GbModificarPlan.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GbJornadaPlanes.SuspendLayout();
            this.gpDatosPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPlanes
            // 
            this.menuPlanes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.btnEliminarJornadaPlan});
            this.menuPlanes.Name = "contextMenuStrip1";
            this.menuPlanes.Size = new System.Drawing.Size(211, 80);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(210, 24);
            this.edit.Text = "Editar";
            // 
            // btnEliminarJornadaPlan
            // 
            this.btnEliminarJornadaPlan.Name = "btnEliminarJornadaPlan";
            this.btnEliminarJornadaPlan.Size = new System.Drawing.Size(210, 24);
            this.btnEliminarJornadaPlan.Text = "Eliminar";
            this.btnEliminarJornadaPlan.Click += new System.EventHandler(this.btnEliminarJornadaPlan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 371);
            this.tabControl1.TabIndex = 72;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GbModificarPlan);
            this.tabPage1.Controls.Add(this.gbDatosCliente);
            this.tabPage1.Controls.Add(this.txtBuscarCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(692, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar Plan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GbModificarPlan
            // 
            this.GbModificarPlan.Controls.Add(this.lblVerJornadas);
            this.GbModificarPlan.Controls.Add(this.lblCuposTotales);
            this.GbModificarPlan.Controls.Add(this.lblCuposRestantes);
            this.GbModificarPlan.Controls.Add(this.label12);
            this.GbModificarPlan.Controls.Add(this.lblCostoMensual);
            this.GbModificarPlan.Controls.Add(this.cmbPlanesActivos);
            this.GbModificarPlan.Controls.Add(this.btnAsignarPlan);
            this.GbModificarPlan.Controls.Add(this.label20);
            this.GbModificarPlan.Location = new System.Drawing.Point(9, 189);
            this.GbModificarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbModificarPlan.Name = "GbModificarPlan";
            this.GbModificarPlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbModificarPlan.Size = new System.Drawing.Size(675, 145);
            this.GbModificarPlan.TabIndex = 16;
            this.GbModificarPlan.TabStop = false;
            this.GbModificarPlan.Text = "Planes vigentes";
            // 
            // lblVerJornadas
            // 
            this.lblVerJornadas.AutoSize = true;
            this.lblVerJornadas.Location = new System.Drawing.Point(267, 22);
            this.lblVerJornadas.Name = "lblVerJornadas";
            this.lblVerJornadas.Size = new System.Drawing.Size(91, 20);
            this.lblVerJornadas.TabIndex = 34;
            this.lblVerJornadas.TabStop = true;
            this.lblVerJornadas.Text = "Ver jornadas";
            this.lblVerJornadas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVerJornadas_LinkClicked);
            // 
            // lblCuposTotales
            // 
            this.lblCuposTotales.AutoSize = true;
            this.lblCuposTotales.Location = new System.Drawing.Point(298, 59);
            this.lblCuposTotales.Name = "lblCuposTotales";
            this.lblCuposTotales.Size = new System.Drawing.Size(25, 20);
            this.lblCuposTotales.TabIndex = 30;
            this.lblCuposTotales.Text = "10";
            // 
            // lblCuposRestantes
            // 
            this.lblCuposRestantes.AutoSize = true;
            this.lblCuposRestantes.Location = new System.Drawing.Point(267, 59);
            this.lblCuposRestantes.Name = "lblCuposRestantes";
            this.lblCuposRestantes.Size = new System.Drawing.Size(25, 20);
            this.lblCuposRestantes.TabIndex = 29;
            this.lblCuposRestantes.Text = "10";
            this.lblCuposRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Planes disponibles";
            // 
            // lblCostoMensual
            // 
            this.lblCostoMensual.AutoSize = true;
            this.lblCostoMensual.Location = new System.Drawing.Point(22, 108);
            this.lblCostoMensual.Name = "lblCostoMensual";
            this.lblCostoMensual.Size = new System.Drawing.Size(121, 20);
            this.lblCostoMensual.TabIndex = 26;
            this.lblCostoMensual.Text = "Costo mensual: $";
            // 
            // cmbPlanesActivos
            // 
            this.cmbPlanesActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanesActivos.FormattingEnabled = true;
            this.cmbPlanesActivos.Location = new System.Drawing.Point(20, 56);
            this.cmbPlanesActivos.Name = "cmbPlanesActivos";
            this.cmbPlanesActivos.Size = new System.Drawing.Size(216, 28);
            this.cmbPlanesActivos.TabIndex = 25;
            this.cmbPlanesActivos.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanesActivos_SelectionChangeCommitted);
            // 
            // btnAsignarPlan
            // 
            this.btnAsignarPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAsignarPlan.FlatAppearance.BorderSize = 0;
            this.btnAsignarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarPlan.Location = new System.Drawing.Point(461, 88);
            this.btnAsignarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPlan.Name = "btnAsignarPlan";
            this.btnAsignarPlan.Size = new System.Drawing.Size(199, 40);
            this.btnAsignarPlan.TabIndex = 24;
            this.btnAsignarPlan.Text = "Asignar plan al Cliente";
            this.btnAsignarPlan.UseVisualStyleBackColor = false;
            this.btnAsignarPlan.Click += new System.EventHandler(this.btnAsignarPlan_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(288, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "/";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.lblPlanesCliente);
            this.gbDatosCliente.Controls.Add(this.lblTelefono);
            this.gbDatosCliente.Controls.Add(this.lblMail);
            this.gbDatosCliente.Controls.Add(this.lblDocumento);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Location = new System.Drawing.Point(9, 48);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosCliente.Size = new System.Drawing.Size(675, 132);
            this.gbDatosCliente.TabIndex = 6;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // lblPlanesCliente
            // 
            this.lblPlanesCliente.AutoSize = true;
            this.lblPlanesCliente.Location = new System.Drawing.Point(358, 60);
            this.lblPlanesCliente.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblPlanesCliente.Name = "lblPlanesCliente";
            this.lblPlanesCliente.Size = new System.Drawing.Size(90, 20);
            this.lblPlanesCliente.TabIndex = 14;
            this.lblPlanesCliente.Text = "Plan Actual: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 91);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 20);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(358, 32);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 20);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(22, 60);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(42, 20);
            this.lblDocumento.TabIndex = 9;
            this.lblDocumento.Text = "DNI: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCliente.Location = new System.Drawing.Point(139, 15);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(396, 25);
            this.txtBuscarCliente.TabIndex = 4;
            this.txtBuscarCliente.Text = "DNI";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.txtBuscarCliente_Enter);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.txtBuscarCliente_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GbJornadaPlanes);
            this.tabPage2.Controls.Add(this.gpDatosPlan);
            this.tabPage2.Controls.Add(this.btnAltaPlan);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(692, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alta de Planes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GbJornadaPlanes
            // 
            this.GbJornadaPlanes.Controls.Add(this.label2);
            this.GbJornadaPlanes.Controls.Add(this.label1);
            this.GbJornadaPlanes.Controls.Add(this.chkTodos);
            this.GbJornadaPlanes.Controls.Add(this.txtHastaSabado);
            this.GbJornadaPlanes.Controls.Add(this.txtDesdeSabado);
            this.GbJornadaPlanes.Controls.Add(this.txtHastaViernes);
            this.GbJornadaPlanes.Controls.Add(this.txtDesdeViernes);
            this.GbJornadaPlanes.Controls.Add(this.txtHastaJueves);
            this.GbJornadaPlanes.Controls.Add(this.txtDesdeJueves);
            this.GbJornadaPlanes.Controls.Add(this.txtHastaMiercoles);
            this.GbJornadaPlanes.Controls.Add(this.txtDesdeMiercoles);
            this.GbJornadaPlanes.Controls.Add(this.txtHastaMartes);
            this.GbJornadaPlanes.Controls.Add(this.txtDesdeMartes);
            this.GbJornadaPlanes.Controls.Add(this.chkSabado);
            this.GbJornadaPlanes.Controls.Add(this.chkViernes);
            this.GbJornadaPlanes.Controls.Add(this.chkJueves);
            this.GbJornadaPlanes.Controls.Add(this.chkMiercoles);
            this.GbJornadaPlanes.Controls.Add(this.chkMartes);
            this.GbJornadaPlanes.Controls.Add(this.chkLunes);
            this.GbJornadaPlanes.Controls.Add(this.txtHastaLunes);
            this.GbJornadaPlanes.Controls.Add(this.txtDesdeLunes);
            this.GbJornadaPlanes.Location = new System.Drawing.Point(375, 9);
            this.GbJornadaPlanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbJornadaPlanes.Name = "GbJornadaPlanes";
            this.GbJornadaPlanes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbJornadaPlanes.Size = new System.Drawing.Size(307, 257);
            this.GbJornadaPlanes.TabIndex = 87;
            this.GbJornadaPlanes.TabStop = false;
            this.GbJornadaPlanes.Text = "Días y horarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Desde";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(123, 24);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(149, 24);
            this.chkTodos.TabIndex = 30;
            this.chkTodos.Text = "Seleccionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.Click += new System.EventHandler(this.chkTodos_Click);
            // 
            // txtHastaSabado
            // 
            this.txtHastaSabado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaSabado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaSabado.Location = new System.Drawing.Point(215, 221);
            this.txtHastaSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaSabado.MaxLength = 5;
            this.txtHastaSabado.Name = "txtHastaSabado";
            this.txtHastaSabado.Size = new System.Drawing.Size(81, 27);
            this.txtHastaSabado.TabIndex = 48;
            this.txtHastaSabado.Text = "hh:mm";
            this.txtHastaSabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaSabado.Enter += new System.EventHandler(this.txtHastaSabado_Enter);
            this.txtHastaSabado.Leave += new System.EventHandler(this.txtHastaSabado_Leave);
            // 
            // txtDesdeSabado
            // 
            this.txtDesdeSabado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeSabado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeSabado.Location = new System.Drawing.Point(128, 221);
            this.txtDesdeSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeSabado.MaxLength = 5;
            this.txtDesdeSabado.Name = "txtDesdeSabado";
            this.txtDesdeSabado.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeSabado.TabIndex = 47;
            this.txtDesdeSabado.Text = "hh:mm";
            this.txtDesdeSabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeSabado.Enter += new System.EventHandler(this.txtDesdeSabado_Enter);
            this.txtDesdeSabado.Leave += new System.EventHandler(this.txtDesdeSabado_Leave);
            // 
            // txtHastaViernes
            // 
            this.txtHastaViernes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaViernes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaViernes.Location = new System.Drawing.Point(215, 191);
            this.txtHastaViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaViernes.MaxLength = 5;
            this.txtHastaViernes.Name = "txtHastaViernes";
            this.txtHastaViernes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaViernes.TabIndex = 45;
            this.txtHastaViernes.Text = "hh:mm";
            this.txtHastaViernes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaViernes.Enter += new System.EventHandler(this.txtHastaViernes_Enter);
            this.txtHastaViernes.Leave += new System.EventHandler(this.txtHastaViernes_Leave);
            // 
            // txtDesdeViernes
            // 
            this.txtDesdeViernes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeViernes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeViernes.Location = new System.Drawing.Point(128, 191);
            this.txtDesdeViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeViernes.MaxLength = 5;
            this.txtDesdeViernes.Name = "txtDesdeViernes";
            this.txtDesdeViernes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeViernes.TabIndex = 44;
            this.txtDesdeViernes.Text = "hh:mm";
            this.txtDesdeViernes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeViernes.Enter += new System.EventHandler(this.txtDesdeViernes_Enter);
            this.txtDesdeViernes.Leave += new System.EventHandler(this.txtDesdeViernes_Leave);
            // 
            // txtHastaJueves
            // 
            this.txtHastaJueves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaJueves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaJueves.Location = new System.Drawing.Point(215, 161);
            this.txtHastaJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaJueves.MaxLength = 5;
            this.txtHastaJueves.Name = "txtHastaJueves";
            this.txtHastaJueves.Size = new System.Drawing.Size(81, 27);
            this.txtHastaJueves.TabIndex = 42;
            this.txtHastaJueves.Text = "hh:mm";
            this.txtHastaJueves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaJueves.Enter += new System.EventHandler(this.txtHastaJueves_Enter);
            this.txtHastaJueves.Leave += new System.EventHandler(this.txtHastaJueves_Leave);
            // 
            // txtDesdeJueves
            // 
            this.txtDesdeJueves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeJueves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeJueves.Location = new System.Drawing.Point(128, 161);
            this.txtDesdeJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeJueves.MaxLength = 5;
            this.txtDesdeJueves.Name = "txtDesdeJueves";
            this.txtDesdeJueves.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeJueves.TabIndex = 41;
            this.txtDesdeJueves.Text = "hh:mm";
            this.txtDesdeJueves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeJueves.Enter += new System.EventHandler(this.txtDesdeJueves_Enter);
            this.txtDesdeJueves.Leave += new System.EventHandler(this.txtDesdeJueves_Leave);
            // 
            // txtHastaMiercoles
            // 
            this.txtHastaMiercoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaMiercoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMiercoles.Location = new System.Drawing.Point(215, 131);
            this.txtHastaMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMiercoles.MaxLength = 5;
            this.txtHastaMiercoles.Name = "txtHastaMiercoles";
            this.txtHastaMiercoles.Size = new System.Drawing.Size(81, 27);
            this.txtHastaMiercoles.TabIndex = 39;
            this.txtHastaMiercoles.Text = "hh:mm";
            this.txtHastaMiercoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaMiercoles.Enter += new System.EventHandler(this.txtHastaMiercoles_Enter);
            this.txtHastaMiercoles.Leave += new System.EventHandler(this.txtHastaMiercoles_Leave);
            // 
            // txtDesdeMiercoles
            // 
            this.txtDesdeMiercoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeMiercoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMiercoles.Location = new System.Drawing.Point(128, 131);
            this.txtDesdeMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMiercoles.MaxLength = 5;
            this.txtDesdeMiercoles.Name = "txtDesdeMiercoles";
            this.txtDesdeMiercoles.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeMiercoles.TabIndex = 38;
            this.txtDesdeMiercoles.Text = "hh:mm";
            this.txtDesdeMiercoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeMiercoles.Enter += new System.EventHandler(this.txtDesdeMiercoles_Enter);
            this.txtDesdeMiercoles.Leave += new System.EventHandler(this.txtDesdeMiercoles_Leave);
            // 
            // txtHastaMartes
            // 
            this.txtHastaMartes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaMartes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMartes.Location = new System.Drawing.Point(215, 101);
            this.txtHastaMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMartes.MaxLength = 5;
            this.txtHastaMartes.Name = "txtHastaMartes";
            this.txtHastaMartes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaMartes.TabIndex = 36;
            this.txtHastaMartes.Text = "hh:mm";
            this.txtHastaMartes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaMartes.Enter += new System.EventHandler(this.txtHastaMartes_Enter);
            this.txtHastaMartes.Leave += new System.EventHandler(this.txtHastaMartes_Leave);
            // 
            // txtDesdeMartes
            // 
            this.txtDesdeMartes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeMartes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMartes.Location = new System.Drawing.Point(128, 101);
            this.txtDesdeMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMartes.MaxLength = 5;
            this.txtDesdeMartes.Name = "txtDesdeMartes";
            this.txtDesdeMartes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeMartes.TabIndex = 35;
            this.txtDesdeMartes.Text = "hh:mm";
            this.txtDesdeMartes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeMartes.Enter += new System.EventHandler(this.txtDesdeMartes_Enter);
            this.txtDesdeMartes.Leave += new System.EventHandler(this.txtDesdeMartes_Leave);
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(10, 224);
            this.chkSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(82, 24);
            this.chkSabado.TabIndex = 46;
            this.chkSabado.Text = "Sabado";
            this.chkSabado.UseVisualStyleBackColor = true;
            this.chkSabado.Click += new System.EventHandler(this.chkSabado_Click);
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(10, 194);
            this.chkViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(79, 24);
            this.chkViernes.TabIndex = 43;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            this.chkViernes.Click += new System.EventHandler(this.chkViernes_Click);
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(10, 164);
            this.chkJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(73, 24);
            this.chkJueves.TabIndex = 40;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            this.chkJueves.Click += new System.EventHandler(this.chkJueves_Click);
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(10, 134);
            this.chkMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(95, 24);
            this.chkMiercoles.TabIndex = 37;
            this.chkMiercoles.Text = "Miercoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            this.chkMiercoles.Click += new System.EventHandler(this.chkMiercoles_Click);
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(10, 104);
            this.chkMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(76, 24);
            this.chkMartes.TabIndex = 34;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            this.chkMartes.Click += new System.EventHandler(this.chkMartes_Click);
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(10, 74);
            this.chkLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(68, 24);
            this.chkLunes.TabIndex = 31;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            this.chkLunes.Click += new System.EventHandler(this.chkLunes_Click);
            // 
            // txtHastaLunes
            // 
            this.txtHastaLunes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaLunes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaLunes.Location = new System.Drawing.Point(215, 72);
            this.txtHastaLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaLunes.MaxLength = 5;
            this.txtHastaLunes.Name = "txtHastaLunes";
            this.txtHastaLunes.Size = new System.Drawing.Size(81, 27);
            this.txtHastaLunes.TabIndex = 33;
            this.txtHastaLunes.Text = "hh:mm";
            this.txtHastaLunes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaLunes.Enter += new System.EventHandler(this.txtHastaLunes_Enter);
            this.txtHastaLunes.Leave += new System.EventHandler(this.txtHastaLunes_Leave);
            // 
            // txtDesdeLunes
            // 
            this.txtDesdeLunes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeLunes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeLunes.Location = new System.Drawing.Point(128, 72);
            this.txtDesdeLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeLunes.MaxLength = 5;
            this.txtDesdeLunes.Name = "txtDesdeLunes";
            this.txtDesdeLunes.Size = new System.Drawing.Size(81, 27);
            this.txtDesdeLunes.TabIndex = 32;
            this.txtDesdeLunes.Text = "hh:mm";
            this.txtDesdeLunes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeLunes.Enter += new System.EventHandler(this.txtDesdeLunes_Enter);
            this.txtDesdeLunes.Leave += new System.EventHandler(this.txtDesdeLunes_Leave);
            // 
            // gpDatosPlan
            // 
            this.gpDatosPlan.Controls.Add(this.label8);
            this.gpDatosPlan.Controls.Add(this.label7);
            this.gpDatosPlan.Controls.Add(this.label6);
            this.gpDatosPlan.Controls.Add(this.label5);
            this.gpDatosPlan.Controls.Add(this.label4);
            this.gpDatosPlan.Controls.Add(this.label3);
            this.gpDatosPlan.Controls.Add(this.dtpFechaInicio);
            this.gpDatosPlan.Controls.Add(this.txtDuracion);
            this.gpDatosPlan.Controls.Add(this.txtCupoTotal);
            this.gpDatosPlan.Controls.Add(this.txtNombrePlan);
            this.gpDatosPlan.Controls.Add(this.txtImporte);
            this.gpDatosPlan.Controls.Add(this.cmbProfesores);
            this.gpDatosPlan.Location = new System.Drawing.Point(8, 9);
            this.gpDatosPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatosPlan.Name = "gpDatosPlan";
            this.gpDatosPlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatosPlan.Size = new System.Drawing.Size(351, 309);
            this.gpDatosPlan.TabIndex = 85;
            this.gpDatosPlan.TabStop = false;
            this.gpDatosPlan.Text = "Datos de Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 95;
            this.label8.Text = "Fecha de Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 94;
            this.label7.Text = "Cupos totales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "Duración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Costo Mensual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nombre de la clase";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(19, 263);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(317, 27);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // txtDuracion
            // 
            this.txtDuracion.ForeColor = System.Drawing.Color.Black;
            this.txtDuracion.Location = new System.Drawing.Point(19, 210);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(144, 27);
            this.txtDuracion.TabIndex = 4;
            // 
            // txtCupoTotal
            // 
            this.txtCupoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtCupoTotal.Location = new System.Drawing.Point(192, 210);
            this.txtCupoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCupoTotal.Name = "txtCupoTotal";
            this.txtCupoTotal.Size = new System.Drawing.Size(144, 27);
            this.txtCupoTotal.TabIndex = 5;
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.ForeColor = System.Drawing.Color.Black;
            this.txtNombrePlan.Location = new System.Drawing.Point(19, 49);
            this.txtNombrePlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(317, 27);
            this.txtNombrePlan.TabIndex = 86;
            // 
            // txtImporte
            // 
            this.txtImporte.ForeColor = System.Drawing.Color.Black;
            this.txtImporte.Location = new System.Drawing.Point(19, 101);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(317, 27);
            this.txtImporte.TabIndex = 1;
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesores.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(19, 153);
            this.cmbProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(317, 28);
            this.cmbProfesores.TabIndex = 3;
            // 
            // btnAltaPlan
            // 
            this.btnAltaPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaPlan.FlatAppearance.BorderSize = 0;
            this.btnAltaPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaPlan.Location = new System.Drawing.Point(375, 272);
            this.btnAltaPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaPlan.Name = "btnAltaPlan";
            this.btnAltaPlan.Size = new System.Drawing.Size(307, 46);
            this.btnAltaPlan.TabIndex = 49;
            this.btnAltaPlan.Text = "Guardar Clase";
            this.btnAltaPlan.UseVisualStyleBackColor = false;
            this.btnAltaPlan.Click += new System.EventHandler(this.btnAltaPlan_Click);
            // 
            // TxtBuscarPlan
            // 
            this.TxtBuscarPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtBuscarPlan.Location = new System.Drawing.Point(392, 375);
            this.TxtBuscarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarPlan.Name = "TxtBuscarPlan";
            this.TxtBuscarPlan.Size = new System.Drawing.Size(304, 27);
            this.TxtBuscarPlan.TabIndex = 50;
            this.TxtBuscarPlan.Text = "Buscar Clase";
            // 
            // dtgvPlanes
            // 
            this.dtgvPlanes.AllowUserToAddRows = false;
            this.dtgvPlanes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Persona_ID,
            this.Nombre,
            this.Profesor_n,
            this.Dias_horarios});
            this.dtgvPlanes.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvPlanes.Location = new System.Drawing.Point(4, 409);
            this.dtgvPlanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPlanes.Name = "dtgvPlanes";
            this.dtgvPlanes.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvPlanes.RowHeadersVisible = false;
            this.dtgvPlanes.RowHeadersWidth = 51;
            this.dtgvPlanes.RowTemplate.Height = 29;
            this.dtgvPlanes.Size = new System.Drawing.Size(692, 230);
            this.dtgvPlanes.TabIndex = 86;
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
            this.Nombre.Width = 180;
            // 
            // Profesor_n
            // 
            this.Profesor_n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Profesor_n.DefaultCellStyle = dataGridViewCellStyle8;
            this.Profesor_n.Frozen = true;
            this.Profesor_n.HeaderText = "Profesor";
            this.Profesor_n.MinimumWidth = 6;
            this.Profesor_n.Name = "Profesor_n";
            this.Profesor_n.ReadOnly = true;
            this.Profesor_n.Width = 200;
            // 
            // Dias_horarios
            // 
            this.Dias_horarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dias_horarios.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dias_horarios.Frozen = true;
            this.Dias_horarios.HeaderText = "Dias y horarios";
            this.Dias_horarios.MinimumWidth = 6;
            this.Dias_horarios.Name = "Dias_horarios";
            this.Dias_horarios.ReadOnly = true;
            this.Dias_horarios.Width = 308;
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.dtgvPlanes);
            this.Controls.Add(this.TxtBuscarPlan);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Planes";
            this.Text = "planes";
            this.menuPlanes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GbModificarPlan.ResumeLayout(false);
            this.GbModificarPlan.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.GbJornadaPlanes.ResumeLayout(false);
            this.GbJornadaPlanes.PerformLayout();
            this.gpDatosPlan.ResumeLayout(false);
            this.gpDatosPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menuPlanes;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarJornadaPlan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpDatosPlan;
        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.Button btnAltaPlan;
        private System.Windows.Forms.GroupBox GbJornadaPlanes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.GroupBox GbModificarPlan;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Label lblPlanesCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCupoTotal;
        private System.Windows.Forms.TextBox TxtBuscarPlan;
        private System.Windows.Forms.DataGridView dtgvPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_horarios;
        private System.Windows.Forms.Label lblCuposTotales;
        private System.Windows.Forms.Label lblCuposRestantes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCostoMensual;
        private System.Windows.Forms.ComboBox cmbPlanesActivos;
        private System.Windows.Forms.Button btnAsignarPlan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lblVerJornadas;
    }
}