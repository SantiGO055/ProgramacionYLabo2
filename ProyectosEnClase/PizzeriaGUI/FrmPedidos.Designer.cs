namespace PizzeriaGUI
{
    partial class FrmPedidos
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
            this.lstPedidosPorRealizar = new System.Windows.Forms.ListBox();
            this.cmbGusto = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.nmuCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCoccion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkEnvia = new System.Windows.Forms.CheckBox();
            this.btnPedir = new System.Windows.Forms.Button();
            this.lblClientePedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmuCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPedidosPorRealizar
            // 
            this.lstPedidosPorRealizar.FormattingEnabled = true;
            this.lstPedidosPorRealizar.Location = new System.Drawing.Point(383, 49);
            this.lstPedidosPorRealizar.Name = "lstPedidosPorRealizar";
            this.lstPedidosPorRealizar.Size = new System.Drawing.Size(213, 199);
            this.lstPedidosPorRealizar.TabIndex = 1;
            this.lstPedidosPorRealizar.SelectedIndexChanged += new System.EventHandler(this.FrmPedidos_Load);
            // 
            // cmbGusto
            // 
            this.cmbGusto.FormattingEnabled = true;
            this.cmbGusto.Items.AddRange(new object[] {
            "Muzzarella",
            "Napolitana",
            "Jamon y morron",
            "Calabresa",
            "Fugazzeta"});
            this.cmbGusto.Location = new System.Drawing.Point(108, 16);
            this.cmbGusto.Name = "cmbGusto";
            this.cmbGusto.Size = new System.Drawing.Size(121, 21);
            this.cmbGusto.TabIndex = 1;
            this.cmbGusto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(7, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // nmuCantidad
            // 
            this.nmuCantidad.Location = new System.Drawing.Point(108, 68);
            this.nmuCantidad.Name = "nmuCantidad";
            this.nmuCantidad.Size = new System.Drawing.Size(121, 20);
            this.nmuCantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gusto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de coccion";
            // 
            // cmbCoccion
            // 
            this.cmbCoccion.FormattingEnabled = true;
            this.cmbCoccion.Items.AddRange(new object[] {
            "Al horno",
            "A la piedra"});
            this.cmbCoccion.Location = new System.Drawing.Point(108, 128);
            this.cmbCoccion.Name = "cmbCoccion";
            this.cmbCoccion.Size = new System.Drawing.Size(121, 21);
            this.cmbCoccion.TabIndex = 3;
            this.cmbCoccion.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cmbCoccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmuCantidad);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.cmbGusto);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(127, 174);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 25);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkEnvia
            // 
            this.chkEnvia.AutoSize = true;
            this.chkEnvia.Location = new System.Drawing.Point(24, 281);
            this.chkEnvia.Name = "chkEnvia";
            this.chkEnvia.Size = new System.Drawing.Size(105, 17);
            this.chkEnvia.TabIndex = 5;
            this.chkEnvia.Text = "Envia a domicilio";
            this.chkEnvia.UseVisualStyleBackColor = true;
            this.chkEnvia.CheckedChanged += new System.EventHandler(this.chkEnvia_CheckedChanged);
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(244, 273);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(77, 25);
            this.btnPedir.TabIndex = 6;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // lblClientePedido
            // 
            this.lblClientePedido.AutoSize = true;
            this.lblClientePedido.Location = new System.Drawing.Point(31, 18);
            this.lblClientePedido.Name = "lblClientePedido";
            this.lblClientePedido.Size = new System.Drawing.Size(45, 13);
            this.lblClientePedido.TabIndex = 9;
            this.lblClientePedido.Text = "Cliente: ";
            this.lblClientePedido.Click += new System.EventHandler(this.lblClientePedido_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 336);
            this.Controls.Add(this.lblClientePedido);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.chkEnvia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPedidosPorRealizar);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmuCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPedidosPorRealizar;
        private System.Windows.Forms.ComboBox cmbGusto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.NumericUpDown nmuCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCoccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnvia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Label lblClientePedido;
    }
}