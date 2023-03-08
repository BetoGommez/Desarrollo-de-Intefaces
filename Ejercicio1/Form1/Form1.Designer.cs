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
            this.btnPos = new System.Windows.Forms.Button();
            this.btnSeparacion = new System.Windows.Forms.Button();
            this.labelTextBox1 = new Ejercicio1.LabelTextBox();
            this.SuspendLayout();
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(29, 54);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(204, 23);
            this.btnPos.TabIndex = 1;
            this.btnPos.Text = "Cambiar Posición";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnSeparacion
            // 
            this.btnSeparacion.Location = new System.Drawing.Point(251, 54);
            this.btnSeparacion.Name = "btnSeparacion";
            this.btnSeparacion.Size = new System.Drawing.Size(231, 23);
            this.btnSeparacion.TabIndex = 3;
            this.btnSeparacion.Text = "Sumar Separacion";
            this.btnSeparacion.UseVisualStyleBackColor = true;
            this.btnSeparacion.Click += new System.EventHandler(this.btnSeparacion_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(12, 12);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = Ejercicio1.LabelTextBox.ePosicion.IZQUIERDA;
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(800, 20);
            this.labelTextBox1.TabIndex = 2;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeparacion);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.btnPos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPos;
        private Ejercicio1.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btnSeparacion;
    }
}

