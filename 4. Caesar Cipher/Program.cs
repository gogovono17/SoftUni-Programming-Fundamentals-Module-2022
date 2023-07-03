

namespace _4._Caesar_Cipher
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach(char chr in input)
            {
                int sum = chr + 3;
                Console.Write((char)sum);
            }
        }
    }
}
