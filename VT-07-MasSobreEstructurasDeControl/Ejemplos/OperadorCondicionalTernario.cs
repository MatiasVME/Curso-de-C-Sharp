using System;

namespace Application
{
    public class OperadorCondicionalTernario
    {
        public static void Main()
        {
            // expresionBoolean ? expression1 : expression2

            Console.WriteLine("Ingrese la hora del día: ");
            int hora = int.Parse(Console.ReadLine());

            string saludo = "buenos " + ((hora <= 12) ? "dias" : "tardes");
            Console.WriteLine(saludo);
        }
    }
}
