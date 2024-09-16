using System.Diagnostics.CodeAnalysis;

internal class Program
{
    /*el usuario debe ingresar dos números y la aplicación consola mostrará el resultado
     de la operación (a+b)*(a-b). La operación debe estar bajo el método Calcular de la 
    clase CalculosMatematicos y el programa principal bajo la clase Program*/

    
    public static void Main(string[] args)
    {
        

        int a = 0, b = 0, suma = 0, resta = 0;   
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Ingrese el valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El resultado de la operación es: " + ((suma)*(resta)));


    }

    private void CalculosMatematicos(int suma, int resta, int a, int b)
    {
        suma = a + b;

    }
}