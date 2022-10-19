
namespace Presentacion
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
            this.TxtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.DtgvEmpleado = new System.Windows.Forms.DataGridView();
            this.GbEmpleado = new System.Windows.Forms.GroupBox();
            this.TxtApellidoEmpleado = new System.Windows.Forms.TextBox();
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
            this.cmbTipoDocumentoEmpleado = new System.Windows.Forms.ComboBox();
            this.TxtObservacionesEmpleado = new System.Windows.Forms.TextBox();
            this.CmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.TxtMailEmpleado = new System.Windows.Forms.TextBox();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.BtnAltaEmpleado = new System.Windows.Forms.Button();
            this.TxtDocument = new System.Windows.Forms.NumericUpDown();
            this.TxtTelefonoEmpleado = new System.Windows.Forms.NumericUpDown();
            this.TxtAlternativoEmpleado = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEmpleado)).BeginInit();
            this.GbEmpleado.SuspendLayout();
            this.GbJornadaEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefonoEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlternativoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarEmpleado
            // 
            this.TxtBuscarEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscarEmpleado.Location = new System.Drawing.Point(440, 403);
            this.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado";
            this.TxtBuscarEmpleado.Size = new System.Drawing.Size(243, 27);
            this.TxtBuscarEmpleado.TabIndex = 64;
            this.TxtBuscarEmpleado.Text = "Buscar";
            // 
            // DtgvEmpleado
            // 
            this.DtgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvEmpleado.Location = new System.Drawing.Point(17, 436);
            this.DtgvEmpleado.Name = "DtgvEmpleado";
            this.DtgvEmpleado.RowHeadersWidth = 51;
            this.DtgvEmpleado.RowTemplate.Height = 29;
            this.DtgvEmpleado.Size = new System.Drawing.Size(666, 205);
            this.DtgvEmpleado.TabIndex = 63;
            // 
            // GbEmpleado
            // 
            this.GbEmpleado.Controls.Add(this.TxtAlternativoEmpleado);
            this.GbEmpleado.Controls.Add(this.TxtTelefonoEmpleado);
            this.GbEmpleado.Controls.Add(this.TxtDocument);
            this.GbEmpleado.Controls.Add(this.TxtApellidoEmpleado);
            this.GbEmpleado.Controls.Add(this.GbJornadaEmpleado);
            this.GbEmpleado.Controls.Add(this.cmbTipoDocumentoEmpleado);
            this.GbEmpleado.Controls.Add(this.TxtObservacionesEmpleado);
            this.GbEmpleado.Controls.Add(this.CmbTipoEmpleado);
            this.GbEmpleado.Controls.Add(this.TxtMailEmpleado);
            this.GbEmpleado.Controls.Add(this.TxtNombreEmpleado);
            this.GbEmpleado.Controls.Add(this.BtnAltaEmpleado);
            this.GbEmpleado.Location = new System.Drawing.Point(17, 11);
            this.GbEmpleado.Name = "GbEmpleado";
            this.GbEmpleado.Size = new System.Drawing.Size(666, 386);
            this.GbEmpleado.TabIndex = 62;
            this.GbEmpleado.TabStop = false;
            this.GbEmpleado.Text = "Datos de Empleado";
            // 
            // TxtApellidoEmpleado
            // 
            this.TxtApellidoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtApellidoEmpleado.Location = new System.Drawing.Point(17, 74);
            this.TxtApellidoEmpleado.Name = "TxtApellidoEmpleado";
            this.TxtApellidoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.TxtApellidoEmpleado.TabIndex = 68;
            this.TxtApellidoEmpleado.Text = "Apellido";
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
            this.GbJornadaEmpleado.Location = new System.Drawing.Point(333, 71);
            this.GbJornadaEmpleado.Name = "GbJornadaEmpleado";
            this.GbJornadaEmpleado.Size = new System.Drawing.Size(307, 249);
            this.GbJornadaEmpleado.TabIndex = 67;
            this.GbJornadaEmpleado.TabStop = false;
            this.GbJornadaEmpleado.Text = "Días y horarios";
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(10, 29);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(149, 24);
            this.ChkTodos.TabIndex = 106;
            this.ChkTodos.Text = "Seleccionar todos";
            this.ChkTodos.UseVisualStyleBackColor = true;
            this.ChkTodos.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
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
            this.ChkSabado.Location = new System.Drawing.Point(10, 216);
            this.ChkSabado.Name = "ChkSabado";
            this.ChkSabado.Size = new System.Drawing.Size(82, 24);
            this.ChkSabado.TabIndex = 95;
            this.ChkSabado.Text = "Sábado";
            this.ChkSabado.UseVisualStyleBackColor = true;
            // 
            // ChkViernes
            // 
            this.ChkViernes.AutoSize = true;
            this.ChkViernes.Location = new System.Drawing.Point(10, 186);
            this.ChkViernes.Name = "ChkViernes";
            this.ChkViernes.Size = new System.Drawing.Size(79, 24);
            this.ChkViernes.TabIndex = 94;
            this.ChkViernes.Text = "Viernes";
            this.ChkViernes.UseVisualStyleBackColor = true;
            // 
            // ChkJueves
            // 
            this.ChkJueves.AutoSize = true;
            this.ChkJueves.Location = new System.Drawing.Point(10, 156);
            this.ChkJueves.Name = "ChkJueves";
            this.ChkJueves.Size = new System.Drawing.Size(73, 24);
            this.ChkJueves.TabIndex = 93;
            this.ChkJueves.Text = "Jueves";
            this.ChkJueves.UseVisualStyleBackColor = true;
            // 
            // ChkMiercoles
            // 
            this.ChkMiercoles.AutoSize = true;
            this.ChkMiercoles.Location = new System.Drawing.Point(10, 126);
            this.ChkMiercoles.Name = "ChkMiercoles";
            this.ChkMiercoles.Size = new System.Drawing.Size(95, 24);
            this.ChkMiercoles.TabIndex = 92;
            this.ChkMiercoles.Text = "Miércoles";
            this.ChkMiercoles.UseVisualStyleBackColor = true;
            // 
            // ChkMartes
            // 
            this.ChkMartes.AutoSize = true;
            this.ChkMartes.Location = new System.Drawing.Point(10, 96);
            this.ChkMartes.Name = "ChkMartes";
            this.ChkMartes.Size = new System.Drawing.Size(76, 24);
            this.ChkMartes.TabIndex = 91;
            this.ChkMartes.Text = "Martes";
            this.ChkMartes.UseVisualStyleBackColor = true;
            // 
            // ChkLunes
            // 
            this.ChkLunes.AutoSize = true;
            this.ChkLunes.Location = new System.Drawing.Point(10, 68);
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
            // cmbTipoDocumentoEmpleado
            // 
            this.cmbTipoDocumentoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoDocumentoEmpleado.FormattingEnabled = true;
            this.cmbTipoDocumentoEmpleado.Location = new System.Drawing.Point(17, 111);
            this.cmbTipoDocumentoEmpleado.Name = "cmbTipoDocumentoEmpleado";
            this.cmbTipoDocumentoEmpleado.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumentoEmpleado.TabIndex = 65;
            this.cmbTipoDocumentoEmpleado.Text = "Tipo";
            // 
            // TxtObservacionesEmpleado
            // 
            this.TxtObservacionesEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtObservacionesEmpleado.Location = new System.Drawing.Point(17, 257);
            this.TxtObservacionesEmpleado.Multiline = true;
            this.TxtObservacionesEmpleado.Name = "TxtObservacionesEmpleado";
            this.TxtObservacionesEmpleado.Size = new System.Drawing.Size(286, 112);
            this.TxtObservacionesEmpleado.TabIndex = 64;
            this.TxtObservacionesEmpleado.Text = "Observaciones y/o consideraciones";
            // 
            // CmbTipoEmpleado
            // 
            this.CmbTipoEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbTipoEmpleado.FormattingEnabled = true;
            this.CmbTipoEmpleado.Location = new System.Drawing.Point(333, 36);
            this.CmbTipoEmpleado.Name = "CmbTipoEmpleado";
            this.CmbTipoEmpleado.Size = new System.Drawing.Size(307, 28);
            this.CmbTipoEmpleado.TabIndex = 61;
            this.CmbTipoEmpleado.Text = "Tipo de empleado";
            // 
            // TxtMailEmpleado
            // 
            this.TxtMailEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtMailEmpleado.Location = new System.Drawing.Point(17, 219);
            this.TxtMailEmpleado.Name = "TxtMailEmpleado";
            this.TxtMailEmpleado.Size = new System.Drawing.Size(286, 27);
            this.TxtMailEmpleado.TabIndex = 60;
            this.TxtMailEmpleado.Text = "Mail";
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(17, 37);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(286, 27);
            this.TxtNombreEmpleado.TabIndex = 56;
            this.TxtNombreEmpleado.Text = "Nombre";
            // 
            // BtnAltaEmpleado
            // 
            this.BtnAltaEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltaEmpleado.Location = new System.Drawing.Point(333, 328);
            this.BtnAltaEmpleado.Name = "BtnAltaEmpleado";
            this.BtnAltaEmpleado.Size = new System.Drawing.Size(307, 41);
            this.BtnAltaEmpleado.TabIndex = 53;
            this.BtnAltaEmpleado.Text = "Guardar";
            this.BtnAltaEmpleado.UseVisualStyleBackColor = false;
            this.BtnAltaEmpleado.Click += new System.EventHandler(this.BtnSaveEmployee_Click);
            // 
            // TxtDocument
            // 
            this.TxtDocument.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtDocument.InterceptArrowKeys = false;
            this.TxtDocument.Location = new System.Drawing.Point(92, 111);
            this.TxtDocument.Name = "TxtDocument";
            this.TxtDocument.Size = new System.Drawing.Size(211, 27);
            this.TxtDocument.TabIndex = 69;
            this.TxtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocument_KeyPress);
            // 
            // TxtTelefonoEmpleado
            // 
            this.TxtTelefonoEmpleado.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtTelefonoEmpleado.InterceptArrowKeys = false;
            this.TxtTelefonoEmpleado.Location = new System.Drawing.Point(17, 148);
            this.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado";
            this.TxtTelefonoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.TxtTelefonoEmpleado.TabIndex = 70;
            // 
            // TxtAlternativoEmpleado
            // 
            this.TxtAlternativoEmpleado.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtAlternativoEmpleado.InterceptArrowKeys = false;
            this.TxtAlternativoEmpleado.Location = new System.Drawing.Point(17, 185);
            this.TxtAlternativoEmpleado.Name = "TxtAlternativoEmpleado";
            this.TxtAlternativoEmpleado.Size = new System.Drawing.Size(286, 27);
            this.TxtAlternativoEmpleado.TabIndex = 71;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.TxtBuscarEmpleado);
            this.Controls.Add(this.DtgvEmpleado);
            this.Controls.Add(this.GbEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "empleados";
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEmpleado)).EndInit();
            this.GbEmpleado.ResumeLayout(false);
            this.GbEmpleado.PerformLayout();
            this.GbJornadaEmpleado.ResumeLayout(false);
            this.GbJornadaEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefonoEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlternativoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarEmpleado;
        private System.Windows.Forms.DataGridView DtgvEmpleado;
        private System.Windows.Forms.GroupBox GbEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoEmpleado;
        private System.Windows.Forms.TextBox TxtObservacionesEmpleado;
        private System.Windows.Forms.ComboBox CmbTipoEmpleado;
        private System.Windows.Forms.TextBox TxtMailEmpleado;
        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.Button BtnAltaEmpleado;
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
        private System.Windows.Forms.TextBox TxtApellidoEmpleado;
        private System.Windows.Forms.NumericUpDown TxtAlternativoEmpleado;
        private System.Windows.Forms.NumericUpDown TxtTelefonoEmpleado;
        private System.Windows.Forms.NumericUpDown TxtDocument;
    }
}