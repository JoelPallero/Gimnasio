
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
            this.TxtApellidoCliente = new System.Windows.Forms.TextBox();
            this.TxtNumDocumentoCliente = new System.Windows.Forms.TextBox();
            this.CmbTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.TxtObservacionesCliente = new System.Windows.Forms.TextBox();
            this.CmbPlanCliente = new System.Windows.Forms.ComboBox();
            this.TxtMailCliente = new System.Windows.Forms.TextBox();
            this.TxtAlternativoCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.BtnAltaCliente = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.TxtApellidoCliente);
            this.groupBox1.Controls.Add(this.TxtNumDocumentoCliente);
            this.groupBox1.Controls.Add(this.CmbTipoDocumentoCliente);
            this.groupBox1.Controls.Add(this.TxtObservacionesCliente);
            this.groupBox1.Controls.Add(this.CmbPlanCliente);
            this.groupBox1.Controls.Add(this.TxtMailCliente);
            this.groupBox1.Controls.Add(this.TxtAlternativoCliente);
            this.groupBox1.Controls.Add(this.TxtTelefonoCliente);
            this.groupBox1.Controls.Add(this.TxtNombreCliente);
            this.groupBox1.Controls.Add(this.BtnAltaCliente);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 225);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // TxtApellidoCliente
            // 
            this.TxtApellidoCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtApellidoCliente.Location = new System.Drawing.Point(28, 73);
            this.TxtApellidoCliente.Name = "TxtApellidoCliente";
            this.TxtApellidoCliente.Size = new System.Drawing.Size(286, 27);
            this.TxtApellidoCliente.TabIndex = 67;
            this.TxtApellidoCliente.Text = "Apellido";
            // 
            // TxtNumDocumentoCliente
            // 
            this.TxtNumDocumentoCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNumDocumentoCliente.Location = new System.Drawing.Point(103, 111);
            this.TxtNumDocumentoCliente.Name = "TxtNumDocumentoCliente";
            this.TxtNumDocumentoCliente.Size = new System.Drawing.Size(211, 27);
            this.TxtNumDocumentoCliente.TabIndex = 66;
            this.TxtNumDocumentoCliente.Text = "N° documento";
            // 
            // CmbTipoDocumentoCliente
            // 
            this.CmbTipoDocumentoCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbTipoDocumentoCliente.FormattingEnabled = true;
            this.CmbTipoDocumentoCliente.Location = new System.Drawing.Point(28, 110);
            this.CmbTipoDocumentoCliente.Name = "CmbTipoDocumentoCliente";
            this.CmbTipoDocumentoCliente.Size = new System.Drawing.Size(69, 28);
            this.CmbTipoDocumentoCliente.TabIndex = 65;
            this.CmbTipoDocumentoCliente.Text = "Tipo";
            // 
            // TxtObservacionesCliente
            // 
            this.TxtObservacionesCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtObservacionesCliente.Location = new System.Drawing.Point(348, 111);
            this.TxtObservacionesCliente.Multiline = true;
            this.TxtObservacionesCliente.Name = "TxtObservacionesCliente";
            this.TxtObservacionesCliente.Size = new System.Drawing.Size(286, 29);
            this.TxtObservacionesCliente.TabIndex = 64;
            this.TxtObservacionesCliente.Text = "Observaciones y/o consideraciones";
            // 
            // CmbPlanCliente
            // 
            this.CmbPlanCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbPlanCliente.FormattingEnabled = true;
            this.CmbPlanCliente.Location = new System.Drawing.Point(348, 73);
            this.CmbPlanCliente.Name = "CmbPlanCliente";
            this.CmbPlanCliente.Size = new System.Drawing.Size(286, 28);
            this.CmbPlanCliente.TabIndex = 61;
            this.CmbPlanCliente.Text = "Seleccionar Plan";
            // 
            // TxtMailCliente
            // 
            this.TxtMailCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtMailCliente.Location = new System.Drawing.Point(348, 37);
            this.TxtMailCliente.Name = "TxtMailCliente";
            this.TxtMailCliente.Size = new System.Drawing.Size(286, 27);
            this.TxtMailCliente.TabIndex = 60;
            this.TxtMailCliente.Text = "Mail";
            // 
            // TxtAlternativoCliente
            // 
            this.TxtAlternativoCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtAlternativoCliente.Location = new System.Drawing.Point(28, 182);
            this.TxtAlternativoCliente.Name = "TxtAlternativoCliente";
            this.TxtAlternativoCliente.Size = new System.Drawing.Size(286, 27);
            this.TxtAlternativoCliente.TabIndex = 59;
            this.TxtAlternativoCliente.Text = "Alternativo";
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(28, 147);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(286, 27);
            this.TxtTelefonoCliente.TabIndex = 58;
            this.TxtTelefonoCliente.Text = "Teléfono";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNombreCliente.Location = new System.Drawing.Point(28, 37);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(286, 27);
            this.TxtNombreCliente.TabIndex = 56;
            this.TxtNombreCliente.Text = "Nombre y Apellido";
            // 
            // BtnAltaCliente
            // 
            this.BtnAltaCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAltaCliente.FlatAppearance.BorderSize = 0;
            this.BtnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltaCliente.Location = new System.Drawing.Point(348, 146);
            this.BtnAltaCliente.Name = "BtnAltaCliente";
            this.BtnAltaCliente.Size = new System.Drawing.Size(286, 63);
            this.BtnAltaCliente.TabIndex = 53;
            this.BtnAltaCliente.Text = "Aceptar";
            this.BtnAltaCliente.UseVisualStyleBackColor = false;
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
            this.Text = "registro";
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
        private System.Windows.Forms.TextBox TxtNumDocumentoCliente;
        private System.Windows.Forms.ComboBox CmbTipoDocumentoCliente;
        private System.Windows.Forms.TextBox TxtObservacionesCliente;
        private System.Windows.Forms.ComboBox CmbPlanCliente;
        private System.Windows.Forms.TextBox TxtMailCliente;
        private System.Windows.Forms.TextBox TxtAlternativoCliente;
        private System.Windows.Forms.TextBox TxtTelefonoCliente;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Button BtnAltaCliente;
        private System.Windows.Forms.TextBox TxtApellidoCliente;
    }
}