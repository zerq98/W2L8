using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters;
            Console.WriteLine("Insert string");
            characters = Console.ReadLine();

            for(int i = characters.Length - 1; i >= 0; i--)
            {
                Console.Write(characters[i]);
            }
        }
    }
}
