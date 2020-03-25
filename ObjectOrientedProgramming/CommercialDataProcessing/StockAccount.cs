using ConsoleTables;
using Newtonsoft.Json;
using ObjectOrientedProgramming.CommercialDataProcessing.Details;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming.CommercialDataProcessing
{
    class StockAccount
    {
        public StockAccount() { }
        public StockAccount(string filename)
        {
            try
            {
                List<Customer> customers = Utility.ReadCustomerData();

                string userName;
                bool check = true, flag = true;

                do
                {
                    do
                    {
                        Console.WriteLine("Enter your Username: ");
                        userName = Console.ReadLine();
                        if (Utility.NameChecking(userName))
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Enter valid Username!");
                            flag = true;
                        }
                    } while (flag);

                    if (Utility.UserChecking(customers, userName))
                    {
                        Console.WriteLine("Username already exists!");
                        check = true;
                    }
                    else
                        check = false;
                } while (check);

                Guid guid = Guid.NewGuid();

                Customer customer = new Customer()
                {
                    ID = guid.ToString(),
                    UserName = userName
                };
                customers.Add(customer);

                CustomerList customerList = new CustomerList()
                {
                    Customers = customers
                };

                Utility.AddCustomerToJson(customerList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public double ValueOf()
        {
            try
            {
                double totalAmount = 0.0;

                List<CustomerPurchased> customerPurchased = Utility.ReadCustomerPurchasedLists();
                customerPurchased = customerPurchased.FindAll(x => x.UserName.Equals(Utility.UserName));
                customerPurchased = Utility.AllCustomerPurchasedShare(customerPurchased);


                foreach (CustomerPurchased custPurchased in customerPurchased)
                    totalAmount += Convert.ToDouble(custPurchased.Amount);

                return totalAmount;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return 0.0;
            }
        }
        public void Buy(int amount, string symbol)
        {
            try
            {
                float customerPurchasedShare;
                string TransactionId, userName;

                Stock stockPortfolio = Utility.SingleStockData(symbol);
                float sharePrice = (float)Convert.ToDouble(stockPortfolio.SharePrice);
                float noOfShare = (float)Convert.ToDouble(stockPortfolio.NoOfShares);

                if (stockPortfolio == null)
                {
                    Console.WriteLine("This Share is not present.");
                    return;
                }

                customerPurchasedShare = (float)amount / sharePrice;

                if (noOfShare < customerPurchasedShare)
                {
                    Console.WriteLine("We Do not Posses this much Share.");
                    return;
                }

                Console.WriteLine();
                Console.Write("Are You Sure, Do you want to Buy {0} Share for Rs.{1} [y/n]: ", symbol, amount);

                if (Console.ReadLine().ToLower()[0] == 'n')
                    return;
                else
                {
                    TransactionId = Guid.NewGuid().ToString();
                    userName = Utility.UserName;

                    stockPortfolio.NoOfShares = (noOfShare - customerPurchasedShare).ToString();

                    List<Stock> stockPortfolios1 = Utility.ReadStockData(stockPortfolio);

                    StockList stock = new StockList()
                    {
                        Stocks = stockPortfolios1
                    };

                    Utility.UpdateStockDataToJson(stock);

                    List<CustomerPurchased> customerPurchasedLists = Utility.ReadCustomerPurchasedLists();

                    CustomerPurchased customerPurchased = new CustomerPurchased
                    {
                        Transaction_Id = TransactionId,
                        UserName = userName,
                        ShareName = symbol,
                        NoOfShare = customerPurchasedShare.ToString(),
                        Amount = amount.ToString(),
                        DateAndTime = DateTime.Now.ToString()
                    };

                    customerPurchasedLists.Add(customerPurchased);

                    CustomerPurchasedList customerPurchasedList = new CustomerPurchasedList
                    {
                        CustomerPurchasedlists = customerPurchasedLists
                    };

                    Utility.AddCustomerPurchasedShareToJson(customerPurchasedList);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }


        public void PrintReport()
        {
            try
            {
                List<CustomerPurchased> customerPurchaseds = Utility.ReadCustomerPurchasedLists();
                customerPurchaseds = customerPurchaseds.FindAll(x => x.UserName.Equals(Utility.UserName));
                if (customerPurchaseds.Count == 0)
                {
                    Console.WriteLine("You Have Purchased Anything. ");
                    return;
                }

                List<CustomerPurchased> customerPurchaseds2;

                int n = ListOfCompanyShares().Count;
                string shareName = "";
                double specificShare = 0.0, totalAmount = 0.0, amount = 0.0, totalShare = 0.0, tempAmount = 0.0;

                int count = 1;
                var table = new ConsoleTable("No.", "Share Name", "No. Of Share", "Amount", "Total Amount");

                for (int i = 0; i < n; i++)
                {
                    shareName = ListOfCompanyShares()[i].ShareName;
                    amount = Convert.ToDouble(ListOfCompanyShares()[i].SharePrice);
                    customerPurchaseds2 = customerPurchaseds.FindAll(x => x.ShareName.Equals(shareName));
                    if (customerPurchaseds2.Count != 0)
                    {
                        foreach (CustomerPurchased customerPurchased in customerPurchaseds2)
                        {
                            specificShare += Convert.ToDouble(customerPurchased.NoOfShare);
                            totalAmount += Convert.ToDouble(customerPurchased.Amount);

                        }

                        table.AddRow(count, shareName, specificShare, "Rs." + amount, "Rs." + totalAmount);

                        count++;
                        totalShare += specificShare;
                        specificShare = 0.0;
                        tempAmount += totalAmount;
                        totalAmount = 0.0;
                    }

                }
                table.Options.EnableCount = false;
                table.Write();

                Console.WriteLine("The Total Share You Have: {0}", totalShare);
                Console.WriteLine("The Total Amount of Share You Have: Rs.{0}", tempAmount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
        public static List<Stock> ListOfCompanyShares()
        {
            try
            {
                string filename = StockAccountReportProgram.StockPath;

                string stocksInfoData = File.ReadAllText(filename);

                var stocksInfoObject = JsonConvert.DeserializeObject<StockList>(stocksInfoData);

                List<Stock> stocks;

                if (stocksInfoObject == null)
                    stocks = new List<Stock>();
                else
                    stocks = stocksInfoObject.Stocks;

                return stocks;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
    }
}
