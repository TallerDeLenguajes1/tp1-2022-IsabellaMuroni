using System;

namespace problema_1
{
    class Program
    {
        static void Main (string[] args)
        {
            int num;

            try 
            {

                Console.WriteLine("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El cuadrado de " + num + " es: " + Cuadrado (num));
            }
            catch (OverflowException) {

                Console.WriteLine("ERROR: Desbordamiento");
            }
            catch(FormatException){

                Console.WriteLine("ERRO: Formato no aceptado");
            }
            catch(Exception ex){

                Console.WriteLine("Error: " + ex.Message);
            }


            int Cuadrado (int numero){

                return numero * numero;
            }
        }
    }
}
