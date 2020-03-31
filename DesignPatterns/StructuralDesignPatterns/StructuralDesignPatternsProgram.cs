using DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern;
using DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns
{
    class StructuralDesignPatternsProgram
    {
        public static void SDPatternRun()
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine("\n\t------------Structural Design Patterns------------\n");
                    Console.WriteLine("\t\t1. Adapter Design Pattern");
                    Console.WriteLine("\t\t2. Facade Design Pattern");
                    Console.WriteLine("\t\t4. Exit");
                    Console.Write("\tEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            AdapterProgram.AdapterRun();
                            break; ;
                        case 2:
                            AddressBookProgram.AddressBookRun();
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
