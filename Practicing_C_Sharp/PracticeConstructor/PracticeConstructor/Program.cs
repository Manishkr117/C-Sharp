using System;

namespace PracticeConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static construct is used to call some methods or properties of a class without creating an instance of the class and to call some code before tatic method is called


            DemoConstructor.Display();

            DemoConstructor demo1 = new DemoConstructor("Hello Mr How r u ?");
            DemoConstructor demo2 = new DemoConstructor(demo1);
            Console.ReadLine();
        }
    }
}
