
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnAltaJornada.Location = new System.Drawing.Point(12, 280);
            this.btnAltaJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaJornada.Name = "btnAltaJornada";
            this.btnAltaJornada.Size = new System.Drawing.Size(307, 41);
            this.btnAltaJornada.TabIndex = 68;
            this.btnAltaJornada.Text = "Guardar Jornada";
            this.btnAltaJornada.UseVisualStyleBackColor = false;
            this.btnAltaJornada.Click += new System.EventHandler(this.btnAltaJornada_Click);
            // 
            // gbJornadaEmpleado
            // 
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
            this.gbJornadaEmpleado.Size = new System.Drawing.Size(307, 265);
            this.gbJornadaEmpleado.TabIndex = 69;
            this.gbJornadaEmpleado.TabStop = false;
            this.gbJornadaEmpleado.Text = "Días y horarios";
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
            this.txtHastaSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaSabado.Location = new System.Drawing.Point(215, 231);
            this.txtHastaSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaSabado.MaxLength = 5;
            this.txtHastaSabado.Name = "txtHastaSabado";
            this.txtHastaSabado.Size = new System.Drawing.Size(81, 22);
            this.txtHastaSabado.TabIndex = 27;
            this.txtHastaSabado.Text = "hh:mm";
            this.txtHastaSabado.Enter += new System.EventHandler(this.txtHastaSabado_Enter);
            this.txtHastaSabado.Leave += new System.EventHandler(this.txtHastaSabado_Leave);
            this.txtHastaSabado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtHastaSabado.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtDesdeSabado
            // 
            this.txtDesdeSabado.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeSabado.Location = new System.Drawing.Point(128, 231);
            this.txtDesdeSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeSabado.MaxLength = 5;
            this.txtDesdeSabado.Name = "txtDesdeSabado";
            this.txtDesdeSabado.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeSabado.TabIndex = 26;
            this.txtDesdeSabado.Text = "hh:mm";
            this.txtDesdeSabado.Enter += new System.EventHandler(this.txtDesdeSabado_Enter);
            this.txtDesdeSabado.Leave += new System.EventHandler(this.txtDesdeSabado_Leave);
            this.txtDesdeSabado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtDesdeSabado.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtHastaViernes
            // 
            this.txtHastaViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaViernes.Location = new System.Drawing.Point(215, 201);
            this.txtHastaViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaViernes.MaxLength = 5;
            this.txtHastaViernes.Name = "txtHastaViernes";
            this.txtHastaViernes.Size = new System.Drawing.Size(81, 22);
            this.txtHastaViernes.TabIndex = 24;
            this.txtHastaViernes.Text = "hh:mm";
            this.txtHastaViernes.Enter += new System.EventHandler(this.txtHastaViernes_Enter);
            this.txtHastaViernes.Leave += new System.EventHandler(this.txtHastaViernes_Leave);
            this.txtHastaViernes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtHastaViernes.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtDesdeViernes
            // 
            this.txtDesdeViernes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeViernes.Location = new System.Drawing.Point(128, 201);
            this.txtDesdeViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeViernes.MaxLength = 5;
            this.txtDesdeViernes.Name = "txtDesdeViernes";
            this.txtDesdeViernes.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeViernes.TabIndex = 23;
            this.txtDesdeViernes.Text = "hh:mm";
            this.txtDesdeViernes.Enter += new System.EventHandler(this.txtDesdeViernes_Enter);
            this.txtDesdeViernes.Leave += new System.EventHandler(this.txtDesdeViernes_Leave);
            this.txtDesdeViernes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtDesdeViernes.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtHastaJueves
            // 
            this.txtHastaJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaJueves.Location = new System.Drawing.Point(215, 171);
            this.txtHastaJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaJueves.MaxLength = 5;
            this.txtHastaJueves.Name = "txtHastaJueves";
            this.txtHastaJueves.Size = new System.Drawing.Size(81, 22);
            this.txtHastaJueves.TabIndex = 21;
            this.txtHastaJueves.Text = "hh:mm";
            this.txtHastaJueves.Enter += new System.EventHandler(this.txtHastaJueves_Enter);
            this.txtHastaJueves.Leave += new System.EventHandler(this.txtHastaJueves_Leave);
            this.txtHastaJueves.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtHastaJueves.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtDesdeJueves
            // 
            this.txtDesdeJueves.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeJueves.Location = new System.Drawing.Point(128, 171);
            this.txtDesdeJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeJueves.MaxLength = 5;
            this.txtDesdeJueves.Name = "txtDesdeJueves";
            this.txtDesdeJueves.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeJueves.TabIndex = 20;
            this.txtDesdeJueves.Text = "hh:mm";
            this.txtDesdeJueves.Enter += new System.EventHandler(this.txtDesdeJueves_Enter);
            this.txtDesdeJueves.Leave += new System.EventHandler(this.txtDesdeJueves_Leave);
            this.txtDesdeJueves.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtDesdeJueves.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtHastaMiercoles
            // 
            this.txtHastaMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMiercoles.Location = new System.Drawing.Point(215, 141);
            this.txtHastaMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMiercoles.MaxLength = 5;
            this.txtHastaMiercoles.Name = "txtHastaMiercoles";
            this.txtHastaMiercoles.Size = new System.Drawing.Size(81, 22);
            this.txtHastaMiercoles.TabIndex = 18;
            this.txtHastaMiercoles.Text = "hh:mm";
            this.txtHastaMiercoles.Enter += new System.EventHandler(this.txtHastaMiercoles_Enter);
            this.txtHastaMiercoles.Leave += new System.EventHandler(this.txtHastaMiercoles_Leave);
            this.txtHastaMiercoles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtHastaMiercoles.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtDesdeMiercoles
            // 
            this.txtDesdeMiercoles.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMiercoles.Location = new System.Drawing.Point(128, 141);
            this.txtDesdeMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMiercoles.MaxLength = 5;
            this.txtDesdeMiercoles.Name = "txtDesdeMiercoles";
            this.txtDesdeMiercoles.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeMiercoles.TabIndex = 17;
            this.txtDesdeMiercoles.Text = "hh:mm";
            this.txtDesdeMiercoles.Enter += new System.EventHandler(this.txtDesdeMiercoles_Enter);
            this.txtDesdeMiercoles.Leave += new System.EventHandler(this.txtDesdeMiercoles_Leave);
            this.txtDesdeMiercoles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtDesdeMiercoles.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtHastaMartes
            // 
            this.txtHastaMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaMartes.Location = new System.Drawing.Point(215, 111);
            this.txtHastaMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaMartes.MaxLength = 5;
            this.txtHastaMartes.Name = "txtHastaMartes";
            this.txtHastaMartes.Size = new System.Drawing.Size(81, 22);
            this.txtHastaMartes.TabIndex = 15;
            this.txtHastaMartes.Text = "hh:mm";
            this.txtHastaMartes.Enter += new System.EventHandler(this.txtHastaMartes_Enter);
            this.txtHastaMartes.Leave += new System.EventHandler(this.txtHastaMartes_Leave);
            this.txtHastaMartes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtHastaMartes.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtDesdeMartes
            // 
            this.txtDesdeMartes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeMartes.Location = new System.Drawing.Point(128, 111);
            this.txtDesdeMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeMartes.MaxLength = 5;
            this.txtDesdeMartes.Name = "txtDesdeMartes";
            this.txtDesdeMartes.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeMartes.TabIndex = 14;
            this.txtDesdeMartes.Text = "hh:mm";
            this.txtDesdeMartes.Enter += new System.EventHandler(this.txtDesdeMartes_Enter);
            this.txtDesdeMartes.Leave += new System.EventHandler(this.txtDesdeMartes_Leave);
            this.txtDesdeMartes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtDesdeMartes.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(10, 233);
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
            this.chkViernes.Location = new System.Drawing.Point(10, 203);
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
            this.chkJueves.Location = new System.Drawing.Point(10, 173);
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
            this.chkMiercoles.Location = new System.Drawing.Point(10, 143);
            this.chkMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(90, 21);
            this.chkMiercoles.TabIndex = 16;
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            this.chkMiercoles.Click += new System.EventHandler(this.chkMiercoles_Click);
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(10, 113);
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
            this.txtHastaLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaLunes.Location = new System.Drawing.Point(215, 79);
            this.txtHastaLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaLunes.MaxLength = 5;
            this.txtHastaLunes.Name = "txtHastaLunes";
            this.txtHastaLunes.Size = new System.Drawing.Size(81, 22);
            this.txtHastaLunes.TabIndex = 12;
            this.txtHastaLunes.Text = "hh:mm";
            this.txtHastaLunes.Enter += new System.EventHandler(this.txtHastaLunes_Enter);
            this.txtHastaLunes.Leave += new System.EventHandler(this.txtHastaLunes_Leave);
            this.txtHastaLunes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtHastaLunes.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // txtDesdeLunes
            // 
            this.txtDesdeLunes.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesdeLunes.Location = new System.Drawing.Point(128, 79);
            this.txtDesdeLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesdeLunes.MaxLength = 5;
            this.txtDesdeLunes.Name = "txtDesdeLunes";
            this.txtDesdeLunes.Size = new System.Drawing.Size(81, 22);
            this.txtDesdeLunes.TabIndex = 11;
            this.txtDesdeLunes.Text = "hh:mm";
            this.txtDesdeLunes.Enter += new System.EventHandler(this.txtDesdeLunes_Enter);
            this.txtDesdeLunes.Leave += new System.EventHandler(this.txtDesdeLunes_Leave);
            this.txtDesdeLunes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jornadas_MouseDown);
            this.txtDesdeLunes.MouseHover += new System.EventHandler(this.txtDesdeLunes_MouseHover);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Location = new System.Drawing.Point(137, 326);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(64, 17);
            this.lblCancelar.TabIndex = 70;
            this.lblCancelar.TabStop = true;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCancelar_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hasta";
            // 
            // Jornadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 349);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnAltaJornada);
            this.Controls.Add(this.gbJornadaEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jornadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jornadas";
            this.Load += new System.EventHandler(this.Jornadas_Load);
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
    }
}