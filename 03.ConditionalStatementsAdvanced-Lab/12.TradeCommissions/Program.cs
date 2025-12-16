namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string city = Console.ReadLine();
              double sales = double.Parse(Console.ReadLine());
              double commission = -1;
                if (city == "Sofia")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.12;
                    }
                }
                else if (city == "Varna")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 0.10;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.13;
                    }
                }
                else if (city == "Plovdiv")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.145;
                    }
            }
                if (commission >= 0)
            {
                double result = sales * commission;
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
