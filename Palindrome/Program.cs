using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to check if it is a palindrome or not:");
            string str = Console.ReadLine();

           bool isPalindrome = IsThePassedStringIsPalindrome(str);
            Console.WriteLine($"The passed string {str} is {(isPalindrome ? "" : "not")} a palindrome.");
            Console.ReadKey();
        }
        static bool IsThePassedStringIsPalindrome(string str)
        {
            if (str == null)
                return false;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1-i])
                    return false;
               
            }
            return true;
        }
    }
}
