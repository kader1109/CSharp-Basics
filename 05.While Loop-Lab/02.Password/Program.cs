namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if ((command) == password)
                {
                    Console.WriteLine($"Welcome {userName}!");
                    break;
                }
            }
        }
    }
}
