using System;
namespace Application
{
    public class EsMayor
    {
        public static void Main()
        {
            Console.WriteLine("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad <= 10) {
                Console.WriteLine("es un niño");
            }

            else if (edad <= 17) {
                Console.WriteLine("Es un joven");
            }

            else {
                Console.WriteLine("Es un adulto");
            }
        }
    }
}
