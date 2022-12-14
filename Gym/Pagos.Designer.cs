
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.DtgvDetalleFacturación = new System.Windows.Forms.DataGridView();
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
            this.txtBuscarClase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDetalleFacturación)).BeginInit();
            this.GbImporteACobrar.SuspendLayout();
            this.GbDatosClienteSaldos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCliente.Location = new System.Drawing.Point(380, 21);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(308, 27);
            this.txtBuscarCliente.TabIndex = 11;
            this.txtBuscarCliente.Text = "DNI";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.TxtDatosClienteSaldos_Enter);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.TxtDatosClienteSaldos_Leave);
            // 
            // DtgvDetalleFacturación
            // 
            this.DtgvDetalleFacturación.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDetalleFacturación.Location = new System.Drawing.Point(12, 406);
            this.DtgvDetalleFacturación.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgvDetalleFacturación.Name = "DtgvDetalleFacturación";
            this.DtgvDetalleFacturación.RowHeadersWidth = 51;
            this.DtgvDetalleFacturación.RowTemplate.Height = 29;
            this.DtgvDetalleFacturación.Size = new System.Drawing.Size(676, 233);
            this.DtgvDetalleFacturación.TabIndex = 14;
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
            this.cmbPlanesPagaPago.Size = new System.Drawing.Size(223, 28);
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
            this.rbPago.Size = new System.Drawing.Size(63, 24);
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
            this.rbCobro.Size = new System.Drawing.Size(71, 24);
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
            this.txtImporte.Size = new System.Drawing.Size(223, 27);
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
            this.lblPlanesAsignadosCliente.Size = new System.Drawing.Size(0, 20);
            this.lblPlanesAsignadosCliente.TabIndex = 32;
            // 
            // lblPlanesCliente
            // 
            this.lblPlanesCliente.AutoSize = true;
            this.lblPlanesCliente.Location = new System.Drawing.Point(354, 53);
            this.lblPlanesCliente.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblPlanesCliente.Name = "lblPlanesCliente";
            this.lblPlanesCliente.Size = new System.Drawing.Size(86, 20);
            this.lblPlanesCliente.TabIndex = 31;
            this.lblPlanesCliente.Text = "Plan Actual:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(18, 79);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 20);
            this.lblTelefono.TabIndex = 30;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(354, 31);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 20);
            this.lblMail.TabIndex = 29;
            this.lblMail.Text = "Mail: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(18, 53);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(42, 20);
            this.lblDocumento.TabIndex = 28;
            this.lblDocumento.Text = "DNI: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtBuscarClase
            // 
            this.txtBuscarClase.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarClase.Location = new System.Drawing.Point(391, 375);
            this.txtBuscarClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarClase.Name = "txtBuscarClase";
            this.txtBuscarClase.Size = new System.Drawing.Size(297, 27);
            this.txtBuscarClase.TabIndex = 27;
            this.txtBuscarClase.Text = "Buscar Movimientos";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.txtBuscarClase);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.DtgvDetalleFacturación);
            this.Controls.Add(this.GbImporteACobrar);
            this.Controls.Add(this.GbDatosClienteSaldos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pagos";
            this.Text = "pagos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDetalleFacturación)).EndInit();
            this.GbImporteACobrar.ResumeLayout(false);
            this.GbImporteACobrar.PerformLayout();
            this.GbDatosClienteSaldos.ResumeLayout(false);
            this.GbDatosClienteSaldos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView DtgvDetalleFacturación;
        private System.Windows.Forms.GroupBox GbImporteACobrar;
        private System.Windows.Forms.Button BtnRegistrarMovimiento;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.GroupBox GbDatosClienteSaldos;
        private System.Windows.Forms.TextBox txtBuscarClase;
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
    }
}