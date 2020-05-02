using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase4
{
    public class PrimerForm : Form
    {
        private Button btnAceptar;

        
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(75, 98);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 30);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // PrimerForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAceptar);
            this.Name = "PrimerForm";
            this.Text = "mi form";
            this.Load += new System.EventHandler(this.PrimerForm_Load);
            this.ResumeLayout(false);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void PrimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
