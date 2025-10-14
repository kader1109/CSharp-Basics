using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentige = double.Parse(Console.ReadLine()) / 100;

            int volumeOfAquarium= length * width * height;
            double volumeOfLiters = volumeOfAquarium * 0.001;
            double watherNeeded= volumeOfLiters * (1-percentige);

            Console.WriteLine(watherNeeded);
            
        }
    }
}
