using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Console.WriteLine("Primary numbers:");
            Console.WriteLine("1");

            for (int i = 2; i <= 100; i++)
            {
                int numberOfDividers = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numberOfDividers++;
                    }
                }

                if(numberOfDividers == 2)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }

            Console.WriteLine($"Number of primary numbers: {counter}");
        }
    }
}
