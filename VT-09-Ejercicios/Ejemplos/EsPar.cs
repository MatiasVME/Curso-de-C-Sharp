using System;

namespace Application
{
    public class EsPar
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Es par");
            }

            else {
                Console.WriteLine("Es impar");
            }
        }
    }
}
