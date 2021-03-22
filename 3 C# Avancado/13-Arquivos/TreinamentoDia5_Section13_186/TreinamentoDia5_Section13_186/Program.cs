﻿using System;
using System.IO;

namespace TreinamentoDia5_Section13_186
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gabriel.seima\source\repos\Treinamento\file1.txt";
            
            string targetPath = @"C:\Users\gabriel.seima\source\repos\Treinamento\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
