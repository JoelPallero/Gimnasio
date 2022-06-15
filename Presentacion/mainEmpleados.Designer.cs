
namespace Presentacion
{
    partial class mainEmpleados
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
            this.windowbox = new System.Windows.Forms.PictureBox();
            this.titlebox = new System.Windows.Forms.PictureBox();
            this.menubox = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.focoAsistencia = new System.Windows.Forms.Label();
            this.focoRegistro = new System.Windows.Forms.Label();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.focoPagos = new System.Windows.Forms.Label();
            this.focoPlanes = new System.Windows.Forms.Label();
            this.focoCaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.windowbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menubox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // windowbox
            // 
            this.windowbox.BackColor = System.Drawing.Color.Transparent;
            this.windowbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowbox.Location = new System.Drawing.Point(250, 50);
            this.windowbox.Name = "windowbox";
            this.windowbox.Size = new System.Drawing.Size(700, 650);
            this.windowbox.TabIndex = 19;
            this.windowbox.TabStop = false;
            // 
            // titlebox
            // 
            this.titlebox.BackColor = System.Drawing.Color.DodgerBlue;
            this.titlebox.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebox.Location = new System.Drawing.Point(250, 0);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(700, 50);
            this.titlebox.TabIndex = 18;
            this.titlebox.TabStop = false;
            this.titlebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebox_MouseDown);
            // 
            // menubox
            // 
            this.menubox.BackColor = System.Drawing.SystemColors.Highlight;
            this.menubox.Dock = System.Windows.Forms.DockStyle.Left;
            this.menubox.Location = new System.Drawing.Point(0, 0);
            this.menubox.Name = "menubox";
            this.menubox.Size = new System.Drawing.Size(250, 700);
            this.menubox.TabIndex = 17;
            this.menubox.TabStop = false;
            this.menubox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebox_MouseDown);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Location = new System.Drawing.Point(15, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(220, 76);
            this.logo.TabIndex = 30;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Empleados";
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(5, 190);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(245, 55);
            this.btnAsistencia.TabIndex = 0;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(5, 262);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(245, 55);
            this.btnRegistro.TabIndex = 35;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPagos.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(5, 334);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(245, 55);
            this.btnPagos.TabIndex = 36;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCaja.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Location = new System.Drawing.Point(5, 478);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(245, 55);
            this.btnCaja.TabIndex = 38;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 645);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 55);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclose.ForeColor = System.Drawing.Color.Maroon;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(900, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 50);
            this.btnclose.TabIndex = 40;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnminimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnminimize.ForeColor = System.Drawing.Color.Maroon;
            this.btnminimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnminimize.Location = new System.Drawing.Point(844, 0);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(50, 50);
            this.btnminimize.TabIndex = 41;
            this.btnminimize.Text = "--";
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // focoAsistencia
            // 
            this.focoAsistencia.AutoSize = true;
            this.focoAsistencia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoAsistencia.Location = new System.Drawing.Point(0, 190);
            this.focoAsistencia.MinimumSize = new System.Drawing.Size(5, 55);
            this.focoAsistencia.Name = "focoAsistencia";
            this.focoAsistencia.Size = new System.Drawing.Size(5, 55);
            this.focoAsistencia.TabIndex = 47;
            this.focoAsistencia.Visible = false;
            // 
            // focoRegistro
            // 
            this.focoRegistro.AutoSize = true;
            this.focoRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoRegistro.Location = new System.Drawing.Point(0, 262);
            this.focoRegistro.MinimumSize = new System.Drawing.Size(5, 55);
            this.focoRegistro.Name = "focoRegistro";
            this.focoRegistro.Size = new System.Drawing.Size(5, 55);
            this.focoRegistro.TabIndex = 48;
            this.focoRegistro.Visible = false;
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPlanes.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlanes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.Location = new System.Drawing.Point(5, 406);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(245, 55);
            this.btnPlanes.TabIndex = 37;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // focoPagos
            // 
            this.focoPagos.AutoSize = true;
            this.focoPagos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoPagos.Location = new System.Drawing.Point(0, 334);
            this.focoPagos.MinimumSize = new System.Drawing.Size(5, 55);
            this.focoPagos.Name = "focoPagos";
            this.focoPagos.Size = new System.Drawing.Size(5, 55);
            this.focoPagos.TabIndex = 49;
            this.focoPagos.Visible = false;
            // 
            // focoPlanes
            // 
            this.focoPlanes.AutoSize = true;
            this.focoPlanes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoPlanes.Location = new System.Drawing.Point(0, 406);
            this.focoPlanes.MinimumSize = new System.Drawing.Size(5, 55);
            this.focoPlanes.Name = "focoPlanes";
            this.focoPlanes.Size = new System.Drawing.Size(5, 55);
            this.focoPlanes.TabIndex = 50;
            this.focoPlanes.Visible = false;
            // 
            // focoCaja
            // 
            this.focoCaja.AutoSize = true;
            this.focoCaja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoCaja.Location = new System.Drawing.Point(0, 478);
            this.focoCaja.MinimumSize = new System.Drawing.Size(5, 55);
            this.focoCaja.Name = "focoCaja";
            this.focoCaja.Size = new System.Drawing.Size(5, 55);
            this.focoCaja.TabIndex = 51;
            this.focoCaja.Visible = false;
            // 
            // mainEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.focoCaja);
            this.Controls.Add(this.focoPlanes);
            this.Controls.Add(this.focoPagos);
            this.Controls.Add(this.focoRegistro);
            this.Controls.Add(this.focoAsistencia);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.windowbox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.menubox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.windowbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menubox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox windowbox;
        private System.Windows.Forms.PictureBox titlebox;
        private System.Windows.Forms.PictureBox menubox;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Label focoAsistencia;
        private System.Windows.Forms.Label focoRegistro;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Label focoPagos;
        private System.Windows.Forms.Label focoPlanes;
        private System.Windows.Forms.Label focoCaja;
    }
}