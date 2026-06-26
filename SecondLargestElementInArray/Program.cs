using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 4, 45, 99 };

            int secondLargest = FindSecondLargest(arr);
            Console.WriteLine("Second largest element in array is {0}", secondLargest);
            Console.ReadKey();
        }
         static int  FindSecondLargest(int[] arr)
        {
            int firstlargest = arr[0];
            int secondlargest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if(firstlargest < arr[i])
                {
                    secondlargest = firstlargest; //Assign the previus largest no to second largest variable
                    firstlargest = arr[i];

                }
              
            }
            return secondlargest;
        }
}
}
