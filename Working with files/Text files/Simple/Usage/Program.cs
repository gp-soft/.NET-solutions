﻿using System;

namespace Usage
{
    public class Program
    {
        public static string FileToRead  = "FileToRead.txt";
        public static string FileToWrite = "FileToWrite{0}.txt";

        static void Main(string[] args)
        {
            #region Reading
                Console.WriteLine("Reading");

                Console.WriteLine("\n\t FileStream method:\n");
                Console.WriteLine(Read.FileStream());

                Console.WriteLine("\n\t TextReader method:\n");
                Console.WriteLine(Read.TextReader());

                Console.WriteLine("\n\t FileInfo method:\n");
                Console.WriteLine(Read.FileInfo());

                Console.WriteLine("\n\t File method:\n");
                Console.WriteLine(Read.File());
            #endregion

            #region Writing
                Console.WriteLine("\n\nWriting");

                Console.WriteLine($"\n\t FileStream method:\t{Write.FileStream()}\n");

                Console.WriteLine($"\n\t TextWriter method:\t{Write.TextWriter()}\n");

                Console.WriteLine($"\n\t FileInfo method:\t{Write.FileInfo()}\n");

                Console.WriteLine($"\n\t File method:\t\t{Write.File()}\n");
            #endregion

        }
    }
}
