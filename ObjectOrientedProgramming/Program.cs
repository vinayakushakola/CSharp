using ObjectOrientedProgramming.Inventory_Data_Management;
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
                    Console.WriteLine("\t1. Inventory Data Management");
                    Console.WriteLine("\t2. Exit");
                    Console.Write("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InventoryUtility.InventoryMain();
                            break;
                        case 2:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
