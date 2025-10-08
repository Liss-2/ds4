using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8.Laboratorio89
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Template template1 = new Template();
            template1.ponerVariable("var1", "Valor1");
            template1.ponerVariable("var2", "Valor2");
            template1.ponerVariable("var3", "Valor3");
            template1.verHtml("<br>Texto de prueba</br>");
        }
    }
}
