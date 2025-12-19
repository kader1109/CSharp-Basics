namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //spring 3000 лв.
            //sumer-autum 4200 лв.
            //winter 2600 лв.

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherManCount = int.Parse(Console.ReadLine());
            double priceBoatForASeason = 0;

            switch (season)
            {
                case "Spring":
                    priceBoatForASeason = 3000;
                    if (fisherManCount <= 6)
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.1;
                    }
                    else if (fisherManCount > 7 && fisherManCount <= 11)
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.15;
                    }
                    else
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.25;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    priceBoatForASeason = 4200;
                    if (fisherManCount <= 6)
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.1;
                    }
                    else if (fisherManCount > 7 && fisherManCount <= 11)
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.15;
                    }
                    else
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.25;
                    }

                    break;
                case "Winter":
                    priceBoatForASeason = 2600;
                    if (fisherManCount <= 6)
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.1;
                    }
                    else if (fisherManCount > 7 && fisherManCount <= 11)
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.15;
                    }
                    else
                    {
                        priceBoatForASeason -= priceBoatForASeason * 0.25;
                    }
                    break;
            }
            if (fisherManCount % 2 == 0)
            {
                if (season != "Autumn")
                {
                    priceBoatForASeason -= priceBoatForASeason * 0.05;
                }
            }
            double diff = Math.Abs(budget - priceBoatForASeason);

            if (budget >= priceBoatForASeason)
            {
                Console.WriteLine($"Yes! You have {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
            }
        }
    }
}
