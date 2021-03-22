using System;
using System.Collections.Generic;

namespace Generics209
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SortedSet<int> b = new SortedSet<int>() { 7, 8, 9, 10, 11 };

            Console.WriteLine("a: ");
            PrintCollection(a);

            Console.WriteLine();

            Console.WriteLine("b: ");
            PrintCollection(b);

            // union

            Console.WriteLine("\nUnionWith: ");

            SortedSet<int> c = new SortedSet<int>(a);

            c.UnionWith(b);

            PrintCollection(c);

            // intersection

            Console.WriteLine("\nIntersectWith: ");

            SortedSet<int> d = new SortedSet<int>(a);

            d.IntersectWith(b);

            PrintCollection(d);

            // difference

            Console.WriteLine("\nExceptWith: ");

            SortedSet<int> e = new SortedSet<int>(a);

            e.ExceptWith(b);

            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
