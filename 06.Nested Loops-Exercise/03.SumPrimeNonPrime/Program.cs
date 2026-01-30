namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int primeNumberSum = 0;
            int nonPrimeNumberSum = 0;

            while (command != "stop")
            {
                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                if (number < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    primeNumberSum += number;
                }
                else
                {
                    nonPrimeNumberSum += number;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumberSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumberSum}");
        }

    }

}
