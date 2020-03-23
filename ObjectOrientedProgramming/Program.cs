using ObjectOrientedProgramming.AddressBook;
using ObjectOrientedProgramming.DeckOfCards;
using ObjectOrientedProgramming.Inventory_Data_Management;
using ObjectOrientedProgramming.Inventory_Management;
using ObjectOrientedProgramming.StockAccountManagement;
using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n........Welcome To Object Oriented Programs........\n");
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\t1. Inventory Data Management");
                    Console.WriteLine("\t2. Inventory Management Program");
                    Console.WriteLine("\t3. Address Book");
                    Console.WriteLine("\t4. Stock Account Management");
                    Console.WriteLine("\t5. Deck Of Cards");
                    Console.WriteLine("\t6. Deck Of Cards Using Queue");
                    Console.WriteLine("\t7. Exit");
                    Console.Write("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InventoryUtility.InventoryMain();
                            break;
                        case 2:
                            InventoryManagement.InventoryManager();
                            break;
                        case 3:
                            AddressBookProgram.AddressBook();
                            break;
                        case 4:
                            StockReportProgram.StockReport();
                            break;
                        case 5:
                            DeckOfCardsProgram.DeckOfCards();
                            break;
                        case 6:
                            DeckOfCardsQueueProgram.DeckOfCardsQueue();
                            break;
                        case 7:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
