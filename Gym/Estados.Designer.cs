
namespace Gym
{
    partial class Estados
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoNumDocumentoPersona = new System.Windows.Forms.Label();
            this.lblEstadoPersona = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnModificarEstado = new System.Windows.Forms.Button();
            this.lblApellidoNombrePersona = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido y Nombre:";
            // 
            // lblTipoNumDocumentoPersona
            // 
            this.lblTipoNumDocumentoPersona.AutoSize = true;
            this.lblTipoNumDocumentoPersona.Location = new System.Drawing.Point(43, 75);
            this.lblTipoNumDocumentoPersona.Name = "lblTipoNumDocumentoPersona";
            this.lblTipoNumDocumentoPersona.Size = new System.Drawing.Size(197, 17);
            this.lblTipoNumDocumentoPersona.TabIndex = 1;
            this.lblTipoNumDocumentoPersona.Text = "Tipo y Número de Documento";
            // 
            // lblEstadoPersona
            // 
            this.lblEstadoPersona.AutoSize = true;
            this.lblEstadoPersona.Location = new System.Drawing.Point(43, 115);
            this.lblEstadoPersona.Name = "lblEstadoPersona";
            this.lblEstadoPersona.Size = new System.Drawing.Size(52, 17);
            this.lblEstadoPersona.TabIndex = 2;
            this.lblEstadoPersona.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // btnModificarEstado
            // 
            this.btnModificarEstado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificarEstado.FlatAppearance.BorderSize = 0;
            this.btnModificarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarEstado.Location = new System.Drawing.Point(310, 213);
            this.btnModificarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarEstado.Name = "btnModificarEstado";
            this.btnModificarEstado.Size = new System.Drawing.Size(164, 43);
            this.btnModificarEstado.TabIndex = 29;
            this.btnModificarEstado.Text = "Modificar";
            this.btnModificarEstado.UseVisualStyleBackColor = false;
            // 
            // lblApellidoNombrePersona
            // 
            this.lblApellidoNombrePersona.AutoSize = true;
            this.lblApellidoNombrePersona.Location = new System.Drawing.Point(277, 37);
            this.lblApellidoNombrePersona.Name = "lblApellidoNombrePersona";
            this.lblApellidoNombrePersona.Size = new System.Drawing.Size(0, 17);
            this.lblApellidoNombrePersona.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 34);
            this.label4.TabIndex = 33;
            this.label4.Text = "Seleccione el nuevo estado de la persona \r\ny luego presione el botón";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblApellidoNombrePersona);
            this.Controls.Add(this.btnModificarEstado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEstadoPersona);
            this.Controls.Add(this.lblTipoNumDocumentoPersona);
            this.Controls.Add(this.label1);
            this.Name = "Estados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar estado de la persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoNumDocumentoPersona;
        private System.Windows.Forms.Label lblEstadoPersona;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnModificarEstado;
        private System.Windows.Forms.Label lblApellidoNombrePersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}