namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            int area = rows * columns;

            switch (typeOfProjection)
            {
                case "Premiere":
                    totalPrice = area * 12.00;
                    break;
                case "Normal":
                    totalPrice = area * 7.50;
                    break;
                case "Discount":
                    totalPrice = area * 5.00;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2} leva");

        }
    }
}
