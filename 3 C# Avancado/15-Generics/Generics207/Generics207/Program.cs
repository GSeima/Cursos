using Generics207.Entities;
using System;

namespace Generics207
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Ana", Email = "ana@gmail.com" };
            Client b = new Client { Name = "Bernardo", Email = "bernardo@gmail.com" };

            Console.WriteLine("a Equal b ? " + a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine("GetHashCode(a) " + a.GetHashCode());
            Console.WriteLine("GetHashCode(b) " + b.GetHashCode());
        }
    }
}
