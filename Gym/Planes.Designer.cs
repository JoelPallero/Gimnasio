
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuPlanes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.detele = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GbModificarPlan = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnReemplazarPlan = new System.Windows.Forms.Button();
            this.LblCostoPlan = new System.Windows.Forms.Label();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPlanCliente = new System.Windows.Forms.Label();
            this.LblTelefonoCliente = new System.Windows.Forms.Label();
            this.LblEstadoCuotasCliente = new System.Windows.Forms.Label();
            this.LblMailCliente = new System.Windows.Forms.Label();
            this.LblDniCliente = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
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
            this.GpDatosPlan = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtNombrePlan = new System.Windows.Forms.TextBox();
            this.TxtCostoPlan = new System.Windows.Forms.TextBox();
            this.CmbProfesorPlan = new System.Windows.Forms.ComboBox();
            this.BtnAltaPlan = new System.Windows.Forms.Button();
            this.TxtBuscarPlan = new System.Windows.Forms.TextBox();
            this.dtgvPlanes = new System.Windows.Forms.DataGridView();
            this.Persona_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_horarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCupos = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuPlanes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GbModificarPlan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GbJornadaEmpleado.SuspendLayout();
            this.GpDatosPlan.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox1);
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
            this.GbModificarPlan.Controls.Add(this.dateTimePicker1);
            this.GbModificarPlan.Controls.Add(this.lblCupos);
            this.GbModificarPlan.Controls.Add(this.linkLabel2);
            this.GbModificarPlan.Controls.Add(this.comboBox2);
            this.GbModificarPlan.Controls.Add(this.btnReemplazarPlan);
            this.GbModificarPlan.Controls.Add(this.LblCostoPlan);
            this.GbModificarPlan.Controls.Add(this.btnAgregarPlan);
            this.GbModificarPlan.Location = new System.Drawing.Point(9, 189);
            this.GbModificarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbModificarPlan.Name = "GbModificarPlan";
            this.GbModificarPlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbModificarPlan.Size = new System.Drawing.Size(675, 145);
            this.GbModificarPlan.TabIndex = 16;
            this.GbModificarPlan.TabStop = false;
            this.GbModificarPlan.Text = "Seleccionar Plan";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(302, 89);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(91, 20);
            this.linkLabel2.TabIndex = 86;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ver jornadas";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 87);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 28);
            this.comboBox2.TabIndex = 85;
            // 
            // btnReemplazarPlan
            // 
            this.btnReemplazarPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReemplazarPlan.FlatAppearance.BorderSize = 0;
            this.btnReemplazarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReemplazarPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReemplazarPlan.Location = new System.Drawing.Point(555, 64);
            this.btnReemplazarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReemplazarPlan.Name = "btnReemplazarPlan";
            this.btnReemplazarPlan.Size = new System.Drawing.Size(104, 40);
            this.btnReemplazarPlan.TabIndex = 19;
            this.btnReemplazarPlan.Text = "Reemplazar";
            this.btnReemplazarPlan.UseVisualStyleBackColor = false;
            // 
            // LblCostoPlan
            // 
            this.LblCostoPlan.AutoSize = true;
            this.LblCostoPlan.Location = new System.Drawing.Point(302, 62);
            this.LblCostoPlan.Name = "LblCostoPlan";
            this.LblCostoPlan.Size = new System.Drawing.Size(70, 20);
            this.LblCostoPlan.TabIndex = 17;
            this.LblCostoPlan.Text = "Costo: $0";
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarPlan.FlatAppearance.BorderSize = 0;
            this.btnAgregarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPlan.Location = new System.Drawing.Point(555, 21);
            this.btnAgregarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPlan.Name = "btnAgregarPlan";
            this.btnAgregarPlan.Size = new System.Drawing.Size(104, 40);
            this.btnAgregarPlan.TabIndex = 15;
            this.btnAgregarPlan.Text = "Agregar";
            this.btnAgregarPlan.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblPlanCliente);
            this.groupBox1.Controls.Add(this.LblTelefonoCliente);
            this.groupBox1.Controls.Add(this.LblEstadoCuotasCliente);
            this.groupBox1.Controls.Add(this.LblMailCliente);
            this.groupBox1.Controls.Add(this.LblDniCliente);
            this.groupBox1.Controls.Add(this.LblNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(9, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(675, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(358, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver jornadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Costo:";
            // 
            // LblPlanCliente
            // 
            this.LblPlanCliente.AutoSize = true;
            this.LblPlanCliente.Location = new System.Drawing.Point(358, 53);
            this.LblPlanCliente.Name = "LblPlanCliente";
            this.LblPlanCliente.Size = new System.Drawing.Size(86, 20);
            this.LblPlanCliente.TabIndex = 14;
            this.LblPlanCliente.Text = "Plan Actual:";
            // 
            // LblTelefonoCliente
            // 
            this.LblTelefonoCliente.AutoSize = true;
            this.LblTelefonoCliente.Location = new System.Drawing.Point(22, 75);
            this.LblTelefonoCliente.Name = "LblTelefonoCliente";
            this.LblTelefonoCliente.Size = new System.Drawing.Size(70, 20);
            this.LblTelefonoCliente.TabIndex = 13;
            this.LblTelefonoCliente.Text = "Telefono:";
            // 
            // LblEstadoCuotasCliente
            // 
            this.LblEstadoCuotasCliente.AutoSize = true;
            this.LblEstadoCuotasCliente.Location = new System.Drawing.Point(358, 32);
            this.LblEstadoCuotasCliente.Name = "LblEstadoCuotasCliente";
            this.LblEstadoCuotasCliente.Size = new System.Drawing.Size(125, 20);
            this.LblEstadoCuotasCliente.TabIndex = 12;
            this.LblEstadoCuotasCliente.Text = "Estado de cuotas:";
            // 
            // LblMailCliente
            // 
            this.LblMailCliente.AutoSize = true;
            this.LblMailCliente.Location = new System.Drawing.Point(22, 97);
            this.LblMailCliente.Name = "LblMailCliente";
            this.LblMailCliente.Size = new System.Drawing.Size(41, 20);
            this.LblMailCliente.TabIndex = 11;
            this.LblMailCliente.Text = "Mail:";
            // 
            // LblDniCliente
            // 
            this.LblDniCliente.AutoSize = true;
            this.LblDniCliente.Location = new System.Drawing.Point(22, 53);
            this.LblDniCliente.Name = "LblDniCliente";
            this.LblDniCliente.Size = new System.Drawing.Size(38, 20);
            this.LblDniCliente.TabIndex = 9;
            this.LblDniCliente.Text = "DNI:";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(22, 32);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(67, 20);
            this.LblNombreCliente.TabIndex = 7;
            this.LblNombreCliente.Text = "Nombre:";
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
            this.txtBuscarCliente.Text = "Nombre o DNI";
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDatoClientePlan_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GbJornadaEmpleado);
            this.tabPage2.Controls.Add(this.GpDatosPlan);
            this.tabPage2.Controls.Add(this.BtnAltaPlan);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(692, 328);
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
            // GpDatosPlan
            // 
            this.GpDatosPlan.Controls.Add(this.comboBox1);
            this.GpDatosPlan.Controls.Add(this.textBox1);
            this.GpDatosPlan.Controls.Add(this.textBox2);
            this.GpDatosPlan.Controls.Add(this.TxtNombrePlan);
            this.GpDatosPlan.Controls.Add(this.TxtCostoPlan);
            this.GpDatosPlan.Controls.Add(this.CmbProfesorPlan);
            this.GpDatosPlan.Location = new System.Drawing.Point(8, 9);
            this.GpDatosPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpDatosPlan.Name = "GpDatosPlan";
            this.GpDatosPlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GpDatosPlan.Size = new System.Drawing.Size(351, 309);
            this.GpDatosPlan.TabIndex = 85;
            this.GpDatosPlan.TabStop = false;
            this.GpDatosPlan.Text = "Datos de Plan";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 263);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 28);
            this.comboBox1.TabIndex = 89;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(19, 178);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 27);
            this.textBox1.TabIndex = 88;
            this.textBox1.Text = "Duración";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(19, 221);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 27);
            this.textBox2.TabIndex = 87;
            this.textBox2.Text = "Cupo total";
            // 
            // TxtNombrePlan
            // 
            this.TxtNombrePlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombrePlan.Location = new System.Drawing.Point(19, 52);
            this.TxtNombrePlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombrePlan.Name = "TxtNombrePlan";
            this.TxtNombrePlan.Size = new System.Drawing.Size(317, 27);
            this.TxtNombrePlan.TabIndex = 86;
            this.TxtNombrePlan.Text = "Nombre de clase";
            // 
            // TxtCostoPlan
            // 
            this.TxtCostoPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCostoPlan.Location = new System.Drawing.Point(19, 93);
            this.TxtCostoPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCostoPlan.Name = "TxtCostoPlan";
            this.TxtCostoPlan.Size = new System.Drawing.Size(317, 27);
            this.TxtCostoPlan.TabIndex = 85;
            this.TxtCostoPlan.Text = "Importe $$";
            // 
            // CmbProfesorPlan
            // 
            this.CmbProfesorPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProfesorPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbProfesorPlan.FormattingEnabled = true;
            this.CmbProfesorPlan.Location = new System.Drawing.Point(19, 135);
            this.CmbProfesorPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbProfesorPlan.Name = "CmbProfesorPlan";
            this.CmbProfesorPlan.Size = new System.Drawing.Size(317, 28);
            this.CmbProfesorPlan.TabIndex = 84;
            // 
            // BtnAltaPlan
            // 
            this.BtnAltaPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAltaPlan.FlatAppearance.BorderSize = 0;
            this.BtnAltaPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltaPlan.Location = new System.Drawing.Point(375, 272);
            this.BtnAltaPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAltaPlan.Name = "BtnAltaPlan";
            this.BtnAltaPlan.Size = new System.Drawing.Size(307, 46);
            this.BtnAltaPlan.TabIndex = 83;
            this.BtnAltaPlan.Text = "Guardar Clase";
            this.BtnAltaPlan.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Profesor_n.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dias_horarios.DefaultCellStyle = dataGridViewCellStyle14;
            this.Dias_horarios.Frozen = true;
            this.Dias_horarios.HeaderText = "Dias y horarios";
            this.Dias_horarios.MinimumWidth = 6;
            this.Dias_horarios.Name = "Dias_horarios";
            this.Dias_horarios.ReadOnly = true;
            this.Dias_horarios.Width = 308;
            // 
            // lblCupos
            // 
            this.lblCupos.AutoSize = true;
            this.lblCupos.Location = new System.Drawing.Point(303, 34);
            this.lblCupos.Name = "lblCupos";
            this.lblCupos.Size = new System.Drawing.Size(50, 20);
            this.lblCupos.TabIndex = 87;
            this.lblCupos.Text = "Cupos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 88;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.GbJornadaEmpleado.ResumeLayout(false);
            this.GbJornadaEmpleado.PerformLayout();
            this.GpDatosPlan.ResumeLayout(false);
            this.GpDatosPlan.PerformLayout();
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
        private System.Windows.Forms.GroupBox GpDatosPlan;
        private System.Windows.Forms.TextBox TxtNombrePlan;
        private System.Windows.Forms.TextBox TxtCostoPlan;
        private System.Windows.Forms.ComboBox CmbProfesorPlan;
        private System.Windows.Forms.Button BtnAltaPlan;
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
        private System.Windows.Forms.Label LblCostoPlan;
        private System.Windows.Forms.Button btnAgregarPlan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPlanCliente;
        private System.Windows.Forms.Label LblTelefonoCliente;
        private System.Windows.Forms.Label LblEstadoCuotasCliente;
        private System.Windows.Forms.Label LblMailCliente;
        private System.Windows.Forms.Label LblDniCliente;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtBuscarPlan;
        private System.Windows.Forms.Button btnReemplazarPlan;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dtgvPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_horarios;
        private System.Windows.Forms.Label lblCupos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}