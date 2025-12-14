namespace _03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 15;

            if (minutes >= 60)
            {
                minutes = minutes % 60;
                hour += 1;
            }

            if (hour > 23)
            {                
                hour = hour % 24;
            }
            
            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
