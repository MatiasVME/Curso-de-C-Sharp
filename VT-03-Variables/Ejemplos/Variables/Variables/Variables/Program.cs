using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte edad = 27;
            Console.WriteLine(edad);
            edad = 28;
            Console.WriteLine(edad);

            int numero = 288838;
            Console.WriteLine(numero);

            bool estaVivo = false;
            Console.WriteLine(estaVivo);

            string nombre = "Matías";
            Console.WriteLine(nombre);

            char caracter = 'c';
            Console.WriteLine(caracter);

            float nota = 5.6f;
            Console.WriteLine(nota);

            Console.WriteLine("Mi edad es: " + edad);
            Console.WriteLine("Estoy vivo: " + estaVivo);
        }
    }
}
