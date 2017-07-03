using System;

namespace Application
{
    public class Ordenar3Numeros
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese un número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor = 0, medio = 0, menor = 0;

            if (num1 > num2 && num1 > num3) {
                mayor = num1;

                if (num2 > num3) {
                    medio = num2;
                    menor = num3;
                }

                else {
                    medio = num3;
                    menor = num2;
                }
            }

            else if (num2 > num3 && num2 > num1) {
                mayor = num2;

                if (num1 > num3) {
                    medio = num1;
                    menor = num3;
                }

                else {
                    medio = num3;
                    menor = num1;
                }
            }

            else if (num3 > num1 && num3 > num2) {
                mayor = num3;

                if (num1 > num2) {
                    medio = num1;
                    menor = num2;
                }

                else {
                    medio = num2;
                    menor = num1;
                }
            }

            Console.Write("Resultado: ");
            Console.WriteLine("{0}, {1}, {2}", menor, medio, mayor);
        }
    }
}
