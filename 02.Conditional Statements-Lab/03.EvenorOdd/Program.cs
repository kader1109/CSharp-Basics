namespace _03.EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else Console.WriteLine("odd");
        }
    }
}
