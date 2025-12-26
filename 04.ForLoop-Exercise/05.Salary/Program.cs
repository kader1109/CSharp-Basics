namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // price for a single tab
            int FacebookTabPrice = 150;
            int InstagramTabPrice = 100;
            int RedditTabPrice = 50;

            // input and slove the problem

            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double sumOfAllTabs = 0;

            for (int i = 0; i < openTabs; i++)
            {
                string nameOfTab = Console.ReadLine();
                if (nameOfTab == "Facebook")
                {
                    sumOfAllTabs += FacebookTabPrice;
                }
                else if (nameOfTab == "Instagram")
                {
                    sumOfAllTabs += InstagramTabPrice;
                }
                else if (nameOfTab == "Reddit")
                {
                    sumOfAllTabs += RedditTabPrice;
                }
            }
            if (sumOfAllTabs >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                double moneyLeft = salary - sumOfAllTabs;
                Console.WriteLine(moneyLeft);
            }
        }
    }
}
