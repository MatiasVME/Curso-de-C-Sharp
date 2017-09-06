using System;

namespace Application
{
    public class While1
    {
        public static void Main()
        {
            // Un bucle es una secuencia de instrucciones que
            // se ejecutan mientras se cumpla una condición.

            int a = 0;
            int b = 5;

            while (a < b) {
                Console.WriteLine("Hola");
                a++;
            }
        }
    }
}
