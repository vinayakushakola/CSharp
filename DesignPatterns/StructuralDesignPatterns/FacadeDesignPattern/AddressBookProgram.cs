using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookProgram
    {
        public static void AddressBookRun()
        {
            try
            {
                Console.WriteLine("\n-----------------Address Book-----------------\n");

                int choice;
                bool inputFlag, flag = true;


                AddressBookMain addressBook = new AddressBookMain();

                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Create Contact");
                    Console.WriteLine("2. Edit Contact");
                    Console.WriteLine("3. Delete Contact");
                    Console.WriteLine("4. Sort By Name");
                    Console.WriteLine("5. Sort By Pin");
                    Console.WriteLine("6. Quit.");
                    Console.Write("Enter Your Choice: ");
                    inputFlag = int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(); ;
                            addressBook.CreateAddressBook();
                            Console.WriteLine("New Contact has been Successfully Created");
                            break;

                        case 2:
                            Console.WriteLine();
                            addressBook.EditAddressBook();
                            break;

                        case 3:
                            Console.WriteLine();
                            addressBook.DeleteAddressBook();
                            break;

                        case 4:
                            Console.WriteLine();
                            addressBook.SortByNameAddressBook();
                            break;

                        case 5:
                            Console.WriteLine();
                            addressBook.SortByPinAddressBook();
                            break;

                        case 6:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
