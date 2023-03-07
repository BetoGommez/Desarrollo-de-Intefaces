namespace AplicacionForm
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
            this.components = new System.ComponentModel.Container();
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxTime = new System.Windows.Forms.ComboBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.reproductor1 = new ReproductorEj3.Reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 12);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(193, 24);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Seleccionar Directorio";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 183);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cboxTime
            // 
            this.cboxTime.FormattingEnabled = true;
            this.cboxTime.Location = new System.Drawing.Point(225, 12);
            this.cboxTime.Name = "cboxTime";
            this.cboxTime.Size = new System.Drawing.Size(175, 24);
            this.cboxTime.TabIndex = 3;
            this.cboxTime.SelectedIndexChanged += new System.EventHandler(this.cboxTime_SelectedIndexChanged);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // reproductor1
            // 
            this.reproductor1.AutoSize = true;
            this.reproductor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reproductor1.Location = new System.Drawing.Point(175, 246);
            this.reproductor1.MM = 0;
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Size = new System.Drawing.Size(84, 57);
            this.reproductor1.SS = 0;
            this.reproductor1.TabIndex = 4;
            this.reproductor1.PlayClick += new System.EventHandler(this.reproductor1_PlayClick);
            this.reproductor1.DesbordarTiempo += new System.EventHandler(this.reproductor1_DesbordarTiempo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(436, 315);
            this.Controls.Add(this.reproductor1);
            this.Controls.Add(this.cboxTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFolder);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxTime;
        private System.Windows.Forms.Timer tmr;
        private ReproductorEj3.Reproductor reproductor1;
    }
}

