
namespace Gym
{
    partial class Cajas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCajas = new System.Windows.Forms.TextBox();
            this.GbImporteACobrar = new System.Windows.Forms.GroupBox();
            this.txtObservacionesCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.txtImporteEfectivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.lblTotalMomentaneo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.dtgvCajas = new System.Windows.Forms.DataGridView();
            this.Caja_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbImporteACobrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCajas
            // 
            this.txtBuscarCajas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCajas.Location = new System.Drawing.Point(509, 270);
            this.txtBuscarCajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCajas.Name = "txtBuscarCajas";
            this.txtBuscarCajas.Size = new System.Drawing.Size(179, 27);
            this.txtBuscarCajas.TabIndex = 78;
            this.txtBuscarCajas.Text = "Buscar Caja";
            this.txtBuscarCajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCajas_KeyPress);
            // 
            // GbImporteACobrar
            // 
            this.GbImporteACobrar.Controls.Add(this.txtObservacionesCaja);
            this.GbImporteACobrar.Controls.Add(this.label2);
            this.GbImporteACobrar.Controls.Add(this.btnAbrirCaja);
            this.GbImporteACobrar.Controls.Add(this.txtImporteEfectivo);
            this.GbImporteACobrar.Location = new System.Drawing.Point(12, 11);
            this.GbImporteACobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImporteACobrar.Name = "GbImporteACobrar";
            this.GbImporteACobrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImporteACobrar.Size = new System.Drawing.Size(323, 161);
            this.GbImporteACobrar.TabIndex = 81;
            this.GbImporteACobrar.TabStop = false;
            this.GbImporteACobrar.Text = "Caja";
            // 
            // txtObservacionesCaja
            // 
            this.txtObservacionesCaja.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtObservacionesCaja.Location = new System.Drawing.Point(18, 60);
            this.txtObservacionesCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesCaja.Multiline = true;
            this.txtObservacionesCaja.Name = "txtObservacionesCaja";
            this.txtObservacionesCaja.Size = new System.Drawing.Size(196, 83);
            this.txtObservacionesCaja.TabIndex = 84;
            this.txtObservacionesCaja.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Importe en caja";
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrirCaja.Location = new System.Drawing.Point(220, 60);
            this.btnAbrirCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(85, 82);
            this.btnAbrirCaja.TabIndex = 82;
            this.btnAbrirCaja.Text = "Abrir";
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            this.btnAbrirCaja.Click += new System.EventHandler(this.txtImporteEfectivo_Click);
            // 
            // txtImporteEfectivo
            // 
            this.txtImporteEfectivo.Location = new System.Drawing.Point(136, 28);
            this.txtImporteEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteEfectivo.Name = "txtImporteEfectivo";
            this.txtImporteEfectivo.Size = new System.Drawing.Size(169, 27);
            this.txtImporteEfectivo.TabIndex = 81;
            this.txtImporteEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDiferencia);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalMomentaneo);
            this.groupBox1.Location = new System.Drawing.Point(365, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(323, 161);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cierre de Caja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Ingresos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Egresos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Diferencia:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(144, 36);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(17, 20);
            this.lblIngresos.TabIndex = 93;
            this.lblIngresos.Text = "0";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(447, 36);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(17, 20);
            this.lblEgresos.TabIndex = 94;
            this.lblEgresos.Text = "0";
            this.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMomentaneo
            // 
            this.lblTotalMomentaneo.AutoSize = true;
            this.lblTotalMomentaneo.Location = new System.Drawing.Point(79, 73);
            this.lblTotalMomentaneo.Name = "lblTotalMomentaneo";
            this.lblTotalMomentaneo.Size = new System.Drawing.Size(17, 20);
            this.lblTotalMomentaneo.TabIndex = 95;
            this.lblTotalMomentaneo.Text = "0";
            this.lblTotalMomentaneo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblIngresos);
            this.groupBox2.Controls.Add(this.lblEgresos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(676, 78);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importes del día";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Importe en caja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 96;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(206, 115);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 37);
            this.btnCerrar.TabIndex = 85;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Total:";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Location = new System.Drawing.Point(79, 115);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(17, 20);
            this.lblDiferencia.TabIndex = 99;
            this.lblDiferencia.Text = "0";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgvCajas
            // 
            this.dtgvCajas.AllowUserToAddRows = false;
            this.dtgvCajas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caja_ID,
            this.Apertura,
            this.ImporteInicial,
            this.ImporteFinal,
            this.Empleado});
            this.dtgvCajas.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvCajas.Location = new System.Drawing.Point(12, 301);
            this.dtgvCajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCajas.Name = "dtgvCajas";
            this.dtgvCajas.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dtgvCajas.RowHeadersVisible = false;
            this.dtgvCajas.RowHeadersWidth = 51;
            this.dtgvCajas.RowTemplate.Height = 29;
            this.dtgvCajas.Size = new System.Drawing.Size(676, 338);
            this.dtgvCajas.TabIndex = 87;
            // 
            // Caja_ID
            // 
            this.Caja_ID.Frozen = true;
            this.Caja_ID.HeaderText = "Caja_ID";
            this.Caja_ID.MinimumWidth = 6;
            this.Caja_ID.Name = "Caja_ID";
            this.Caja_ID.ReadOnly = true;
            this.Caja_ID.Visible = false;
            this.Caja_ID.Width = 125;
            // 
            // Apertura
            // 
            this.Apertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Apertura.DefaultCellStyle = dataGridViewCellStyle20;
            this.Apertura.Frozen = true;
            this.Apertura.HeaderText = "Fecha";
            this.Apertura.MinimumWidth = 6;
            this.Apertura.Name = "Apertura";
            this.Apertura.ReadOnly = true;
            this.Apertura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apertura.Width = 160;
            // 
            // ImporteInicial
            // 
            this.ImporteInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImporteInicial.DefaultCellStyle = dataGridViewCellStyle21;
            this.ImporteInicial.Frozen = true;
            this.ImporteInicial.HeaderText = "Importe de Inicio";
            this.ImporteInicial.MinimumWidth = 6;
            this.ImporteInicial.Name = "ImporteInicial";
            this.ImporteInicial.ReadOnly = true;
            this.ImporteInicial.Width = 180;
            // 
            // ImporteFinal
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImporteFinal.DefaultCellStyle = dataGridViewCellStyle22;
            this.ImporteFinal.Frozen = true;
            this.ImporteFinal.HeaderText = "Importe de Cierre";
            this.ImporteFinal.MinimumWidth = 6;
            this.ImporteFinal.Name = "ImporteFinal";
            this.ImporteFinal.ReadOnly = true;
            this.ImporteFinal.Width = 180;
            // 
            // Empleado
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Empleado.DefaultCellStyle = dataGridViewCellStyle23;
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Empleado.Width = 153;
            // 
            // Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.dtgvCajas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbImporteACobrar);
            this.Controls.Add(this.txtBuscarCajas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cajas";
            this.Text = "Abrir Caja";
            this.GbImporteACobrar.ResumeLayout(false);
            this.GbImporteACobrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarCajas;
        private System.Windows.Forms.GroupBox GbImporteACobrar;
        private System.Windows.Forms.TextBox txtObservacionesCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.TextBox txtImporteEfectivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalMomentaneo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.DataGridView dtgvCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
    }
}