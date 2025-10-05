using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8.Laboratorio89
{
    internal class Template : iTemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine($"Metodo poner varibale {nombre} : {var}");
        }

        public void verHtml(string template)
        {
            Console.WriteLine($"Metodo ver html {template}");
        }
    }
}
