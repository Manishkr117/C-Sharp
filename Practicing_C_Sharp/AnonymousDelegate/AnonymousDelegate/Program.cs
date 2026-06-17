using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate
{
    internal class Program
    {

        public delegate void Calculator(int a, int b);
        static void Main(string[] args)
        {
            Calculator add = delegate (int a, int b)
            {
                Console.WriteLine($"Addition: {a + b}");
            };
            add(5, 6);
        }
    }
}
