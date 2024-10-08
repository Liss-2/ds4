using System;

namespace Lab33
{
    class CalculosMatematicos
    {
        // Método para calcular la operación (a+b)*(a-b)
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }

        // Método para calcular el área de un círculo
        public static double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2); // Área = π * r^2
        }

        // Método para calcular el perímetro de un rectángulo
        public static double CalcularPerimetroRectangulo(double lado1, double lado2)
        {
            return 2 * (lado1 + lado2); // Perímetro = 2 * (lado1 + lado2)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- Ejercicio 1 ---
            Console.Write("Ingrese el valor para 'a': ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor para 'b': ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = CalculosMatematicos.Calcular(numero1, numero2);
            Console.WriteLine("El resultado de la operación (a+b)*(a-b) es: " + resultado);

            // --- Ejercicio 2 ---
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            double areaCirculo = CalculosMatematicos.CalculoArea(radio);
            Console.WriteLine("El área del círculo es: " + areaCirculo);

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