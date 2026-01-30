namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            for (int num = 1111; num <= 9999; num++)
            {
                string numberAsString = num.ToString();
                bool IsSpecial = true;

                foreach (char digitChar in numberAsString)
                {

                    int digit = digitChar - '0';

                    if (digit == 0 || N % digit != 0)
                    {
                        IsSpecial = false;
                        break;
                    }

                }

                if (IsSpecial)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
