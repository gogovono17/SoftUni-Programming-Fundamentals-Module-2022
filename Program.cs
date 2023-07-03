

namespace _1._Valid_Usernames
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach(string username in usernames)
            {
                bool checker = true;
                if(username.Length >= 3 && username.Length <= 16)
                {
                    foreach(char chr in username)
                    {
                        if(!(char.IsLetterOrDigit(chr) || chr == '-' || chr == '_'))
                        {
                            checker = false;
                            break;
                        }
                    }
                    if (checker)
                    {
                        Console.WriteLine(username);
                    }
                    
                }
                
            }
        }
    }
}
