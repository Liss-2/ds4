using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    internal class Laboratorio54
    {
        private static void Main(string[] args)
        {
            List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };
            int suma = 0;
            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / (double)calificaciones.Count;
            Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
        }
    }
}
