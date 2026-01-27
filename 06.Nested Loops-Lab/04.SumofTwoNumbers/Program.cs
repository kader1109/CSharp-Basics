namespace _04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startOfTheInterval = int.Parse(Console.ReadLine());
            int endOfTheInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationCount = 0;

            for (int i = startOfTheInterval; i <= endOfTheInterval; i++)
            {
                for (int j = startOfTheInterval; j <= endOfTheInterval; j++)
                {
                    combinationCount++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({i}" +
                            $" + {j} = {magicNumber})");
                        return;

                    }
                }
            }
            Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
        }

    }
}


