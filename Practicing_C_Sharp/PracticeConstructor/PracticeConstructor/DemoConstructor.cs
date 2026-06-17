using System;

namespace PracticeConstructor
{
    public  class DemoConstructor
    {

        public string Name { get; set; }
        //Static construct is used to call some methods or properties of a class without creating an instance of the class and to call some code before tatic method is called
        static DemoConstructor() { 
        Console.WriteLine("DemoConstructor is called");
        }

        //Parameterized Constructor is used to initialize the object with specific values when it is created.
        //It allows you to pass arguments to the constructor to set the initial state of the object.
        public DemoConstructor(string name)
        {
            Console.WriteLine("Parameterized Constructor is called");
            Name = name;
        }
        //Copy Constructor is used to create a new object as a copy of an existing object.
        //It is a constructor that takes an object of the same class as a parameter and initializes the new object with the values of the existing object.
        public DemoConstructor(DemoConstructor copy)
        {
            Console.WriteLine("Copy Constructor is called");
            Name = copy.Name;
        }
       

        public static void Display()
        { Console.WriteLine("Inside Display Method");
        
        }
    }
}
