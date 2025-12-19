namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examHour * 60 + examMinute;
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;
            int timeDifference = arrivalTimeInMinutes - examTimeInMinutes;

            if(timeDifference > 0)
            {
                Console.WriteLine("Late");
                int hoursLate = timeDifference / 60;
                int minutesLate = timeDifference % 60;
                if (hoursLate > 0)
                {
                    Console.WriteLine($"{hoursLate}:{minutesLate:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutesLate} minutes after the start");
                }
            }
            else if (timeDifference >= -30)
            {
                Console.WriteLine("On time");
                int minutesEarly = -timeDifference;
                if (minutesEarly > 0)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                int hoursEarly = -timeDifference / 60;
                int minutesEarly = -timeDifference % 60;
                if (hoursEarly > 0)
                {
                    Console.WriteLine($"{hoursEarly}:{minutesEarly:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
            }
        }
    }
}
