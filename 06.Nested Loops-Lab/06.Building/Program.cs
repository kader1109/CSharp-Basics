namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloor = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());

            for (int floor = numberOfFloor; floor >= 1; floor--)
            {
                for (int room = 0 ; room < numberOfRooms; room++)
                {
                    if (floor == numberOfFloor)
                    {
                        Console.Write($"L{floor}{room} ");

                    }

                    else if (floor % 2 == 0)
                    {

                        Console.Write($"O{floor}{room} ");

                    }
                    else
                    {

                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
                
            }
        }
    }
}
