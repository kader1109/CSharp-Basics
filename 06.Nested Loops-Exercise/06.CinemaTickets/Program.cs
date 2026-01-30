using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;

            while (command != "Finish")
            {
                string movieName = command;
                int seats = int.Parse(Console.ReadLine());

                int soldTickets = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End" && soldTickets < seats)
                {
                    if (ticketType == "student")
                    { studentCount++; }

                    else if (ticketType == "standard")
                    { standardCount++; }

                    else if (ticketType == "kid")
                    { kidCount++; }

                    soldTickets++;

                    ticketType = Console.ReadLine();
                }

                double percentFull = soldTickets * 100.0 / seats;
                Console.WriteLine($"{movieName} - {percentFull:F2}% full.");

                command = Console.ReadLine(); // ЧЕТЕМ СЛЕДВАЩИЯ ФИЛМ
            }

            int totalTickets = studentCount + standardCount + kidCount;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentCount * 100.0 / totalTickets:F2}% student tickets.");
            Console.WriteLine($"{standardCount * 100.0 / totalTickets:F2}% standard tickets.");
            Console.WriteLine($"{kidCount * 100.0 / totalTickets:F2}% kids tickets.");
        }
    }
}
