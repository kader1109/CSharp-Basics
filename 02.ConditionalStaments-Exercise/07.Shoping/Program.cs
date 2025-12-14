namespace Shoping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int videoCardCount = int.Parse(Console.ReadLine());
            int CPUCount = int.Parse(Console.ReadLine());
            int RAMCount = int.Parse(Console.ReadLine());

            double videoCardPrice = videoCardCount * 250;
            double CPUPrice = (videoCardPrice * 0.35) * CPUCount;
            double RAMPrice = (videoCardPrice * 0.10) * RAMCount;

            double SumOfProducts = videoCardPrice + CPUPrice + RAMPrice;

            if (videoCardCount > CPUCount)
            {
                SumOfProducts -= SumOfProducts * 0.15;
            }

            double difference = Math.Abs(SumOfProducts - budget);

            if (SumOfProducts < budget)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
            }


        }
    }
}
