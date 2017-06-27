using System;

namespace Application
{
    public class EntradaDeDatos
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Cuál es tu nombre?: ");
            string nombre;
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nombre);

            int edad;
            Console.WriteLine("Cuál es tu edad?: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu edad es: " + edad);
        }
    }
}
