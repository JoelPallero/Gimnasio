
namespace Presentacion
{
    partial class Asistencia
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
            this.TxtDatoClienteAsistencia = new System.Windows.Forms.TextBox();
            this.GbClienteAsistencia = new System.Windows.Forms.GroupBox();
            this.BtnAltaAsistencia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtgvClienteAsistencia = new System.Windows.Forms.DataGridView();
            this.TxtBuscarClienteAsistencia = new System.Windows.Forms.TextBox();
            this.GbClienteAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvClienteAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDatoClienteAsistencia
            // 
            this.TxtDatoClienteAsistencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDatoClienteAsistencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDatoClienteAsistencia.Location = new System.Drawing.Point(12, 32);
            this.TxtDatoClienteAsistencia.Name = "TxtDatoClienteAsistencia";
            this.TxtDatoClienteAsistencia.Size = new System.Drawing.Size(396, 27);
            this.TxtDatoClienteAsistencia.TabIndex = 0;
            this.TxtDatoClienteAsistencia.Text = "Nombre o DNI";
            // 
            // GbClienteAsistencia
            // 
            this.GbClienteAsistencia.Controls.Add(this.label4);
            this.GbClienteAsistencia.Controls.Add(this.label8);
            this.GbClienteAsistencia.Controls.Add(this.label7);
            this.GbClienteAsistencia.Controls.Add(this.label6);
            this.GbClienteAsistencia.Controls.Add(this.label5);
            this.GbClienteAsistencia.Controls.Add(this.label3);
            this.GbClienteAsistencia.Location = new System.Drawing.Point(12, 65);
            this.GbClienteAsistencia.Name = "GbClienteAsistencia";
            this.GbClienteAsistencia.Size = new System.Drawing.Size(676, 145);
            this.GbClienteAsistencia.TabIndex = 3;
            this.GbClienteAsistencia.TabStop = false;
            this.GbClienteAsistencia.Text = "Datos Personales";
            // 
            // BtnAltaAsistencia
            // 
            this.BtnAltaAsistencia.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAltaAsistencia.FlatAppearance.BorderSize = 0;
            this.BtnAltaAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltaAsistencia.Location = new System.Drawing.Point(515, 216);
            this.BtnAltaAsistencia.Name = "BtnAltaAsistencia";
            this.BtnAltaAsistencia.Size = new System.Drawing.Size(173, 40);
            this.BtnAltaAsistencia.TabIndex = 7;
            this.BtnAltaAsistencia.Text = "Confirmar Asistencia";
            this.BtnAltaAsistencia.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado de cuotas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alternativo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // DtgvClienteAsistencia
            // 
            this.DtgvClienteAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvClienteAsistencia.Location = new System.Drawing.Point(12, 312);
            this.DtgvClienteAsistencia.Name = "DtgvClienteAsistencia";
            this.DtgvClienteAsistencia.RowHeadersWidth = 51;
            this.DtgvClienteAsistencia.RowTemplate.Height = 29;
            this.DtgvClienteAsistencia.Size = new System.Drawing.Size(676, 326);
            this.DtgvClienteAsistencia.TabIndex = 4;
            // 
            // TxtBuscarClienteAsistencia
            // 
            this.TxtBuscarClienteAsistencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscarClienteAsistencia.Location = new System.Drawing.Point(12, 279);
            this.TxtBuscarClienteAsistencia.Name = "TxtBuscarClienteAsistencia";
            this.TxtBuscarClienteAsistencia.Size = new System.Drawing.Size(296, 27);
            this.TxtBuscarClienteAsistencia.TabIndex = 6;
            this.TxtBuscarClienteAsistencia.Text = "Buscar";
            // 
            // asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.BtnAltaAsistencia);
            this.Controls.Add(this.TxtBuscarClienteAsistencia);
            this.Controls.Add(this.DtgvClienteAsistencia);
            this.Controls.Add(this.GbClienteAsistencia);
            this.Controls.Add(this.TxtDatoClienteAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "asistencia";
            this.Text = "asistencia";
            this.GbClienteAsistencia.ResumeLayout(false);
            this.GbClienteAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvClienteAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDatoClienteAsistencia;
        private System.Windows.Forms.GroupBox GbClienteAsistencia;
        private System.Windows.Forms.DataGridView DtgvClienteAsistencia;
        private System.Windows.Forms.TextBox TxtBuscarClienteAsistencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAltaAsistencia;
    }
}