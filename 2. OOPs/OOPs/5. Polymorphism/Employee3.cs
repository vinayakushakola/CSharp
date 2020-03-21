using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._5._Polymorphism
{
    public class Employee3
    {
        public string FirstName = "V";
        public string LastName = "U";

        public virtual void PrintFullName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
    }

    public class FullTimeEmployee3 : Employee3
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName +" - Full Time");
        }
    }

    public class PartTimeEmployee3 : Employee3
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class TemporaryEmployee3 : Employee3
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary");
        }
    }

}
