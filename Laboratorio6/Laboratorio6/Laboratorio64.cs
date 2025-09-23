using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    internal class Laboratorio64
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException(message: "Acceso negado - No cumple con el criterio de edad");
            }
            else
            {
                Console.WriteLine("Acceso Concedido");
            }
        }

        static void Main(string[] args)
        {
            checkAge(15);
        }
    }
}
