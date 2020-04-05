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
                int choice;
                bool flag = false, exitFlag = false;
                do
                {
                    do
                    {
                        Console.WriteLine("\n---------------Welcome To Data Structures----------------\n");
                        Console.WriteLine("\tLinked List");
                        Console.WriteLine("\t\t1. Singly Linked List");
                        Console.WriteLine("\t\t2. Exit");
                        Console.Write("Enter your choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        if (choice < 0 || choice > 4)
                        {
                            Console.WriteLine("Enter valid choice!");
                            flag = false;
                        }
                    } while (!flag);
                    switch (choice)
                    {
                        case 1:
                            LinkedList.SinglyLinkedList.LinkedListTest.LinkedListTestRun();
                            break;
                        case 2:
                            exitFlag = true;
                            break;
                        default:
                            Console.WriteLine("Inavlid choice!");
                            break;
                    }
                } while (!exitFlag);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
