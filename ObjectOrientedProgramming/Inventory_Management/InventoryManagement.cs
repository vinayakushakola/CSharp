using Newtonsoft.Json;
using System;
using System.IO;

namespace ObjectOrientedProgramming.Inventory_Management
{
    class InventoryManagement
    {
        public static void InventoryManager()
        {
            try
            {
                Console.WriteLine("\n....Inventory Management Program....");

                string inputPath = @"D:\Github\CSharp\ObjectOrientedProgramming\Inventory_Management\InventoryData.json";

                string jsonData = File.ReadAllText(inputPath);

                var myData = JsonConvert.DeserializeObject<InventoryList>(jsonData);

                Console.WriteLine();
                Console.WriteLine("Welcome to Bridelabz Bazaar"); 

                string stockDepartment = "Rice Department.";
                ManagerUtility.PrintInventory(myData.Rice, stockDepartment);

                stockDepartment = "Pulses Department.";
                ManagerUtility.PrintInventory(myData.Pulses, stockDepartment);

                stockDepartment = "Wheat Department.";
                ManagerUtility.PrintInventory(myData.Wheats, stockDepartment);

                int choice;
                bool flag = false, inputFlag;

                do
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("From Which Department You want to Buy.");
                        Console.WriteLine("1. Rice Department");
                        Console.WriteLine("2. Pulses Department");
                        Console.WriteLine("3. Wheat Department");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter your Choice: ");
                        inputFlag = int.TryParse(Console.ReadLine(), out choice);
                        Console.WriteLine(inputFlag);
                    } while (!inputFlag);
                    switch (choice)
                    {
                        case 1:
                            stockDepartment = "Rice Department";
                            ManagerUtility.PrintInventory(myData.Rice, stockDepartment);
                            myData.Rice = ManagerUtility.BuyInventory(myData.Rice, stockDepartment);
                            break;

                        case 2:
                            stockDepartment = "Pulses Department";
                            ManagerUtility.PrintInventory(myData.Pulses, stockDepartment);
                            myData.Pulses = ManagerUtility.BuyInventory(myData.Pulses, stockDepartment);
                            break;

                        case 3:
                            stockDepartment = "Wheats Department";
                            ManagerUtility.PrintInventory(myData.Wheats, stockDepartment);
                            myData.Wheats = ManagerUtility.BuyInventory(myData.Wheats, stockDepartment);
                            break;

                        case 4:
                            Console.WriteLine("Thanks For Shopping from BridgeLabz Bazaar");
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice !!");
                            break;

                    }
                } while (!flag);

                InventoryList inventory = new InventoryList
                {
                    Rice = myData.Rice,
                    Pulses = myData.Pulses,
                    Wheats = myData.Wheats
                };

                string data = JsonConvert.SerializeObject(inventory);

                using (StreamWriter streamwriter = new StreamWriter(inputPath))
                    streamwriter.WriteLine(data);

                Console.WriteLine("Json File Updated.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
