namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxPoints = 1250.5;

            string nameOfActor = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int numberOfJudges = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfJudges; i++)
            {
                string nameOfJudge = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());
                startingPoints += (nameOfJudge.Length * pointsFromJudge) / 2;
                if (startingPoints > maxPoints)
                {
                    break;
                }
            }
            if (startingPoints > maxPoints)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {startingPoints:f1}!");
            }
            else
            {
                double pointsNeeded = maxPoints - startingPoints;
                Console.WriteLine($"Sorry, {nameOfActor} you need {pointsNeeded:f1} more!");
            }
        }
    }
}
