using System;

namespace Application
{
    public class SegundosADias
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            Divisible(num);
        }

        public static void Divisible(int num)
        {
            if (num % 2 == 0) {
                Console.WriteLine("Es divisible por 2.");
            }

            else {
                Console.WriteLine("No es divisible por 2.");
            }

            if (num % 3 == 0) {
                Console.WriteLine("Es divisible por 3.");
            }

            else {
                Console.WriteLine("No es divisible por 3.");
            }

            if (num % 5 == 0) {
                Console.WriteLine("Es divisible por 5.");
            }

            else {
                Console.WriteLine("No es divisible por 5.");
            }
        }
    }
}
