
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCajas = new System.Windows.Forms.TextBox();
            this.gbAperturaCaja = new System.Windows.Forms.GroupBox();
            this.txtObservacionesCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.txtImporteEfectivo = new System.Windows.Forms.TextBox();
            this.gbCierreCaja = new System.Windows.Forms.GroupBox();
            this.lblDiferenciaFinal = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporteFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvCajas = new System.Windows.Forms.DataGridView();
            this.Caja_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAperturaCaja.SuspendLayout();
            this.gbCierreCaja.SuspendLayout();
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
            this.txtBuscarCajas.Size = new System.Drawing.Size(179, 23);
            this.txtBuscarCajas.TabIndex = 78;
            this.txtBuscarCajas.Text = "Buscar Caja";
            this.txtBuscarCajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCajas_KeyPress);
            // 
            // gbAperturaCaja
            // 
            this.gbAperturaCaja.Controls.Add(this.txtObservacionesCaja);
            this.gbAperturaCaja.Controls.Add(this.label2);
            this.gbAperturaCaja.Controls.Add(this.btnAbrirCaja);
            this.gbAperturaCaja.Controls.Add(this.txtImporteEfectivo);
            this.gbAperturaCaja.Location = new System.Drawing.Point(12, 11);
            this.gbAperturaCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAperturaCaja.Name = "gbAperturaCaja";
            this.gbAperturaCaja.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAperturaCaja.Size = new System.Drawing.Size(323, 161);
            this.gbAperturaCaja.TabIndex = 81;
            this.gbAperturaCaja.TabStop = false;
            this.gbAperturaCaja.Text = "Caja";
            // 
            // txtObservacionesCaja
            // 
            this.txtObservacionesCaja.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtObservacionesCaja.Location = new System.Drawing.Point(21, 64);
            this.txtObservacionesCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesCaja.Multiline = true;
            this.txtObservacionesCaja.Name = "txtObservacionesCaja";
            this.txtObservacionesCaja.Size = new System.Drawing.Size(193, 83);
            this.txtObservacionesCaja.TabIndex = 84;
            this.txtObservacionesCaja.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Importe en caja";
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrirCaja.Location = new System.Drawing.Point(220, 114);
            this.btnAbrirCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(85, 33);
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
            this.txtImporteEfectivo.Size = new System.Drawing.Size(169, 23);
            this.txtImporteEfectivo.TabIndex = 81;
            this.txtImporteEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteEfectivo_KeyPress);
            // 
            // gbCierreCaja
            // 
            this.gbCierreCaja.Controls.Add(this.lblDiferenciaFinal);
            this.gbCierreCaja.Controls.Add(this.btnCerrar);
            this.gbCierreCaja.Controls.Add(this.label3);
            this.gbCierreCaja.Controls.Add(this.txtImporteFinal);
            this.gbCierreCaja.Controls.Add(this.label5);
            this.gbCierreCaja.Enabled = false;
            this.gbCierreCaja.Location = new System.Drawing.Point(365, 11);
            this.gbCierreCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCierreCaja.Name = "gbCierreCaja";
            this.gbCierreCaja.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCierreCaja.Size = new System.Drawing.Size(323, 161);
            this.gbCierreCaja.TabIndex = 85;
            this.gbCierreCaja.TabStop = false;
            this.gbCierreCaja.Text = "Cierre de Caja";
            // 
            // lblDiferenciaFinal
            // 
            this.lblDiferenciaFinal.AutoSize = true;
            this.lblDiferenciaFinal.Location = new System.Drawing.Point(102, 82);
            this.lblDiferenciaFinal.Name = "lblDiferenciaFinal";
            this.lblDiferenciaFinal.Size = new System.Drawing.Size(13, 15);
            this.lblDiferenciaFinal.TabIndex = 102;
            this.lblDiferenciaFinal.Text = "0";
            this.lblDiferenciaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(133, 114);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(169, 33);
            this.btnCerrar.TabIndex = 85;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Importe en caja";
            // 
            // txtImporteFinal
            // 
            this.txtImporteFinal.Location = new System.Drawing.Point(134, 30);
            this.txtImporteFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteFinal.Name = "txtImporteFinal";
            this.txtImporteFinal.Size = new System.Drawing.Size(169, 23);
            this.txtImporteFinal.TabIndex = 96;
            this.txtImporteFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteFinal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 92;
            this.label5.Text = "Diferencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(546, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 15);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 90;
            this.label4.Text = "Ingresos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 91;
            this.label1.Text = "Egresos:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(144, 36);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(13, 15);
            this.lblIngresos.TabIndex = 93;
            this.lblIngresos.Text = "0";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(358, 36);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(13, 15);
            this.lblEgresos.TabIndex = 94;
            this.lblEgresos.Text = "0";
            this.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTotal);
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
            // dtgvCajas
            // 
            this.dtgvCajas.AllowUserToAddRows = false;
            this.dtgvCajas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caja_ID,
            this.Apertura,
            this.ImporteInicial,
            this.ImporteFinal,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvCajas.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvCajas.Location = new System.Drawing.Point(12, 301);
            this.dtgvCajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCajas.Name = "dtgvCajas";
            this.dtgvCajas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.Caja_ID.Width = 84;
            // 
            // Apertura
            // 
            this.Apertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Apertura.DefaultCellStyle = dataGridViewCellStyle2;
            this.Apertura.Frozen = true;
            this.Apertura.HeaderText = "Fecha";
            this.Apertura.MinimumWidth = 6;
            this.Apertura.Name = "Apertura";
            this.Apertura.ReadOnly = true;
            this.Apertura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apertura.Width = 84;
            // 
            // ImporteInicial
            // 
            this.ImporteInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImporteInicial.DefaultCellStyle = dataGridViewCellStyle3;
            this.ImporteInicial.Frozen = true;
            this.ImporteInicial.HeaderText = "Apertura Caja";
            this.ImporteInicial.MinimumWidth = 6;
            this.ImporteInicial.Name = "ImporteInicial";
            this.ImporteInicial.ReadOnly = true;
            this.ImporteInicial.Width = 84;
            // 
            // ImporteFinal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImporteFinal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ImporteFinal.Frozen = true;
            this.ImporteFinal.HeaderText = "Cierre Caja";
            this.ImporteFinal.MinimumWidth = 6;
            this.ImporteFinal.Name = "ImporteFinal";
            this.ImporteFinal.ReadOnly = true;
            this.ImporteFinal.Width = 84;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ingreso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Egreso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 84;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Motivo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 84;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Empleado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 84;
            // 
            // Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.dtgvCajas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCierreCaja);
            this.Controls.Add(this.gbAperturaCaja);
            this.Controls.Add(this.txtBuscarCajas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cajas";
            this.Text = "Abrir Caja";
            this.gbAperturaCaja.ResumeLayout(false);
            this.gbAperturaCaja.PerformLayout();
            this.gbCierreCaja.ResumeLayout(false);
            this.gbCierreCaja.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarCajas;
        private System.Windows.Forms.GroupBox gbAperturaCaja;
        private System.Windows.Forms.TextBox txtObservacionesCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.TextBox txtImporteEfectivo;
        private System.Windows.Forms.GroupBox gbCierreCaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImporteFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgvCajas;
        private System.Windows.Forms.Label lblDiferenciaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}