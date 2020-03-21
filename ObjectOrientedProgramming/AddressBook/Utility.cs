using ConsoleTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming.AddressBook
{
    class Utility
    {
        public static AddressBook CreateAddressBookData()
        {
            string name, mobile, email, address;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Your Mobile Number: ");
            mobile = Console.ReadLine();

            Console.Write("Enter Your Email-Id: ");
            email = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            address = Console.ReadLine();

            AddressBook addressBook = new AddressBook()
            {
                Name = name,
                Mobile = mobile,
                Email = email,
                Address = address
            };
            return addressBook;
        }

        public static void SaveAddressBook(List<AddressBook> addressBooks, string path)
        {
            AddressBookList addressBookLists = new AddressBookList
            {
                AddressBook = addressBooks
            };

            string printAddressBook = JsonConvert.SerializeObject(addressBookLists);

            using (StreamWriter sw = new StreamWriter(path))
                sw.WriteLine(printAddressBook);
        }
        public static void DisplayAddressBookData(List<AddressBook> addressBooks)
        {
            if (addressBooks.Count == 0)
                Console.WriteLine("Address Book is Empty");
            else
            {
                int count = 1;

                var table = new ConsoleTable("No.", "Name", "Mobile Number", "Email-Id", "Address");
                foreach (AddressBook addressBook in addressBooks)
                {
                    table.AddRow(count, addressBook.Name, addressBook.Mobile, addressBook.Email, addressBook.Address);
                    count++;
                }

                table.Options.EnableCount = false;
                table.Write();
            }
        }

        public static List<AddressBook> EditAddressBookData(List<AddressBook> addressBooks)
        {
            try
            {
                if (addressBooks.Count == 0)
                {
                    Console.WriteLine("Address Book is Empty");
                    return null;
                }

                DisplayAddressBookData(addressBooks);

                int choice, count;
                bool inputFlag;
                string name = null, mobileNumber = null, email = null, address = null, zip = null;
                bool flag;
                do
                {
                    Console.WriteLine();
                    Console.Write("Please Choose which Contact you want to Edit: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= 0 || choice > addressBooks.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice");
                        Console.WriteLine();
                        DisplayAddressBookData(addressBooks);
                        flag = false;
                    }
                } while (!flag);

                count = 1;

                foreach (AddressBook addressBook in addressBooks)
                {
                    if (count == choice)
                    {
                        name = addressBook.Name;
                        mobileNumber = addressBook.Mobile;
                        email = addressBook.Email;
                        address = addressBook.Address;
                        break;
                    }
                    count++;
                }
                flag = true;
                count--;
                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine("Details for the Selected Address are: ");
                    Console.WriteLine("1. Name: {0}", name);
                    Console.WriteLine("2. Mobile Number: {0}", mobileNumber);
                    Console.WriteLine("3. Email: {0}", email);
                    Console.WriteLine("4. Address: {0}", address);
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Your Choice: ");
                    inputFlag = int.TryParse(Console.ReadLine(), out choice);
                    
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Your Name you want to update: ");
                            name = Console.ReadLine();
                            addressBooks[count].Name = name;

                            Console.WriteLine("Your Name Has Been Successfully Updated. !!");
                            break;

                        case 2:
                            Console.Write("Enter Your Mobile Number you want to update: ");
                            mobileNumber = Console.ReadLine();
                            addressBooks[count].Mobile = mobileNumber;

                            Console.WriteLine("Your Mobile Number Has Been Successfully Updated. !!");
                            break;

                        case 3:
                            Console.Write("Enter Your Email-Id you want to update: ");
                            email = Console.ReadLine();
                            addressBooks[count].Email = email;

                            Console.WriteLine("Your Email-Id Has Been Successfully Updated. !!");
                            break;

                        case 4:
                            Console.Write("Enter Your Address you want to update: ");
                            address = Console.ReadLine();
                            addressBooks[count].Address = address;

                            Console.WriteLine("Your Address Has Been Successfully Updated. !!");
                            break;

                        case 5:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. !!!");
                            break;
                    }
                }

                return addressBooks;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
        public static List<AddressBook> DeleteAddressBookData(List<AddressBook> addressBooks)
        {
            try
            {
                if (addressBooks.Count == 0)
                {
                    Console.WriteLine("No Address Data to Delete. !!!");
                    return null;
                }

                DisplayAddressBookData(addressBooks);

                int choice;

                Console.WriteLine();
                Console.Write("Please Choose which Contact you want to Delete: ");
                choice = int.Parse(Console.ReadLine());

                Console.Write("Are You Sure, Do you want to Delete this Address Book Data: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    addressBooks.RemoveAt(choice - 1);
                    Console.WriteLine("This Address Data has been Successfully Deleted. !!");
                    return addressBooks;
                }
                else
                    return addressBooks;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
    }
}
