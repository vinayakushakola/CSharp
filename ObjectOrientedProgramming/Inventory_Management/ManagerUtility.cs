using System;
using System.Collections.Generic;
using ConsoleTables;
namespace ObjectOrientedProgramming.Inventory_Management
{
    class ManagerUtility
    {
        public static void PrintInventory(List<InventoryData> list, string stockDepartment)
        {
            try
            {
                int count = 1;
                Console.WriteLine("\n\t\t{0}\t\t", stockDepartment);
                var table = new ConsoleTable("No.", "Name", "Weight(kg)", "Rs.Price/Kg");
                if (list == null)
                    Console.WriteLine("No Data Present. !!");
                else
                {
                    foreach (InventoryData li in list)
                    {
                        table.AddRow(count, li.Name, li.Weight, li.Price);

                        count++;
                    }
                    table.Options.EnableCount = false;
                    table.Write();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        public static List<InventoryData> BuyInventory(List<InventoryData> list, string stockDepartment)
        {
            try
            {
                string Name = "";
                int choice, weight = 0, price = 0, quantity, userPrice = 0, count;
                bool flag, outerFlag = false;
                do
                {
                    count = 1;
                    do
                    {
                        Console.WriteLine();
                        Console.Write("Enter Your Choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        if (choice > list.Count)
                        {
                            Console.WriteLine("Invalid Choice !!");
                            flag = false;
                        }
                    } while (!flag);
                    foreach (InventoryData li in list)
                    {
                        if (count == choice)
                        {
                            Name = li.Name;
                            weight = li.Weight;
                            price = li.Price;
                            break;
                        }
                        count++;
                    }
                    do
                    {
                        Console.WriteLine("You Choose to buy: {0}", Name);
                        Console.WriteLine("It's Price is: {0}/kg", price);
                        Console.Write("How Much Quantity Do you want to buy: ");
                        flag = int.TryParse(Console.ReadLine(), out quantity);
                    } while (!flag);
                    if (quantity > weight)
                    {
                        Console.WriteLine("At present, we dont posses this much quantity.");
                        Console.WriteLine();
                        PrintInventory(list, stockDepartment);
                    }
                    else
                    {
                        userPrice = quantity * price;
                        Console.WriteLine("Your Total Price is: {0}", userPrice);
                        Console.Write("Are you Sure, you want to Buy this item [y/n]: ");
                        if (Console.ReadLine()[0] == 'y')
                        {
                            weight -= quantity;
                            count = 1;
                            foreach (InventoryData li in list)
                            {
                                if (count == choice)
                                {
                                    li.Weight = weight;
                                    break;
                                }
                                count++;
                            }
                            Console.WriteLine("Congratulation you have successfully bought this item !!");
                        }


                        Console.Write("Do you want to Contiune Shopping [y/n]: ");
                        if (Console.ReadLine()[0] == 'y')
                        {
                            Console.WriteLine();
                            PrintInventory(list, stockDepartment);
                        }
                        else
                            outerFlag = true;
                    }
                } while (!outerFlag);

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
    }
}
