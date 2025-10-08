internal class Laboratorio91
{
    static string usuario = "", producto = "";
    static float monto = 0;
    private static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido a nuestro servicio de ventas online! \n");
        preguntarNombre();
        Console.ReadKey();
        Mensaje();
    }

    private static void preguntarNombre()
    {
        Console.Write("\nIngrese su nombre: ");
        usuario = Console.ReadLine();
        preguntarProducto();
    }

    private static void preguntarProducto()
    {
        Console.Write("\n¿Qué producto desea comprar?: ");
        producto = Console.ReadLine();
        preguntarPrecio();
    }

    private static void preguntarPrecio()
    {
        Console.Write("\nIngrese el precio del producto: ");
        monto = float.Parse(Console.ReadLine());
        FormaDePago();
    }


    private static void FormaDePago()
    {
        int formaDePago = 0;
        Console.WriteLine("\nElija el metodo de pago(1 o 2):\n1. Efectivo \n2.Tarjeta de débito/crédito\n");
        formaDePago = int.Parse(Console.ReadLine());

        if (formaDePago < 1)
            Console.WriteLine("\nEl valor ingresado es inválido.");
        if (formaDePago == 1)
            Console.WriteLine($"\nEl monto a pagar por {producto} es de: {monto:F2}");
        if (formaDePago == 2)
        {
            float numeroCuenta = 0;
            Console.Write("\nIngrese el número de cuenta: ");
            numeroCuenta = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nEl monto a pagar por {producto} es de: {monto:F2}");
        }
    }

    private static void Mensaje()
    {
        Console.Clear();
        Console.WriteLine($"\nMuchas gracias sr./sra. {usuario} por utilizar nuestros servicios, tenga un excelente día.");
    }
}