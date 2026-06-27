using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check if it's prime:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number {number} is {(IsPrime(number) ? "" : "not ")}prime.");
        }

        static bool IsPrime(int n)
        {
            if(n<=1)
                return false;
            int counter = 2;
            while(counter <=n/2)
            {
                if(n%counter==0)
                {
                    return false;
                }
                counter++;
            }
            return true;
        }
    }
}
