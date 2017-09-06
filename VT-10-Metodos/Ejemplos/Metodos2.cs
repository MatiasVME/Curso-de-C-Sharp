using System;
namespace Application
{
    public class Metodos2
    {
        public static void Main() {
            int a = 5, b = 10;

            Intercambiar(ref a, ref b);

            Console.WriteLine(a + ", " + b);
        }

        public static void Intercambiar(ref int num1, ref int num2) {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            //Console.WriteLine(num1 + ", " + num2);
        }
    }
}
