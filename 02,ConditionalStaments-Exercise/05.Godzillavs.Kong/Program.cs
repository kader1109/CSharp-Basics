namespace _05.Godzillavs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double priceOfClothestForOnePerson = double.Parse(Console.ReadLine());

            double decoration = buget * 0.10;
            double totalPriceOfClothes = priceOfClothestForOnePerson * statistsCount;

            if (statistsCount > 150)
            {
                totalPriceOfClothes -= totalPriceOfClothes * 0.10;
            }

            double totalSum = decoration + totalPriceOfClothes;
            double difference = Math.Abs(totalSum - buget);

            if (totalSum <= buget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
            else if(totalSum > buget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:F2} leva more.");
            }

        }
    }
}
/*
 
20000
120
55,5

 */
