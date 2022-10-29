
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
            this.TbCobroCliente = new System.Windows.Forms.TabControl();
            this.TbIngreso = new System.Windows.Forms.TabPage();
            this.TxtDatosClienteSaldos = new System.Windows.Forms.TextBox();
            this.DtgvDetalleFacturación = new System.Windows.Forms.DataGridView();
            this.GbImporteACobrar = new System.Windows.Forms.GroupBox();
            this.TxtImporte = new System.Windows.Forms.TextBox();
            this.CmbImporteAPagar = new System.Windows.Forms.ComboBox();
            this.BtnRegistrarCobro = new System.Windows.Forms.Button();
            this.GbDatosClienteSaldos = new System.Windows.Forms.GroupBox();
            this.LblimporteFacturadoTotal = new System.Windows.Forms.Label();
            this.LblSaldoCliente = new System.Windows.Forms.Label();
            this.LblTelefonoCliente = new System.Windows.Forms.Label();
            this.LblCuotasAdeudadasCliente = new System.Windows.Forms.Label();
            this.LblMailCliente = new System.Windows.Forms.Label();
            this.LblPlanCliente = new System.Windows.Forms.Label();
            this.LblDniCliente = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.TbEgreso = new System.Windows.Forms.TabPage();
            this.TxtBuscarPagosRealizados = new System.Windows.Forms.TextBox();
            this.GbImportesAPagar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnRegistrarPagoPagar = new System.Windows.Forms.Button();
            this.DtgvPagosRealizados = new System.Windows.Forms.DataGridView();
            this.TbCobroCliente.SuspendLayout();
            this.TbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDetalleFacturación)).BeginInit();
            this.GbImporteACobrar.SuspendLayout();
            this.GbDatosClienteSaldos.SuspendLayout();
            this.TbEgreso.SuspendLayout();
            this.GbImportesAPagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvPagosRealizados)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCobroCliente
            // 
            this.TbCobroCliente.Controls.Add(this.TbIngreso);
            this.TbCobroCliente.Controls.Add(this.TbEgreso);
            this.TbCobroCliente.Location = new System.Drawing.Point(0, 0);
            this.TbCobroCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbCobroCliente.Name = "TbCobroCliente";
            this.TbCobroCliente.SelectedIndex = 0;
            this.TbCobroCliente.Size = new System.Drawing.Size(700, 650);
            this.TbCobroCliente.TabIndex = 0;
            // 
            // TbIngreso
            // 
            this.TbIngreso.Controls.Add(this.TxtDatosClienteSaldos);
            this.TbIngreso.Controls.Add(this.DtgvDetalleFacturación);
            this.TbIngreso.Controls.Add(this.GbImporteACobrar);
            this.TbIngreso.Controls.Add(this.GbDatosClienteSaldos);
            this.TbIngreso.Location = new System.Drawing.Point(4, 29);
            this.TbIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbIngreso.Name = "TbIngreso";
            this.TbIngreso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbIngreso.Size = new System.Drawing.Size(692, 617);
            this.TbIngreso.TabIndex = 0;
            this.TbIngreso.Text = "Ingreso";
            this.TbIngreso.UseVisualStyleBackColor = true;
            // 
            // TxtDatosClienteSaldos
            // 
            this.TxtDatosClienteSaldos.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDatosClienteSaldos.Location = new System.Drawing.Point(376, 10);
            this.TxtDatosClienteSaldos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDatosClienteSaldos.Name = "TxtDatosClienteSaldos";
            this.TxtDatosClienteSaldos.Size = new System.Drawing.Size(308, 27);
            this.TxtDatosClienteSaldos.TabIndex = 7;
            this.TxtDatosClienteSaldos.Text = "Nombre o dni";
            // 
            // DtgvDetalleFacturación
            // 
            this.DtgvDetalleFacturación.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDetalleFacturación.Location = new System.Drawing.Point(8, 349);
            this.DtgvDetalleFacturación.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgvDetalleFacturación.Name = "DtgvDetalleFacturación";
            this.DtgvDetalleFacturación.RowHeadersWidth = 51;
            this.DtgvDetalleFacturación.RowTemplate.Height = 29;
            this.DtgvDetalleFacturación.Size = new System.Drawing.Size(676, 260);
            this.DtgvDetalleFacturación.TabIndex = 10;
            // 
            // GbImporteACobrar
            // 
            this.GbImporteACobrar.Controls.Add(this.TxtImporte);
            this.GbImporteACobrar.Controls.Add(this.CmbImporteAPagar);
            this.GbImporteACobrar.Controls.Add(this.BtnRegistrarCobro);
            this.GbImporteACobrar.Location = new System.Drawing.Point(8, 218);
            this.GbImporteACobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImporteACobrar.Name = "GbImporteACobrar";
            this.GbImporteACobrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImporteACobrar.Size = new System.Drawing.Size(676, 125);
            this.GbImporteACobrar.TabIndex = 9;
            this.GbImporteACobrar.TabStop = false;
            this.GbImporteACobrar.Text = "Importes a cobrar";
            // 
            // TxtImporte
            // 
            this.TxtImporte.Enabled = false;
            this.TxtImporte.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtImporte.Location = new System.Drawing.Point(70, 72);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(233, 27);
            this.TxtImporte.TabIndex = 56;
            this.TxtImporte.Text = " Importe $$";
            // 
            // CmbImporteAPagar
            // 
            this.CmbImporteAPagar.FormattingEnabled = true;
            this.CmbImporteAPagar.Items.AddRange(new object[] {
            "Total",
            "Saldo",
            "Otro importe"});
            this.CmbImporteAPagar.Location = new System.Drawing.Point(68, 26);
            this.CmbImporteAPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbImporteAPagar.Name = "CmbImporteAPagar";
            this.CmbImporteAPagar.Size = new System.Drawing.Size(235, 28);
            this.CmbImporteAPagar.TabIndex = 55;
            // 
            // BtnRegistrarCobro
            // 
            this.BtnRegistrarCobro.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRegistrarCobro.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarCobro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrarCobro.Location = new System.Drawing.Point(410, 21);
            this.BtnRegistrarCobro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarCobro.Name = "BtnRegistrarCobro";
            this.BtnRegistrarCobro.Size = new System.Drawing.Size(153, 92);
            this.BtnRegistrarCobro.TabIndex = 54;
            this.BtnRegistrarCobro.Text = "Aceptar";
            this.BtnRegistrarCobro.UseVisualStyleBackColor = false;
            // 
            // GbDatosClienteSaldos
            // 
            this.GbDatosClienteSaldos.Controls.Add(this.LblimporteFacturadoTotal);
            this.GbDatosClienteSaldos.Controls.Add(this.LblSaldoCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.LblTelefonoCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.LblCuotasAdeudadasCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.LblMailCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.LblPlanCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.LblDniCliente);
            this.GbDatosClienteSaldos.Controls.Add(this.LblNombreCliente);
            this.GbDatosClienteSaldos.Location = new System.Drawing.Point(8, 36);
            this.GbDatosClienteSaldos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbDatosClienteSaldos.Name = "GbDatosClienteSaldos";
            this.GbDatosClienteSaldos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbDatosClienteSaldos.Size = new System.Drawing.Size(676, 176);
            this.GbDatosClienteSaldos.TabIndex = 8;
            this.GbDatosClienteSaldos.TabStop = false;
            this.GbDatosClienteSaldos.Text = "Datos Personales";
            // 
            // LblimporteFacturadoTotal
            // 
            this.LblimporteFacturadoTotal.AutoSize = true;
            this.LblimporteFacturadoTotal.Location = new System.Drawing.Point(360, 142);
            this.LblimporteFacturadoTotal.Name = "LblimporteFacturadoTotal";
            this.LblimporteFacturadoTotal.Size = new System.Drawing.Size(91, 20);
            this.LblimporteFacturadoTotal.TabIndex = 15;
            this.LblimporteFacturadoTotal.Text = "Monto total:";
            // 
            // LblSaldoCliente
            // 
            this.LblSaldoCliente.AutoSize = true;
            this.LblSaldoCliente.Location = new System.Drawing.Point(360, 104);
            this.LblSaldoCliente.Name = "LblSaldoCliente";
            this.LblSaldoCliente.Size = new System.Drawing.Size(50, 20);
            this.LblSaldoCliente.TabIndex = 14;
            this.LblSaldoCliente.Text = "Saldo:";
            // 
            // LblTelefonoCliente
            // 
            this.LblTelefonoCliente.AutoSize = true;
            this.LblTelefonoCliente.Location = new System.Drawing.Point(19, 104);
            this.LblTelefonoCliente.Name = "LblTelefonoCliente";
            this.LblTelefonoCliente.Size = new System.Drawing.Size(70, 20);
            this.LblTelefonoCliente.TabIndex = 13;
            this.LblTelefonoCliente.Text = "Telefono:";
            // 
            // LblCuotasAdeudadasCliente
            // 
            this.LblCuotasAdeudadasCliente.AutoSize = true;
            this.LblCuotasAdeudadasCliente.Location = new System.Drawing.Point(360, 68);
            this.LblCuotasAdeudadasCliente.Name = "LblCuotasAdeudadasCliente";
            this.LblCuotasAdeudadasCliente.Size = new System.Drawing.Size(134, 20);
            this.LblCuotasAdeudadasCliente.TabIndex = 12;
            this.LblCuotasAdeudadasCliente.Text = "Cuotas adeudadas:";
            // 
            // LblMailCliente
            // 
            this.LblMailCliente.AutoSize = true;
            this.LblMailCliente.Location = new System.Drawing.Point(360, 32);
            this.LblMailCliente.Name = "LblMailCliente";
            this.LblMailCliente.Size = new System.Drawing.Size(41, 20);
            this.LblMailCliente.TabIndex = 11;
            this.LblMailCliente.Text = "Mail:";
            // 
            // LblPlanCliente
            // 
            this.LblPlanCliente.AutoSize = true;
            this.LblPlanCliente.Location = new System.Drawing.Point(19, 142);
            this.LblPlanCliente.Name = "LblPlanCliente";
            this.LblPlanCliente.Size = new System.Drawing.Size(40, 20);
            this.LblPlanCliente.TabIndex = 10;
            this.LblPlanCliente.Text = "Plan:";
            // 
            // LblDniCliente
            // 
            this.LblDniCliente.AutoSize = true;
            this.LblDniCliente.Location = new System.Drawing.Point(19, 68);
            this.LblDniCliente.Name = "LblDniCliente";
            this.LblDniCliente.Size = new System.Drawing.Size(38, 20);
            this.LblDniCliente.TabIndex = 9;
            this.LblDniCliente.Text = "DNI:";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(19, 32);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(67, 20);
            this.LblNombreCliente.TabIndex = 7;
            this.LblNombreCliente.Text = "Nombre:";
            // 
            // TbEgreso
            // 
            this.TbEgreso.Controls.Add(this.TxtBuscarPagosRealizados);
            this.TbEgreso.Controls.Add(this.GbImportesAPagar);
            this.TbEgreso.Controls.Add(this.DtgvPagosRealizados);
            this.TbEgreso.Location = new System.Drawing.Point(4, 25);
            this.TbEgreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbEgreso.Name = "TbEgreso";
            this.TbEgreso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbEgreso.Size = new System.Drawing.Size(692, 621);
            this.TbEgreso.TabIndex = 1;
            this.TbEgreso.Text = "Egreso";
            this.TbEgreso.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarPagosRealizados
            // 
            this.TxtBuscarPagosRealizados.Location = new System.Drawing.Point(474, 191);
            this.TxtBuscarPagosRealizados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarPagosRealizados.Name = "TxtBuscarPagosRealizados";
            this.TxtBuscarPagosRealizados.Size = new System.Drawing.Size(210, 27);
            this.TxtBuscarPagosRealizados.TabIndex = 14;
            this.TxtBuscarPagosRealizados.Text = "Buscar";
            // 
            // GbImportesAPagar
            // 
            this.GbImportesAPagar.Controls.Add(this.label2);
            this.GbImportesAPagar.Controls.Add(this.label1);
            this.GbImportesAPagar.Controls.Add(this.textBox2);
            this.GbImportesAPagar.Controls.Add(this.textBox1);
            this.GbImportesAPagar.Controls.Add(this.BtnRegistrarPagoPagar);
            this.GbImportesAPagar.Location = new System.Drawing.Point(8, 22);
            this.GbImportesAPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImportesAPagar.Name = "GbImportesAPagar";
            this.GbImportesAPagar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbImportesAPagar.Size = new System.Drawing.Size(676, 149);
            this.GbImportesAPagar.TabIndex = 13;
            this.GbImportesAPagar.TabStop = false;
            this.GbImportesAPagar.Text = "Importes a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Concepto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Importe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(425, 27);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 27);
            this.textBox1.TabIndex = 0;
            // 
            // BtnRegistrarPagoPagar
            // 
            this.BtnRegistrarPagoPagar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRegistrarPagoPagar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarPagoPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarPagoPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrarPagoPagar.Location = new System.Drawing.Point(488, 85);
            this.BtnRegistrarPagoPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarPagoPagar.Name = "BtnRegistrarPagoPagar";
            this.BtnRegistrarPagoPagar.Size = new System.Drawing.Size(173, 50);
            this.BtnRegistrarPagoPagar.TabIndex = 12;
            this.BtnRegistrarPagoPagar.Text = "Aceptar";
            this.BtnRegistrarPagoPagar.UseVisualStyleBackColor = false;
            // 
            // DtgvPagosRealizados
            // 
            this.DtgvPagosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvPagosRealizados.Location = new System.Drawing.Point(8, 224);
            this.DtgvPagosRealizados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgvPagosRealizados.Name = "DtgvPagosRealizados";
            this.DtgvPagosRealizados.RowHeadersWidth = 51;
            this.DtgvPagosRealizados.RowTemplate.Height = 29;
            this.DtgvPagosRealizados.Size = new System.Drawing.Size(676, 385);
            this.DtgvPagosRealizados.TabIndex = 11;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.TbCobroCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pagos";
            this.Text = "pagos";
            this.TbCobroCliente.ResumeLayout(false);
            this.TbIngreso.ResumeLayout(false);
            this.TbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDetalleFacturación)).EndInit();
            this.GbImporteACobrar.ResumeLayout(false);
            this.GbImporteACobrar.PerformLayout();
            this.GbDatosClienteSaldos.ResumeLayout(false);
            this.GbDatosClienteSaldos.PerformLayout();
            this.TbEgreso.ResumeLayout(false);
            this.TbEgreso.PerformLayout();
            this.GbImportesAPagar.ResumeLayout(false);
            this.GbImportesAPagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvPagosRealizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbCobroCliente;
        private System.Windows.Forms.TabPage TbIngreso;
        private System.Windows.Forms.TextBox TxtDatosClienteSaldos;
        private System.Windows.Forms.DataGridView DtgvDetalleFacturación;
        private System.Windows.Forms.GroupBox GbImporteACobrar;
        private System.Windows.Forms.ComboBox CmbImporteAPagar;
        private System.Windows.Forms.Button BtnRegistrarCobro;
        private System.Windows.Forms.GroupBox GbDatosClienteSaldos;
        private System.Windows.Forms.Label LblimporteFacturadoTotal;
        private System.Windows.Forms.Label LblSaldoCliente;
        private System.Windows.Forms.Label LblTelefonoCliente;
        private System.Windows.Forms.Label LblCuotasAdeudadasCliente;
        private System.Windows.Forms.Label LblMailCliente;
        private System.Windows.Forms.Label LblPlanCliente;
        private System.Windows.Forms.Label LblDniCliente;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.TabPage TbEgreso;
        private System.Windows.Forms.TextBox TxtImporte;
        private System.Windows.Forms.DataGridView DtgvPagosRealizados;
        private System.Windows.Forms.GroupBox GbImportesAPagar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnRegistrarPagoPagar;
        private System.Windows.Forms.TextBox TxtBuscarPagosRealizados;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}