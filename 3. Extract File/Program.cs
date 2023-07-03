

namespace _3._Extract_File
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split("\\");
            string fileName = filePath[filePath.Length-1];

            string[] partsToPrint = fileName.Split('.');

            string name = partsToPrint[0];
            string extension = partsToPrint[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
