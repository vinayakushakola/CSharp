/*
 * Purpose: Entry point for Linked List
 * @author  Vinayak Ushakola
 * @version 1.0
 * @since   05-04-2020
 */

using System;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    class LinkedListTest
    {
        public static void LinkedListTestRun()
        {
            try
            {
                int choice, position;
                string key, data;
                bool flag = false, exitFlag = false;
                LinkedList<String> llist = new LinkedList<string>();
                do
                {
                    do
                    {
                        Console.WriteLine("\n\t--------Singly Linked List--------\n");
                        Console.WriteLine("\t\t1. Display Data");
                        Console.WriteLine("\t\t2. Add Data");
                        Console.WriteLine("\t\t3. Add First");
                        Console.WriteLine("\t\t4. Add At Position");
                        Console.WriteLine("\t\t5. Insert After");
                        Console.WriteLine("\t\t6. Insert Before");
                        Console.WriteLine("\t\t7. Delete Node");
                        Console.WriteLine("\t\t8. Delete Node by Position");
                        Console.WriteLine("\t\t9. Exit");
                        Console.Write("\tEnter your choice: ");
                        flag = int.TryParse(Console.ReadLine(), out choice);
                        if (choice < 0 || choice > 9)
                        {
                            Console.WriteLine("Enter valid choice!");
                            flag = false;
                        }
                    } while (!flag);
                    
                    Console.WriteLine("\nOutput: ");
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();
                            llist.Display();
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.Write("Enter Data to Add At End: ");
                            data = Console.ReadLine();
                            llist.AddLast(data);
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.Write("Enter Data to Add At Start: ");
                            data = Console.ReadLine();
                            llist.AddFirst(data);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.Write("Enter Position where you want to Add this Data: ");
                            position = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter data: ");
                            data = Console.ReadLine();
                            llist.AddAt(position, data);
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine();
                            Console.Write("Enter Old Data: ");
                            key = Console.ReadLine();
                            Console.Write("Enter New Data: ");
                            data = Console.ReadLine();
                            llist.InsertAfter(key, data);
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.Write("Enter Old Data: ");
                            key = Console.ReadLine();
                            Console.Write("Enter New Data: ");
                            data = Console.ReadLine();
                            llist.InsertBefore(key, data);
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine();
                            Console.Write("Enter Old Data which you want to Delete: ");
                            key = Console.ReadLine();
                            llist.DeleteNode(key);
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.WriteLine();
                            Console.Write("Enter the Position of the Data to Delete: ");
                            position = Convert.ToInt32(Console.ReadLine());
                            llist.DeleteNodeAt(position);
                            Console.WriteLine();
                            break;
                        case 9:
                            exitFlag = true;
                            break;
                        default:
                            break;
                    }
                } while (!exitFlag);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
