using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine($"Insert first number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Insert second number");
            b = double.Parse(Console.ReadLine());
            double x = a * b;
            double w;
            while (b != 0)
            {
                w = a % b;
                a = b;
                b = w;
            }
            double nww = x / a;
            Console.WriteLine($"NWW= {nww}");
        }
    }
}
