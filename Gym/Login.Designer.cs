
namespace Gym
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGenerarPrimerUsuario = new System.Windows.Forms.LinkLabel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(36, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Usuario";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(36, 244);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 34);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Clave";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(125, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidé mi contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblGenerarPrimerUsuario
            // 
            this.lblGenerarPrimerUsuario.AutoSize = true;
            this.lblGenerarPrimerUsuario.Location = new System.Drawing.Point(76, 292);
            this.lblGenerarPrimerUsuario.Name = "lblGenerarPrimerUsuario";
            this.lblGenerarPrimerUsuario.Size = new System.Drawing.Size(246, 20);
            this.lblGenerarPrimerUsuario.TabIndex = 6;
            this.lblGenerarPrimerUsuario.TabStop = true;
            this.lblGenerarPrimerUsuario.Text = "Generar contraseña por primera vez";
            this.lblGenerarPrimerUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGenerarPrimerUsuario_LinkClicked);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(336, -1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 62;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(369, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 61;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGenerarPrimerUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblGenerarPrimerUsuario;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}