using System;
//Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
//For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.//
namespace exercise3
{
 class Excercise
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Please, insert a number");
            var number = Console.ReadLine();
            var numberConvertido = int.Parse(number);
            int fatorial = 1;

            for (var i = numberConvertido; i >= 1; i--)
            {
                fatorial *= i; 
            }
            Console.WriteLine(fatorial);
        }
    }
}
