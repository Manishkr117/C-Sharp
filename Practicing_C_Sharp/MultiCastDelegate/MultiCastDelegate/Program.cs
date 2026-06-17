using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    internal class Program
    {
        public delegate void Calculator(int x, int y);

        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition: " + (x + y));
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication: " + (x * y));
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(Add);
            calculator += Multiply; // Add Multiply to the delegate
            calculator(5, 3); // Call the delegate
        }
      
    }
    
}
