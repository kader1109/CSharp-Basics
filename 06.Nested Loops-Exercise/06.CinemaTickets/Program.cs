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

                while (soldTickets < seats)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    if (ticketType == "student")
                    {
                        studentCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCount++;
                    }

                    soldTickets++;
                }

                double percentFull = soldTickets * 100.0 / seats;
                Console.WriteLine($"{movieName} - {percentFull:F2}% full.");

                command = Console.ReadLine();
            }

            int totalTickets = studentCount + standardCount + kidCount;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentCount * 100.0 / totalTickets:F2}% student tickets.");
            Console.WriteLine($"{standardCount * 100.0 / totalTickets:F2}% standard tickets.");
            Console.WriteLine($"{kidCount * 100.0 / totalTickets:F2}% kids tickets.");
        }
    }
}
