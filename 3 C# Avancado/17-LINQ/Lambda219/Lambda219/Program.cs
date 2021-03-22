﻿using Lambda219.Entities;
using System;
using System.Collections.Generic;

namespace Lambda219
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900));
            list.Add(new Product("Notebook", 1200));
            list.Add(new Product("Tablet", 450));

            list.Sort( (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()) );

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}