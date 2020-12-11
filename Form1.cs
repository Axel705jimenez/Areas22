using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Cuadrado(numCuadrado.Value);
            lblCuadrado.Text = resultado + "";
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Rectangulo(numRectangulo.Value, numRectangulo1.Value);
            lblRectangulo.Text = resultado + "";
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Triangulo(numTriangulo.Value, numTriangulo1.Value);
            lblTriangulo.Text = resultado + "";
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Rombo(numRombo.Value, numRombo1.Value);
            lblRombo.Text = resultado + "";
        }

        private void btnRomboide_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Romboide(numRomboide.Value, numRomboide1.Value);
            lblRomboide.Text = resultado + "";
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Poligono(numPoligono.Value, numPoligono1.Value);
            lblPoligono.Text = resultado + "";
        }
        private void btnCirculo_Click(object sender, EventArgs e)
        {
           Areas a= new Areas();
            decimal resultado = a.Circulo(numCirculo.Value);
            lblCirculo.Text = resultado + "";
		}

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.Trapecio(numTrapecio.Value, numTrapecio1.Value, numtrapecio2.Value);
            lblTrapecio.Text = resultado + "";
        }
    }
}
