using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAstring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "Manhattan SCALE Source Code is here";
            string reversedStr = ReverseString(str);
            Console.WriteLine("Original String: " + str);
            Console.WriteLine("Reversed String: " + reversedStr);
            Console.ReadKey();
        }

        static string ReverseString(string str)
        {
            //handle edge case for null or empty string
            if (string.IsNullOrEmpty(str))
                return str;

            StringBuilder   reversedString = new StringBuilder(str.Length);
            char[] chars = new char[str.Length];
            for (int i = str.Length-1; i>=0; i--)
            {
                reversedString.Append(str[i]);
            }
            return reversedString.ToString();
        }
    }
}
