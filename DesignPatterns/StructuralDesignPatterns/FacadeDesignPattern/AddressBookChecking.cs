using System;
using System.Text.RegularExpressions;

namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    class AddressBookChecking
    {
        /// <summary>
        /// This Method is used to check name
        /// </summary>
        /// <returns></returns>
        public static string NameChecking()
        {
            try
            {
                string name, pattern = @"^[a-zA-Z\s]*$";
                bool flag;

                do
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                    flag = Regex.IsMatch(name, pattern);
                    if (!flag)
                        Console.WriteLine("Enter valid name");
                } while (!flag);
                return name;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This method is used to check address format
        /// </summary>
        /// <returns></returns>
        public static string AddressChecking()
        {
            try
            {
                string address, pattern = @"^[a-zA-Z0-9\,\-\.\s]*$";
                bool flag;

                do
                {
                    Console.Write("Enter your address: ");
                    address = Console.ReadLine();
                    flag = Regex.IsMatch(address, pattern);
                    if (!flag)
                        Console.WriteLine("Enter address properly!");
                } while (!flag);

                return address;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// This method is used to check email format
        /// </summary>
        /// <returns></returns>
        public static string EmailChecking()
        {
            try
            {
                string email;
                string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                bool flag;

                do
                {
                    Console.Write("Enter Your Email-Id: ");
                    email = Console.ReadLine();
                    flag = Regex.IsMatch(email, pattern);
                    if (!flag)
                        Console.WriteLine("Enter valid Email-ID");
                } while (!flag);

                return email;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// This method is used to check mmobile number format
        /// </summary>
        /// <returns></returns>
        public static string MobileNumberChecking()
        {
            try
            {
                string mobileNumber;
                string pattern = @"^((\+)?(\d{2}[-])?(\d{10}){1})?(\d{11}){0,1}?$";
                bool flag;

                do
                {
                    Console.Write("Enter Your Mobile Number: ");
                    mobileNumber = Console.ReadLine();
                    flag = Regex.IsMatch(mobileNumber, pattern);
                    if (!flag)
                        Console.WriteLine("Enter Valid Phone Number");
                } while (!flag);

                return mobileNumber;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// This method is used to check pin code format
        /// </summary>
        /// <returns></returns>
        public static string PinChecking()
        {
            try
            {
                string pin, pattern = @"^[1-9][0-9]{5}$";
                bool flag;

                do
                {
                    Console.Write("Enter Your Zip: ");
                    pin = Console.ReadLine();
                    flag = Regex.IsMatch(pin, pattern);
                    if (!flag)
                        Console.WriteLine("Enter valid Pin Code");
                } while (!flag);

                return pin;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                return null;
            }
        }
    }
}
