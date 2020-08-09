using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power of \"power\"");

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}
