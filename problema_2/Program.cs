using System;

namespace problema_2
{
    class Program
    {
        static void Main (string[] args)
        {
            int num, num1;

            try {

                Console.WriteLine ("Ingrese dividendo: ");
                num1 = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine ("Ingrese divisor: ");
                num = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine ("El cociente entre es: " + Cociente(num1, num));

            }
            catch (FormatException) {

                Console.WriteLine ("ERROR: Formato no aceptado");

            }
            catch (System.DivideByZeroException) {

                Console.WriteLine ("ERROR: División por cero");

            }
            catch (OverflowException) {

                Console.WriteLine ("ERROR: Desbordamiento");

            }
            catch (Exception ex) {

                Console.WriteLine ("ERROR: " + ex.Message);

            }



            int Cociente (int divisor, int dividendo) {

                return dividendo / divisor;
               
            }
        }
    }
}
