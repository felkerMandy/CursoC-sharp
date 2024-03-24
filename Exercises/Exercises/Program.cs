using System;
using System.Runtime.Serialization;
namespace iterations
{
 class program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            double soma = 0.0;
            while (continuar)
            {
                string inicio = ("Enter a number to continue or 'OK' to stop.");
                Console.WriteLine(inicio);
                var user = Console.ReadLine().ToUpper();
             
                string fim = "OK";
               
                if(user.Equals(fim))
                {
                    continuar = false;      
                }
                else
                {
                    double userDou = double.Parse(user);
                    soma += double.Parse(user);
                    
                }
               
            }

            Console.WriteLine(soma);
        }

    }
} 