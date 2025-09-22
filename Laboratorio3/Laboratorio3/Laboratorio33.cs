using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laboratorio3.Laboratorio31;

namespace Laboratorio3
{
    internal class Laboratorio33
    {
        public static void Main(string[] args)
        { 
            // --- Ejercicio 3 ---
            Console.Write("Ingrese el lado 1 del rectángulo: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2 del rectángulo: ");
            double lado2 = double.Parse(Console.ReadLine());

            double perimetroRectangulo = CalculosMatematicos.CalcularPerimetroRectangulo(lado1, lado2);
            Console.WriteLine("El perímetro del rectángulo es: " + perimetroRectangulo);
        }
    }
}
