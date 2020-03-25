using ObjectOrientedProgramming.CommercialDataProcessing.Details;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.CommercialDataProcessing
{
    class StockAccountReportProgram
    {
        public static string CustomerPath = @"D:\Github\CSharp\ObjectOrientedProgramming\CommercialDataProcessing\Data\CustomerInfo.json";
        public static string CustomerPurchasedPath = @"D:\Github\CSharp\ObjectOrientedProgramming\CommercialDataProcessing\Data\CustomerPurchasedInfo.json";
        public static string StockPath = @"D:\Github\CSharp\ObjectOrientedProgramming\CommercialDataProcessing\Data\StockData.json";
        public static string customerSoldPath = @"D:\Github\CSharp\ObjectOrientedProgramming\CommercialDataProcessing\Data\CustomerSoldInfo.json";

        public static void StockReport()
        {
            Console.WriteLine("\n-----------------Commercial Data Processing Program-----------------");

            int choice;
            bool flag = true;
            string userName;

            List<Customer> customers = Utility.ReadCustomerData();

            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Login ");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        StockAccount stockAccount = new StockAccount(CustomerPath);
                        break;
                    case 2:
                        Console.WriteLine();
                        customers = Utility.ReadCustomerData();
                        Console.Write("Enter Your UserName: ");
                        userName = Console.ReadLine();

                        if (Utility.UserChecking(customers, userName))
                        {
                            Console.WriteLine("Login Successfull");
                            flag = true;
                            StockLoginProgram.StockLogin(userName);
                        }
                        else
                        {
                            Console.WriteLine("UserName not Found!");
                            flag = true;
                        }
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
