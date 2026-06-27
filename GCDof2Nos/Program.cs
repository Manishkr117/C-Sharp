using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDof2Nos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number for GCD:");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please enter the second number for GCD:");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            int gcd = CalculateGCD(firstNumber, secondNumber);
            Console.WriteLine($"The GCD of {firstNumber} and {secondNumber} is {gcd}");
        }

        static int CalculateGCD(int biggerNo, int smallerNo)
        {
           if(biggerNo<=0 || smallerNo<=0)
              { 
                Console.WriteLine("Please enter positive integers grater than 0 only.");
                return 0; 
            }

          if(biggerNo <smallerNo)
            {

                biggerNo = biggerNo + smallerNo;
                smallerNo = biggerNo - smallerNo;
                biggerNo = biggerNo - smallerNo;
            }

          for(int i = smallerNo-1; i >1; i--)
            {
                if(biggerNo % i == 0 && smallerNo % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
