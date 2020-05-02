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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.lstPedidosPendientes = new System.Windows.Forms.ListBox();
            this.lstPedidosSalieron = new System.Windows.Forms.ListBox();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblListos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione usuario de la lista para realizar el pedido, si no existe puede crear " +
    "uno";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(15, 185);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(77, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Crear Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes:";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(15, 71);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(161, 108);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(182, 114);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(161, 23);
            this.btnRealizarPedido.TabIndex = 3;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click_1);
            // 
            // lstPedidosPendientes
            // 
            this.lstPedidosPendientes.FormattingEnabled = true;
            this.lstPedidosPendientes.Location = new System.Drawing.Point(383, 71);
            this.lstPedidosPendientes.Name = "lstPedidosPendientes";
            this.lstPedidosPendientes.Size = new System.Drawing.Size(418, 95);
            this.lstPedidosPendientes.TabIndex = 5;
            this.lstPedidosPendientes.SelectedIndexChanged += new System.EventHandler(this.lstPedidosPendientes_SelectedIndexChanged);
            // 
            // lstPedidosSalieron
            // 
            this.lstPedidosSalieron.FormattingEnabled = true;
            this.lstPedidosSalieron.Location = new System.Drawing.Point(383, 219);
            this.lstPedidosSalieron.Name = "lstPedidosSalieron";
            this.lstPedidosSalieron.Size = new System.Drawing.Size(418, 95);
            this.lstPedidosSalieron.TabIndex = 6;
            this.lstPedidosSalieron.SelectedIndexChanged += new System.EventHandler(this.lstPedidosSalieron_SelectedIndexChanged);
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(380, 45);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(60, 13);
            this.lblPendientes.TabIndex = 7;
            this.lblPendientes.Text = "Pendientes";
            // 
            // lblListos
            // 
            this.lblListos.AutoSize = true;
            this.lblListos.Location = new System.Drawing.Point(380, 195);
            this.lblListos.Name = "lblListos";
            this.lblListos.Size = new System.Drawing.Size(34, 13);
            this.lblListos.TabIndex = 8;
            this.lblListos.Text = "Listos";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.lblListos);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lstPedidosSalieron);
            this.Controls.Add(this.lstPedidosPendientes);
            this.Controls.Add(this.btnRealizarPedido);
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
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.ListBox lstPedidosPendientes;
        private System.Windows.Forms.ListBox lstPedidosSalieron;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblListos;
        private System.Windows.Forms.Timer timer1;
    }
}

