using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Laboratorio31
    {

        public class CalculosMatematicos
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
/*
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
            }
        }*/
    }
}
