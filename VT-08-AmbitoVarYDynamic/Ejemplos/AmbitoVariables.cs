using System;

namespace Application
{
    public class AmbitoVariables
    {
        private static int num3 = 77;

        public static void Main()
        {
            int num = 10;

            {
                Console.WriteLine(num);

                {
                    Console.WriteLine(num);
                    int num2 = 88;
                    Console.WriteLine(num2);
                }
            }
            //Console.WriteLine(num2);
            Console.WriteLine(num3);
            Hola();
        }

        public static void Hola() {
            //Console.WriteLine(num);
            Console.WriteLine("esta funcionando: " + num3);
        }
    }
}
