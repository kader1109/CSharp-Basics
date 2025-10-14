namespace _03._DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal depositeSum = decimal.Parse(Console.ReadLine());
            int termInMonths = int.Parse(Console.ReadLine());
            double percentigeForAYear = double.Parse(Console.ReadLine()) /100;

            decimal result = depositeSum + termInMonths * ((depositeSum * (decimal)percentigeForAYear) / 12);
            Console.WriteLine(result);
        }
    }
}
