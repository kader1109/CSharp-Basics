namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());

            int countOfPuzzle = int.Parse(Console.ReadLine()); // price 2.6lv
            int countOfSpeakingDoll = int.Parse(Console.ReadLine()); // price 3lv
            int countOfTedyBear = int.Parse(Console.ReadLine()); //price 4.10lv
            int countOfMinion = int.Parse(Console.ReadLine()); //price 8.20 lv
            int countOfLoryToy = int.Parse(Console.ReadLine()); // price 2lv

            int totalNumberOfToys = countOfLoryToy + countOfMinion + countOfTedyBear + countOfSpeakingDoll + countOfPuzzle;

            double totalPriceOfToys = (countOfLoryToy * 2) +
                                      (countOfMinion * 8.20) +
                                      (countOfTedyBear * 4.10) +
                                      (countOfSpeakingDoll * 3) +
                                      (countOfPuzzle * 2.60);

            double rent = totalPriceOfToys * 0.10;
            totalPriceOfToys -= rent;

            if (totalNumberOfToys > 50)
            {
                totalPriceOfToys -= totalPriceOfToys * 0.25;
            }

            double difference = Math.Abs(priceTrip - totalPriceOfToys);

            if (totalPriceOfToys >= priceTrip) Console.WriteLine($"Yes! {difference:F2} lv left.");
            else Console.WriteLine($"Not enough money! {difference:F2} lv needed.");

        }
    }
}
