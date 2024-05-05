
namespace Primer_Parcial
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarPersonajes = new System.Windows.Forms.Button();
            this.rtbPersonajes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMostrarPersonajes
            // 
            this.btnMostrarPersonajes.Location = new System.Drawing.Point(228, 47);
            this.btnMostrarPersonajes.Name = "btnMostrarPersonajes";
            this.btnMostrarPersonajes.Size = new System.Drawing.Size(173, 31);
            this.btnMostrarPersonajes.TabIndex = 0;
            this.btnMostrarPersonajes.Text = "Mostrar Personajes";
            this.btnMostrarPersonajes.UseVisualStyleBackColor = true;
            this.btnMostrarPersonajes.Click += new System.EventHandler(this.btnMostrarPersonajes_Click);
            // 
            // rtbPersonajes
            // 
            this.rtbPersonajes.Location = new System.Drawing.Point(12, 153);
            this.rtbPersonajes.Name = "rtbPersonajes";
            this.rtbPersonajes.Size = new System.Drawing.Size(610, 266);
            this.rtbPersonajes.TabIndex = 1;
            this.rtbPersonajes.Text = "";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.rtbPersonajes);
            this.Controls.Add(this.btnMostrarPersonajes);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esteban.Marcelo.Quiroz.Ejemplo.V1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPersonajes;
        private System.Windows.Forms.RichTextBox rtbPersonajes;
    }
}

