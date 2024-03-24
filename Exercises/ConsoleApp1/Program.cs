using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the width of your image.");
            var width = Console.ReadLine();
            float widthValue = float.Parse(width);

            Console.WriteLine("Please, enter the height of your image.");
            var height = Console.ReadLine();
            float heightValue = float.Parse(height);

            if (widthValue > heightValue)
            {
                Console.WriteLine("This image is landscape.");
            }

            else if (heightValue > widthValue)
            {
                Console.WriteLine("This image is a portrait.");
            }

        }
    }
}
