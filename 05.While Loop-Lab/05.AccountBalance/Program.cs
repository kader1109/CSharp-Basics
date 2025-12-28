namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalSum = 0;
            while (command != "NoMoreMoney")
            {
                double sum = double.Parse(command);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += sum;
                Console.WriteLine($"Increase: {sum:f2}");
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalSum:f2}");

        }
    }
}
