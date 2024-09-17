/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}*/

class Program
{

    static void main(String[] args)
    {
        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Algo salió mal, valide el indice del arreglo");
        }
        finally
        {

            Console.WriteLine("Continuacion de la aplicacion, luego del bloque try/catch");
        }
    }
}