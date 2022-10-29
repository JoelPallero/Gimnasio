
namespace Presentacion
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
            this.TxtBuscarCliente = new System.Windows.Forms.TextBox();
            this.DtgvCliente = new System.Windows.Forms.DataGridView();
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
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscarCliente.Location = new System.Drawing.Point(486, 265);
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.Size = new System.Drawing.Size(197, 27);
            this.TxtBuscarCliente.TabIndex = 61;
            this.TxtBuscarCliente.Text = "Buscar";
            // 
            // DtgvCliente
            // 
            this.DtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvCliente.Location = new System.Drawing.Point(17, 298);
            this.DtgvCliente.Name = "DtgvCliente";
            this.DtgvCliente.RowHeadersWidth = 51;
            this.DtgvCliente.RowTemplate.Height = 29;
            this.DtgvCliente.Size = new System.Drawing.Size(666, 340);
            this.DtgvCliente.TabIndex = 60;
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 250);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.Location = new System.Drawing.Point(28, 29);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(286, 27);
            this.txtNombreCliente.TabIndex = 70;
            this.txtNombreCliente.Text = "Nombre";
            // 
            // cmbSexo
            // 
            this.cmbSexo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(28, 138);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(286, 28);
            this.cmbSexo.TabIndex = 68;
            this.cmbSexo.Text = "Sexo";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoCliente.Location = new System.Drawing.Point(28, 65);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtApellidoCliente.TabIndex = 69;
            this.txtApellidoCliente.Text = "Apellido";
            this.txtApellidoCliente.Enter += new System.EventHandler(this.txtApellidoCliente_Enter);
            this.txtApellidoCliente.Leave += new System.EventHandler(this.txtApellidoCliente_Leave);
            // 
            // txtNumDocumentoCliente
            // 
            this.txtNumDocumentoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumDocumentoCliente.Location = new System.Drawing.Point(103, 103);
            this.txtNumDocumentoCliente.Name = "txtNumDocumentoCliente";
            this.txtNumDocumentoCliente.Size = new System.Drawing.Size(211, 27);
            this.txtNumDocumentoCliente.TabIndex = 66;
            this.txtNumDocumentoCliente.Text = "N° documento";
            this.txtNumDocumentoCliente.Enter += new System.EventHandler(this.txtNumDocumentoCliente_Enter);
            this.txtNumDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocumentoCliente_KeyPress);
            this.txtNumDocumentoCliente.Leave += new System.EventHandler(this.txtNumDocumentoCliente_Leave);
            // 
            // cmbTipoDocumentoCliente
            // 
            this.cmbTipoDocumentoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoDocumentoCliente.FormattingEnabled = true;
            this.cmbTipoDocumentoCliente.Location = new System.Drawing.Point(28, 102);
            this.cmbTipoDocumentoCliente.Name = "cmbTipoDocumentoCliente";
            this.cmbTipoDocumentoCliente.Size = new System.Drawing.Size(69, 28);
            this.cmbTipoDocumentoCliente.TabIndex = 65;
            this.cmbTipoDocumentoCliente.Text = "Tipo";
            // 
            // txtObservacionesCliente
            // 
            this.txtObservacionesCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacionesCliente.Location = new System.Drawing.Point(348, 65);
            this.txtObservacionesCliente.Multiline = true;
            this.txtObservacionesCliente.Name = "txtObservacionesCliente";
            this.txtObservacionesCliente.Size = new System.Drawing.Size(286, 101);
            this.txtObservacionesCliente.TabIndex = 64;
            this.txtObservacionesCliente.Text = "Observaciones y/o consideraciones";
            this.txtObservacionesCliente.Enter += new System.EventHandler(this.txtAlternativoCliente_Enter);
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtMailCliente.Location = new System.Drawing.Point(348, 29);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(286, 27);
            this.txtMailCliente.TabIndex = 60;
            this.txtMailCliente.Text = "Mail";
            this.txtMailCliente.Enter += new System.EventHandler(this.txtMailCliente_Enter);
            this.txtMailCliente.Leave += new System.EventHandler(this.txtMailCliente_Leave);
            // 
            // txtAlternativoCliente
            // 
            this.txtAlternativoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtAlternativoCliente.Location = new System.Drawing.Point(28, 209);
            this.txtAlternativoCliente.Name = "txtAlternativoCliente";
            this.txtAlternativoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtAlternativoCliente.TabIndex = 59;
            this.txtAlternativoCliente.Text = "Alternativo";
            this.txtAlternativoCliente.Enter += new System.EventHandler(this.txtAlternativoCliente_Enter);
            this.txtAlternativoCliente.Leave += new System.EventHandler(this.txtAlternativoCliente_Leave);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(28, 174);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(286, 27);
            this.txtTelefonoCliente.TabIndex = 58;
            this.txtTelefonoCliente.Text = "Teléfono";
            this.txtTelefonoCliente.Enter += new System.EventHandler(this.txtTelefonoCliente_Enter);
            this.txtTelefonoCliente.Leave += new System.EventHandler(this.txtTelefonoCliente_Leave);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAltaCliente.FlatAppearance.BorderSize = 0;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltaCliente.Location = new System.Drawing.Point(348, 173);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(286, 63);
            this.btnAltaCliente.TabIndex = 53;
            this.btnAltaCliente.Text = "Aceptar";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.DtgvCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarCliente;
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
    }
}