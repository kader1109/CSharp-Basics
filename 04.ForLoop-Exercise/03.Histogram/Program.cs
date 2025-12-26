namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            for (int i = 0; i < n; i++)
            {

                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    count1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    count2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    count3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    count4++;
                }
                else if (number >= 800)
                {
                    count5++;

                }

            }
            p1 = (double)count1 * 100 / n;
            p2 = (double)count2 * 100 / n;
            p3 = (double)count3 * 100 / n;
            p4 = (double)count4 * 100 / n;
            p5 = (double)count5 * 100 / n;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");




        }
    }
}
