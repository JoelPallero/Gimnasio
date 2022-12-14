
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCajas = new System.Windows.Forms.TextBox();
            this.gbAperturaCaja = new System.Windows.Forms.GroupBox();
            this.txtObservacionesCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.txtImporteEfectivo = new System.Windows.Forms.TextBox();
            this.gbCierreCaja = new System.Windows.Forms.GroupBox();
            this.lblImporteCajaFinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporteFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblImporteInicial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvCajas = new System.Windows.Forms.DataGridView();
            this.Caja_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtBuscarCajas.Size = new System.Drawing.Size(179, 27);
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
            this.btnAbrirCaja.Location = new System.Drawing.Point(220, 114);
            this.btnAbrirCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(85, 33);
            this.btnAbrirCaja.TabIndex = 82;
            this.btnAbrirCaja.Text = "Abrir";
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // txtImporteEfectivo
            // 
            this.txtImporteEfectivo.Location = new System.Drawing.Point(136, 28);
            this.txtImporteEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteEfectivo.Name = "txtImporteEfectivo";
            this.txtImporteEfectivo.Size = new System.Drawing.Size(169, 27);
            this.txtImporteEfectivo.TabIndex = 81;
            this.txtImporteEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteEfectivo_KeyPress);
            // 
            // gbCierreCaja
            // 
            this.gbCierreCaja.Controls.Add(this.lblImporteCajaFinal);
            this.gbCierreCaja.Controls.Add(this.label7);
            this.gbCierreCaja.Controls.Add(this.lblDiferencia);
            this.gbCierreCaja.Controls.Add(this.label9);
            this.gbCierreCaja.Controls.Add(this.btnCerrar);
            this.gbCierreCaja.Controls.Add(this.label3);
            this.gbCierreCaja.Controls.Add(this.txtImporteFinal);
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
            // lblImporteCajaFinal
            // 
            this.lblImporteCajaFinal.AutoSize = true;
            this.lblImporteCajaFinal.Location = new System.Drawing.Point(115, 67);
            this.lblImporteCajaFinal.Name = "lblImporteCajaFinal";
            this.lblImporteCajaFinal.Size = new System.Drawing.Size(17, 20);
            this.lblImporteCajaFinal.TabIndex = 106;
            this.lblImporteCajaFinal.Text = "0";
            this.lblImporteCajaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 105;
            this.label7.Text = "Importe Final:";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Location = new System.Drawing.Point(115, 91);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(17, 20);
            this.lblDiferencia.TabIndex = 104;
            this.lblDiferencia.Text = "0";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 103;
            this.label9.Text = "Diferencia:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(197, 114);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 33);
            this.btnCerrar.TabIndex = 85;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // txtImporteFinal
            // 
            this.txtImporteFinal.Location = new System.Drawing.Point(134, 30);
            this.txtImporteFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteFinal.Name = "txtImporteFinal";
            this.txtImporteFinal.Size = new System.Drawing.Size(169, 27);
            this.txtImporteFinal.TabIndex = 96;
            this.txtImporteFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteFinal_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(571, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 20);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Ingresos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Egresos:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(278, 37);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(17, 20);
            this.lblIngresos.TabIndex = 93;
            this.lblIngresos.Text = "0";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(425, 37);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(17, 20);
            this.lblEgresos.TabIndex = 94;
            this.lblEgresos.Text = "0";
            this.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImporteInicial);
            this.groupBox2.Controls.Add(this.label8);
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
            // lblImporteInicial
            // 
            this.lblImporteInicial.AutoSize = true;
            this.lblImporteInicial.Location = new System.Drawing.Point(133, 37);
            this.lblImporteInicial.Name = "lblImporteInicial";
            this.lblImporteInicial.Size = new System.Drawing.Size(17, 20);
            this.lblImporteInicial.TabIndex = 104;
            this.lblImporteInicial.Text = "0";
            this.lblImporteInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Importe Inicial:";
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
            this.Diferencia});
            this.dtgvCajas.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvCajas.Location = new System.Drawing.Point(12, 301);
            this.dtgvCajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCajas.Name = "dtgvCajas";
            this.dtgvCajas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.Caja_ID.Width = 130;
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
            this.Apertura.Width = 130;
            // 
            // ImporteInicial
            // 
            this.ImporteInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImporteInicial.DefaultCellStyle = dataGridViewCellStyle3;
            this.ImporteInicial.Frozen = true;
            this.ImporteInicial.HeaderText = "Efectivo Inicial";
            this.ImporteInicial.MinimumWidth = 6;
            this.ImporteInicial.Name = "ImporteInicial";
            this.ImporteInicial.ReadOnly = true;
            this.ImporteInicial.Width = 140;
            // 
            // ImporteFinal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImporteFinal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ImporteFinal.Frozen = true;
            this.ImporteFinal.HeaderText = "Efectivo final";
            this.ImporteFinal.MinimumWidth = 6;
            this.ImporteFinal.Name = "ImporteFinal";
            this.ImporteFinal.ReadOnly = true;
            this.ImporteFinal.Width = 133;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Cierre de Caja";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 145;
            // 
            // Diferencia
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle6;
            this.Diferencia.HeaderText = "Diferencia";
            this.Diferencia.MinimumWidth = 6;
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.Width = 125;
            // 
            // Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
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
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblImporteCajaFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblImporteInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
    }
}