using System.Diagnostics.CodeAnalysis;

    /*el usuario debe ingresar dos números y la aplicación consola mostrará el resultado
     de la operación (a+b)*(a-b). La operación debe estar bajo el método Calcular de la 
    clase CalculosMatematicos y el programa principal bajo la clase Program*/


namespace Lab31
{
    // Clase que contiene los métodos de cálculo
    class CalculosMatematicos
    {
        // Método para calcular la operación (a+b)*(a-b)
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Solicitando la entrada de dos números al usuario
            Console.Write("Ingrese el valor para 'a': ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor para 'b': ");
            int numero2 = int.Parse(Console.ReadLine());

            // Llamando al método Calcular de la clase CalculosMatematicos
            int resultado = CalculosMatematicos.Calcular(numero1, numero2);

            // Mostrando el resultado
            Console.WriteLine("El resultado de la operación (a+b)*(a-b) es: " + resultado);
        }
    }
}