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

        private String imagenMarca = "C:\\Users\\Trabajo\\Desktop\\imagen.jpeg";
        [Category("Appearance")]
        [Description("Indica si tiene un fondo con gradiente")]
        public String ImagenMarca
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
        public Color Incial
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


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (gradiente)
            {

                LinearGradientBrush lineB = new LinearGradientBrush(new Point(0, 0), new Point(this.Width,offsetY), inicial, final);
                g.DrawLine(new Pen(lineB, this.Height*2), 0, 0,  offsetX+this.Width, 0);
              
                lineB.Dispose();
            }
           
         
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (checkImagen(ImagenMarca))
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
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }

        private bool checkImagen(String imagen)
        {
            try
            {
                this.imagen = Image.FromFile(imagen);
                if (!(this.imagen.Height > 0))
                {
                    throw new Exception();
                }
            } catch (Exception e)
            {
                return false;
            }
            return true;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (this.Marca != eMarca.Nada && e.Location.X < this.grosor+this.Font.Height)
            {
                
                this.Parent.Text = "(X: " + e.Location.X + ", Y: " + e.Location.Y + ")";

            }
        }
    }
}
