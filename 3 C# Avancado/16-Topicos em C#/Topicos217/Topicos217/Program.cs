using System;

namespace Topicos217
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
