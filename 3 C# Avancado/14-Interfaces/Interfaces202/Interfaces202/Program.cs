using Interfaces202.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interfaces202
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabriel.seima\source\repos\Treinamento\C#3 Avancado\14-Interfaces\csvEmployees.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
