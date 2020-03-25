using Newtonsoft.Json;
using ObjectOrientedProgramming.CommercialDataProcessing.Details;
using ObjectOrientedProgramming.StockAccountManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using StockList = ObjectOrientedProgramming.CommercialDataProcessing.Details.StockList;
using ConsoleTables;

namespace ObjectOrientedProgramming.CommercialDataProcessing
{
    class Utility
    {
        public static string UserName = null;

        public static List<Customer> ReadCustomerData()
        {
            try
            {
                string filename = StockAccountReportProgram.CustomerPath;

                string customerInfoData = File.ReadAllText(filename);

                var customerInfoObject = JsonConvert.DeserializeObject<CustomerList>(customerInfoData);

                List<Customer> customers;

                if (customerInfoObject == null)
                    customers = new List<Customer>();
                else
                    customers = customerInfoObject.Customers;

                return customers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }
        public static List<Stock> ReadStockData()
        {
            try
            {
                string filename = StockAccountReportProgram.StockPath;
                string stockInfoData = File.ReadAllText(filename);
                var stockInfoObject = JsonConvert.DeserializeObject<StockList>(stockInfoData);

                List<Stock> stocks;

                if (stockInfoObject == null)
                    stocks = new List<Stock>();
                else
                    stocks = stockInfoObject.Stocks;

                return stocks;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static List<CustomerPurchased> ReadCustomerPurchasedLists()
        {
            try
            {
                string filename = StockAccountReportProgram.CustomerPurchasedPath;
                string custPurchasedInfoData = File.ReadAllText(filename);
                var custPurchasedInfoObject = JsonConvert.DeserializeObject<CustomerPurchasedList>(custPurchasedInfoData);

                List<CustomerPurchased> CustomerPurchasedlist;

                if (custPurchasedInfoObject == null)
                    CustomerPurchasedlist = new List<CustomerPurchased>();
                else
                    CustomerPurchasedlist = custPurchasedInfoObject.CustomerPurchasedlists;

                return CustomerPurchasedlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static List<Stock> ReadStockData(Stock stockPortfolio)
        {
            try
            {
                List<Stock> stockPortfolios = StockAccount.ListOfCompanyShares();

                if (stockPortfolios != null)
                {
                    foreach (Stock stockPortfolio1 in stockPortfolios)
                    {
                        if (stockPortfolio1.ShareName.Equals(stockPortfolio.ShareName))
                        {
                            stockPortfolio1.NoOfShares = stockPortfolio.NoOfShares;
                            return stockPortfolios;
                        }
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }

        }
        public static List<CustomerSold> ReadCustomerSoldList()
        {
            try
            {
                string filename = StockAccountReportProgram.customerSoldPath;
                string custSoldInfoData = File.ReadAllText(filename);
                var custSoldInfoObject = JsonConvert.DeserializeObject<CustomerSoldList>(custSoldInfoData);

                List<CustomerSold> CustomerSoldlist;

                if (custSoldInfoObject == null)
                    CustomerSoldlist = new List<CustomerSold>();
                else
                    CustomerSoldlist = custSoldInfoObject.CustomerSolds;

                return CustomerSoldlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public static void ShowStocks()
        {
            try
            {
                List<Stock> stocks = ReadStockData();
                int count = 1;
                var table = new ConsoleTable("No", "Share Name", "No of Shares", "Share Price");
                foreach(Stock data in stocks)
                {
                    table.AddRow(count, data.ShareName, data.NoOfShares, data.SharePrice);
                    count++;
                }
                table.Options.EnableCount = false;
                table.Write();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<CustomerPurchased> AllCustomerPurchasedShare(List<CustomerPurchased> customerPurchased)
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }

        public static void UpdateStockDataToJson(StockList stock)
        {
            try
            {
                string filename = StockAccountReportProgram.StockPath;

                string updateStockData = JsonConvert.SerializeObject(stock);

                using StreamWriter streamWriter = new StreamWriter(filename);
                streamWriter.WriteLine(updateStockData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        public static Stock SingleStockData(string symbol)
        {
            try
            {
                List<Stock> stockPortfolios = StockAccount.ListOfCompanyShares();

                if (stockPortfolios.Count != 0)
                {
                    foreach (Stock stockPortfolio in stockPortfolios)
                    {
                        if (stockPortfolio.ShareName.Equals(symbol))
                            return stockPortfolio;
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }

        }

        public static void AddCustomerPurchasedShareToJson(CustomerPurchasedList customerPurchasedList)
        {
            try
            {
                string filename = StockAccountReportProgram.CustomerPurchasedPath;

                string customerPurchasedData = JsonConvert.SerializeObject(customerPurchasedList);

                using (StreamWriter streamWriter = new StreamWriter(filename))
                    streamWriter.WriteLine(customerPurchasedData);

                Console.WriteLine("Your Have Successfully Brought this Share.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }

        }
        public static void AddCustomerToJson(CustomerList customerList)
        {
            try
            {
                string filename = StockAccountReportProgram.CustomerPath;

                string customerData = JsonConvert.SerializeObject(customerList);

                using (StreamWriter streamWriter = new StreamWriter(filename))
                    streamWriter.WriteLine(customerData);

                Console.WriteLine("Your Account Has Been Successfully Created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static bool UserChecking(List<Customer> customers, string userName)
        {
            try
            {
                foreach(Customer data in customers)
                {
                    if (data.UserName.Equals(userName))
                        return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool NameChecking(string userName)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9]{3,15}$";
                return Regex.IsMatch(userName, pattern);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
