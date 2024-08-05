namespace CriacaoClasses1
{
    public class CriacaoClasses1
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Insira os dados da primeira pessoa:");
            Console.Write("Nome:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da segunda pessoa:");
            Console.Write("Nome:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else if (p2.idade > p1.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade.");
            }


        }
    }
}