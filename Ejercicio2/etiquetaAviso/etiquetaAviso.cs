using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.LinkLabel;

namespace etiquetaAviso
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    public partial class etiquetaAviso: Control
    {
        private Image imagen;
        private int grosor;

        public etiquetaAviso()
        {
            InitializeComponent();
        }

        private Image imagenMarca;
        [Category("Appearance")]
        [Description("Indica si tiene un fondo con gradiente")]
        public Image ImagenMarca
        {
            set
            {
              
                imagenMarca = value;
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        private bool gradiente = true;
        [Category("Appearance")]
        [Description("Indica si tiene un fondo con gradiente")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        private Color inicial = Color.Blue;
        [Category("Appearance")]
        [Description("Es el Color inicial")]
        public Color Inicial
        {
            set
            {
                inicial = value;
                this.Refresh();
            }
            get
            {
                return inicial;
            }
        }
        private Color final = Color.Red;
        [Category("Appearance")]
        [Description("Color final del gradiente")]
        public Color Final
        {
            set
            {
                final = value;
                this.Refresh();

            }
            get
            {
                return final;
            }
        }

        private eMarca marca = eMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();

            }
            get
            {
                return marca;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen;
            grosor = 0;
            int offsetX = 0; 
            int offsetY = 0;
            LinearGradientBrush lineB = null;
            int h = this.Font.Height;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (Marca)
            {

                case eMarca.Circulo:
                    grosor = 20;
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    offsetX = h + grosor;
                    offsetY = grosor / 2;

                    break;
                case eMarca.Imagen:
                    if (imagen!=null)
                    {
                        g.DrawImage(imagen, 0, 0, h, h);
                    }
                    else
                    {
                        this.Marca = eMarca.Nada;
                    }
                    break;
            }

            Size tam = g.MeasureString(this.Text, this.Font).ToSize();

            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);

            if (gradiente)
            {
                lineB = new LinearGradientBrush(new Point(0, 0), new Point(this.Width+offsetX, offsetY), this.Inicial, this.Final);
                pen = new Pen(lineB, this.Height * 2);
                g.DrawLine(pen, 0, 0, this.Width, 0);
                pen.Dispose();
                lineB.Dispose();
            }

            switch (Marca)
            {
                
                case eMarca.Circulo:
                    grosor = 20;
                    pen = new Pen(Color.Green, grosor);
                    g.DrawEllipse(pen, grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    pen.Dispose();
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    pen = new Pen(Color.Red, grosor);
                    g.DrawLine(pen, grosor, grosor, h, h);
                    g.DrawLine(pen, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;

                    pen.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagen!=null)
                    {
                        g.DrawImage(imagen,0,0,h,h);
                        offsetX = h;
                    }
                    else
                    {
                        this.Marca = eMarca.Nada;
                    }
                    break;
            }
            
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);

            b.Dispose();
            

        }


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            OnClickEnMarca(e);
        }

        [Category("Appearance")]
        [Description("Se lanza cuando se pulsa la marca")]
        public event System.EventHandler clickEnMarca;
        protected virtual void OnClickEnMarca(MouseEventArgs e)
        {
            if (this.Marca != eMarca.Nada && e.Location.X < this.grosor + this.Font.Height)
            {

                this.Parent.Text = "(X: " + e.Location.X + ", Y: " + e.Location.Y + ")";
                if (clickEnMarca != null)
                {
                    clickEnMarca.Invoke(this, e);
                }
            }
            
        }

    }
}
