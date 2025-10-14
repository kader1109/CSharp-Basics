namespace _04.Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesOfABook = int.Parse(Console.ReadLine());
            int pagesForAnHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = pagesOfABook / pagesForAnHour;
            int totalDays = hours / days;
            Console.WriteLine(totalDays);

        }
    }
}
