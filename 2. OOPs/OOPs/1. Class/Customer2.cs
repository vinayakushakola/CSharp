using System;

namespace OOPs
{
    class Customer2
    {
        string _FirstName;
        string _LastName;

        //Overloading Constructor
        public Customer2() : this("NoFirstName", "NoLastName")
        {
        }

        public Customer2(string firstname, string lastname)
        {
            _FirstName = firstname;
            _LastName = lastname;
        }

        public void PrintFullName()
        {
            Console.WriteLine(this._FirstName + " " + this._LastName);
        }
    }
}
