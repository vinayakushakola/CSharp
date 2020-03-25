using ObjectOrientedProgramming.CommercialDataProcessing.Details;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.CommercialDataProcessing
{
    class StockLoginProgram
    {
        public static void StockLogin(string userName)
        {
            List<Stock> stocks;
            StockAccount stockAccount;
            int amount, count, choice;
            string shareName = null;
            bool flag = true;
            Console.WriteLine();
            Console.WriteLine("Welcome {0} to the Commercial Data Processing", userName);

            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("1. Your Account Value.");
                Console.WriteLine("2. Buy Shares.");
                Console.WriteLine("3. Sell Shares.");
                Console.WriteLine("4. Display Transaction.");
                Console.WriteLine("5. Print Report.");
                Console.WriteLine("6. Exit.");
                Console.Write("Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine();
                        stockAccount = new StockAccount();
                        Console.WriteLine("Your Account Worth is: Rs.{0}", stockAccount.ValueOf());
                        break;
                    case 2:
                        Console.WriteLine();
                        Utility.ShowStocks();
                        Console.Write("Enter your choice: ");
                        int userChoice= Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter the amount: ");
                        amount = Convert.ToInt32(Console.ReadLine());

                        count = 1;
                        stocks = Utility.ReadStockData();
                        foreach(Stock data in stocks)
                        {
                            if (count == userChoice)
                            {
                                shareName = data.ShareName;
                                count++;
                            }
                        }
                        stockAccount = new StockAccount();
                        stockAccount.Buy(amount, shareName);
                        break;
                    case 5:
                        Console.WriteLine();
                        stockAccount = new StockAccount();
                        stockAccount.PrintReport();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
