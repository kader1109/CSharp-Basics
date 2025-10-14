namespace _07.AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double a = 0;
            double ha = 0;
            double b = 0;

            double area = 0;


            if (figure == "square")
            {
                 a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "triangle")
                {
                    a = double.Parse(Console.ReadLine());
                   ha = double.Parse(Console.ReadLine());
                    area = (a * ha)/2;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b= double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine($"{area:F3}"); ;
            }
            else if (figure == "circle")
            {
                a = double.Parse(Console.ReadLine());
                area = Math.PI * a* a;
                Console.WriteLine($"{area:F3}");
            }

        }
    }
}
