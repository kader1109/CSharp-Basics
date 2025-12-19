namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            //price of the flowers for one unit

            double rosePrice = 5.00;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;

            switch (flowerType)
            {
                case "Roses":
                    totalPrice = flowerCount * rosePrice;
                    if (flowerCount > 80)
                    {
                        totalPrice *= 0.90;
                    }
                    break;
                case "Dahlias":
                    totalPrice = flowerCount * dahliasPrice;
                    if (flowerCount > 90)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Tulips":
                    totalPrice = flowerCount * tulipsPrice;
                    if (flowerCount > 80)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Narcissus":
                    totalPrice = flowerCount * narcissusPrice;
                    if (flowerCount < 120)
                    {
                        totalPrice *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = flowerCount * gladiolusPrice;
                    if (flowerCount < 80)
                    {
                        totalPrice *= 1.20;
                    }
                    break;
            }
            double difference =Math.Abs( budget - totalPrice);
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {difference:F2} leva left. ");
            }
            else {
                Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
            }
        }
    }
}
