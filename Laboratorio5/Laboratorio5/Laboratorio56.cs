using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    internal class Laboratorio56
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> paisesyCapitales = new Dictionary<string, string>
        {
            {"Francia", "Paris" },
            {"España", "Madrid" },
            {"Italia", "Roma" },
        };

            foreach (KeyValuePair<string, string> par in paisesyCapitales)
            {
                Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
            }
        }
    }
}
