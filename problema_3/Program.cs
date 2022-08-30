using System;

namespace problema_3
{
    class Program
    {
        static void Main (string [] args)
        {
            int kilometros, litros;

            try
            {
                
                Console.WriteLine ("Ingrese kilómetros: ");
                kilometros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine ("Ingrese litros:" );
                litros = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine ("Los kilómetros por litro son: " + Cociente (litros, kilometros));

            }
            catch (OverflowException)
            {
                Console.WriteLine ("ERROR: Desbordamiento");
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine ("ERROR: División pr cero");
            }
            catch (Exception ex)
            {
                Console.WriteLine ("ERROR: " + ex.Message);
            }



            int Cociente (int divisor, int dividendo) {

                return dividendo / divisor;
               
            }
        }
    }
}