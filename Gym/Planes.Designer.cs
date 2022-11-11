
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
            this.detele = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GbModificarPlan = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lblCuposTotales = new System.Windows.Forms.Label();
            this.lblCuposRestantes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCostoMensual = new System.Windows.Forms.Label();
            this.cmbPlanesActivos = new System.Windows.Forms.ComboBox();
            this.btnAsignarPlan = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPlanesCliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GbJornadaEmpleado = new System.Windows.Forms.GroupBox();
            this.ChkTodos = new System.Windows.Forms.CheckBox();
            this.TxtHastaSabado = new System.Windows.Forms.TextBox();
            this.TxtDesdeSabado = new System.Windows.Forms.TextBox();
            this.TxtHastaViernes = new System.Windows.Forms.TextBox();
            this.TxtDesdeViernes = new System.Windows.Forms.TextBox();
            this.TxtHastaJueves = new System.Windows.Forms.TextBox();
            this.TxtDesdeJueves = new System.Windows.Forms.TextBox();
            this.TxtHastaMiercoles = new System.Windows.Forms.TextBox();
            this.TxtDesdeMiercoles = new System.Windows.Forms.TextBox();
            this.TxtHastaMartes = new System.Windows.Forms.TextBox();
            this.TxtDesdeMartes = new System.Windows.Forms.TextBox();
            this.ChkSabado = new System.Windows.Forms.CheckBox();
            this.ChkViernes = new System.Windows.Forms.CheckBox();
            this.ChkJueves = new System.Windows.Forms.CheckBox();
            this.ChkMiercoles = new System.Windows.Forms.CheckBox();
            this.ChkMartes = new System.Windows.Forms.CheckBox();
            this.ChkLunes = new System.Windows.Forms.CheckBox();
            this.TxtHastaLunes = new System.Windows.Forms.TextBox();
            this.TxtDesdeLunes = new System.Windows.Forms.TextBox();
            this.gpDatosPlan = new System.Windows.Forms.GroupBox();
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.menuPlanes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GbModificarPlan.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GbJornadaEmpleado.SuspendLayout();
            this.gpDatosPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPlanes
            // 
            this.menuPlanes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.detele});
            this.menuPlanes.Name = "contextMenuStrip1";
            this.menuPlanes.Size = new System.Drawing.Size(133, 52);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(132, 24);
            this.edit.Text = "Editar";
            // 
            // detele
            // 
            this.detele.Name = "detele";
            this.detele.Size = new System.Drawing.Size(132, 24);
            this.detele.Text = "Eliminar";
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
            this.GbModificarPlan.Controls.Add(this.linkLabel2);
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
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(22, 103);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(91, 20);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ver jornadas";
            // 
            // lblCuposTotales
            // 
            this.lblCuposTotales.AutoSize = true;
            this.lblCuposTotales.Location = new System.Drawing.Point(280, 60);
            this.lblCuposTotales.Name = "lblCuposTotales";
            this.lblCuposTotales.Size = new System.Drawing.Size(25, 20);
            this.lblCuposTotales.TabIndex = 30;
            this.lblCuposTotales.Text = "10";
            // 
            // lblCuposRestantes
            // 
            this.lblCuposRestantes.AutoSize = true;
            this.lblCuposRestantes.Location = new System.Drawing.Point(249, 60);
            this.lblCuposRestantes.Name = "lblCuposRestantes";
            this.lblCuposRestantes.Size = new System.Drawing.Size(25, 20);
            this.lblCuposRestantes.TabIndex = 29;
            this.lblCuposRestantes.Text = "10";
            this.lblCuposRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Planes disponibles";
            // 
            // lblCostoMensual
            // 
            this.lblCostoMensual.AutoSize = true;
            this.lblCostoMensual.Location = new System.Drawing.Point(253, 24);
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
            // 
            // btnAsignarPlan
            // 
            this.btnAsignarPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAsignarPlan.FlatAppearance.BorderSize = 0;
            this.btnAsignarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarPlan.Location = new System.Drawing.Point(487, 88);
            this.btnAsignarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPlan.Name = "btnAsignarPlan";
            this.btnAsignarPlan.Size = new System.Drawing.Size(173, 40);
            this.btnAsignarPlan.TabIndex = 24;
            this.btnAsignarPlan.Text = "Asignar Plan";
            this.btnAsignarPlan.UseVisualStyleBackColor = false;
            this.btnAsignarPlan.Click += new System.EventHandler(this.btnAsignarPlan_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(270, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "/";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.linkLabel1);
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(353, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver jornadas";
            // 
            // lblPlanesCliente
            // 
            this.lblPlanesCliente.AutoSize = true;
            this.lblPlanesCliente.Location = new System.Drawing.Point(353, 32);
            this.lblPlanesCliente.Name = "lblPlanesCliente";
            this.lblPlanesCliente.Size = new System.Drawing.Size(86, 20);
            this.lblPlanesCliente.TabIndex = 14;
            this.lblPlanesCliente.Text = "Plan Actual:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 75);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 20);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(22, 97);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 20);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(22, 53);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(38, 20);
            this.lblDocumento.TabIndex = 9;
            this.lblDocumento.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
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
            this.tabPage2.Controls.Add(this.GbJornadaEmpleado);
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
            // GbJornadaEmpleado
            // 
            this.GbJornadaEmpleado.Controls.Add(this.ChkTodos);
            this.GbJornadaEmpleado.Controls.Add(this.TxtHastaSabado);
            this.GbJornadaEmpleado.Controls.Add(this.TxtDesdeSabado);
            this.GbJornadaEmpleado.Controls.Add(this.TxtHastaViernes);
            this.GbJornadaEmpleado.Controls.Add(this.TxtDesdeViernes);
            this.GbJornadaEmpleado.Controls.Add(this.TxtHastaJueves);
            this.GbJornadaEmpleado.Controls.Add(this.TxtDesdeJueves);
            this.GbJornadaEmpleado.Controls.Add(this.TxtHastaMiercoles);
            this.GbJornadaEmpleado.Controls.Add(this.TxtDesdeMiercoles);
            this.GbJornadaEmpleado.Controls.Add(this.TxtHastaMartes);
            this.GbJornadaEmpleado.Controls.Add(this.TxtDesdeMartes);
            this.GbJornadaEmpleado.Controls.Add(this.ChkSabado);
            this.GbJornadaEmpleado.Controls.Add(this.ChkViernes);
            this.GbJornadaEmpleado.Controls.Add(this.ChkJueves);
            this.GbJornadaEmpleado.Controls.Add(this.ChkMiercoles);
            this.GbJornadaEmpleado.Controls.Add(this.ChkMartes);
            this.GbJornadaEmpleado.Controls.Add(this.ChkLunes);
            this.GbJornadaEmpleado.Controls.Add(this.TxtHastaLunes);
            this.GbJornadaEmpleado.Controls.Add(this.TxtDesdeLunes);
            this.GbJornadaEmpleado.Location = new System.Drawing.Point(375, 9);
            this.GbJornadaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbJornadaEmpleado.Name = "GbJornadaEmpleado";
            this.GbJornadaEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbJornadaEmpleado.Size = new System.Drawing.Size(307, 257);
            this.GbJornadaEmpleado.TabIndex = 87;
            this.GbJornadaEmpleado.TabStop = false;
            this.GbJornadaEmpleado.Text = "Días y horarios";
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(17, 29);
            this.ChkTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(149, 24);
            this.ChkTodos.TabIndex = 106;
            this.ChkTodos.Text = "Seleccionar todos";
            this.ChkTodos.UseVisualStyleBackColor = true;
            // 
            // TxtHastaSabado
            // 
            this.TxtHastaSabado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaSabado.Location = new System.Drawing.Point(215, 214);
            this.TxtHastaSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHastaSabado.Name = "TxtHastaSabado";
            this.TxtHastaSabado.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaSabado.TabIndex = 105;
            this.TxtHastaSabado.Text = "Hasta";
            // 
            // TxtDesdeSabado
            // 
            this.TxtDesdeSabado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeSabado.Location = new System.Drawing.Point(128, 214);
            this.TxtDesdeSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDesdeSabado.Name = "TxtDesdeSabado";
            this.TxtDesdeSabado.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeSabado.TabIndex = 104;
            this.TxtDesdeSabado.Text = "Desde";
            // 
            // TxtHastaViernes
            // 
            this.TxtHastaViernes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaViernes.Location = new System.Drawing.Point(215, 184);
            this.TxtHastaViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHastaViernes.Name = "TxtHastaViernes";
            this.TxtHastaViernes.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaViernes.TabIndex = 103;
            this.TxtHastaViernes.Text = "Hasta";
            // 
            // TxtDesdeViernes
            // 
            this.TxtDesdeViernes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeViernes.Location = new System.Drawing.Point(128, 184);
            this.TxtDesdeViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDesdeViernes.Name = "TxtDesdeViernes";
            this.TxtDesdeViernes.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeViernes.TabIndex = 102;
            this.TxtDesdeViernes.Text = "Desde";
            // 
            // TxtHastaJueves
            // 
            this.TxtHastaJueves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaJueves.Location = new System.Drawing.Point(215, 154);
            this.TxtHastaJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHastaJueves.Name = "TxtHastaJueves";
            this.TxtHastaJueves.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaJueves.TabIndex = 101;
            this.TxtHastaJueves.Text = "Hasta";
            // 
            // TxtDesdeJueves
            // 
            this.TxtDesdeJueves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeJueves.Location = new System.Drawing.Point(128, 154);
            this.TxtDesdeJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDesdeJueves.Name = "TxtDesdeJueves";
            this.TxtDesdeJueves.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeJueves.TabIndex = 100;
            this.TxtDesdeJueves.Text = "Desde";
            // 
            // TxtHastaMiercoles
            // 
            this.TxtHastaMiercoles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaMiercoles.Location = new System.Drawing.Point(215, 124);
            this.TxtHastaMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHastaMiercoles.Name = "TxtHastaMiercoles";
            this.TxtHastaMiercoles.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaMiercoles.TabIndex = 99;
            this.TxtHastaMiercoles.Text = "Hasta";
            // 
            // TxtDesdeMiercoles
            // 
            this.TxtDesdeMiercoles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeMiercoles.Location = new System.Drawing.Point(128, 124);
            this.TxtDesdeMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDesdeMiercoles.Name = "TxtDesdeMiercoles";
            this.TxtDesdeMiercoles.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeMiercoles.TabIndex = 98;
            this.TxtDesdeMiercoles.Text = "Desde";
            // 
            // TxtHastaMartes
            // 
            this.TxtHastaMartes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaMartes.Location = new System.Drawing.Point(215, 94);
            this.TxtHastaMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHastaMartes.Name = "TxtHastaMartes";
            this.TxtHastaMartes.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaMartes.TabIndex = 97;
            this.TxtHastaMartes.Text = "Hasta";
            // 
            // TxtDesdeMartes
            // 
            this.TxtDesdeMartes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeMartes.Location = new System.Drawing.Point(128, 94);
            this.TxtDesdeMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDesdeMartes.Name = "TxtDesdeMartes";
            this.TxtDesdeMartes.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeMartes.TabIndex = 96;
            this.TxtDesdeMartes.Text = "Desde";
            // 
            // ChkSabado
            // 
            this.ChkSabado.AutoSize = true;
            this.ChkSabado.Location = new System.Drawing.Point(17, 216);
            this.ChkSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkSabado.Name = "ChkSabado";
            this.ChkSabado.Size = new System.Drawing.Size(82, 24);
            this.ChkSabado.TabIndex = 95;
            this.ChkSabado.Text = "Sábado";
            this.ChkSabado.UseVisualStyleBackColor = true;
            // 
            // ChkViernes
            // 
            this.ChkViernes.AutoSize = true;
            this.ChkViernes.Location = new System.Drawing.Point(17, 186);
            this.ChkViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkViernes.Name = "ChkViernes";
            this.ChkViernes.Size = new System.Drawing.Size(79, 24);
            this.ChkViernes.TabIndex = 94;
            this.ChkViernes.Text = "Viernes";
            this.ChkViernes.UseVisualStyleBackColor = true;
            // 
            // ChkJueves
            // 
            this.ChkJueves.AutoSize = true;
            this.ChkJueves.Location = new System.Drawing.Point(17, 156);
            this.ChkJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkJueves.Name = "ChkJueves";
            this.ChkJueves.Size = new System.Drawing.Size(73, 24);
            this.ChkJueves.TabIndex = 93;
            this.ChkJueves.Text = "Jueves";
            this.ChkJueves.UseVisualStyleBackColor = true;
            // 
            // ChkMiercoles
            // 
            this.ChkMiercoles.AutoSize = true;
            this.ChkMiercoles.Location = new System.Drawing.Point(17, 126);
            this.ChkMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkMiercoles.Name = "ChkMiercoles";
            this.ChkMiercoles.Size = new System.Drawing.Size(95, 24);
            this.ChkMiercoles.TabIndex = 92;
            this.ChkMiercoles.Text = "Miércoles";
            this.ChkMiercoles.UseVisualStyleBackColor = true;
            // 
            // ChkMartes
            // 
            this.ChkMartes.AutoSize = true;
            this.ChkMartes.Location = new System.Drawing.Point(17, 96);
            this.ChkMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkMartes.Name = "ChkMartes";
            this.ChkMartes.Size = new System.Drawing.Size(76, 24);
            this.ChkMartes.TabIndex = 91;
            this.ChkMartes.Text = "Martes";
            this.ChkMartes.UseVisualStyleBackColor = true;
            // 
            // ChkLunes
            // 
            this.ChkLunes.AutoSize = true;
            this.ChkLunes.Location = new System.Drawing.Point(17, 68);
            this.ChkLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkLunes.Name = "ChkLunes";
            this.ChkLunes.Size = new System.Drawing.Size(68, 24);
            this.ChkLunes.TabIndex = 90;
            this.ChkLunes.Text = "Lunes";
            this.ChkLunes.UseVisualStyleBackColor = true;
            // 
            // TxtHastaLunes
            // 
            this.TxtHastaLunes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaLunes.Location = new System.Drawing.Point(215, 62);
            this.TxtHastaLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHastaLunes.Name = "TxtHastaLunes";
            this.TxtHastaLunes.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaLunes.TabIndex = 89;
            this.TxtHastaLunes.Text = "Hasta";
            // 
            // TxtDesdeLunes
            // 
            this.TxtDesdeLunes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeLunes.Location = new System.Drawing.Point(128, 62);
            this.TxtDesdeLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDesdeLunes.Name = "TxtDesdeLunes";
            this.TxtDesdeLunes.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeLunes.TabIndex = 88;
            this.TxtDesdeLunes.Text = "Desde";
            // 
            // gpDatosPlan
            // 
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
            // txtDuracion
            // 
            this.txtDuracion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDuracion.Location = new System.Drawing.Point(19, 178);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(317, 27);
            this.txtDuracion.TabIndex = 88;
            this.txtDuracion.Text = "Duración";
            // 
            // txtCupoTotal
            // 
            this.txtCupoTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCupoTotal.Location = new System.Drawing.Point(19, 221);
            this.txtCupoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCupoTotal.Name = "txtCupoTotal";
            this.txtCupoTotal.Size = new System.Drawing.Size(317, 27);
            this.txtCupoTotal.TabIndex = 87;
            this.txtCupoTotal.Text = "Cupo total";
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombrePlan.Location = new System.Drawing.Point(19, 52);
            this.txtNombrePlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(317, 27);
            this.txtNombrePlan.TabIndex = 86;
            this.txtNombrePlan.Text = "Nombre de clase";
            // 
            // txtImporte
            // 
            this.txtImporte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtImporte.Location = new System.Drawing.Point(19, 93);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(317, 27);
            this.txtImporte.TabIndex = 85;
            this.txtImporte.Text = "Importe $$";
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesores.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(19, 135);
            this.cmbProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(317, 28);
            this.cmbProfesores.TabIndex = 84;
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
            this.btnAltaPlan.TabIndex = 83;
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
            this.TxtBuscarPlan.TabIndex = 85;
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
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(19, 263);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(317, 27);
            this.dtpFechaInicio.TabIndex = 89;
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
            this.GbJornadaEmpleado.ResumeLayout(false);
            this.GbJornadaEmpleado.PerformLayout();
            this.gpDatosPlan.ResumeLayout(false);
            this.gpDatosPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menuPlanes;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem detele;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpDatosPlan;
        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.Button btnAltaPlan;
        private System.Windows.Forms.GroupBox GbJornadaEmpleado;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.TextBox TxtHastaSabado;
        private System.Windows.Forms.TextBox TxtDesdeSabado;
        private System.Windows.Forms.TextBox TxtHastaViernes;
        private System.Windows.Forms.TextBox TxtDesdeViernes;
        private System.Windows.Forms.TextBox TxtHastaJueves;
        private System.Windows.Forms.TextBox TxtDesdeJueves;
        private System.Windows.Forms.TextBox TxtHastaMiercoles;
        private System.Windows.Forms.TextBox TxtDesdeMiercoles;
        private System.Windows.Forms.TextBox TxtHastaMartes;
        private System.Windows.Forms.TextBox TxtDesdeMartes;
        private System.Windows.Forms.CheckBox ChkSabado;
        private System.Windows.Forms.CheckBox ChkViernes;
        private System.Windows.Forms.CheckBox ChkJueves;
        private System.Windows.Forms.CheckBox ChkMiercoles;
        private System.Windows.Forms.CheckBox ChkMartes;
        private System.Windows.Forms.CheckBox ChkLunes;
        private System.Windows.Forms.TextBox TxtHastaLunes;
        private System.Windows.Forms.TextBox TxtDesdeLunes;
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
        private System.Windows.Forms.LinkLabel linkLabel1;
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
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}