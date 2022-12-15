
namespace Gym
{
    partial class Pagos
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.GbImporteACobrar = new System.Windows.Forms.GroupBox();
            this.cmbPlanesPagaPago = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.rbCobro = new System.Windows.Forms.RadioButton();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.BtnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.GbDatosClienteSaldos = new System.Windows.Forms.GroupBox();
            this.lblPlanesAsignadosCliente = new System.Windows.Forms.Label();
            this.lblPlanesCliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarMovimiento = new System.Windows.Forms.TextBox();
            this.dtgvDetalles = new System.Windows.Forms.DataGridView();
            this.Detalle_Caja_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbImporteACobrar.SuspendLayout();
            this.GbDatosClienteSaldos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCliente.Location = new System.Drawing.Point(380, 21);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(308, 23);
            this.txtBuscarCliente.TabIndex = 11;
            this.txtBuscarCliente.Text = "DNI";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.TxtDatosClienteSaldos_Enter);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.TxtDatosClienteSaldos_Leave);
            // 
            // GbImporteACobrar
            // 
            this.GbImporteACobrar.Controls.Add(this.cmbPlanesPagaPago);
            this.GbImporteACobrar.Controls.Add(this.txtObservaciones);
            this.GbImporteACobrar.Controls.Add(this.rbPago);
            this.GbImporteACobrar.Controls.Add(this.rbCobro);
            this.GbImporteACobrar.Controls.Add(this.txtImporte);
            this.GbImporteACobrar.Controls.Add(this.BtnRegistrarMovimiento);
            this.GbImporteACobrar.Location = new System.Drawing.Point(12, 188);
            this.GbImporteACobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImporteACobrar.Name = "GbImporteACobrar";
            this.GbImporteACobrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImporteACobrar.Size = new System.Drawing.Size(676, 169);
            this.GbImporteACobrar.TabIndex = 13;
            this.GbImporteACobrar.TabStop = false;
            this.GbImporteACobrar.Text = "Importes a cobrar";
            // 
            // cmbPlanesPagaPago
            // 
            this.cmbPlanesPagaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanesPagaPago.FormattingEnabled = true;
            this.cmbPlanesPagaPago.Location = new System.Drawing.Point(123, 35);
            this.cmbPlanesPagaPago.Name = "cmbPlanesPagaPago";
            this.cmbPlanesPagaPago.Size = new System.Drawing.Size(223, 23);
            this.cmbPlanesPagaPago.TabIndex = 60;
            this.cmbPlanesPagaPago.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanesPagaPago_SelectionChangeCommitted);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservaciones.Location = new System.Drawing.Point(368, 35);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(289, 65);
            this.txtObservaciones.TabIndex = 59;
            this.txtObservaciones.Text = "Observaciones";
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Location = new System.Drawing.Point(22, 75);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(52, 19);
            this.rbPago.TabIndex = 58;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            // 
            // rbCobro
            // 
            this.rbCobro.AutoSize = true;
            this.rbCobro.Checked = true;
            this.rbCobro.Location = new System.Drawing.Point(22, 36);
            this.rbCobro.Name = "rbCobro";
            this.rbCobro.Size = new System.Drawing.Size(58, 19);
            this.rbCobro.TabIndex = 57;
            this.rbCobro.TabStop = true;
            this.rbCobro.Text = "Cobro";
            this.rbCobro.UseVisualStyleBackColor = true;
            this.rbCobro.CheckedChanged += new System.EventHandler(this.rbCobro_CheckedChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.ForeColor = System.Drawing.Color.DimGray;
            this.txtImporte.Location = new System.Drawing.Point(123, 73);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(223, 23);
            this.txtImporte.TabIndex = 56;
            this.txtImporte.Text = "Importe $";
            this.txtImporte.Enter += new System.EventHandler(this.TxtImporte_Enter);
            this.txtImporte.Leave += new System.EventHandler(this.TxtImporte_Leave);
            // 
            // BtnRegistrarMovimiento
            // 
            this.BtnRegistrarMovimiento.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRegistrarMovimiento.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarMovimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrarMovimiento.Location = new System.Drawing.Point(504, 117);
            this.BtnRegistrarMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarMovimiento.Name = "BtnRegistrarMovimiento";
            this.BtnRegistrarMovimiento.Size = new System.Drawing.Size(153, 36);
            this.BtnRegistrarMovimiento.TabIndex = 54;
            this.BtnRegistrarMovimiento.Text = "Aceptar";
            this.BtnRegistrarMovimiento.UseVisualStyleBackColor = false;
            this.BtnRegistrarMovimiento.Click += new System.EventHandler(this.BtnRegistrarMovimiento_Click);
            // 
            // GbDatosClienteSaldos
            // 
            this.GbDatosClienteSaldos.Controls.Add(this.lblPlanesAsignadosCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.lblPlanesCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.lblTelefono);
            this.GbDatosClienteSaldos.Controls.Add(this.lblMail);
            this.GbDatosClienteSaldos.Controls.Add(this.lblDocumento);
            this.GbDatosClienteSaldos.Controls.Add(this.lblNombre);
            this.GbDatosClienteSaldos.Location = new System.Drawing.Point(12, 57);
            this.GbDatosClienteSaldos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbDatosClienteSaldos.Name = "GbDatosClienteSaldos";
            this.GbDatosClienteSaldos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbDatosClienteSaldos.Size = new System.Drawing.Size(676, 122);
            this.GbDatosClienteSaldos.TabIndex = 12;
            this.GbDatosClienteSaldos.TabStop = false;
            this.GbDatosClienteSaldos.Text = "Datos Personales";
            // 
            // lblPlanesAsignadosCliente
            // 
            this.lblPlanesAsignadosCliente.AutoSize = true;
            this.lblPlanesAsignadosCliente.Location = new System.Drawing.Point(449, 53);
            this.lblPlanesAsignadosCliente.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblPlanesAsignadosCliente.Name = "lblPlanesAsignadosCliente";
            this.lblPlanesAsignadosCliente.Size = new System.Drawing.Size(0, 15);
            this.lblPlanesAsignadosCliente.TabIndex = 32;
            // 
            // lblPlanesCliente
            // 
            this.lblPlanesCliente.AutoSize = true;
            this.lblPlanesCliente.Location = new System.Drawing.Point(354, 53);
            this.lblPlanesCliente.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblPlanesCliente.Name = "lblPlanesCliente";
            this.lblPlanesCliente.Size = new System.Drawing.Size(70, 15);
            this.lblPlanesCliente.TabIndex = 31;
            this.lblPlanesCliente.Text = "Plan Actual:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(18, 79);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 15);
            this.lblTelefono.TabIndex = 30;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(354, 31);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 15);
            this.lblMail.TabIndex = 29;
            this.lblMail.Text = "Mail: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(18, 53);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(33, 15);
            this.lblDocumento.TabIndex = 28;
            this.lblDocumento.Text = "DNI: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtBuscarMovimiento
            // 
            this.txtBuscarMovimiento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarMovimiento.Location = new System.Drawing.Point(391, 375);
            this.txtBuscarMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarMovimiento.Name = "txtBuscarMovimiento";
            this.txtBuscarMovimiento.Size = new System.Drawing.Size(297, 23);
            this.txtBuscarMovimiento.TabIndex = 27;
            this.txtBuscarMovimiento.Text = "Buscar Movimientos";
            this.txtBuscarMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarClase_KeyPress);
            // 
            // dtgvDetalles
            // 
            this.dtgvDetalles.AllowUserToAddRows = false;
            this.dtgvDetalles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle_Caja_ID,
            this.Ingreso,
            this.Egreso,
            this.Observaciones});
            this.dtgvDetalles.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvDetalles.Location = new System.Drawing.Point(12, 402);
            this.dtgvDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDetalles.Name = "dtgvDetalles";
            this.dtgvDetalles.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvDetalles.RowHeadersVisible = false;
            this.dtgvDetalles.RowHeadersWidth = 51;
            this.dtgvDetalles.RowTemplate.Height = 29;
            this.dtgvDetalles.Size = new System.Drawing.Size(676, 237);
            this.dtgvDetalles.TabIndex = 87;
            // 
            // Detalle_Caja_ID
            // 
            this.Detalle_Caja_ID.Frozen = true;
            this.Detalle_Caja_ID.HeaderText = "Detalle_Caja_ID";
            this.Detalle_Caja_ID.MinimumWidth = 6;
            this.Detalle_Caja_ID.Name = "Detalle_Caja_ID";
            this.Detalle_Caja_ID.ReadOnly = true;
            this.Detalle_Caja_ID.Visible = false;
            this.Detalle_Caja_ID.Width = 125;
            // 
            // Ingreso
            // 
            this.Ingreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ingreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ingreso.Frozen = true;
            this.Ingreso.HeaderText = "Importe de Ingreso";
            this.Ingreso.MinimumWidth = 6;
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ReadOnly = true;
            this.Ingreso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ingreso.Width = 200;
            // 
            // Egreso
            // 
            this.Egreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Egreso.DefaultCellStyle = dataGridViewCellStyle3;
            this.Egreso.Frozen = true;
            this.Egreso.HeaderText = "Importe de Egreso";
            this.Egreso.MinimumWidth = 6;
            this.Egreso.Name = "Egreso";
            this.Egreso.ReadOnly = true;
            this.Egreso.Width = 200;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.Observaciones.Frozen = true;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 340;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.dtgvDetalles);
            this.Controls.Add(this.txtBuscarMovimiento);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.GbImporteACobrar);
            this.Controls.Add(this.GbDatosClienteSaldos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pagos";
            this.Text = "pagos";
            this.GbImporteACobrar.ResumeLayout(false);
            this.GbImporteACobrar.PerformLayout();
            this.GbDatosClienteSaldos.ResumeLayout(false);
            this.GbDatosClienteSaldos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.GroupBox GbImporteACobrar;
        private System.Windows.Forms.Button BtnRegistrarMovimiento;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.GroupBox GbDatosClienteSaldos;
        private System.Windows.Forms.TextBox txtBuscarMovimiento;
        private System.Windows.Forms.Label lblPlanesAsignadosCliente;
        private System.Windows.Forms.Label lblPlanesCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.RadioButton rbCobro;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ComboBox cmbPlanesPagaPago;
        private System.Windows.Forms.DataGridView dtgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle_Caja_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}