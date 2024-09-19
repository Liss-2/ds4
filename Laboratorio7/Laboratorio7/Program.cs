/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}*/

using Laboratorio7;

internal class Program
{
    static void Main(String[] args)
    {
        Banco banco1 = new Banco();
        banco1.Operar();
        banco1.DepositosTotales();
        Console.ReadKey();
    }
}