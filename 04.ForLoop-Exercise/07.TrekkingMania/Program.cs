namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            for (int i = 1; i <= groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;
                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    kilimanjaro += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else
                {
                    everest += peopleInGroup;
                }
            }
            Console.WriteLine($"{(musala * 1.0 / totalPeople * 100):f2}%");
            Console.WriteLine($"{(monblan * 1.0 / totalPeople * 100):f2}%");
            Console.WriteLine($"{(kilimanjaro * 1.0 / totalPeople * 100):f2}%");
            Console.WriteLine($"{(k2 * 1.0 / totalPeople * 100):f2}%");
            Console.WriteLine($"{(everest * 1.0 / totalPeople * 100):f2}%");
            
        }
    }
}
