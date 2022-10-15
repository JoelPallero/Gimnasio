
namespace Presentacion
{
    partial class AltaEmpleados
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
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.gbEmployeeData = new System.Windows.Forms.GroupBox();
            this.gbJournalTIme = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.txtToSaturday = new System.Windows.Forms.TextBox();
            this.txtFromSaturday = new System.Windows.Forms.TextBox();
            this.txtToFriday = new System.Windows.Forms.TextBox();
            this.txtFromFriday = new System.Windows.Forms.TextBox();
            this.txtToThursday = new System.Windows.Forms.TextBox();
            this.txtFromThursday = new System.Windows.Forms.TextBox();
            this.txtToWednesday = new System.Windows.Forms.TextBox();
            this.txtFromWednesday = new System.Windows.Forms.TextBox();
            this.txtToTuesday = new System.Windows.Forms.TextBox();
            this.txtFromTuesday = new System.Windows.Forms.TextBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.txtToMonday = new System.Windows.Forms.TextBox();
            this.txtFromMonday = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtcomments = new System.Windows.Forms.TextBox();
            this.cmbTipoEmployee = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAlternative = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.gbEmployeeData.SuspendLayout();
            this.gbJournalTIme.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchEmployee.Location = new System.Drawing.Point(440, 403);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(243, 27);
            this.txtSearchEmployee.TabIndex = 64;
            this.txtSearchEmployee.Text = "Buscar";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(17, 436);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.Size = new System.Drawing.Size(666, 205);
            this.dgvEmployee.TabIndex = 63;
            // 
            // gbEmployeeData
            // 
            this.gbEmployeeData.Controls.Add(this.gbJournalTIme);
            this.gbEmployeeData.Controls.Add(this.txtDocument);
            this.gbEmployeeData.Controls.Add(this.cmbTipoDocumento);
            this.gbEmployeeData.Controls.Add(this.txtcomments);
            this.gbEmployeeData.Controls.Add(this.cmbTipoEmployee);
            this.gbEmployeeData.Controls.Add(this.txtMail);
            this.gbEmployeeData.Controls.Add(this.txtAlternative);
            this.gbEmployeeData.Controls.Add(this.txtPhone);
            this.gbEmployeeData.Controls.Add(this.txtName);
            this.gbEmployeeData.Controls.Add(this.btnSaveEmployee);
            this.gbEmployeeData.Location = new System.Drawing.Point(17, 11);
            this.gbEmployeeData.Name = "gbEmployeeData";
            this.gbEmployeeData.Size = new System.Drawing.Size(666, 386);
            this.gbEmployeeData.TabIndex = 62;
            this.gbEmployeeData.TabStop = false;
            this.gbEmployeeData.Text = "Datos de Empleado";
            // 
            // gbJournalTIme
            // 
            this.gbJournalTIme.Controls.Add(this.chkAll);
            this.gbJournalTIme.Controls.Add(this.txtToSaturday);
            this.gbJournalTIme.Controls.Add(this.txtFromSaturday);
            this.gbJournalTIme.Controls.Add(this.txtToFriday);
            this.gbJournalTIme.Controls.Add(this.txtFromFriday);
            this.gbJournalTIme.Controls.Add(this.txtToThursday);
            this.gbJournalTIme.Controls.Add(this.txtFromThursday);
            this.gbJournalTIme.Controls.Add(this.txtToWednesday);
            this.gbJournalTIme.Controls.Add(this.txtFromWednesday);
            this.gbJournalTIme.Controls.Add(this.txtToTuesday);
            this.gbJournalTIme.Controls.Add(this.txtFromTuesday);
            this.gbJournalTIme.Controls.Add(this.chkSaturday);
            this.gbJournalTIme.Controls.Add(this.chkFriday);
            this.gbJournalTIme.Controls.Add(this.chkThursday);
            this.gbJournalTIme.Controls.Add(this.chkWednesday);
            this.gbJournalTIme.Controls.Add(this.chkTuesday);
            this.gbJournalTIme.Controls.Add(this.chkMonday);
            this.gbJournalTIme.Controls.Add(this.txtToMonday);
            this.gbJournalTIme.Controls.Add(this.txtFromMonday);
            this.gbJournalTIme.Location = new System.Drawing.Point(333, 71);
            this.gbJournalTIme.Name = "gbJournalTIme";
            this.gbJournalTIme.Size = new System.Drawing.Size(307, 249);
            this.gbJournalTIme.TabIndex = 67;
            this.gbJournalTIme.TabStop = false;
            this.gbJournalTIme.Text = "Días y horarios";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(10, 29);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(149, 24);
            this.chkAll.TabIndex = 106;
            this.chkAll.Text = "Seleccionar todos";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // txtToSaturday
            // 
            this.txtToSaturday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtToSaturday.Location = new System.Drawing.Point(215, 214);
            this.txtToSaturday.Name = "txtToSaturday";
            this.txtToSaturday.Size = new System.Drawing.Size(81, 27);
            this.txtToSaturday.TabIndex = 105;
            this.txtToSaturday.Text = "Hasta";
            // 
            // txtFromSaturday
            // 
            this.txtFromSaturday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFromSaturday.Location = new System.Drawing.Point(128, 214);
            this.txtFromSaturday.Name = "txtFromSaturday";
            this.txtFromSaturday.Size = new System.Drawing.Size(81, 27);
            this.txtFromSaturday.TabIndex = 104;
            this.txtFromSaturday.Text = "Desde";
            // 
            // txtToFriday
            // 
            this.txtToFriday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtToFriday.Location = new System.Drawing.Point(215, 184);
            this.txtToFriday.Name = "txtToFriday";
            this.txtToFriday.Size = new System.Drawing.Size(81, 27);
            this.txtToFriday.TabIndex = 103;
            this.txtToFriday.Text = "Hasta";
            // 
            // txtFromFriday
            // 
            this.txtFromFriday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFromFriday.Location = new System.Drawing.Point(128, 184);
            this.txtFromFriday.Name = "txtFromFriday";
            this.txtFromFriday.Size = new System.Drawing.Size(81, 27);
            this.txtFromFriday.TabIndex = 102;
            this.txtFromFriday.Text = "Desde";
            // 
            // txtToThursday
            // 
            this.txtToThursday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtToThursday.Location = new System.Drawing.Point(215, 154);
            this.txtToThursday.Name = "txtToThursday";
            this.txtToThursday.Size = new System.Drawing.Size(81, 27);
            this.txtToThursday.TabIndex = 101;
            this.txtToThursday.Text = "Hasta";
            // 
            // txtFromThursday
            // 
            this.txtFromThursday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFromThursday.Location = new System.Drawing.Point(128, 154);
            this.txtFromThursday.Name = "txtFromThursday";
            this.txtFromThursday.Size = new System.Drawing.Size(81, 27);
            this.txtFromThursday.TabIndex = 100;
            this.txtFromThursday.Text = "Desde";
            // 
            // txtToWednesday
            // 
            this.txtToWednesday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtToWednesday.Location = new System.Drawing.Point(215, 124);
            this.txtToWednesday.Name = "txtToWednesday";
            this.txtToWednesday.Size = new System.Drawing.Size(81, 27);
            this.txtToWednesday.TabIndex = 99;
            this.txtToWednesday.Text = "Hasta";
            // 
            // txtFromWednesday
            // 
            this.txtFromWednesday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFromWednesday.Location = new System.Drawing.Point(128, 124);
            this.txtFromWednesday.Name = "txtFromWednesday";
            this.txtFromWednesday.Size = new System.Drawing.Size(81, 27);
            this.txtFromWednesday.TabIndex = 98;
            this.txtFromWednesday.Text = "Desde";
            // 
            // txtToTuesday
            // 
            this.txtToTuesday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtToTuesday.Location = new System.Drawing.Point(215, 94);
            this.txtToTuesday.Name = "txtToTuesday";
            this.txtToTuesday.Size = new System.Drawing.Size(81, 27);
            this.txtToTuesday.TabIndex = 97;
            this.txtToTuesday.Text = "Hasta";
            // 
            // txtFromTuesday
            // 
            this.txtFromTuesday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFromTuesday.Location = new System.Drawing.Point(128, 94);
            this.txtFromTuesday.Name = "txtFromTuesday";
            this.txtFromTuesday.Size = new System.Drawing.Size(81, 27);
            this.txtFromTuesday.TabIndex = 96;
            this.txtFromTuesday.Text = "Desde";
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(10, 216);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(82, 24);
            this.chkSaturday.TabIndex = 95;
            this.chkSaturday.Text = "Sábado";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(10, 186);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(79, 24);
            this.chkFriday.TabIndex = 94;
            this.chkFriday.Text = "Viernes";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(10, 156);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(73, 24);
            this.chkThursday.TabIndex = 93;
            this.chkThursday.Text = "Jueves";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(10, 126);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(95, 24);
            this.chkWednesday.TabIndex = 92;
            this.chkWednesday.Text = "Miércoles";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(10, 96);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(76, 24);
            this.chkTuesday.TabIndex = 91;
            this.chkTuesday.Text = "Martes";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(10, 68);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(68, 24);
            this.chkMonday.TabIndex = 90;
            this.chkMonday.Text = "Lunes";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // txtToMonday
            // 
            this.txtToMonday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtToMonday.Location = new System.Drawing.Point(215, 63);
            this.txtToMonday.Name = "txtToMonday";
            this.txtToMonday.Size = new System.Drawing.Size(81, 27);
            this.txtToMonday.TabIndex = 89;
            this.txtToMonday.Text = "Hasta";
            // 
            // txtFromMonday
            // 
            this.txtFromMonday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFromMonday.Location = new System.Drawing.Point(128, 63);
            this.txtFromMonday.Name = "txtFromMonday";
            this.txtFromMonday.Size = new System.Drawing.Size(81, 27);
            this.txtFromMonday.TabIndex = 88;
            this.txtFromMonday.Text = "Desde";
            // 
            // txtDocument
            // 
            this.txtDocument.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDocument.Location = new System.Drawing.Point(92, 77);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(211, 27);
            this.txtDocument.TabIndex = 66;
            this.txtDocument.Text = "N° documento";
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(17, 76);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumento.TabIndex = 65;
            this.cmbTipoDocumento.Text = "Tipo";
            // 
            // txtcomments
            // 
            this.txtcomments.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtcomments.Location = new System.Drawing.Point(17, 255);
            this.txtcomments.Multiline = true;
            this.txtcomments.Name = "txtcomments";
            this.txtcomments.Size = new System.Drawing.Size(286, 114);
            this.txtcomments.TabIndex = 64;
            this.txtcomments.Text = "Observaciones y/o consideraciones";
            // 
            // cmbTipoEmployee
            // 
            this.cmbTipoEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTipoEmployee.FormattingEnabled = true;
            this.cmbTipoEmployee.Location = new System.Drawing.Point(333, 37);
            this.cmbTipoEmployee.Name = "cmbTipoEmployee";
            this.cmbTipoEmployee.Size = new System.Drawing.Size(307, 28);
            this.cmbTipoEmployee.TabIndex = 61;
            this.cmbTipoEmployee.Text = "Tipo de empleado";
            // 
            // txtMail
            // 
            this.txtMail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMail.Location = new System.Drawing.Point(17, 206);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(286, 27);
            this.txtMail.TabIndex = 60;
            this.txtMail.Text = "Mail";
            // 
            // txtAlternative
            // 
            this.txtAlternative.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAlternative.Location = new System.Drawing.Point(17, 162);
            this.txtAlternative.Name = "txtAlternative";
            this.txtAlternative.Size = new System.Drawing.Size(286, 27);
            this.txtAlternative.TabIndex = 59;
            this.txtAlternative.Text = "Alternativo";
            this.txtAlternative.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhone.Location = new System.Drawing.Point(17, 117);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(286, 27);
            this.txtPhone.TabIndex = 58;
            this.txtPhone.Text = "Teléfono";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(17, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 27);
            this.txtName.TabIndex = 56;
            this.txtName.Text = "Nombre y Apellido";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveEmployee.FlatAppearance.BorderSize = 0;
            this.btnSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveEmployee.Location = new System.Drawing.Point(333, 328);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(307, 41);
            this.btnSaveEmployee.TabIndex = 53;
            this.btnSaveEmployee.Text = "Guardar";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.gbEmployeeData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaEmpleados";
            this.Text = "empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.gbEmployeeData.ResumeLayout(false);
            this.gbEmployeeData.PerformLayout();
            this.gbJournalTIme.ResumeLayout(false);
            this.gbJournalTIme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox gbEmployeeData;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtcomments;
        private System.Windows.Forms.ComboBox cmbTipoEmployee;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAlternative;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.GroupBox gbJournalTIme;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.TextBox txtToSaturday;
        private System.Windows.Forms.TextBox txtFromSaturday;
        private System.Windows.Forms.TextBox txtToFriday;
        private System.Windows.Forms.TextBox txtFromFriday;
        private System.Windows.Forms.TextBox txtToThursday;
        private System.Windows.Forms.TextBox txtFromThursday;
        private System.Windows.Forms.TextBox txtToWednesday;
        private System.Windows.Forms.TextBox txtFromWednesday;
        private System.Windows.Forms.TextBox txtToTuesday;
        private System.Windows.Forms.TextBox txtFromTuesday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.TextBox txtToMonday;
        private System.Windows.Forms.TextBox txtFromMonday;
    }
}