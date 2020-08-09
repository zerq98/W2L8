using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for(int i = 0; i <= 20; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                sum += 1 / Convert.ToDouble(i);
            }

            Console.WriteLine($"Sum: {Math.Round(sum, 2)}");
        }
    }
}
