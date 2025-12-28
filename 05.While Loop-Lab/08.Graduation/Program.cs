namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int clas = 1;
            int failed = 0;
            while (clas <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    failed++;
                    if (failed == 2)
                    {
                        break;
                    }
                    continue;
                }
                clas++;
                sum += grade;
            }
            if (clas > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {clas} grade");
            }
        }


    }
}

