using System;

namespace Application
{
    public class EstructurasDeControl
    {
        public static void Main ()
        {
            /* > mayor que
             * < menor que
             * >= mayor o igual que
             * <= menor o igual que
             * == igual que
             * != distinto que
             */
            
			if (-5 >= 1)
			{
                Console.WriteLine("Se hace esto :D");

                if (true != false) {
                    Console.WriteLine("OK.");
                }
			}

            else {
                Console.WriteLine("si no");
            }

            Console.WriteLine("Fin.");
        }
    }
}
