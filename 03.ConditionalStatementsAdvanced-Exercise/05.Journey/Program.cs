namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double expense = 0;
            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    expense = budget * 0.30;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    expense = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    expense = budget * 0.40;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    expense = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";

                if (season == "summer" || season == "winter")
                
                    place = "Hotel";
                    expense = budget * 0.90;
                
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {expense:F2}");
        }
    }
}
