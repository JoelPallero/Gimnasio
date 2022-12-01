
namespace Gym
{
    partial class Jornadas
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
            this.btnAltaJornada = new System.Windows.Forms.Button();
            this.gbJornadaEmpleado = new System.Windows.Forms.GroupBox();
            this.btnDelSabado = new System.Windows.Forms.Button();
            this.btnDelViernes = new System.Windows.Forms.Button();
            this.btnDelJueves = new System.Windows.Forms.Button();
            this.btnDelMiercoles = new System.Windows.Forms.Button();
            this.btnDelMartes = new System.Windows.Forms.Button();
            this.btnDelLunes = new System.Windows.Forms.Button();
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
            this.lblCancelar = new System.Windows.Forms.LinkLabel();
            this.ttFormatoHora = new System.Windows.Forms.ToolTip(this.components);
            this.gbJornadaEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaJornada
            // 
            this.btnAltaJornada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaJornada.FlatAppearance.BorderSize = 0;
            this.btnAltaJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaJornada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaJornada.Location = new System.Drawing.Point(39, 280);
            this.btnAltaJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaJornada.Name = "btnAltaJornada";
            this.btnAltaJornada.Size = new System.Drawing.Size(285, 41);
            this.btnAltaJornada.TabIndex = 68;
            this.btnAltaJornada.Text = "Guardar Jornada";
            this.btnAltaJornada.UseVisualStyleBackColor = false;
            this.btnAltaJornada.Click += new System.EventHandler(this.btnAltaJornada_Click);
            // 
            // gbJornadaEmpleado
            // 
            this.gbJornadaEmpleado.Controls.Add(this.btnDelSabado);
            this.gbJornadaEmpleado.Controls.Add(this.btnDelViernes);
            this.gbJornadaEmpleado.Controls.Add(this.btnDelJueves);
            this.gbJornadaEmpleado.Controls.Add(this.btnDelMiercoles);
            this.gbJornadaEmpleado.Controls.Add(this.btnDelMartes);
            this.gbJornadaEmpleado.Controls.Add(this.btnDelLunes);
            this.gbJornadaEmpleado.Controls.Add(this.label2);
            this.gbJornadaEmpleado.Controls.Add(this.label1);
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
            this.gbJornadaEmpleado.Location = new System.Drawing.Point(12, 11);
            this.gbJornadaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbJornadaEmpleado.Name = "gbJornadaEmpleado";
            this.gbJornadaEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbJornadaEmpleado.Size = new System.Drawing.Size(336, 265);
            this.gbJornadaEmpleado.TabIndex = 69;
            this.gbJornadaEmpleado.TabStop = false;
            this.gbJornadaEmpleado.Text = "Días y horarios";
            // 
            // btnDelSabado
            // 
            this.btnDelSabado.BackColor = System.Drawing.Color.Red;
            this.btnDelSabado.FlatAppearance.BorderSize = 0;
            this.btnDelSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSabado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelSabado.Location = new System.Drawing.Point(302, 228);
            this.btnDelSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelSabado.Name = "btnDelSabado";
            this.btnDelSabado.Size = new System.Drawing.Size(27, 23);
            this.btnDelSabado.TabIndex = 76;
            this.btnDelSabado.Text = "X";
            this.btnDelSabado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelSabado.UseVisualStyleBackColor = false;
            this.btnDelSabado.Click += new System.EventHandler(this.btnDelSabado_Click);
            // 
            // btnDelViernes
            // 
            this.btnDelViernes.BackColor = System.Drawing.Color.Red;
            this.btnDelViernes.FlatAppearance.BorderSize = 0;
            this.btnDelViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelViernes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelViernes.Location = new System.Drawing.Point(302, 197);
            this.btnDelViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelViernes.Name = "btnDelViernes";
            this.btnDelViernes.Size = new System.Drawing.Size(27, 23);
            this.btnDelViernes.TabIndex = 75;
            this.btnDelViernes.Text = "X";
            this.btnDelViernes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelViernes.UseVisualStyleBackColor = false;
            this.btnDelViernes.Click += new System.EventHandler(this.btnDelViernes_Click);
            // 
            // btnDelJueves
            // 
            this.btnDelJueves.BackColor = System.Drawing.Color.Red;
            this.btnDelJueves.FlatAppearance.BorderSize = 0;
            this.btnDelJueves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelJueves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelJueves.Location = new System.Drawing.Point(302, 168);
            this.btnDelJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelJueves.Name = "btnDelJueves";
            this.btnDelJueves.Size = new System.Drawing.Size(27, 23);
            this.btnDelJueves.TabIndex = 74;
            this.btnDelJueves.Text = "X";
            this.btnDelJueves.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelJueves.UseVisualStyleBackColor = false;
            this.btnDelJueves.Click += new System.EventHandler(this.btnDelJueves_Click);
            // 
            // btnDelMiercoles
            // 
            this.btnDelMiercoles.BackColor = System.Drawing.Color.Red;
            this.btnDelMiercoles.FlatAppearance.BorderSize = 0;
            this.btnDelMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMiercoles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelMiercoles.Location = new System.Drawing.Point(302, 138);
            this.btnDelMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelMiercoles.Name = "btnDelMiercoles";
            this.btnDelMiercoles.Size = new System.Drawing.Size(27, 23);
            this.btnDelMiercoles.TabIndex = 73;
            this.btnDelMiercoles.Text = "X";
            this.btnDelMiercoles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelMiercoles.UseVisualStyleBackColor = false;
            this.btnDelMiercoles.Click += new System.EventHandler(this.btnDelMiercoles_Click);
            // 
            // btnDelMartes
            // 
            this.btnDelMartes.BackColor = System.Drawing.Color.Red;
            this.btnDelMartes.FlatAppearance.BorderSize = 0;
            this.btnDelMartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMartes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelMartes.Location = new System.Drawing.Point(302, 108);
            this.btnDelMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelMartes.Name = "btnDelMartes";
            this.btnDelMartes.Size = new System.Drawing.Size(27, 23);
            this.btnDelMartes.TabIndex = 72;
            this.btnDelMartes.Text = "X";
            this.btnDelMartes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelMartes.UseVisualStyleBackColor = false;
            this.btnDelMartes.Click += new System.EventHandler(this.btnDelMartes_Click);
            // 
            // btnDelLunes
            // 
            this.btnDelLunes.BackColor = System.Drawing.Color.Red;
            this.btnDelLunes.FlatAppearance.BorderSize = 0;
            this.btnDelLunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLunes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelLunes.Location = new System.Drawing.Point(302, 79);
            this.btnDelLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelLunes.Name = "btnDelLunes";
            this.btnDelLunes.Size = new System.Drawing.Size(27, 23);
            this.btnDelLunes.TabIndex = 71;
            this.btnDelLunes.Text = "X";
            this.btnDelLunes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelLunes.UseVisualStyleBackColor = false;
            this.btnDelLunes.Click += new System.EventHandler(this.btnDelLunes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Desde";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(10, 29);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(143, 21);
            this.chkTodos.TabIndex = 9;
            this.chkTodos.Text = "Seleccionar todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.Click += new System.EventHandler(this.chkTodos_Click);
            // 
            // txtHastaSabado
            // 
            this.txtHastaSabado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaSabado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaSabado.Location = new System.Drawing.Point(215, 228);
            this.txtHastaSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaSabado.MaxLength = 5;
            this.txtHastaSabado.Name = "txtHastaSabado";
            this.txtHastaSabado.Size = new System.Drawing.Size(81, 22);
            this.txtHastaSabado.TabIndex = 27;
            this.txtHastaSabado.Text = "hh:mm";
            this.txtHastaSabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaSabado.Enter += new System.EventHandler(this.txtHastaSabado_Enter);
            this.txtHastaSabado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaSabado_KeyPress);
            this.txtHastaSabado.Leave += new System.EventHandler(this.txtHastaSabado_Leave);
            // 
            // txtDesdeSabado
            // 
            this.txtDesdeSabado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeSabado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeSabado.Location = new System.Drawing.Point(128, 228);
            this.txtDesdeSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeSabado.MaxLength = 5;
            this.txtDesdeSabado.Name = "txtDesdeSabado";
            this.txtDesdeSabado.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeSabado.TabIndex = 26;
            this.txtDesdeSabado.Text = "hh:mm";
            this.txtDesdeSabado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeSabado.Enter += new System.EventHandler(this.txtDesdeSabado_Enter);
            this.txtDesdeSabado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeSabado_KeyPress);
            this.txtDesdeSabado.Leave += new System.EventHandler(this.txtDesdeSabado_Leave);
            // 
            // txtHastaViernes
            // 
            this.txtHastaViernes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaViernes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaViernes.Location = new System.Drawing.Point(215, 198);
            this.txtHastaViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaViernes.MaxLength = 5;
            this.txtHastaViernes.Name = "txtHastaViernes";
            this.txtHastaViernes.Size = new System.Drawing.Size(81, 22);
            this.txtHastaViernes.TabIndex = 24;
            this.txtHastaViernes.Text = "hh:mm";
            this.txtHastaViernes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaViernes.Enter += new System.EventHandler(this.txtHastaViernes_Enter);
            this.txtHastaViernes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaViernes_KeyPress);
            this.txtHastaViernes.Leave += new System.EventHandler(this.txtHastaViernes_Leave);
            // 
            // txtDesdeViernes
            // 
            this.txtDesdeViernes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeViernes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeViernes.Location = new System.Drawing.Point(128, 198);
            this.txtDesdeViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeViernes.MaxLength = 5;
            this.txtDesdeViernes.Name = "txtDesdeViernes";
            this.txtDesdeViernes.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeViernes.TabIndex = 23;
            this.txtDesdeViernes.Text = "hh:mm";
            this.txtDesdeViernes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeViernes.Enter += new System.EventHandler(this.txtDesdeViernes_Enter);
            this.txtDesdeViernes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeViernes_KeyPress);
            this.txtDesdeViernes.Leave += new System.EventHandler(this.txtDesdeViernes_Leave);
            // 
            // txtHastaJueves
            // 
            this.txtHastaJueves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaJueves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaJueves.Location = new System.Drawing.Point(215, 168);
            this.txtHastaJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaJueves.MaxLength = 5;
            this.txtHastaJueves.Name = "txtHastaJueves";
            this.txtHastaJueves.Size = new System.Drawing.Size(81, 22);
            this.txtHastaJueves.TabIndex = 21;
            this.txtHastaJueves.Text = "hh:mm";
            this.txtHastaJueves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaJueves.Enter += new System.EventHandler(this.txtHastaJueves_Enter);
            this.txtHastaJueves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaJueves_KeyPress);
            this.txtHastaJueves.Leave += new System.EventHandler(this.txtHastaJueves_Leave);
            // 
            // txtDesdeJueves
            // 
            this.txtDesdeJueves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeJueves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeJueves.Location = new System.Drawing.Point(128, 168);
            this.txtDesdeJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeJueves.MaxLength = 5;
            this.txtDesdeJueves.Name = "txtDesdeJueves";
            this.txtDesdeJueves.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeJueves.TabIndex = 20;
            this.txtDesdeJueves.Text = "hh:mm";
            this.txtDesdeJueves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeJueves.Enter += new System.EventHandler(this.txtDesdeJueves_Enter);
            this.txtDesdeJueves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeJueves_KeyPress);
            this.txtDesdeJueves.Leave += new System.EventHandler(this.txtDesdeJueves_Leave);
            // 
            // txtHastaMiercoles
            // 
            this.txtHastaMiercoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaMiercoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMiercoles.Location = new System.Drawing.Point(215, 138);
            this.txtHastaMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMiercoles.MaxLength = 5;
            this.txtHastaMiercoles.Name = "txtHastaMiercoles";
            this.txtHastaMiercoles.Size = new System.Drawing.Size(81, 22);
            this.txtHastaMiercoles.TabIndex = 18;
            this.txtHastaMiercoles.Text = "hh:mm";
            this.txtHastaMiercoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaMiercoles.Enter += new System.EventHandler(this.txtHastaMiercoles_Enter);
            this.txtHastaMiercoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaMiercoles_KeyPress);
            this.txtHastaMiercoles.Leave += new System.EventHandler(this.txtHastaMiercoles_Leave);
            // 
            // txtDesdeMiercoles
            // 
            this.txtDesdeMiercoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeMiercoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMiercoles.Location = new System.Drawing.Point(128, 138);
            this.txtDesdeMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMiercoles.MaxLength = 5;
            this.txtDesdeMiercoles.Name = "txtDesdeMiercoles";
            this.txtDesdeMiercoles.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeMiercoles.TabIndex = 17;
            this.txtDesdeMiercoles.Text = "hh:mm";
            this.txtDesdeMiercoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeMiercoles.Enter += new System.EventHandler(this.txtDesdeMiercoles_Enter);
            this.txtDesdeMiercoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeMiercoles_KeyPress);
            this.txtDesdeMiercoles.Leave += new System.EventHandler(this.txtDesdeMiercoles_Leave);
            // 
            // txtHastaMartes
            // 
            this.txtHastaMartes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaMartes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMartes.Location = new System.Drawing.Point(215, 108);
            this.txtHastaMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMartes.MaxLength = 5;
            this.txtHastaMartes.Name = "txtHastaMartes";
            this.txtHastaMartes.Size = new System.Drawing.Size(81, 22);
            this.txtHastaMartes.TabIndex = 15;
            this.txtHastaMartes.Text = "hh:mm";
            this.txtHastaMartes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaMartes.Enter += new System.EventHandler(this.txtHastaMartes_Enter);
            this.txtHastaMartes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaMartes_KeyPress);
            this.txtHastaMartes.Leave += new System.EventHandler(this.txtHastaMartes_Leave);
            // 
            // txtDesdeMartes
            // 
            this.txtDesdeMartes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeMartes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMartes.Location = new System.Drawing.Point(128, 108);
            this.txtDesdeMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMartes.MaxLength = 5;
            this.txtDesdeMartes.Name = "txtDesdeMartes";
            this.txtDesdeMartes.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeMartes.TabIndex = 14;
            this.txtDesdeMartes.Text = "hh:mm";
            this.txtDesdeMartes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeMartes.Enter += new System.EventHandler(this.txtDesdeMartes_Enter);
            this.txtDesdeMartes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeMartes_KeyPress);
            this.txtDesdeMartes.Leave += new System.EventHandler(this.txtDesdeMartes_Leave);
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(10, 231);
            this.chkSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(79, 21);
            this.chkSabado.TabIndex = 25;
            this.chkSabado.Text = "Sabado";
            this.chkSabado.UseVisualStyleBackColor = true;
            this.chkSabado.Click += new System.EventHandler(this.chkSabado_Click);
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(10, 201);
            this.chkViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(78, 21);
            this.chkViernes.TabIndex = 22;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            this.chkViernes.Click += new System.EventHandler(this.chkViernes_Click);
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(10, 171);
            this.chkJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(75, 21);
            this.chkJueves.TabIndex = 19;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            this.chkJueves.Click += new System.EventHandler(this.chkJueves_Click);
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(10, 141);
            this.chkMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(90, 21);
            this.chkMiercoles.TabIndex = 16;
            this.chkMiercoles.Text = "Miercoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            this.chkMiercoles.Click += new System.EventHandler(this.chkMiercoles_Click);
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(10, 111);
            this.chkMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(73, 21);
            this.chkMartes.TabIndex = 13;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            this.chkMartes.Click += new System.EventHandler(this.chkMartes_Click);
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(10, 81);
            this.chkLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(69, 21);
            this.chkLunes.TabIndex = 10;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            this.chkLunes.Click += new System.EventHandler(this.chkLunes_Click);
            // 
            // txtHastaLunes
            // 
            this.txtHastaLunes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHastaLunes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtHastaLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaLunes.Location = new System.Drawing.Point(215, 79);
            this.txtHastaLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaLunes.MaxLength = 5;
            this.txtHastaLunes.Name = "txtHastaLunes";
            this.txtHastaLunes.Size = new System.Drawing.Size(81, 22);
            this.txtHastaLunes.TabIndex = 12;
            this.txtHastaLunes.Text = "hh:mm";
            this.txtHastaLunes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaLunes.Enter += new System.EventHandler(this.txtHastaLunes_Enter);
            this.txtHastaLunes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaLunes_KeyPress);
            this.txtHastaLunes.Leave += new System.EventHandler(this.txtHastaLunes_Leave);
            // 
            // txtDesdeLunes
            // 
            this.txtDesdeLunes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDesdeLunes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesdeLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeLunes.Location = new System.Drawing.Point(128, 79);
            this.txtDesdeLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeLunes.MaxLength = 5;
            this.txtDesdeLunes.Name = "txtDesdeLunes";
            this.txtDesdeLunes.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeLunes.TabIndex = 11;
            this.txtDesdeLunes.Text = "hh:mm";
            this.txtDesdeLunes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesdeLunes.Enter += new System.EventHandler(this.txtDesdeLunes_Enter);
            this.txtDesdeLunes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeLunes_KeyPress);
            this.txtDesdeLunes.Leave += new System.EventHandler(this.txtDesdeLunes_Leave);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Location = new System.Drawing.Point(157, 323);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(64, 17);
            this.lblCancelar.TabIndex = 70;
            this.lblCancelar.TabStop = true;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCancelar_LinkClicked);
            // 
            // Jornadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(362, 349);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnAltaJornada);
            this.Controls.Add(this.gbJornadaEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jornadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jornadas";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.gbJornadaEmpleado.ResumeLayout(false);
            this.gbJornadaEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaJornada;
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
        private System.Windows.Forms.LinkLabel lblCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttFormatoHora;
        private System.Windows.Forms.Button btnDelLunes;
        private System.Windows.Forms.Button btnDelSabado;
        private System.Windows.Forms.Button btnDelViernes;
        private System.Windows.Forms.Button btnDelJueves;
        private System.Windows.Forms.Button btnDelMiercoles;
        private System.Windows.Forms.Button btnDelMartes;
    }
}