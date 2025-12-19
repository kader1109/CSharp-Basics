using System.Threading.Channels;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            if(month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;
                if(nights > 7 && nights <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if(nights > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            else if(month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;
                if(nights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            else if(month == "July" || month == "August")
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
                if(nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
        
    }
}
