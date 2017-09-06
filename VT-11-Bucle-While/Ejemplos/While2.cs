using System;
namespace Application
{
    public class While2
    {
        public static void Main()
        {
            string resp = "y";

            while (resp == "y") {
                Console.WriteLine("¿Desea seguir iterando?");
                resp = Console.ReadLine();
            }
        }
    }
}
