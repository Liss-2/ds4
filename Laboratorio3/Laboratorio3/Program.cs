
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // ------- ejemplo 1 --------
        int primerNumero, segundoNumero, suma;

        Console.WriteLine("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("La suma de {0} y {1} es {2}", primerNumero, segundoNumero, suma);


    }
}