
namespace Gym
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuboxMain = new System.Windows.Forms.PictureBox();
            this.titleboxMain = new System.Windows.Forms.PictureBox();
            this.windowboxMain = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.focoRegistro = new System.Windows.Forms.Label();
            this.focoCaja = new System.Windows.Forms.Label();
            this.focoPagos = new System.Windows.Forms.Label();
            this.focoPlanes = new System.Windows.Forms.Label();
            this.focoAsistencia = new System.Windows.Forms.Label();
            this.focoEmpleados = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuboxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleboxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowboxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuboxMain
            // 
            this.menuboxMain.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuboxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuboxMain.Location = new System.Drawing.Point(0, 0);
            this.menuboxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuboxMain.Name = "menuboxMain";
            this.menuboxMain.Size = new System.Drawing.Size(250, 700);
            this.menuboxMain.TabIndex = 0;
            this.menuboxMain.TabStop = false;
            this.menuboxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleboxMain_MouseDown);
            // 
            // titleboxMain
            // 
            this.titleboxMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleboxMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleboxMain.Location = new System.Drawing.Point(250, 0);
            this.titleboxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleboxMain.Name = "titleboxMain";
            this.titleboxMain.Size = new System.Drawing.Size(700, 50);
            this.titleboxMain.TabIndex = 1;
            this.titleboxMain.TabStop = false;
            this.titleboxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleboxMain_MouseDown);
            // 
            // windowboxMain
            // 
            this.windowboxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowboxMain.Location = new System.Drawing.Point(250, 50);
            this.windowboxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowboxMain.Name = "windowboxMain";
            this.windowboxMain.Size = new System.Drawing.Size(700, 650);
            this.windowboxMain.TabIndex = 16;
            this.windowboxMain.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 645);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 55);
            this.btnLogout.TabIndex = 47;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Location = new System.Drawing.Point(5, 200);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(245, 50);
            this.btnCaja.TabIndex = 46;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.BtnCaja_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPlanes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnPlanes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.Location = new System.Drawing.Point(5, 376);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(245, 50);
            this.btnPlanes.TabIndex = 45;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.BtnPlanes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPagos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(5, 317);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(245, 50);
            this.btnPagos.TabIndex = 44;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.BtnPagos_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(5, 435);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(245, 50);
            this.btnRegistro.TabIndex = 43;
            this.btnRegistro.Text = "Clientes";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(5, 258);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(245, 50);
            this.btnAsistencia.TabIndex = 42;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(5, 493);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(245, 50);
            this.btnEmpleados.TabIndex = 51;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 140);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 52;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleboxMain_MouseDown);
            // 
            // focoRegistro
            // 
            this.focoRegistro.AutoSize = true;
            this.focoRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoRegistro.Location = new System.Drawing.Point(0, 435);
            this.focoRegistro.MinimumSize = new System.Drawing.Size(5, 50);
            this.focoRegistro.Name = "focoRegistro";
            this.focoRegistro.Size = new System.Drawing.Size(5, 50);
            this.focoRegistro.TabIndex = 54;
            this.focoRegistro.Visible = false;
            // 
            // focoCaja
            // 
            this.focoCaja.AutoSize = true;
            this.focoCaja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoCaja.Location = new System.Drawing.Point(0, 200);
            this.focoCaja.MinimumSize = new System.Drawing.Size(5, 50);
            this.focoCaja.Name = "focoCaja";
            this.focoCaja.Size = new System.Drawing.Size(5, 50);
            this.focoCaja.TabIndex = 57;
            this.focoCaja.Visible = false;
            // 
            // focoPagos
            // 
            this.focoPagos.AutoSize = true;
            this.focoPagos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoPagos.Location = new System.Drawing.Point(0, 317);
            this.focoPagos.MinimumSize = new System.Drawing.Size(5, 50);
            this.focoPagos.Name = "focoPagos";
            this.focoPagos.Size = new System.Drawing.Size(5, 50);
            this.focoPagos.TabIndex = 55;
            this.focoPagos.Visible = false;
            // 
            // focoPlanes
            // 
            this.focoPlanes.AutoSize = true;
            this.focoPlanes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoPlanes.Location = new System.Drawing.Point(0, 376);
            this.focoPlanes.MinimumSize = new System.Drawing.Size(5, 50);
            this.focoPlanes.Name = "focoPlanes";
            this.focoPlanes.Size = new System.Drawing.Size(5, 50);
            this.focoPlanes.TabIndex = 56;
            this.focoPlanes.Visible = false;
            // 
            // focoAsistencia
            // 
            this.focoAsistencia.AutoSize = true;
            this.focoAsistencia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoAsistencia.Location = new System.Drawing.Point(0, 258);
            this.focoAsistencia.MinimumSize = new System.Drawing.Size(5, 50);
            this.focoAsistencia.Name = "focoAsistencia";
            this.focoAsistencia.Size = new System.Drawing.Size(5, 50);
            this.focoAsistencia.TabIndex = 53;
            this.focoAsistencia.Visible = false;
            // 
            // focoEmpleados
            // 
            this.focoEmpleados.AutoSize = true;
            this.focoEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.focoEmpleados.Location = new System.Drawing.Point(0, 493);
            this.focoEmpleados.MinimumSize = new System.Drawing.Size(5, 50);
            this.focoEmpleados.Name = "focoEmpleados";
            this.focoEmpleados.Size = new System.Drawing.Size(5, 50);
            this.focoEmpleados.TabIndex = 58;
            this.focoEmpleados.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(844, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 60;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(900, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.BackgroundImage")));
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(200, 650);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(50, 50);
            this.btnConfiguracion.TabIndex = 61;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenido.Location = new System.Drawing.Point(266, 14);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(0, 23);
            this.lblBienvenido.TabIndex = 62;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.focoEmpleados);
            this.Controls.Add(this.focoCaja);
            this.Controls.Add(this.focoPlanes);
            this.Controls.Add(this.focoPagos);
            this.Controls.Add(this.focoRegistro);
            this.Controls.Add(this.focoAsistencia);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.windowboxMain);
            this.Controls.Add(this.titleboxMain);
            this.Controls.Add(this.menuboxMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainJefe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuboxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleboxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowboxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox menuboxMain;
        private System.Windows.Forms.PictureBox titleboxMain;
        private System.Windows.Forms.PictureBox windowboxMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label focoRegistro;
        private System.Windows.Forms.Label focoCaja;
        private System.Windows.Forms.Label focoPagos;
        private System.Windows.Forms.Label focoPlanes;
        private System.Windows.Forms.Label focoAsistencia;
        private System.Windows.Forms.Label focoEmpleados;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label lblBienvenido;
    }
}