﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    }

    //Definición de método que suma dos números e imprime el resultado.
    public void Sumar(int valor1, int valor2)
    {
        int variableLocal = valor1 + valor2;//declarndo variable local variableLocal
        Console.WriteLine(variableLocal);//Esto imprime el resultado de la suma
    }
    Console.WriteLine(variableLocal); //Esto presenta error de compilación
    
}