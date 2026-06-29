using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of Fibonacci numbers to generate:");
            int number = int.Parse(Console.ReadLine());
            GenerateFibonacci( number);

            Console.WriteLine($"Above is Fibonacci series of {number} number" , number);
        }

        static void GenerateFibonacci(int number)
        {
            int peviousNumber = 0;
            int currentNumber = 1;
            int temp = 0;
            Console.Write(peviousNumber);
            for (int i = 2; i < number; i++)
            {
                Console.Write("  " + currentNumber);
                temp = currentNumber;
                currentNumber = currentNumber + peviousNumber;
                peviousNumber = temp;
            }
            Console.WriteLine("  " + currentNumber);
        }
    }
}
