using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedProgramming.Inventory_Data_Management
{
    class InventoryUtility
    {
        public static void InventoryMain()
        {
            try
            {
                Console.WriteLine("\n.....Inventory Data Management Program.....");

                string inputPath = @"D:\Github\CSharp\ObjectOrientedProgramming\Inventory_Data_Management\InventoryData.json";
                string outputPath = @"D:\Github\CSharp\ObjectOrientedProgramming\Inventory_Data_Management\InventoryTotalPrice.json";

                string jsonData = File.ReadAllText(inputPath);

                var myData = JsonConvert.DeserializeObject<InventoryList>(jsonData);

                int totalRiceAmount = 0, totalPulsesAmount = 0, totalWheatAmount = 0;

                List<InventoryData> rice = myData.Rice;
                foreach (InventoryData data in rice)
                    totalRiceAmount += Convert.ToInt32(data.Weight) * Convert.ToInt32(data.Price);

                List<InventoryData> pulses = myData.Pulses;
                foreach (InventoryData data in pulses)
                    totalPulsesAmount += Convert.ToInt32(data.Weight) * Convert.ToInt32(data.Price);

                List<InventoryData> wheats = myData.Wheats;
                foreach (InventoryData data in wheats)
                    totalWheatAmount += Convert.ToInt32(data.Weight) * Convert.ToInt32(data.Price);


                Console.WriteLine("Total Rice Amount: Rs.{0}", totalRiceAmount);
                Console.WriteLine("Total Pulses Amount: Rs.{0}", totalPulsesAmount);
                Console.WriteLine("Total Wheat Amount: Rs.{0}", totalWheatAmount);

                List<Prices> prices = new List<Prices>();

                Prices ricePrice = new Prices
                {
                    Name = "Rice",
                    Price = totalRiceAmount
                };

                Prices pulsesPrice = new Prices
                {
                    Name = "Pulses",
                    Price = totalPulsesAmount
                };

                Prices wheatPrice = new Prices
                {
                    Name = "Wheat",
                    Price = totalWheatAmount
                };

                
                prices.Add(ricePrice);
                prices.Add(pulsesPrice);
                prices.Add(wheatPrice);

                string TotalAmount = JsonConvert.SerializeObject(prices);
                Console.WriteLine(TotalAmount);

                File.WriteAllText(outputPath, TotalAmount);
                Console.WriteLine("File Saved Successfully");
                Console.WriteLine("--------------------------------------------------------------------------------\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
