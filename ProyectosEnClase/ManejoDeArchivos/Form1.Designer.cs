namespace ManejoDeArchivos
{
    partial class Form1
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rtbLeer = new System.Windows.Forms.RichTextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.lblResultadoGuardar = new System.Windows.Forms.Label();
            this.lblResultadoLeer = new System.Windows.Forms.Label();
            this.btnLeerArchivoProfe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(74, 44);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(231, 257);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(88, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(197, 44);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rtbLeer
            // 
            this.rtbLeer.Location = new System.Drawing.Point(417, 48);
            this.rtbLeer.Name = "rtbLeer";
            this.rtbLeer.Size = new System.Drawing.Size(261, 252);
            this.rtbLeer.TabIndex = 2;
            this.rtbLeer.Text = "";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(417, 343);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(68, 63);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer archivo creado";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Location = new System.Drawing.Point(690, 180);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(98, 44);
            this.btnLimpiarTodo.TabIndex = 4;
            this.btnLimpiarTodo.Text = "Limpiar Todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // lblResultadoGuardar
            // 
            this.lblResultadoGuardar.AutoSize = true;
            this.lblResultadoGuardar.Location = new System.Drawing.Point(87, 318);
            this.lblResultadoGuardar.Name = "lblResultadoGuardar";
            this.lblResultadoGuardar.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoGuardar.TabIndex = 5;
            // 
            // lblResultadoLeer
            // 
            this.lblResultadoLeer.AutoSize = true;
            this.lblResultadoLeer.Location = new System.Drawing.Point(470, 318);
            this.lblResultadoLeer.Name = "lblResultadoLeer";
            this.lblResultadoLeer.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoLeer.TabIndex = 6;
            // 
            // btnLeerArchivoProfe
            // 
            this.btnLeerArchivoProfe.Location = new System.Drawing.Point(564, 343);
            this.btnLeerArchivoProfe.Name = "btnLeerArchivoProfe";
            this.btnLeerArchivoProfe.Size = new System.Drawing.Size(68, 63);
            this.btnLeerArchivoProfe.TabIndex = 7;
            this.btnLeerArchivoProfe.Text = "Leer archivo del profe";
            this.btnLeerArchivoProfe.UseVisualStyleBackColor = true;
            this.btnLeerArchivoProfe.Click += new System.EventHandler(this.btnLeerArchivoProfe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeerArchivoProfe);
            this.Controls.Add(this.lblResultadoLeer);
            this.Controls.Add(this.lblResultadoGuardar);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.rtbLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtbTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rtbLeer;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Label lblResultadoGuardar;
        private System.Windows.Forms.Label lblResultadoLeer;
        private System.Windows.Forms.Button btnLeerArchivoProfe;
    }
}

