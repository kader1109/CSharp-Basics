namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfVacation = double.Parse(Console.ReadLine());
            double ownerMoney = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int daysCounter = 0;

            while (ownerMoney < priceOfVacation && spendingCounter < 5)
            {
                string optionsSpendOrSave = Console.ReadLine();
                double savedOrSpendMoney = double.Parse(Console.ReadLine());

                daysCounter++;

                if (optionsSpendOrSave == "save")
                {
                    ownerMoney += savedOrSpendMoney;
                    spendingCounter = 0;

                }
                else if (optionsSpendOrSave == "spend")
                {
                    ownerMoney -= savedOrSpendMoney;
                    spendingCounter++;

                    if (ownerMoney < 0)
                    {
                        ownerMoney = 0;                        
                    }
                   
                    if (spendingCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        return;
                    }
                }


                if (priceOfVacation <= ownerMoney)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    return;
                }



            }

        }
    }
}
