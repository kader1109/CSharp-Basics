namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paidAmount = double.Parse(Console.ReadLine());
            int coins = 0;

            int cents = (int)Math.Round(paidAmount * 100);
            int[] coinValue = { 200, 100, 50, 20, 10, 05, 02, 01 };

            foreach (int coin in coinValue)
            {

                while (cents >= coin)
                {
                    cents -= coin;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
