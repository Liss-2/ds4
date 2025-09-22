using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    internal class Laboratorio31
    {

        class CalculosMatematicos
        {
            // Método para calcular la operación (a+b)*(a-b)
            public static int Calcular(int a, int b)
            {
                return (a + b) * (a - b);
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
            }
        }
    }
}
