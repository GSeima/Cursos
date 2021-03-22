using System;
using System.IO;

namespace TreinamentoDia5_Section13_188
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabriel.seima\source\repos\Treinamento\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
