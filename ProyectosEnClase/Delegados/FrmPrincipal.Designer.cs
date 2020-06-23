namespace Delegados
{
    partial class FrmPrincipal
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnRecibe = new System.Windows.Forms.Button();
            this.btnJueguito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(89, 12);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 24);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnRecibe
            // 
            this.btnRecibe.Location = new System.Drawing.Point(89, 53);
            this.btnRecibe.Name = "btnRecibe";
            this.btnRecibe.Size = new System.Drawing.Size(100, 24);
            this.btnRecibe.TabIndex = 2;
            this.btnRecibe.Text = "Recibir";
            this.btnRecibe.UseVisualStyleBackColor = true;
            this.btnRecibe.Click += new System.EventHandler(this.btnRecibe_Click);
            // 
            // btnJueguito
            // 
            this.btnJueguito.Location = new System.Drawing.Point(89, 121);
            this.btnJueguito.Name = "btnJueguito";
            this.btnJueguito.Size = new System.Drawing.Size(100, 24);
            this.btnJueguito.TabIndex = 3;
            this.btnJueguito.Text = "Jueguito";
            this.btnJueguito.UseVisualStyleBackColor = true;
            this.btnJueguito.Click += new System.EventHandler(this.btnJueguito_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 190);
            this.Controls.Add(this.btnJueguito);
            this.Controls.Add(this.btnRecibe);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FrmPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnRecibe;
        private System.Windows.Forms.Button btnJueguito;
    }
}

