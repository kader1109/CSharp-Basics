namespace _01._USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal bng = decimal.Parse(Console.ReadLine());
            decimal usd = 1.79549m;

            decimal result = bng * usd;
            Console.WriteLine(result);
        }
    }
}
