
namespace Gym
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.DtgvCliente = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNumDocumentoCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.txtObservacionesCliente = new System.Windows.Forms.TextBox();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.txtAlternativoCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCliente.Location = new System.Drawing.Point(486, 265);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(197, 27);
            this.txtBuscarCliente.TabIndex = 10;
            this.txtBuscarCliente.Text = "Buscar";
            this.txtBuscarCliente.Enter += new System.EventHandler(this.txtBuscarCliente_Enter);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.txtBuscarCliente_Leave);
            // 
            // DtgvCliente
            // 
            this.DtgvCliente.AllowUserToAddRows = false;
            this.DtgvCliente.AllowUserToDeleteRows = false;
            this.DtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Telefono,
            this.Mail});
            this.DtgvCliente.Location = new System.Drawing.Point(17, 298);
            this.DtgvCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgvCliente.Name = "DtgvCliente";
            this.DtgvCliente.ReadOnly = true;
            this.DtgvCliente.RowHeadersVisible = false;
            this.DtgvCliente.RowHeadersWidth = 51;
            this.DtgvCliente.RowTemplate.Height = 29;
            this.DtgvCliente.Size = new System.Drawing.Size(666, 340);
            this.DtgvCliente.TabIndex = 60;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle6;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 130;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle7;
            this.Apellido.Frozen = true;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 130;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle8;
            this.Documento.Frozen = true;
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 130;
            // 
            // Telefono
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle9;
            this.Telefono.Frozen = true;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 130;
            // 
            // Mail
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Mail.DefaultCellStyle = dataGridViewCellStyle10;
            this.Mail.Frozen = true;
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 142;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.txtNumDocumentoCliente);
            this.groupBox1.Controls.Add(this.cmbTipoDocumentoCliente);
            this.groupBox1.Controls.Add(this.txtObservacionesCliente);
            this.groupBox1.Controls.Add(this.txtMailCliente);
            this.groupBox1.Controls.Add(this.txtAlternativoCliente);
            this.groupBox1.Controls.Add(this.txtTelefonoCliente);
            this.groupBox1.Controls.Add(this.btnAltaCliente);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(666, 250);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.Location = new System.Drawing.Point(28, 29);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(286, 27);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.Text = "Nombre";
            this.txtNombreCliente.Enter += new System.EventHandler(this.txtNombreCliente_Enter);
            this.txtNombreCliente.Leave += new System.EventHandler(this.txtNombreCliente_Leave);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.ForeColor = System.Drawing.Color.Black;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(28, 138);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(286, 28);
            this.cmbSexo.TabIndex = 4;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoCliente.Location = new System.Drawing.Point(28, 65);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtApellidoCliente.TabIndex = 2;
            this.txtApellidoCliente.Text = "Apellido";
            this.txtApellidoCliente.Enter += new System.EventHandler(this.txtApellidoCliente_Enter);
            this.txtApellidoCliente.Leave += new System.EventHandler(this.txtApellidoCliente_Leave);
            // 
            // txtNumDocumentoCliente
            // 
            this.txtNumDocumentoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumDocumentoCliente.Location = new System.Drawing.Point(103, 102);
            this.txtNumDocumentoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumDocumentoCliente.Name = "txtNumDocumentoCliente";
            this.txtNumDocumentoCliente.Size = new System.Drawing.Size(211, 27);
            this.txtNumDocumentoCliente.TabIndex = 3;
            this.txtNumDocumentoCliente.Text = "N° documento";
            this.txtNumDocumentoCliente.Enter += new System.EventHandler(this.txtNumDocumentoCliente_Enter);
            this.txtNumDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocumentoCliente_KeyPress);
            this.txtNumDocumentoCliente.Leave += new System.EventHandler(this.txtNumDocumentoCliente_Leave);
            // 
            // cmbTipoDocumentoCliente
            // 
            this.cmbTipoDocumentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDocumentoCliente.FormattingEnabled = true;
            this.cmbTipoDocumentoCliente.Location = new System.Drawing.Point(28, 102);
            this.cmbTipoDocumentoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDocumentoCliente.Name = "cmbTipoDocumentoCliente";
            this.cmbTipoDocumentoCliente.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumentoCliente.TabIndex = 0;
            // 
            // txtObservacionesCliente
            // 
            this.txtObservacionesCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacionesCliente.Location = new System.Drawing.Point(348, 64);
            this.txtObservacionesCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionesCliente.MaxLength = 200;
            this.txtObservacionesCliente.Multiline = true;
            this.txtObservacionesCliente.Name = "txtObservacionesCliente";
            this.txtObservacionesCliente.Size = new System.Drawing.Size(286, 102);
            this.txtObservacionesCliente.TabIndex = 8;
            this.txtObservacionesCliente.Text = "Observaciones y/o consideraciones";
            this.txtObservacionesCliente.Enter += new System.EventHandler(this.txtObservacionesCliente_Enter);
            this.txtObservacionesCliente.Leave += new System.EventHandler(this.txtObservacionesCliente_Leave);
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtMailCliente.Location = new System.Drawing.Point(348, 29);
            this.txtMailCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(286, 27);
            this.txtMailCliente.TabIndex = 7;
            this.txtMailCliente.Text = "Mail";
            this.txtMailCliente.Enter += new System.EventHandler(this.txtMailCliente_Enter);
            this.txtMailCliente.Leave += new System.EventHandler(this.txtMailCliente_Leave);
            // 
            // txtAlternativoCliente
            // 
            this.txtAlternativoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtAlternativoCliente.Location = new System.Drawing.Point(28, 209);
            this.txtAlternativoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlternativoCliente.Name = "txtAlternativoCliente";
            this.txtAlternativoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtAlternativoCliente.TabIndex = 6;
            this.txtAlternativoCliente.Text = "Alternativo";
            this.txtAlternativoCliente.Enter += new System.EventHandler(this.txtAlternativoCliente_Enter);
            this.txtAlternativoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlternativoCliente_KeyPress);
            this.txtAlternativoCliente.Leave += new System.EventHandler(this.txtAlternativoCliente_Leave);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(28, 174);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtTelefonoCliente.TabIndex = 5;
            this.txtTelefonoCliente.Text = "Teléfono";
            this.txtTelefonoCliente.Enter += new System.EventHandler(this.txtTelefonoCliente_Enter);
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            this.txtTelefonoCliente.Leave += new System.EventHandler(this.txtTelefonoCliente_Leave);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaCliente.FlatAppearance.BorderSize = 0;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaCliente.Location = new System.Drawing.Point(348, 174);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(286, 62);
            this.btnAltaCliente.TabIndex = 9;
            this.btnAltaCliente.Text = "Aceptar";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.DtgvCliente);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView DtgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumDocumentoCliente;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoCliente;
        private System.Windows.Forms.TextBox txtObservacionesCliente;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.TextBox txtAlternativoCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}