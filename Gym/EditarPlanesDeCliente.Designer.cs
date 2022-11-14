
namespace Gym
{
    partial class EditarPlanesDeCliente
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
            this.btnEliminarPlanes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminarPlanes
            // 
            this.btnEliminarPlanes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarPlanes.FlatAppearance.BorderSize = 0;
            this.btnEliminarPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlanes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlanes.Location = new System.Drawing.Point(25, 154);
            this.btnEliminarPlanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPlanes.Name = "btnEliminarPlanes";
            this.btnEliminarPlanes.Size = new System.Drawing.Size(147, 30);
            this.btnEliminarPlanes.TabIndex = 26;
            this.btnEliminarPlanes.Text = "Eliminar planes";
            this.btnEliminarPlanes.UseVisualStyleBackColor = false;
            this.btnEliminarPlanes.Click += new System.EventHandler(this.btnEliminarPlanes_Click);
            // 
            // EditarPlanesDeCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(203, 205);
            this.Controls.Add(this.btnEliminarPlanes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarPlanesDeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Planes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPlanes;
    }
}