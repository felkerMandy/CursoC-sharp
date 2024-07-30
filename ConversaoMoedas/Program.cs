using System;
using System.Globalization;


namespace ConversaoMoedas
{
    public class Conversao
    {
        public static void Main(string[] args)
        {
            double valorDolar = 5.65;
            double valorEuro = 6.11;
            double valorIene = 0.037;
            double valorLibra = 7.25;
            string menu = ("Escolha a moeda de conversão através dos números de identificação:\n" +
                "1.Dólar\n" +
                "2.Euro\n" +
                "3.Iene\n" +
                "4.Libra\n");

            Console.WriteLine("Por favor, insira o valor em Real a ser convertido:");
            string valorInicial = Console.ReadLine();
            double valor = double.Parse(valorInicial);
            Console.WriteLine(menu);
            string menuOpcao = Console.ReadLine();
            int opcao = int.Parse(menuOpcao);
            while (opcao == 1)
            {
                double conversaoDolar = valor / valorDolar;
                string dolarConvertido = conversaoDolar.ToString("F2", CultureInfo.InvariantCulture);
                Console.WriteLine("$" + dolarConvertido);
                break;
            }

            while (opcao == 2)
            {
                double conversaoEuro = valor / valorEuro;
                string euroConvertido = conversaoEuro.ToString("F2");
                Console.WriteLine(euroConvertido + "€");
                break;
            }

            while (opcao == 3)
            {
                double conversaoIene = valor / valorIene;
                string ieneConvertido = conversaoIene.ToString("F2", CultureInfo.InvariantCulture);
                Console.WriteLine("¥ " + ieneConvertido);
                break;
            }

            while (opcao == 4)
            {
                double conversaoLibra = valor / valorLibra;
                string libraConvertido = conversaoLibra.ToString("F2", CultureInfo.InvariantCulture);
                Console.WriteLine("£" + libraConvertido);
                break;
            }

        }
    }
}