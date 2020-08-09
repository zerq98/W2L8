using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string decimalNumber = string.Empty;
            Console.WriteLine("Converter");
            Console.WriteLine("Insert number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} in decimal");

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    decimalNumber += "0";
                }
                else
                {
                    decimalNumber += "1";
                }

                number /= 2;
            }

            for(int i = decimalNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(decimalNumber[i]);
            }
        }
    }
}
