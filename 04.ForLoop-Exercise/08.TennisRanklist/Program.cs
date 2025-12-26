namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int totalPoints = startingPoints;
            int wonTournaments = 0;
            for (int i = 1; i <= numberOfTournaments; i++)
            {
                string stageOfTournament = Console.ReadLine();
                switch (stageOfTournament)
                {
                    case "W":
                        totalPoints += 2000;
                        wonTournaments++;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {((totalPoints - startingPoints) / numberOfTournaments)}");
            Console.WriteLine($"{((wonTournaments * 1.0 / numberOfTournaments) * 100):f2}%");

        }
    }
}
