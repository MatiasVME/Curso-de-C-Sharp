using System;

namespace Application
{
    public class MasSobreEstructurasDeControl
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            // 5 a 9
            if (num >= 5 && num <= 9) {
                Console.WriteLine("Esta dentro del rango!");
            }

            else {
                Console.WriteLine("No esta dentro del rango");
            }

            // Operador condicional AND &&
            // Operador condicional OR ||
            // expresion && expresion
            // expresion || expresion
        }
    }
}
