using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Class1
    {
        static void Main(string[] args)
        {

        }
    }

    public class Client
    {
        //Declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public string GetFullName()
        {
            //utilizando variables de instancia dentro de metodos de la clase
            return FirstName + "" + LastName;
        }
    }
}
