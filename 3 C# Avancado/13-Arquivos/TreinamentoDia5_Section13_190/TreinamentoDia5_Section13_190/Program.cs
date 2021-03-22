﻿using System;
using System.IO;

namespace TreinamentoDia5_Section13_190
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabriel.seima\source\repos\Treinamento";

            try
            {
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                
                //Console.WriteLine("FOLDERS: ");
                
                //foreach(string s in folders)
                //{
                //    Console.WriteLine(s);
                //}

                //var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                //Console.WriteLine("FILES: ");

                //foreach (string s in files)
                //{
                //    Console.WriteLine(s);
                //}

                Directory.CreateDirectory(path + "/newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
