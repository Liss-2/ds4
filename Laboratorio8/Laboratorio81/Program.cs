﻿/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}*/

class Persona
{
    //Campo de cada objeto Persona que almacena su nombre
    public string Nombre;
    //Campo de cada objeto Persona que almacena su edad
    public int Edad;
    //Campo de cada objeto Persona que almacena su NIF

    public string NIF;
    void cumpleaños()
    {
        Edad++;
    }

    //constructor de PErsona
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;    
        Edad = edad;    
        NIF = nif;
    }
}