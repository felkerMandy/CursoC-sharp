using System;
namespace ExerciseFour
/*
Write a program that picks a random number between 1 and 10.
Give the user 4 chances to guess the number. If the user guesses the number, display “You won";
otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
*/
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            var tries = 4;

            for (var i = 1; i <= tries; i++)
            {
                Console.WriteLine("You have four chances to guess this random number between 1 to 10. Please, insert your first try!");
                var user = Console.ReadLine();
                var userNumber = int.Parse(user);

                if (userNumber == randomNumber)
                {
                   Console.WriteLine("You won.Congratulations!");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You lost. Thanks for playing!");
                }    
                else
                {
                    Console.WriteLine("Try again.");
                }
                
            }
        }

    }
}


