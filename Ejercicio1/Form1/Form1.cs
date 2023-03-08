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

        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            _ = labelTextBox1.Posicion == Ejercicio1.LabelTextBox.ePosicion.IZQUIERDA ? labelTextBox1.Posicion = Ejercicio1.LabelTextBox.ePosicion.DERECHA : labelTextBox1.Posicion = Ejercicio1.LabelTextBox.ePosicion.IZQUIERDA;
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Separacion.ToString();
        }

        private void btnSeparacion_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion++;
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "Tecla levantada";
        }
    }

}
