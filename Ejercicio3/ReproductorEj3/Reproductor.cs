using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReproductorEj3.Properties;

namespace ReproductorEj3
{
    public partial class Reproductor: UserControl
    {

        private Timer timer;
        private bool playing=false;
        public Reproductor()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timeSet;
           

        }

        private int minutos = 0;
        [Category("Appearance")]
        [Description("Minutos")]
        public int Minutos
        {
            set
            {
                minutos = value;
                
            }
            get
            {
                return minutos;
            }
        }

        [Category("Hizo tick")]
        [Description("Cada vez que el timer se activa")]
        public event System.EventHandler CambioSeg;
        protected virtual void OnCambioSeg(EventArgs e)
        {
            e.ToString();
        }



        private int segundos = 0;
        [Category("Appearance")]
        [Description("Segundos")]
        public int Segundos
        {
            set
            {
                segundos = value;
                
            }
            get
            {
                return segundos;
            }
        }

        public void stopTimer()
        {
            if (playing)
            {
                playClick();

            }
        }

        public void startTimer()
        {
            if (!playing)
            {
                playClick();

            }
        }


        private void playClick()
        {
            if (playing)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
            playing = !playing;
        }



        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            
            playClick();
            if (playing)
            {
                btnPlayPause.Image = Resources.btnPause;

            }
            else
            {
                btnPlayPause.Image = Resources.btnplay;

            }
        }

        private void timeSet(object sender, EventArgs e)
        {
            segundos++;
            CambioSeg(sender,e);
            if (segundos > 59)
            {
                desbordarTiempo();
            }
            this.lblTime.Text = String.Format("{0:D2}", minutos) + ":" + String.Format("{0:D2}",segundos);
        }

        private void desbordarTiempo()
        {
            if (minutos < 0 || segundos < 0)
            {
                throw new ArgumentException("No existe el tiempo negativo");
            }
            minutos++;
            segundos = 0;
        }
    }
}
