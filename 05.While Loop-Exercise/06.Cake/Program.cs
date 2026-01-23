namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int areaOfCake = cakeLength * cakeWidth;
            int totalPieces = 0;



            while (areaOfCake >= totalPieces)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{areaOfCake - totalPieces} pieces are left.");
                    break;
                }

                totalPieces += int.Parse(input);
                if (totalPieces >= areaOfCake)
                {

                    Console.WriteLine($"No more cake left! You need {Math.Abs(areaOfCake - totalPieces)} pieces more.");
                    break;
                }
            }
        }
    }
}
