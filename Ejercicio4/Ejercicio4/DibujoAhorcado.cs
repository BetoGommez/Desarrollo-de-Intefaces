using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Text;

namespace Ejercicio4
{
    public partial class DibujoAhorcado: UserControl
    {

        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores = 0;
        [Category("Appearance")]
        [Description("Partes del ahorcado según n errores")]
        public int Errores
        {
            set
            {

                if (value>= 7)
                {
                    this.errores = 7;
                    OnAhorcado(EventArgs.Empty);

                }
                else
                {
                    if (value < 0)
                    {
                        this.errores = 0;
                    }
                    else
                    {
                        this.errores = value;

                    }

                }
                OnCambiaError(EventArgs.Empty);
                this.Refresh();
            }
            get
            {
                return this.errores;
            }
        }


        [Category("La propiedad cambió")]
        [Description("Cambió el número de errores")]
        public event System.EventHandler CambiaError;
        public void OnCambiaError(EventArgs e)
        {
            if (CambiaError != null)
            {
                CambiaError(this, e);
            }
            
        }

        [Category("La propiedad cambió")]
        [Description("Llegó a siete errores")]
        public event System.EventHandler Ahorcado;
        public void OnAhorcado(EventArgs e)
        {

            Ahorcado(this,e);
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DibujoAhorcado_Paint(object sender, PaintEventArgs e)
        {
            
            int ancho = this.Width;
            int alto = this.Height;

            Pen pincel = new Pen(Color.Black,ancho/30);
            

            int unitX = ancho / 5;
            int unitY = alto/8;

            int baseX = unitX+(unitX/5);
            int baseY =unitY*7+(unitY/5);

            int newBaseY = baseY - unitY * 6 + unitX;
            int newBaseX = baseX + unitX * 2;

            switch (errores)
            {
                case 7:
                    //Piernas
                    e.Graphics.DrawLine(pincel, newBaseX, newBaseY + unitY * 2, newBaseX - unitX, newBaseY + unitY * 7 / 2);
                    e.Graphics.DrawLine(pincel, newBaseX, newBaseY + unitY * 2, newBaseX + unitX, newBaseY + unitY * 7 / 2);
                    goto case 6;
                case 6:
                    //Brazos
                    e.Graphics.DrawLine(pincel, newBaseX, newBaseY + unitY, newBaseX - unitX, newBaseY);
                    e.Graphics.DrawLine(pincel, newBaseX, newBaseY + unitY, newBaseX + unitX, newBaseY);
                    goto case 5;
                case 5:
                    //Torso
                    e.Graphics.DrawLine(pincel, newBaseX, newBaseY, newBaseX, newBaseY + unitY * 2);
                    goto case 4;
                case 4:
                    //CABEZA
                    e.Graphics.DrawEllipse(pincel, new Rectangle(baseX + unitX * 2 - unitX / 2, baseY - unitY * 6, unitX, unitX));
                    goto case 3;
                case 3:
                    //PALO DERECHO Y CUERDITA
                    e.Graphics.DrawLine(pincel, baseX, baseY - unitY * 7, baseX + unitX * 2, baseY - unitY * 7);
                    e.Graphics.DrawLine(pincel, baseX + unitX * 2, baseY - unitY * 7, baseX + unitX * 2, baseY - unitY * 6);
                    goto case 2;
                case 2:
                    //PALO
                    e.Graphics.DrawLine(pincel, baseX, baseY - unitY, baseX, baseY - unitY * 7);
                    goto case 1;
                case 1:
                    ///SOSTENEDOR
                    e.Graphics.DrawLine(pincel, baseX - unitX, baseY, baseX, baseY - unitY);
                    e.Graphics.DrawLine(pincel, baseX + unitX, baseY, baseX, baseY - unitY);
                    break;
            }
        }


    }
}
