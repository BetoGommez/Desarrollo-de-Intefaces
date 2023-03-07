namespace Form1
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
            this.btnMarca = new System.Windows.Forms.Button();
            this.etqAviso = new etiquetaAviso.etiquetaAviso();
            this.SuspendLayout();
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(153, 327);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(118, 19);
            this.btnMarca.TabIndex = 1;
            this.btnMarca.Text = "Botón Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // etqAviso
            // 
            this.etqAviso.Final = System.Drawing.Color.Red;
            this.etqAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etqAviso.Gradiente = true;
            this.etqAviso.Inicial = System.Drawing.Color.Blue;
            this.etqAviso.Location = new System.Drawing.Point(129, 61);
            this.etqAviso.Marca = etiquetaAviso.eMarca.Nada;
            this.etqAviso.Margin = new System.Windows.Forms.Padding(2);
            this.etqAviso.Name = "etqAviso";
            this.etqAviso.Size = new System.Drawing.Size(243, 107);
            this.etqAviso.TabIndex = 2;
            this.etqAviso.Text = "Aviso";
            this.etqAviso.Click += new System.EventHandler(this.etqAviso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.etqAviso);
            this.Controls.Add(this.btnMarca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMarca;
        private etiquetaAviso.etiquetaAviso etqAviso;
    }
}

