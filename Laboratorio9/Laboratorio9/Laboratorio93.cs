using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    internal class Laboratorio93
    {
        private static void Main(string[] args)
        {
            // Solicitar los tres lados del triángulo
            Console.WriteLine("Ingrese el primer lado:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer lado:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Verificar si los lados pueden formar un triángulo
            if (EsTrianguloValido(lado1, lado2, lado3))
            {
                // Determinar el tipo de triángulo
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Es un triángulo equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Es un triángulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Es un triángulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo.");
            }
        }

        // Función para verificar si los lados pueden formar un triángulo
        static bool EsTrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

    }
}
