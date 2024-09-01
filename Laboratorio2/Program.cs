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

using System;

namespace Laboratorio2
{
    class Program
    {

        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Su_Nombre";
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }

        public class Client
        {
            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }
    }