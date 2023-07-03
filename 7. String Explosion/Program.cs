

namespace _7._String_Explosion
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bombs = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if(bombs > 0 && input[i] != '>')
                {
                    input = input.Remove(i,1);
                    bombs--;
                    i--;
                }
                else if(input[i] == '>')
                {
                    bombs += int.Parse(input[i+1].ToString());
                } 
            }
            Console.WriteLine(input);
        }
    }
}
