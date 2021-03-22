using System;
using System.IO;

namespace TreinamentoDia5_Section13_191
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabriel.seima\source\repos\Treinamento\file1.txt";

            Console.WriteLine("Path.DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            Console.WriteLine("Path.PathSeparator: " + Path.PathSeparator);
            
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));

            Console.WriteLine("Path.GetFileName: " + Path.GetFileName(path));

            Console.WriteLine("Path.GetExtension: " + Path.GetExtension(path));

            Console.WriteLine("Path.GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("Path.GetFullPath: " + Path.GetFullPath(path));

            Console.WriteLine("Path.GetTempPath: " + Path.GetTempPath());
        }
    }
}
