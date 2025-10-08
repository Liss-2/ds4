using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;


namespace Laboratorio9
{
    internal class Laboratorio95
    {
        private static void Main(string[] args)
        {
            // Crear una instancia de la clase Aleatorios
            Aleatorios aleatorio = new Aleatorios();

            try
            {
                // Generar un arreglo de 5 números únicos entre 1 y 10
                int[] arregloUnico = aleatorio.ArregloNoRepetido(1, 11, 5);

                Console.WriteLine("Arreglo de números aleatorios no repetidos:");
                foreach (int num in arregloUnico)
                {
                    Console.WriteLine(num);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
