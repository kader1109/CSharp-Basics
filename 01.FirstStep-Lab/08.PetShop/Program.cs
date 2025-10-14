namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = 2.5;
            double catFood = 4;

            int pacetDogFood = int.Parse(Console.ReadLine());
            int pacetCatFood = int.Parse(Console.ReadLine());

            double sum = (dogFood * pacetDogFood) + (catFood * pacetCatFood);
            Console.WriteLine($"{sum} lv.");
        }
    }
}
