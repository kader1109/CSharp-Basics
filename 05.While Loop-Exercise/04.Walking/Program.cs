using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int dailyGoal = 10000;
            int totalSteps = 0;

            while (totalSteps < dailyGoal)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }

                totalSteps += int.Parse(input);
            }

            if (totalSteps >= dailyGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - dailyGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{dailyGoal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
