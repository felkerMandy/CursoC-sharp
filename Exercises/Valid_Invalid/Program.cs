using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite um número de 1 a 10.");

            var numero = Console.ReadLine();
            int numeroUsuario = Convert.ToInt32(numero);

            if (numeroUsuario > 0 && numeroUsuario < 10)
            {
                Console.WriteLine("Valid");
            }

            else if (numeroUsuario == 10)
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("Invalid. Please try again.");
            }
         
                
        }
    }
}




