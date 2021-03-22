using System;
using System.Globalization;
using System.Collections.Generic;
using TreinamentoDia4_Section10_137.Entities;

namespace TreinamentoDia4_Section10_137
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, expenditures));

                    Console.WriteLine();

                    
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid character");
                }
            }
            double sum = 0;

            Console.WriteLine("TAXES PAID: ");

            foreach (Person p in list)
            {
                double t = p.Total();

                Console.WriteLine(p.Name + ": $" + t.ToString("F2", CultureInfo.InvariantCulture));

                sum += t;
            }

            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
