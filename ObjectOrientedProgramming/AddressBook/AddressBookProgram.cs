using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedProgramming.AddressBook
{
    class AddressBookProgram
    {
        public static void AddressBook()
        {
            try
            {
                Console.WriteLine("\n.........Address Book.........\n");

                string path = @"D:\Github\CSharp\ObjectOrientedProgramming\AddressBook\AddressBookData.json";
                string addressString = File.ReadAllText(path);
                var Data = JsonConvert.DeserializeObject<AddressBookList>(addressString);

                int choice;
                bool flag = true;

                List<AddressBook> addressBookList;
                AddressBook addressBook;

                if (Data == null)
                    addressBookList = new List<AddressBook>();
                else
                    addressBookList = Data.AddressBook;

                while (flag)
                {
                    Console.WriteLine("Address Book");
                    Console.WriteLine("\t1. Create Contact");
                    Console.WriteLine("\t2. Edit Contact");
                    Console.WriteLine("\t3. Delete Contact");
                    Console.WriteLine("\t4. Display Contact");
                    Console.WriteLine("\t5. Exit.");
                    Console.Write("Enter Your Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            addressBook = Utility.CreateAddressBookData();
                            addressBookList.Add(addressBook);
                            Utility.SaveAddressBook(addressBookList, path);
                            Console.WriteLine("New Contact has been Saved Successfully");
                            break;
                        case 2:
                            addressBookList = Utility.EditAddressBookData(addressBookList);
                            Utility.SaveAddressBook(addressBookList, path);
                            Console.WriteLine("The Contact Has Been Successfully Updated. !!");
                            break;
                        case 3:
                            Console.WriteLine();
                            addressBookList = Utility.DeleteAddressBookData(addressBookList);
                            Utility.SaveAddressBook(addressBookList, path);
                            Console.WriteLine("The Contact has been Deleted Successfully");
                            break;
                        case 4:
                            Utility.DisplayAddressBookData(addressBookList);
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice!");
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
