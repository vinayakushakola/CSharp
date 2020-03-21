using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedProgramming.StockAccountManagement
{
    class StockReportProgram
    {
        public static void StockReport()
        {
            try
            {
                Console.WriteLine("\nWelcome to Stock Reports\n");

                string shareName;
                int sharePrice, noOfShares, noOFStocks, totalSharePrice, totalStockPrice = 0;

                List<StockPortfolio> StocksData = new List<StockPortfolio>();
                StockPortfolio stock;

                Console.Write("Enter the Number of stocks: ");
                noOFStocks = int.Parse(Console.ReadLine());
                Console.WriteLine();
                while (noOFStocks > 0)
                {
                    Console.Write("Enter the Share Name: ");
                    shareName = Console.ReadLine();
                    Console.Write("Enter the Number of Shares: ");
                    noOfShares = int.Parse(Console.ReadLine());
                    bool flag = false;
                    do
                    {
                        Console.Write("Enter the Share Price: ");
                        sharePrice = int.Parse(Console.ReadLine());
                        if (sharePrice <= 0)
                            flag = true;
                    } while (flag);
                    Console.WriteLine();
                    totalSharePrice = sharePrice * noOfShares;
                    totalStockPrice += (sharePrice * noOfShares);
                    stock = new StockPortfolio()
                    {
                        ShareName = shareName,
                        NoOfShares = noOfShares,
                        SharePrice = sharePrice,
                        TotalSharePrice = totalSharePrice
                    };
                    StocksData.Add(stock);

                    noOFStocks--;
                }
                Console.WriteLine("Your Total Stock Price: {0}\n", totalStockPrice);

                foreach (StockPortfolio sl in StocksData)
                {
                    Console.WriteLine("Share Name: {0}\nNumber of Shares: {1}\nShare Price: {2}\nTotal Share Price: {3}\n", sl.ShareName, sl.NoOfShares
                        , sl.SharePrice, sl.TotalSharePrice);
                }
                StockList stockList = new StockList()
                {
                    Stocks = StocksData
                };
                string stockJsonData = JsonConvert.SerializeObject(stockList);

                string outputPath = @"D:/Github/CSharp/ObjectOrientedProgramming/StockAccountManagement/StockReportData.json";

                using (StreamWriter sw = new StreamWriter(outputPath))
                    sw.WriteLine(stockJsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
