using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._3._inheritance
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Message from Parent Constructor");
        }
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling parent class")
        {
            Console.WriteLine("Message from Child COnstructor");
        }
    }
}
