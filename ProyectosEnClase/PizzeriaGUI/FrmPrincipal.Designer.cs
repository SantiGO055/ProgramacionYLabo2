namespace PizzeriaGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione usuario de la lista para realizar el pedido, si no existe puede crear " +
    "uno";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(406, 82);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(77, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Crear Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes:";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(185, 71);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(161, 108);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(373, 156);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(144, 23);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Realizar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 216);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnPedido;
    }
}

