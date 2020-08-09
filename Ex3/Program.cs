using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine("Fibonacci");
            Console.WriteLine("0. 0");
            Console.WriteLine("1. 1");
            for (int i = 2; i < 100; i++)
            {
                Console.WriteLine(i+". " +(n1 + n2));
                int temp = n1;
                n1 = n2;
                n2 = n2 + temp;
            }
        }
    }
}
