using System;
using System.IO;

namespace TreinamentoDia5_Section13_189
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gabriel.seima\source\repos\Treinamento\file1.txt";

            string targetPath = @"C:\Users\gabriel.seima\source\repos\Treinamento\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
