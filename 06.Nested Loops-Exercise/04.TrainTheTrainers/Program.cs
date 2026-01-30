namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juries = int.Parse(Console.ReadLine());
            string command=Console.ReadLine();

            double totalAverage = 0;
            int presentationCount = 0;

            while (command != "Finish")
            {
                string presantationName = command;
                double sumGrades = 0;

                for (int i = 0; i < juries; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                }
                double average = sumGrades / juries;

                Console.WriteLine($"{presantationName} - {average:F2}.");

                totalAverage += average;
                presentationCount++; 

                command = Console.ReadLine();

            }
            double finalAverage = totalAverage / presentationCount;
            Console.WriteLine($"Student's final assessment is {finalAverage:F2}.");
        }
    }
}
