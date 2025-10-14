namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string realRass = "s3cr3t!P@ssw0rd";

            string entrypass = Console.ReadLine();

            if (entrypass == realRass)
            {
                Console.WriteLine("Welcome");
            }
            else Console.WriteLine("Wrong password!");
        }
    }
}
