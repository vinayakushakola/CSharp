using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    public class Customer1
    {
        string _FirstName;
        string _LastName;

        public Customer1(string firstname, string lastname)
        {
            _FirstName = firstname;
            _LastName = lastname;
        }

        public void PrintFullName()
        {
            Console.WriteLine(this._FirstName + " " + this._LastName);
        }

        //Destructor
        ~Customer1()
        {
            //clean up
        }
    }
}
