using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfaNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to calculate the sum of its digits:");
            int number = Convert.ToInt32(Console.ReadLine());
           int sum = CalculateSumOfDigits(number);
            Console.WriteLine($"The sum of the digits of {number} is {sum}"); Console.WriteLine(sum);
        }

        static int CalculateSumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
