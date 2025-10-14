using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12
{
    public partial class Laboratorio121 : Form
    {
        CalculoDistancia obj = new CalculoDistancia();
        public Laboratorio121()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDistanciaRecorrida_Click(object sender, EventArgs e)
        {
            Console.WriteLine("en actionPerformed");
            //d=v*t
            double velocidad = double.Parse(txtVelocidad.Text);
            double tiempo = double.Parse(txtTiempo.Text);
            double distancia = obj.Calcular(velocidad, tiempo);
            txtResultado.Text = $"{distancia} km";
        }

        //método para limpiar los datos
        private void Limpiar()
        {
            txtVelocidad.Text = "";
            txtTiempo.Text = "";
            txtResultado.Text = $"{0} km";
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
