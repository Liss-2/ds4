internal class Program
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