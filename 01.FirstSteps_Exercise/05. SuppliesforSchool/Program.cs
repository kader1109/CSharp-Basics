namespace _05._SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pencilCountAndPrice = double.Parse(Console.ReadLine()) * 5.80;
            double markerCountAndPrice = double.Parse(Console.ReadLine()) * 7.20;
            double literOfCleaneProductAndPrice = double.Parse(Console.ReadLine()) * 1.20;

            double percentOfDiscount = double.Parse(Console.ReadLine()) / 100;

            double sumOfProducts = pencilCountAndPrice + markerCountAndPrice + literOfCleaneProductAndPrice;
            double discount = sumOfProducts * percentOfDiscount;

            double total = sumOfProducts - discount;

            Console.WriteLine(total);

        }
    }
}
