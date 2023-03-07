using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionForm
{
    public partial class Form1 : Form
    {
      
      
        private ArrayList imagenes;
        int index = 0;
        int intervalTime = 0;
        int timeElapsed=0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Formulario";
            reproductor1.Enabled = false;
            imagenes = new ArrayList();
            imagenes.Add(pictureBox1.Image);
            for (int i = 1; i < 21; i++)
            {
                cboxTime.Items.Add(i);
            }
            cboxTime.SelectedIndex = 0;
        }


        private void btnFolder_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            reproductor1.SS = 0;
            reproductor1.Enabled = false;
            pictureBox1.Image= null;
            openFolder.ShowDialog();
            if (Directory.Exists(openFolder.SelectedPath))
            {
                DirectoryInfo di = new DirectoryInfo(openFolder.SelectedPath);
                FileInfo[] archivos = di.GetFiles();
                imagenes.Clear();
                for (int i = 0; i < archivos.Length; i++)
                {
                    if (".png,.jpeg,.jpg".Contains(archivos[i].Extension))
                    {
                        try
                        {
                            Image image = Image.FromFile(archivos[i].FullName);
                            imagenes.Add(image);
                        }catch(ArgumentException a)
                        {

                        }
                    }
                }
                if (imagenes.Count > 0)
                {
                    reproductor1.Enabled = true;
                }
            }
        }

        


        private void cboxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            intervalTime = (cboxTime.SelectedIndex+1);

        }

        private void reproductor1_PlayClick(object sender, EventArgs e)
        {
            if (tmr.Enabled)
            {
                tmr.Stop();
            }
            else
            {
                tmr.Start();
            }
        }

        private void reproductor1_DesbordarTiempo(object sender, EventArgs e)
        {
            reproductor1.MM++;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            reproductor1.SS += tmr.Interval / 1000;
            if (imagenes.Count > 0)
            {
                if(reproductor1.SS % intervalTime == 0)
                {
                    if (index == (imagenes.Count - 1))
                    {
                        index = 0;
                    }
                    pictureBox1.Image = (Image)imagenes[index];
                    index++;
                }
            }
        }
    }
}
