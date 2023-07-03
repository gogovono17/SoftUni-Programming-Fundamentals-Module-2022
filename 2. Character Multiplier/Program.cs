

namespace _2._Character_Multiplier
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string firstWord = input[0];
            string secondWord = input[1];

            int totalSum = 0;
            int counter = 0;
            for(int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                totalSum += firstWord[i] * secondWord[i];
                counter++;
            }

            if(firstWord.Length > secondWord.Length)
            {
                for(int j = counter; j < firstWord.Length; j++)
                {
                    totalSum += firstWord[j];
                }
            }
            else if(secondWord.Length > firstWord.Length)
            {
                for (int j = counter; j < secondWord.Length; j++)
                {
                    totalSum += secondWord[j];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
