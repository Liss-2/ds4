

namespace Laboratorio22
{
    class MyClass
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
            Console.WriteLine(object2.Nombre);
            Console.WriteLine(object1.Nombre);

        }

    }

}
