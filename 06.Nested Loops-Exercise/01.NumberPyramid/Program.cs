namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigest = false;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > n)
                    {
                        isBigest = true;
                        break;
                    }

                    Console.Write(current + " ");
                    current++;
                }
                if (isBigest)
                {
                    break;
                }
                Console.WriteLine();

            }
        }
    }
}
