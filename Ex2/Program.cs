using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Positive numbers:");

            for(int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Number of positive numbers: {counter}");
        }
    }
}
