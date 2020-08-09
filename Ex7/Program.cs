using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars;
            Console.WriteLine("Max count of stars in row:");
            stars = int.Parse(Console.ReadLine());

            if (stars % 2 == 0)
            {
                stars -= 1;
            }

            for (int i = 1; i <= stars; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= ((stars - i) / 2); j++)
                    {
                        Console.Write(" ");
                    }

                    for (int s = 1; s <= i; s++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\r\n");
                }
            }

            for (int i = stars-1; i >0; i--)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= ((stars - i) / 2); j++)
                    {
                        Console.Write(" ");
                    }

                    for (int s = 1; s <= i; s++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\r\n");
                }
            }
        }
    }
}
