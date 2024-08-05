namespace CriacaoClasses1
{
    public class CriacaoClasses1
    {
        public static void Main(string[] args)
        {
            var listaPessoa = new List<Pessoa>()
            {
                new Pessoa(),
                new Pessoa(),
            };

            Console.WriteLine("Insira os dados da primeira pessoa:");
            Console.Write("Nome:");
            listaPessoa[0].nome = Console.ReadLine();
            Console.Write("Idade: ");
            listaPessoa[0].idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da segunda pessoa:");
            Console.Write("Nome:");
            listaPessoa[1].nome = Console.ReadLine();
            Console.Write("Idade: ");
            listaPessoa[1].idade = int.Parse(Console.ReadLine());

            if (listaPessoa[0].idade > listaPessoa[1].idade)
            {
                Console.WriteLine("Pessoa mais velha: " + listaPessoa[0].nome);
            }

            else if (listaPessoa[1].idade > listaPessoa[0].idade)
            {
                Console.WriteLine("Pessoa mais velha: " + listaPessoa[1].nome);
            }

            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade.");
            }

        }
    }
}