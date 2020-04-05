/*
 * Purpose: Entry point for the program
 * @author  Vinayak Ushakola
 * @version 1.0
 * @since   05-04-2020
 */

using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n---------------Welcome To Data Structures----------------\n");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
