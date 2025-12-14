namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            double totalPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5;
                totalPoints = points + bonusPoints;
                //Console.WriteLine(bonusPoints);
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints = (double)points * 0.20; // 20% of the points number
                totalPoints = points + bonusPoints;
                //Console.WriteLine(bonusPoints);
            }
            else if (points > 1000)
            {
                bonusPoints = (double)points * 0.10; // 10% of the points number
                totalPoints = points + bonusPoints;
               // Console.WriteLine(bonusPoints);
            }

            if (points % 2 == 0)
            {
                bonusPoints += 1;
                totalPoints += 1;
            }
            if (points % 10 == 5)
            {

                bonusPoints += 2;
                totalPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);
        }
    }
}
