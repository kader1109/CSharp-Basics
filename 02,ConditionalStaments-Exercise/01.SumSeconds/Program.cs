namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int runer1InSeconds = int.Parse(Console.ReadLine());
            int runer2InSeconds = int.Parse(Console.ReadLine());
            int runer3InSeconds = int.Parse(Console.ReadLine());

            int sumOfTheRunersTime = runer1InSeconds + runer2InSeconds + runer3InSeconds;

            int reminingSeconds = sumOfTheRunersTime % 60;

            int minutes = sumOfTheRunersTime / 60;

            if(reminingSeconds < 10)   Console.WriteLine($"{minutes}:0{reminingSeconds}");
            else Console.WriteLine($"{minutes}:{reminingSeconds}");
        }
    }
}
