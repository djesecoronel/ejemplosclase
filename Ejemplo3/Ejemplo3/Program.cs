using System;

namespace ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite el segundo mumero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("El primer numero es mayor o igual que el segundo");
            }
            else
            {
                Console.WriteLine("El segundo numero es mayor que el primero");
            }

            Console.ReadLine();
        }
    }
}