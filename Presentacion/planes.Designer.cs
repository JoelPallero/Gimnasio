
namespace Presentacion
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
            this.menuPlanes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.detele = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtBuscarPlan = new System.Windows.Forms.TextBox();
            this.DtgvPlan = new System.Windows.Forms.DataGridView();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpDatosPlan = new System.Windows.Forms.GroupBox();
            this.TxtNombrePlan = new System.Windows.Forms.TextBox();
            this.TxtCostoPlan = new System.Windows.Forms.TextBox();
            this.CmbProfesorPlan = new System.Windows.Forms.ComboBox();
            this.BtnAltaPlan = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTelefonoCliente = new System.Windows.Forms.Label();
            this.LblEstadoCuotasCliente = new System.Windows.Forms.Label();
            this.LblMailCliente = new System.Windows.Forms.Label();
            this.LblDniCliente = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.BtnBuscarClientePlan = new System.Windows.Forms.Button();
            this.TxtDatoClientePlan = new System.Windows.Forms.TextBox();
            this.LblPlanCliente = new System.Windows.Forms.Label();
            this.DtgvClientePlan = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GbModificarPlan = new System.Windows.Forms.GroupBox();
            this.BtnActualizarPlanCliente = new System.Windows.Forms.Button();
            this.LblNombrePlan = new System.Windows.Forms.Label();
            this.LblCostoPlan = new System.Windows.Forms.Label();
            this.LblJornadaPlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAnularPlan = new System.Windows.Forms.Button();
            this.menuPlanes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvPlan)).BeginInit();
            this.GpDatosPlan.SuspendLayout();
            this.GbJornadaEmpleado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvClientePlan)).BeginInit();
            this.GbModificarPlan.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 650);
            this.tabControl1.TabIndex = 72;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GbModificarPlan);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.DtgvClientePlan);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.BtnBuscarClientePlan);
            this.tabPage1.Controls.Add(this.TxtDatoClientePlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar Plan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GbJornadaEmpleado);
            this.tabPage2.Controls.Add(this.GpDatosPlan);
            this.tabPage2.Controls.Add(this.DtgvPlan);
            this.tabPage2.Controls.Add(this.TxtBuscarPlan);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alta de Planes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarPlan
            // 
            this.TxtBuscarPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtBuscarPlan.Location = new System.Drawing.Point(375, 264);
            this.TxtBuscarPlan.Name = "TxtBuscarPlan";
            this.TxtBuscarPlan.Size = new System.Drawing.Size(307, 27);
            this.TxtBuscarPlan.TabIndex = 83;
            this.TxtBuscarPlan.Text = "Buscar Clase";
            // 
            // DtgvPlan
            // 
            this.DtgvPlan.AllowUserToAddRows = false;
            this.DtgvPlan.AllowUserToDeleteRows = false;
            this.DtgvPlan.AllowUserToOrderColumns = true;
            this.DtgvPlan.AllowUserToResizeColumns = false;
            this.DtgvPlan.AllowUserToResizeRows = false;
            this.DtgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clase,
            this.Profesor,
            this.Dias,
            this.Horarios});
            this.DtgvPlan.ContextMenuStrip = this.menuPlanes;
            this.DtgvPlan.Location = new System.Drawing.Point(6, 299);
            this.DtgvPlan.Name = "DtgvPlan";
            this.DtgvPlan.ReadOnly = true;
            this.DtgvPlan.RowHeadersVisible = false;
            this.DtgvPlan.RowHeadersWidth = 51;
            this.DtgvPlan.RowTemplate.Height = 29;
            this.DtgvPlan.Size = new System.Drawing.Size(676, 310);
            this.DtgvPlan.TabIndex = 84;
            // 
            // Clase
            // 
            this.Clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Clase.FillWeight = 150F;
            this.Clase.HeaderText = "Clase";
            this.Clase.MinimumWidth = 170;
            this.Clase.Name = "Clase";
            this.Clase.ReadOnly = true;
            this.Clase.Width = 170;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.MinimumWidth = 200;
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.Width = 200;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias";
            this.Dias.MinimumWidth = 150;
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 150;
            // 
            // Horarios
            // 
            this.Horarios.HeaderText = "Horarios";
            this.Horarios.MinimumWidth = 6;
            this.Horarios.Name = "Horarios";
            this.Horarios.ReadOnly = true;
            this.Horarios.Width = 150;
            // 
            // GpDatosPlan
            // 
            this.GpDatosPlan.Controls.Add(this.TxtNombrePlan);
            this.GpDatosPlan.Controls.Add(this.TxtCostoPlan);
            this.GpDatosPlan.Controls.Add(this.CmbProfesorPlan);
            this.GpDatosPlan.Controls.Add(this.BtnAltaPlan);
            this.GpDatosPlan.Location = new System.Drawing.Point(8, 9);
            this.GpDatosPlan.Name = "GpDatosPlan";
            this.GpDatosPlan.Size = new System.Drawing.Size(351, 249);
            this.GpDatosPlan.TabIndex = 85;
            this.GpDatosPlan.TabStop = false;
            this.GpDatosPlan.Text = "Datos de Plan";
            // 
            // TxtNombrePlan
            // 
            this.TxtNombrePlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtNombrePlan.Location = new System.Drawing.Point(19, 53);
            this.TxtNombrePlan.Name = "TxtNombrePlan";
            this.TxtNombrePlan.Size = new System.Drawing.Size(317, 27);
            this.TxtNombrePlan.TabIndex = 86;
            this.TxtNombrePlan.Text = "Nombre de clase";
            // 
            // TxtCostoPlan
            // 
            this.TxtCostoPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCostoPlan.Location = new System.Drawing.Point(19, 130);
            this.TxtCostoPlan.Name = "TxtCostoPlan";
            this.TxtCostoPlan.Size = new System.Drawing.Size(317, 27);
            this.TxtCostoPlan.TabIndex = 85;
            this.TxtCostoPlan.Text = "Importe $$";
            // 
            // CmbProfesorPlan
            // 
            this.CmbProfesorPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbProfesorPlan.FormattingEnabled = true;
            this.CmbProfesorPlan.Location = new System.Drawing.Point(19, 92);
            this.CmbProfesorPlan.Name = "CmbProfesorPlan";
            this.CmbProfesorPlan.Size = new System.Drawing.Size(317, 28);
            this.CmbProfesorPlan.TabIndex = 84;
            this.CmbProfesorPlan.Text = "Seleccionar Profesor";
            // 
            // BtnAltaPlan
            // 
            this.BtnAltaPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAltaPlan.FlatAppearance.BorderSize = 0;
            this.BtnAltaPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltaPlan.Location = new System.Drawing.Point(61, 172);
            this.BtnAltaPlan.Name = "BtnAltaPlan";
            this.BtnAltaPlan.Size = new System.Drawing.Size(248, 50);
            this.BtnAltaPlan.TabIndex = 83;
            this.BtnAltaPlan.Text = "Guardar Clase";
            this.BtnAltaPlan.UseVisualStyleBackColor = false;
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
            this.GbJornadaEmpleado.Name = "GbJornadaEmpleado";
            this.GbJornadaEmpleado.Size = new System.Drawing.Size(307, 249);
            this.GbJornadaEmpleado.TabIndex = 87;
            this.GbJornadaEmpleado.TabStop = false;
            this.GbJornadaEmpleado.Text = "Días y horarios";
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(17, 29);
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
            this.TxtHastaSabado.Name = "TxtHastaSabado";
            this.TxtHastaSabado.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaSabado.TabIndex = 105;
            this.TxtHastaSabado.Text = "Hasta";
            // 
            // TxtDesdeSabado
            // 
            this.TxtDesdeSabado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeSabado.Location = new System.Drawing.Point(128, 214);
            this.TxtDesdeSabado.Name = "TxtDesdeSabado";
            this.TxtDesdeSabado.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeSabado.TabIndex = 104;
            this.TxtDesdeSabado.Text = "Desde";
            // 
            // TxtHastaViernes
            // 
            this.TxtHastaViernes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaViernes.Location = new System.Drawing.Point(215, 184);
            this.TxtHastaViernes.Name = "TxtHastaViernes";
            this.TxtHastaViernes.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaViernes.TabIndex = 103;
            this.TxtHastaViernes.Text = "Hasta";
            // 
            // TxtDesdeViernes
            // 
            this.TxtDesdeViernes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeViernes.Location = new System.Drawing.Point(128, 184);
            this.TxtDesdeViernes.Name = "TxtDesdeViernes";
            this.TxtDesdeViernes.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeViernes.TabIndex = 102;
            this.TxtDesdeViernes.Text = "Desde";
            // 
            // TxtHastaJueves
            // 
            this.TxtHastaJueves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaJueves.Location = new System.Drawing.Point(215, 154);
            this.TxtHastaJueves.Name = "TxtHastaJueves";
            this.TxtHastaJueves.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaJueves.TabIndex = 101;
            this.TxtHastaJueves.Text = "Hasta";
            // 
            // TxtDesdeJueves
            // 
            this.TxtDesdeJueves.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeJueves.Location = new System.Drawing.Point(128, 154);
            this.TxtDesdeJueves.Name = "TxtDesdeJueves";
            this.TxtDesdeJueves.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeJueves.TabIndex = 100;
            this.TxtDesdeJueves.Text = "Desde";
            // 
            // TxtHastaMiercoles
            // 
            this.TxtHastaMiercoles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaMiercoles.Location = new System.Drawing.Point(215, 124);
            this.TxtHastaMiercoles.Name = "TxtHastaMiercoles";
            this.TxtHastaMiercoles.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaMiercoles.TabIndex = 99;
            this.TxtHastaMiercoles.Text = "Hasta";
            // 
            // TxtDesdeMiercoles
            // 
            this.TxtDesdeMiercoles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeMiercoles.Location = new System.Drawing.Point(128, 124);
            this.TxtDesdeMiercoles.Name = "TxtDesdeMiercoles";
            this.TxtDesdeMiercoles.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeMiercoles.TabIndex = 98;
            this.TxtDesdeMiercoles.Text = "Desde";
            // 
            // TxtHastaMartes
            // 
            this.TxtHastaMartes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaMartes.Location = new System.Drawing.Point(215, 94);
            this.TxtHastaMartes.Name = "TxtHastaMartes";
            this.TxtHastaMartes.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaMartes.TabIndex = 97;
            this.TxtHastaMartes.Text = "Hasta";
            // 
            // TxtDesdeMartes
            // 
            this.TxtDesdeMartes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeMartes.Location = new System.Drawing.Point(128, 94);
            this.TxtDesdeMartes.Name = "TxtDesdeMartes";
            this.TxtDesdeMartes.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeMartes.TabIndex = 96;
            this.TxtDesdeMartes.Text = "Desde";
            // 
            // ChkSabado
            // 
            this.ChkSabado.AutoSize = true;
            this.ChkSabado.Location = new System.Drawing.Point(17, 216);
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
            this.ChkLunes.Name = "ChkLunes";
            this.ChkLunes.Size = new System.Drawing.Size(68, 24);
            this.ChkLunes.TabIndex = 90;
            this.ChkLunes.Text = "Lunes";
            this.ChkLunes.UseVisualStyleBackColor = true;
            // 
            // TxtHastaLunes
            // 
            this.TxtHastaLunes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtHastaLunes.Location = new System.Drawing.Point(215, 63);
            this.TxtHastaLunes.Name = "TxtHastaLunes";
            this.TxtHastaLunes.Size = new System.Drawing.Size(81, 27);
            this.TxtHastaLunes.TabIndex = 89;
            this.TxtHastaLunes.Text = "Hasta";
            // 
            // TxtDesdeLunes
            // 
            this.TxtDesdeLunes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDesdeLunes.Location = new System.Drawing.Point(128, 63);
            this.TxtDesdeLunes.Name = "TxtDesdeLunes";
            this.TxtDesdeLunes.Size = new System.Drawing.Size(81, 27);
            this.TxtDesdeLunes.TabIndex = 88;
            this.TxtDesdeLunes.Text = "Desde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAnularPlan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblPlanCliente);
            this.groupBox1.Controls.Add(this.LblTelefonoCliente);
            this.groupBox1.Controls.Add(this.LblEstadoCuotasCliente);
            this.groupBox1.Controls.Add(this.LblMailCliente);
            this.groupBox1.Controls.Add(this.LblDniCliente);
            this.groupBox1.Controls.Add(this.LblNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(19, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // LblTelefonoCliente
            // 
            this.LblTelefonoCliente.AutoSize = true;
            this.LblTelefonoCliente.Location = new System.Drawing.Point(22, 104);
            this.LblTelefonoCliente.Name = "LblTelefonoCliente";
            this.LblTelefonoCliente.Size = new System.Drawing.Size(70, 20);
            this.LblTelefonoCliente.TabIndex = 13;
            this.LblTelefonoCliente.Text = "Telefono:";
            // 
            // LblEstadoCuotasCliente
            // 
            this.LblEstadoCuotasCliente.AutoSize = true;
            this.LblEstadoCuotasCliente.Location = new System.Drawing.Point(358, 33);
            this.LblEstadoCuotasCliente.Name = "LblEstadoCuotasCliente";
            this.LblEstadoCuotasCliente.Size = new System.Drawing.Size(125, 20);
            this.LblEstadoCuotasCliente.TabIndex = 12;
            this.LblEstadoCuotasCliente.Text = "Estado de cuotas:";
            // 
            // LblMailCliente
            // 
            this.LblMailCliente.AutoSize = true;
            this.LblMailCliente.Location = new System.Drawing.Point(22, 142);
            this.LblMailCliente.Name = "LblMailCliente";
            this.LblMailCliente.Size = new System.Drawing.Size(41, 20);
            this.LblMailCliente.TabIndex = 11;
            this.LblMailCliente.Text = "Mail:";
            // 
            // LblDniCliente
            // 
            this.LblDniCliente.AutoSize = true;
            this.LblDniCliente.Location = new System.Drawing.Point(22, 67);
            this.LblDniCliente.Name = "LblDniCliente";
            this.LblDniCliente.Size = new System.Drawing.Size(38, 20);
            this.LblDniCliente.TabIndex = 9;
            this.LblDniCliente.Text = "DNI:";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(22, 33);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(67, 20);
            this.LblNombreCliente.TabIndex = 7;
            this.LblNombreCliente.Text = "Nombre:";
            // 
            // BtnBuscarClientePlan
            // 
            this.BtnBuscarClientePlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBuscarClientePlan.FlatAppearance.BorderSize = 0;
            this.BtnBuscarClientePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarClientePlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBuscarClientePlan.Location = new System.Drawing.Point(499, 26);
            this.BtnBuscarClientePlan.Name = "BtnBuscarClientePlan";
            this.BtnBuscarClientePlan.Size = new System.Drawing.Size(141, 40);
            this.BtnBuscarClientePlan.TabIndex = 5;
            this.BtnBuscarClientePlan.Text = "Buscar";
            this.BtnBuscarClientePlan.UseVisualStyleBackColor = false;
            // 
            // TxtDatoClientePlan
            // 
            this.TxtDatoClientePlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDatoClientePlan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDatoClientePlan.Location = new System.Drawing.Point(19, 33);
            this.TxtDatoClientePlan.Name = "TxtDatoClientePlan";
            this.TxtDatoClientePlan.Size = new System.Drawing.Size(396, 27);
            this.TxtDatoClientePlan.TabIndex = 4;
            this.TxtDatoClientePlan.Text = "Nombre o DNI";
            // 
            // LblPlanCliente
            // 
            this.LblPlanCliente.AutoSize = true;
            this.LblPlanCliente.Location = new System.Drawing.Point(358, 67);
            this.LblPlanCliente.Name = "LblPlanCliente";
            this.LblPlanCliente.Size = new System.Drawing.Size(86, 20);
            this.LblPlanCliente.TabIndex = 14;
            this.LblPlanCliente.Text = "Plan Actual:";
            // 
            // DtgvClientePlan
            // 
            this.DtgvClientePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvClientePlan.Location = new System.Drawing.Point(19, 430);
            this.DtgvClientePlan.Name = "DtgvClientePlan";
            this.DtgvClientePlan.RowHeadersWidth = 51;
            this.DtgvClientePlan.RowTemplate.Height = 29;
            this.DtgvClientePlan.Size = new System.Drawing.Size(665, 179);
            this.DtgvClientePlan.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(377, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 27);
            this.textBox1.TabIndex = 84;
            this.textBox1.Text = "Buscar Clase";
            // 
            // GbModificarPlan
            // 
            this.GbModificarPlan.Controls.Add(this.LblJornadaPlan);
            this.GbModificarPlan.Controls.Add(this.LblCostoPlan);
            this.GbModificarPlan.Controls.Add(this.LblNombrePlan);
            this.GbModificarPlan.Controls.Add(this.BtnActualizarPlanCliente);
            this.GbModificarPlan.Location = new System.Drawing.Point(19, 256);
            this.GbModificarPlan.Name = "GbModificarPlan";
            this.GbModificarPlan.Size = new System.Drawing.Size(665, 135);
            this.GbModificarPlan.TabIndex = 16;
            this.GbModificarPlan.TabStop = false;
            this.GbModificarPlan.Text = "Seleccionar Plan";
            // 
            // BtnActualizarPlanCliente
            // 
            this.BtnActualizarPlanCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnActualizarPlanCliente.FlatAppearance.BorderSize = 0;
            this.BtnActualizarPlanCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarPlanCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActualizarPlanCliente.Location = new System.Drawing.Point(555, 29);
            this.BtnActualizarPlanCliente.Name = "BtnActualizarPlanCliente";
            this.BtnActualizarPlanCliente.Size = new System.Drawing.Size(104, 94);
            this.BtnActualizarPlanCliente.TabIndex = 15;
            this.BtnActualizarPlanCliente.Text = "Actualizar";
            this.BtnActualizarPlanCliente.UseVisualStyleBackColor = false;
            // 
            // LblNombrePlan
            // 
            this.LblNombrePlan.AutoSize = true;
            this.LblNombrePlan.Location = new System.Drawing.Point(19, 35);
            this.LblNombrePlan.Name = "LblNombrePlan";
            this.LblNombrePlan.Size = new System.Drawing.Size(67, 20);
            this.LblNombrePlan.TabIndex = 16;
            this.LblNombrePlan.Text = "Nombre:";
            // 
            // LblCostoPlan
            // 
            this.LblCostoPlan.AutoSize = true;
            this.LblCostoPlan.Location = new System.Drawing.Point(22, 66);
            this.LblCostoPlan.Name = "LblCostoPlan";
            this.LblCostoPlan.Size = new System.Drawing.Size(50, 20);
            this.LblCostoPlan.TabIndex = 17;
            this.LblCostoPlan.Text = "Costo:";
            // 
            // LblJornadaPlan
            // 
            this.LblJornadaPlan.AutoSize = true;
            this.LblJornadaPlan.Location = new System.Drawing.Point(22, 99);
            this.LblJornadaPlan.Name = "LblJornadaPlan";
            this.LblJornadaPlan.Size = new System.Drawing.Size(64, 20);
            this.LblJornadaPlan.TabIndex = 18;
            this.LblJornadaPlan.Text = "Jornada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Jornada:";
            // 
            // BtnAnularPlan
            // 
            this.BtnAnularPlan.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAnularPlan.FlatAppearance.BorderSize = 0;
            this.BtnAnularPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnularPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnularPlan.Location = new System.Drawing.Point(556, 142);
            this.BtnAnularPlan.Name = "BtnAnularPlan";
            this.BtnAnularPlan.Size = new System.Drawing.Size(103, 30);
            this.BtnAnularPlan.TabIndex = 19;
            this.BtnAnularPlan.Text = "Anular";
            this.BtnAnularPlan.UseVisualStyleBackColor = false;
            // 
            // planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "planes";
            this.Text = "planes";
            this.menuPlanes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvPlan)).EndInit();
            this.GpDatosPlan.ResumeLayout(false);
            this.GpDatosPlan.PerformLayout();
            this.GbJornadaEmpleado.ResumeLayout(false);
            this.GbJornadaEmpleado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvClientePlan)).EndInit();
            this.GbModificarPlan.ResumeLayout(false);
            this.GbModificarPlan.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView DtgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horarios;
        private System.Windows.Forms.TextBox TxtBuscarPlan;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTelefonoCliente;
        private System.Windows.Forms.Label LblEstadoCuotasCliente;
        private System.Windows.Forms.Label LblMailCliente;
        private System.Windows.Forms.Label LblDniCliente;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Button BtnBuscarClientePlan;
        private System.Windows.Forms.TextBox TxtDatoClientePlan;
        private System.Windows.Forms.Label LblPlanCliente;
        private System.Windows.Forms.DataGridView DtgvClientePlan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GbModificarPlan;
        private System.Windows.Forms.Label LblJornadaPlan;
        private System.Windows.Forms.Label LblCostoPlan;
        private System.Windows.Forms.Label LblNombrePlan;
        private System.Windows.Forms.Button BtnActualizarPlanCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAnularPlan;
    }
}