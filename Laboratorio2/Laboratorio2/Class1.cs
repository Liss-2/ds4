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
            Client client = new Client();
            //ejemplo utilizando las variables de instancia de Clase.
            client.FirstName = "Liseth";
            client.LastName = "Montezuma";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());    

        }
    }

    public class Client
    {
        //Declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            //utilizando variables de instancia dentro de metodos de la clase
            return FirstName + "" + LastName;
        }
    }
}
