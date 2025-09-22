using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Laboratorio32
    {
        public static void Main(string[] args)
        {
            // --- Ejercicio 2 ---
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            double areaCirculo = Laboratorio31.CalculosMatematicos.CalculoArea(radio);
            Console.WriteLine("El área del círculo es: " + areaCirculo);
        }
    }
}
