namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //price per night
            double roomForOnePersonPrice = 18.00;
            double apartmentPrice = 25.00;
            double presidentApartmentPrice = 35.00;

            // input
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            double totalPrice = 0;

            // calculate price
            double price = 0;
            switch (typeOfRoom)
            {
                case "room for one person":
                    price = nights * roomForOnePersonPrice;
                    totalPrice = price;
                    break;
                case "apartment":
                    price = nights * apartmentPrice;
                    if (nights < 10)
                    {
                        totalPrice = price - (price * 0.30);
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        totalPrice = price - (price * 0.35);
                    }
                    else
                    {
                        totalPrice = price - (price * 0.50);
                    }
                    break;
                case "president apartment":
                    price = nights * presidentApartmentPrice;
                    if (nights < 10)
                    {
                        totalPrice = price - (price * 0.10);
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        totalPrice = price - (price * 0.15);
                    }
                    else
                    {
                        totalPrice = price - (price * 0.20);
                    }
                    break;
            }
            // adjust price based on rating
            if (rating == "positive")
            {
                totalPrice = totalPrice + (totalPrice * 0.25);
            }
            else if (rating == "negative")
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
