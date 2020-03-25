using ObjectOrientedProgramming.CommercialDataProcessing.Details;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.CommercialDataProcessing
{
    class StockAccount
    {
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
    }
}
