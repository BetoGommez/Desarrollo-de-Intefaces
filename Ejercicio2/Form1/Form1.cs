using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            if (etqAviso.Marca == etiquetaAviso.eMarca.Nada)
            {
                etqAviso.Marca = etiquetaAviso.eMarca.Cruz;
            }
            else{

            _ = etqAviso.Marca == etiquetaAviso.eMarca.Cruz ? etqAviso.Marca = etiquetaAviso.eMarca.Circulo : etqAviso.Marca = etiquetaAviso.eMarca.Nada;
            }
        }

        private void etqAviso_Click(object sender, EventArgs e)
        {

        }
    }
}
