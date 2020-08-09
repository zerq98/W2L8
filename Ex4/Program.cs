using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 1;
            int counter = 0;
            int number;
            Console.WriteLine("Insert number");
            number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                if (counter < level)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    counter++;
                }
                else
                {
                    counter = 0;
                    level++;
                    Console.Write("\r\n");
                    i--;
                }
            }
        }
    }
}
