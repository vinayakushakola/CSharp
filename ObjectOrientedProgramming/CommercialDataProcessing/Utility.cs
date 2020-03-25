using Newtonsoft.Json;
using ObjectOrientedProgramming.CommercialDataProcessing.Details;
using ObjectOrientedProgramming.StockAccountManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ObjectOrientedProgramming.CommercialDataProcessing
{
    class Utility
    {
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
