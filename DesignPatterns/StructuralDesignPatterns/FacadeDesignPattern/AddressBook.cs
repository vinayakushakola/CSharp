using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    public class AddressBook : IAddressBook
    {
        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public string Address { get; set; }

        public string Pin { get; set; }
    }
}
