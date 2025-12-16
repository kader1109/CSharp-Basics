namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();
            int ticketPrice = 0;
            switch (dayOfTheWeek)
            {
                case "Monday":
                    ticketPrice = 12;
                    break;
                case "Tuesday":
                    ticketPrice = 12;
                    break;
                case "Wednesday":
                    ticketPrice = 14;
                    break;
                case "Thursday":
                    ticketPrice = 14;
                    break;
                case "Friday":
                    ticketPrice = 12;
                    break;
                case "Saturday":
                    ticketPrice = 16;
                    break;
                case "Sunday":
                    ticketPrice = 16;
                    break;
                default:
                    ticketPrice = 0;
                    break;


            }
            Console.WriteLine(ticketPrice);


        }
    }
}
