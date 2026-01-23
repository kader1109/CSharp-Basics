namespace _05.While_Loop_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine()?.Trim() ?? "0");
            int length = int.Parse(Console.ReadLine()?.Trim() ?? "0");
            int height = int.Parse(Console.ReadLine()?.Trim() ?? "0");

            int freeVolume = width * length * height;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{freeVolume} Cubic meters left.");
                    break;
                }

                int boxes = int.Parse(input);

                freeVolume -= boxes;

                if (freeVolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeVolume)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}

