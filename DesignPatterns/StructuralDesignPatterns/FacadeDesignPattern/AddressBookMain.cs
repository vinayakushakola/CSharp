using System;
using System.Collections.Generic;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookMain
    {

        /// <summary>
        /// It is used to create Address book
        /// </summary>
        public void CreateAddressBook()
        {
            try
            {
                string name, mobileNumber, emailId, address, pin;

                name = AddressBookChecking.NameChecking();
                mobileNumber = AddressBookChecking.MobileNumberChecking();
                emailId = AddressBookChecking.EmailChecking();
                address = AddressBookChecking.AddressChecking();
                pin = AddressBookChecking.PinChecking();

                AddressBook createAddressBook = new AddressBook
                {
                    Name = name,
                    MobileNumber = mobileNumber,
                    EmailId = emailId,
                    Address = address,
                    Pin = pin
                };

                List<AddressBook> addressBooks = AddressBookUtility.ReadAddressBookFile();
                addressBooks.Add(createAddressBook);
                AddressBookUtility.SaveAddressBookInFile(addressBooks);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }


        /// <summary>
        /// It Edits the data in Address Book
        /// </summary>
        public void EditAddressBook()
        {
            try
            {
                List<AddressBook> addressBooks = AddressBookUtility.ReadAddressBookFile();

                if (addressBooks.Count == 0)
                {
                    Console.WriteLine("Address Book is Empty!");
                    return;
                }

                AddressBookUtility.DisplayAddressBook(addressBooks);

                int choice, count;
                bool inputFlag;
                string name = null, mobileNumber = null, email = null, address = null, pin = null;
                bool flag;
                do
                {
                    Console.WriteLine();
                    Console.Write("Please Choose which Contact you want to Edit: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= 0 || choice > addressBooks.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice!");
                        Console.WriteLine();
                        AddressBookUtility.DisplayAddressBook(addressBooks);
                        flag = false;
                    }
                } while (!flag);

                count = 1;

                foreach (AddressBook addressBook in addressBooks)
                {
                    if (count == choice)
                    {
                        name = addressBook.Name;
                        mobileNumber = addressBook.MobileNumber;
                        email = addressBook.EmailId;
                        address = addressBook.Address;
                        pin = addressBook.Pin;
                        break;
                    }
                    count++;
                }
                flag = false;
                count--;

                do
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Details for the Selected Address are: ");
                        Console.WriteLine("1. Name: {0}", name);
                        Console.WriteLine("2. Mobile Number: {0}", mobileNumber);
                        Console.WriteLine("3. Email: {0}", email);
                        Console.WriteLine("4. Address: {0}", address);
                        Console.WriteLine("5. Pin: {0}", pin);
                        Console.WriteLine("6. Exit");
                        Console.Write("Enter Your Choice: ");
                        inputFlag = int.TryParse(Console.ReadLine(), out choice);
                    } while (!inputFlag);
                    Console.WriteLine();
                    string tempData;
                    switch (choice)
                    {
                        case 1:
                            tempData = AddressBookChecking.NameChecking();

                            name = tempData;
                            addressBooks[count].Name = name;
                            AddressBookUtility.SaveAddressBookInFile(addressBooks);
                            Console.WriteLine("Your Name Has Been Successfully Updated"); 
                            break;

                        case 2:
                            tempData = AddressBookChecking.MobileNumberChecking();
                            mobileNumber = tempData;
                            addressBooks[count].MobileNumber = mobileNumber;
                            AddressBookUtility.SaveAddressBookInFile(addressBooks);
                            Console.WriteLine("Your Mobile Number Has Been Successfully Updated. !!");
                            break;

                        case 3:
                            tempData = AddressBookChecking.EmailChecking();
                            email = tempData;
                            addressBooks[count].EmailId = email;
                            AddressBookUtility.SaveAddressBookInFile(addressBooks);
                            Console.WriteLine("Your Email-Id Has Been Successfully Updated");
                            break;

                        case 4:
                            tempData = AddressBookChecking.AddressChecking();
                            address = tempData;
                            addressBooks[count].Address = address;
                            AddressBookUtility.SaveAddressBookInFile(addressBooks);
                            Console.WriteLine("Your Address Has Been Successfully Updated");
                            break;

                        case 5:
                            tempData = AddressBookChecking.PinChecking();
                            pin = tempData;
                            addressBooks[count].Pin = pin;
                            AddressBookUtility.SaveAddressBookInFile(addressBooks);
                            Console.WriteLine("Your Pin Has Been Successfully Updated. !!");
                            break;

                        case 6:
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. !!!");
                            break;
                    }

                } while (!flag);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }

        /// <summary>
        /// It Deletes the data in Address Book
        /// </summary>
        public void DeleteAddressBook()
        {
            try
            {

                List<AddressBook> addressBooks = AddressBookUtility.ReadAddressBookFile();

                if (addressBooks.Count == 0)
                {
                    Console.WriteLine("No Address Data to Delete. !!!");
                    return;
                }

                AddressBookUtility.DisplayAddressBook(addressBooks);

                int choice;
                bool flag;
                do
                {
                    Console.WriteLine();
                    Console.Write("Please Choose which Contact you want to Delete: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                    if (choice <= 0 || choice > addressBooks.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice");
                        Console.WriteLine();
                        AddressBookUtility.DisplayAddressBook(addressBooks);
                        flag = false;
                    }
                } while (!flag);

                Console.Write("Are You Sure, Do you want to Delete this Address Data: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    addressBooks.RemoveAt(choice - 1);
                    Console.WriteLine("This Address Data has been Successfully Deleted. !!");
                    AddressBookUtility.SaveAddressBookInFile(addressBooks);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        /// <summary>
        /// It Sorts the Address book by Name
        /// </summary>
        public void SortByNameAddressBook()
        {
            try
            {
                List<AddressBook> tempAddress = AddressBookUtility.ReadAddressBookFile();
                tempAddress.Sort((addressName1, addressName2) => addressName1.Name.CompareTo(addressName2.Name));
                AddressBookUtility.DisplayAddressBook(tempAddress);
                Console.WriteLine();
                Console.Write("Do you want to Save the Data in Name Order [y/n]: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    AddressBookUtility.SaveAddressBookInFile(tempAddress);
                    Console.WriteLine("The Data Has Been Sorted by Name and Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }

        /// <summary>
        /// It Sort the Address Book By Pin Code.
        /// </summary>
        public void SortByPinAddressBook()
        {
            try
            {
                List<AddressBook> tempAddress = AddressBookUtility.ReadAddressBookFile();
                tempAddress.Sort((addressName1, addressName2) => addressName1.Pin.CompareTo(addressName2.Pin));
                AddressBookUtility.DisplayAddressBook(tempAddress);
                Console.WriteLine();
                Console.Write("Do you want to Save the Data in PinCode Order [y/n]: ");
                if (Console.ReadLine().ToLower()[0] == 'y')
                {
                    AddressBookUtility.SaveAddressBookInFile(tempAddress);
                    Console.WriteLine("The Data Has Been Saved in Zip Order.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }

        }
    }
}
