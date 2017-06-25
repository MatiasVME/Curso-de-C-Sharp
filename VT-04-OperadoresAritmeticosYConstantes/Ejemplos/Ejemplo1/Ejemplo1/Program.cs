using System;

namespace Ejemplo1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const float PI = 3.14f;
            Console.WriteLine(PI); // hola

            // Este es un comentario

            /* Este es 
             * un comentario
             * de multiples lineas
             */

            int var1 = 5;
            int var2 = 3;
            int res = var1 + var2 - (3 + var2) * (var1 - 1);

            Console.WriteLine(res);
		}
    }
}
