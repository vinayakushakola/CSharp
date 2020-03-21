using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._4._MethodHididng
{
    public class Employee2
    {
        public string FirstName = "VIN";
        public string LastName = "USh";

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee2 : Employee2
    {
        public new void PrintFullName()
        {
            // to call parent printfullname method
            //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName+"-Contractor");
        }
    }

}
