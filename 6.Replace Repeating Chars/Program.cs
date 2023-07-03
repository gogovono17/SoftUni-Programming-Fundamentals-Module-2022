

namespace _6.Replace_Repeating_Chars
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.Write(input[0]);
            for(int i = 1; i < input.Length; i++)
            {
                if(!(input[i] == input[i - 1]))
                {
                    Console.Write(input[i]);
                }
                
            }
        }
    }
}
