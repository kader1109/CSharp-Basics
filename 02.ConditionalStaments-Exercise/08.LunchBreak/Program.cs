namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfSeries = Console.ReadLine();

            int seriesTime = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());


            double timeForLunch = time * 0.125;
            double timeForBreak = time * 0.25;

            double restTime = Math.Abs(time - timeForLunch - timeForBreak);
            double diffrence = Math.Abs(Math.Floor(restTime - seriesTime));

            if (restTime >= seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {diffrence} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {diffrence} more minutes.");
            }


        }
    }
}
