using System;
namespace Application
{
    public class AmbitoVarYDynamic
    {
        public static void Main()
        {
            dynamic algo = 111;
            Console.WriteLine(algo.GetType());
            //algo = "hola";
            Console.WriteLine(algo.GetType());

            if (algo is int) {
                Console.WriteLine("Es un entero");
            }
            else if (algo is string) {
                Console.WriteLine("Es un string");
            }
        }
    }
}
