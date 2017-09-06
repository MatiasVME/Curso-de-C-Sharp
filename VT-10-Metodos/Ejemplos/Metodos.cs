using System;

namespace Application
{
    public class Metodos
    {
        public static void Main()
        {
            Console.WriteLine(suma(2, 3));
            Console.WriteLine(suma(4, 6));
        }

        public static int suma(int num1, int num2) {
            return num1 + num2;
        }
    }
}
