
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
    
}

// --------------------------------------------------------------------------------------------------


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

//----------------------------------------------------------------------------------------------------



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

//------------------------------------------------------------------------------------


internal class Program1
{
    //imprimiendo en consola variables
    private static void Main(string[] args)
    {
        int valor1 = 28;
        int valor2 = valor1;
        valor2 = 30;
        Console.WriteLine(valor1);
        Console.WriteLine(valor2);
        
        Console.WriteLine(valor1);
        Console.WriteLine(valor2);
    }
}

//----------------------------------------------------------------------------------------

internal class Program2
{
    private static void Main(string[] args)
    {
        int valor1 = 28;
        int valor2 = valor1;
        valor2 = 30;
        Console.WriteLine(valor1);
        Console.WriteLine(valor2);

        Console.WriteLine(valor1);
        Console.WriteLine(valor2);
    }
}

//*************************************************************************************************************
*/

namespace Laboratorio22
{
    public class MyClass
    {
        //Declarando variable estática
        public string Nombre { get; set; }
        public int Edad { get; set; }

    }

    public class Program
    {
        public static void Main()
        {

            //Creando nueva instancia
            MyClass object1 = new MyClass();
            object1.Nombre = "Fulano";
            object1.Edad = 28;

            //Asignando una variable a otra
            MyClass object2 = object1;

            //Este cambio en la propiedad afecta tanto a object1 como object2
            object2.Nombre = "Jose";

            //Al imprimir en consola vemos que ambas referencias imprimen el mismo valor 'Jose'
            Console.WriteLine(object2);
            Console.WriteLine(object1);

        }

    }

}
