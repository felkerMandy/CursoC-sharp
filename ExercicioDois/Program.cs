using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    public class ExercicioFixacao2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string [] frase  = Console.ReadLine().Split(',');
            string ultimoNome = frase[0];
            int idade = int.Parse(frase[1]);
            double altura = double.Parse(frase[2], CultureInfo.InvariantCulture);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}