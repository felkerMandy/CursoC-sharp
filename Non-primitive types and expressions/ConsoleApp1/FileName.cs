

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + FirstName + " " + LastName + "!");
        }
    }

    class Progam
    {
        public static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "Amanda";
            john.LastName = "Felker";
            john.Introduce();
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Console.WriteLine("\nresultado da calculadora: " + result);
        }
    }
}