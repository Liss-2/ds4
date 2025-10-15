using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio12.Laboratorio123
{
    public class CalcularTriangulo
    {
        public double CalcularSemiperimetro(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        public double CalcularArea(double a, double b, double c)
        {
            double s = CalcularSemiperimetro(a, b, c);
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        
    }
}
