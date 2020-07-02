namespace RepasoParcial2
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
            this.btnAutom = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.txtPuesto1 = new System.Windows.Forms.TextBox();
            this.txtPuesto2 = new System.Windows.Forms.TextBox();
            this.txtPuesto3 = new System.Windows.Forms.TextBox();
            this.txtPuesto4 = new System.Windows.Forms.TextBox();
            this.lblPuesto1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxContagiados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAutom
            // 
            this.btnAutom.Location = new System.Drawing.Point(26, 26);
            this.btnAutom.Name = "btnAutom";
            this.btnAutom.Size = new System.Drawing.Size(133, 30);
            this.btnAutom.TabIndex = 2;
            this.btnAutom.Text = "GenerarAutom";
            this.btnAutom.UseVisualStyleBackColor = true;
            this.btnAutom.Click += new System.EventHandler(this.btnAutom_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(26, 92);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(133, 32);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // txtPuesto1
            // 
            this.txtPuesto1.Location = new System.Drawing.Point(37, 175);
            this.txtPuesto1.Name = "txtPuesto1";
            this.txtPuesto1.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto1.TabIndex = 4;
            // 
            // txtPuesto2
            // 
            this.txtPuesto2.Location = new System.Drawing.Point(37, 231);
            this.txtPuesto2.Name = "txtPuesto2";
            this.txtPuesto2.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto2.TabIndex = 5;
            // 
            // txtPuesto3
            // 
            this.txtPuesto3.Location = new System.Drawing.Point(37, 288);
            this.txtPuesto3.Name = "txtPuesto3";
            this.txtPuesto3.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto3.TabIndex = 6;
            // 
            // txtPuesto4
            // 
            this.txtPuesto4.Location = new System.Drawing.Point(37, 345);
            this.txtPuesto4.Name = "txtPuesto4";
            this.txtPuesto4.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto4.TabIndex = 7;
            // 
            // lblPuesto1
            // 
            this.lblPuesto1.AutoSize = true;
            this.lblPuesto1.Location = new System.Drawing.Point(40, 160);
            this.lblPuesto1.Name = "lblPuesto1";
            this.lblPuesto1.Size = new System.Drawing.Size(49, 13);
            this.lblPuesto1.TabIndex = 8;
            this.lblPuesto1.Text = "Puesto 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puesto 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Puesto 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Puesto 4";
            // 
            // listBoxContagiados
            // 
            this.listBoxContagiados.FormattingEnabled = true;
            this.listBoxContagiados.Location = new System.Drawing.Point(227, 37);
            this.listBoxContagiados.Name = "listBoxContagiados";
            this.listBoxContagiados.Size = new System.Drawing.Size(281, 316);
            this.listBoxContagiados.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxContagiados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuesto1);
            this.Controls.Add(this.txtPuesto4);
            this.Controls.Add(this.txtPuesto3);
            this.Controls.Add(this.txtPuesto2);
            this.Controls.Add(this.txtPuesto1);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnAutom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAutom;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.TextBox txtPuesto1;
        private System.Windows.Forms.TextBox txtPuesto2;
        private System.Windows.Forms.TextBox txtPuesto3;
        private System.Windows.Forms.TextBox txtPuesto4;
        private System.Windows.Forms.Label lblPuesto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxContagiados;
    }
}

