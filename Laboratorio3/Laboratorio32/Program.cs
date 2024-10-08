
/* Crear una aplicación consola que calcule el área de un círculo, 
 agregando el método CalculoArea a la clase creada en el anterior
ejercicio. Los datos para calcular el área de circulo son leídos por
teclado.*/
using System;

namespace Lab32
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
        }
    }
}