namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxesForAYear = double.Parse(Console.ReadLine());

            double priceOfShooses = taxesForAYear - (taxesForAYear * 0.40);
            double priceOfTeamClotes = priceOfShooses - (priceOfShooses * 0.20);
            double priceOfBall = priceOfTeamClotes * 0.25;
            double basketballAcssesoars = priceOfBall * 0.20;

            double sum = taxesForAYear + priceOfShooses + priceOfTeamClotes + priceOfBall + basketballAcssesoars;
            Console.WriteLine(sum);


        }
    }
}
