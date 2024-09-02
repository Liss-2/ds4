
/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    } 
    //ejemplo de variable local 1
    public void Sumar(int valor1, int valor2)
        {
            int variableLocal = valor1 + valor2;
            Console.WriteLine(variableLocal);   
        }
    
}*/

/* --------------------------------------------------------------------------------------------------
using System;

namespace Laboratorio2
{
    class Program
    {

        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Su Nombre";
            client.LastName = "Su Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }

        public class Client
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }
    }
}

----------------------------------------------------------------------------------------------------*/


using System;


namespace Laboratorio21
{
    public class MyClass
    {
        //Declarando variable estática
        public static int valor;
    }

    public class Program
    {
        public static void Main()
        {

            //asignando valor a variable estática
            MyClass.valor = 1;
            Console.WriteLine(MyClass.valor);
        }

    }

}