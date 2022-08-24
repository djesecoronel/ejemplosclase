using System;

namespace ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Escribe tu nombre:");
            String nombre = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Escribe una ciudad:");
            String ciudad = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Hola " + nombre + " bienvenido a la ciudad de " + ciudad);

            Console.ReadLine();

        }
    }
}