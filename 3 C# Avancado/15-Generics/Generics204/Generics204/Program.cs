using System;
using System.Collections.Generic;

namespace Generics204
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Value #{i}: ");
                int value = int.Parse(Console.ReadLine());

                printService.AddValue(value);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());
        }
    }
}
