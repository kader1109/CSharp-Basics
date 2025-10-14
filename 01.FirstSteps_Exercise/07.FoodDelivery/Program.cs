namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chikenMenuAndPrice = double.Parse(Console.ReadLine()) * 10.35;
            double fishMenuAndPrice = double.Parse(Console.ReadLine()) * 12.4;
            double vegetableMenuAndPrice = double.Parse(Console.ReadLine()) * 8.15;

            double sum = chikenMenuAndPrice + fishMenuAndPrice + vegetableMenuAndPrice;
            double desertPrice = sum * 0.20;
            double total = sum + desertPrice + 2.50;// price of shepeeng is 2.50 lv;

            Console.WriteLine(total);

        }
    }
}
