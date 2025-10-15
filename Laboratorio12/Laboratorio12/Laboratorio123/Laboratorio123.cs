using Laboratorio12.Laboratorio123;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12.Laboratorio123
{
    public partial class Laboratorio123 : Form
    {
        CalcularTriangulo obj = new CalcularTriangulo();
        public Laboratorio123()
        {
            InitializeComponent();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtSemiperimetro.Clear();
            txtArea.Clear();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtLadoA.Text);
            double b = double.Parse(txtLadoB.Text);
            double c = double.Parse(txtLadoC.Text);

            double s = obj.CalcularSemiperimetro(a, b, c);

            txtSemiperimetro.Text = $"{s:F2}";
        }


        private void btnArea_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtLadoA.Text);
            double b = double.Parse(txtLadoB.Text);
            double c = double.Parse(txtLadoC.Text);

            double s = obj.CalcularSemiperimetro(a, b, c);
            double area = obj.CalcularArea(a, b, c);

            txtArea.Text = $"{area:F2}";
        }

    }
}
