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
        int contadorSeg=0;
        public Form1()
        {
            InitializeComponent();
            reproductor1.Minutos = 0;
            reproductor1.Segundos = 0;
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
            reproductor1.stopTimer();
            reproductor1.Enabled = false;
            contadorSeg = 0;
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
                        imagenes.Add(Image.FromFile(archivos[i].FullName));
                        
                       
                    }
                }
                if (imagenes.Count > 0)
                {
                    reproductor1.Enabled = true;
                   
                    
                }
                
            }
        }

        private void reproductor1_Load(object sender, EventArgs e)
        {

        }

        private void reproductor1_CambioSeg(object sender, EventArgs e)
        {

            if (imagenes.Count > 0)
            {
                if (contadorSeg == cboxTime.SelectedIndex + 1)
                {
                    if (index == (imagenes.Count-1))
                    {
                        index = 0;
                    }
                    pictureBox1.Image = (Image)imagenes[index];
                    index++;
                    contadorSeg = 0;
                }
                contadorSeg++;
            }
        }

        private void cboxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            contadorSeg= 0;
        }
    }
}
