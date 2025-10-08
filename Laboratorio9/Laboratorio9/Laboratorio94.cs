using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
namespace Laboratorio9
{
    //LAB94
    class Aleatorios
    {
        // Atributo: instancia de Random
        private Random random;

        // Constructor: inicializa el Random
        public Aleatorios()
        {
            random = new Random();
        }

        // Método: Genera un arreglo de números aleatorios SIN REPETICIONES
        public int[] ArregloNoRepetido(int min, int max, int tamaño)
        {
            if ((max - min) < tamaño)
            {
                throw new ArgumentException("El rango es demasiado pequeño para generar números únicos.");
            }

            List<int> numerosDisponibles = new List<int>();
            for (int i = min; i < max; i++)
            {
                numerosDisponibles.Add(i);
            }

            int[] arreglo = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                int indiceAleatorio = random.Next(0, numerosDisponibles.Count);
                arreglo[i] = numerosDisponibles[indiceAleatorio];
                numerosDisponibles.RemoveAt(indiceAleatorio);
            }

            return arreglo;
        }
    }

}
