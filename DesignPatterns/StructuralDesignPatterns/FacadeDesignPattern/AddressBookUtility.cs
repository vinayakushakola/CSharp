using ConsoleTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookUtility
    {
        static string path = @"D:\Github\CSharp\DesignPatterns\StructuralDesignPatterns\FacadeDesignPattern\AddressBook.json";
        public static List<AddressBook> ReadAddressBookFile()
        {
            try
            {
                string readingAddressBook; 

                readingAddressBook = File.ReadAllText(path);
                var addressData = JsonConvert.DeserializeObject<AddressBookList>(readingAddressBook);

                List<AddressBook> addressBooks;

                if (addressData == null)
                    addressBooks = new List<AddressBook>();
                else
                    addressBooks = addressData.AddressBooks;

                return addressBooks;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }
        public static void SaveAddressBookInFile(List<AddressBook> addressBooks)
        {
            try
            {
                AddressBookList addressBookList = new AddressBookList
                {
                    AddressBooks = addressBooks
                };

                string saveAddressBook = JsonConvert.SerializeObject(addressBookList);

                using StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(saveAddressBook);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
        public static void DisplayAddressBook(List<AddressBook> addressBooks)
        {
            try
            {
                if (addressBooks.Count == 0)
                    Console.WriteLine("Address Book is Empty");
                else
                {
                    int count = 1;

                    var table = new ConsoleTable("No.", "Name", "Mobile Number", "Email-Id", "Address", "Pin");
                    foreach (AddressBook addressBook in addressBooks)
                    {
                        table.AddRow(count, addressBook.Name, addressBook.MobileNumber, addressBook.EmailId, addressBook.Address, addressBook.Pin);
                        count++;
                    }

                    table.Options.EnableCount = false;
                    table.Write();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
