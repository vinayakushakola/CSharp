using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._3._inheritance
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    class PartTimeEmployee : Employee
    {
        public float HourlySalary;
    }
}
