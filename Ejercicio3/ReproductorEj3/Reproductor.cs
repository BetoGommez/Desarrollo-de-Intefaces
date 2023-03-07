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


        }

        private void updateTime()
        {
            this.lblTime.Text = $"{mm,2:d2}:{ss,2:d2}";
        }

        private int mm = 0;
        [Category("Appearance")]
        [Description("mm")]
        public int MM
        {
            set
            {
                mm =value;
                if (mm < 0)
                {
                    throw new ArgumentException("No existe el tiempo negativo");

                }
                if (mm > 59)
                {
                    mm = 0;
                }
                updateTime();
            }
            get
            {
                return mm;
            }
        }




        private int ss = 0;
        [Category("Appearance")]
        [Description("ss")]
        public int SS
        {
            set
            {
                ss = value;

                if (ss < 0)
                {
                    throw new ArgumentException("No existe el tiempo negativo");
                }
                

                if (ss > 59)
                {
                    ss = ss%60;
                    OnDesbordarTiempo(EventArgs.Empty);
                }
                updateTime();
                
                
            }
            get
            {
                return ss;
            }
        }


        public event System.EventHandler PlayClick;

        protected virtual void OnPlayClick(EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, e);
            }
        }





        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            
            OnPlayClick(EventArgs.Empty);
            if (playing)
            {
                btnPlayPause.Image = Resources.btnplay;
                playing= false;
            }
            else
            {
                btnPlayPause.Image = Resources.btnPause;
                playing= true;
            }

        }


        public event System.EventHandler DesbordarTiempo;
        protected virtual void OnDesbordarTiempo(EventArgs e)
        {
            int ssAux = 0;
            if (DesbordarTiempo != null)
            {
                DesbordarTiempo.Invoke(this, e);
            }


            
        }
    }
}
