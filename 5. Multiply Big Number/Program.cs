

namespace _5._Multiply_Big_Number
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            int remainder = 0;
            if(bigNumber == "0" || multiplyer == 0)
            {
                Console.WriteLine(0);
                return;
            }
           
            for(int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(bigNumber[i].ToString());
                int product = currDigit * multiplyer + remainder;
                int finalResult = product % 10;
                remainder = product / 10;
                result.Insert(0, finalResult);
            }

            if(remainder > 0)
            {
                result.Insert(0, remainder);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
