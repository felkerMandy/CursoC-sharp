namespace DemoString
{
    public class DemoString
    {
        public static void Main(string[] args)
        {
            var firstName = "Amanda";
            var middleName = " Felker";
            var midName = " Gomes";
            var lastName = "de Moraes";
            var fullName = firstName + middleName + midName + lastName;
            var fullNametd = string.Format("My name is {0} {1} {2} {3}",firstName, middleName, midName, lastName);

            Console.WriteLine(fullNametd);

            var text = @"Hi,John
Look at the following paths
c:/folder/1";
            Console.WriteLine(text);

               
                
        }
    }
}
