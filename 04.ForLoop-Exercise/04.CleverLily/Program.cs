int age = int.Parse(Console.ReadLine());
double priceOfWashingMachine = double.Parse(Console.ReadLine());
double toyPrice = double.Parse(Console.ReadLine());
double moneySaved = 0;
double moneyGiven = 10;
int toyCount = 0;

for (int birthday = 1; birthday <=age; birthday++)
{
    if(birthday % 2 == 0)
    {
        moneySaved += moneyGiven - 1;
        moneyGiven += 10;

    }
    else
    {
        toyCount++;
    }

}
double moneyFromToys = toyCount * toyPrice;
double totalMoney = moneySaved + moneyFromToys;
double difference = Math.Abs(totalMoney - priceOfWashingMachine);
if(totalMoney >= priceOfWashingMachine)
{
    Console.WriteLine($"Yes! {difference:f2}");
}
else
{
    Console.WriteLine($"No! {difference:f2}");
}