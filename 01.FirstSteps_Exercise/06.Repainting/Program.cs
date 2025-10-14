namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double plactikcoverPerSquareAndPrice = double.Parse(Console.ReadLine()) * 1.50;
            double litreOfPlaintAndPrice = double.Parse(Console.ReadLine()) * 14.5;
            double diliuentOfPaintAndPrice = double.Parse(Console.ReadLine()) * 5;

            int hourOfMaster = int.Parse(Console.ReadLine());

            double sum =( plactikcoverPerSquareAndPrice + litreOfPlaintAndPrice + diliuentOfPaintAndPrice ) + 
                0.4 + (litreOfPlaintAndPrice * 0.10) + 3;//2sq plactic => 2.150 = 3

            double masterPrice = hourOfMaster * (sum * 0.3);
            double total= sum+ masterPrice;

            Console.WriteLine(total);

            
        }
    }
}
