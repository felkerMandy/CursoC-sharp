using System.ComponentModel;
using System.Runtime.Serialization;

public class Program
    {

    public static void Main()
    {
        bool leitura = true;
        var programacao = 15;
        var ingles = 10;
        var literatura = 12;
        var engenharia = 26;
        var excel = 15;

        var conhecimentoProgramacao = 0;
        var conhecimentoIngles = 0;
        var conhecimentoLiteratura = 0;
        var conhecimentoEngenharia = 0;
        var conhecimentoExcel = 0;

        Console.WriteLine("Qual o seu nome?");
        string name = Console.ReadLine(); // amanda
        Console.WriteLine("Bem-vindo," + " " + name + "!");
        while (leitura)
        {
            string curso = "Por favor, escolha as opções de livros que deseja acessar hoje" + ":" +
                "\n1.Programação;\n2.Inglês;\n3.Literatura;\n4.Engenharia;\n5.Excel;\n6.Parar leitura.";
            Console.WriteLine(curso);
            var entradaString = Console.ReadLine();

            var entrada = int.Parse(entradaString);
            

            switch (entrada)
            {
                case 1:
                    Console.WriteLine("Você ganhou" + " " + programacao + " " + "pontos. Parabéns!");
                    conhecimentoProgramacao += programacao;
                    break;

                case 2:
                    Console.WriteLine("Você ganhou" + " " + ingles + " " + "pontos. Parabéns!");
                    conhecimentoIngles += ingles;
                    break;

                case 3:
                    Console.WriteLine("Você ganhou" + " " + literatura + " " + "pontos. Parabéns!");
                    conhecimentoLiteratura += literatura;
                    break;

                case 4:
                    Console.WriteLine("Você ganhou" + " " + engenharia + " " + "pontos. Parabéns!");
                    conhecimentoEngenharia += engenharia;
                    break;

                case 5:
                    Console.WriteLine("Você ganhou" + " " + excel + " " + "pontos. Parabéns!");
                    conhecimentoExcel += excel;
                    break;

                case 6:
                    leitura = false;
                    Console.WriteLine("Obrigada pela leitura!");
                    Console.WriteLine("Este foi seu conhecimento adquirido nas seguintes áreas:\n1.Conhecimento em Programação:" + conhecimentoProgramacao + "\n2.Conhecimento em Inglês:" + conhecimentoIngles + "\n3.Conhecimento em Literatura:" + conhecimentoLiteratura + "\n4.Conhecimento em Engenharia:" + conhecimentoEngenharia + "\n5.Conhecimento em Excel:" + conhecimentoExcel);
                    break;

                default:
                    Console.WriteLine("Curso inválido. Por favor, selecione uma opção válida.");
                    break;
            }         
          
        }
        }

}
