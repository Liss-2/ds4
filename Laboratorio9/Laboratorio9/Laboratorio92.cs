using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    internal class Laboratorio92
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine($"{i} es un número par y es divisible entre 3.");

                else if (i % 2 == 0)
                    Console.WriteLine($"{i} es un número par.");

                else if (i % 3 == 0)
                    Console.WriteLine($"{i} es divisible entre 3.");
            }
        }
    }
}
