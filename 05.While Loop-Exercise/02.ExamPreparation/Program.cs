using System.Diagnostics;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int slovedProblems = 0;
            double sumOfGrades = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedTimes++;
                }
                slovedProblems++;
                sumOfGrades += grade;
                lastProblem = problemName;


            }
            double averageScore = sumOfGrades / slovedProblems;
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {slovedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }

        }
    }
}
