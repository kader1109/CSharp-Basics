namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareArea=double.Parse(Console.ReadLine()) * 7.61;
            double discount = squareArea * 0.18;
            double finalPrice=squareArea-discount;
           
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
