using DesignPatterns.CreationalDesignPatterns.SingletonLink;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns
{
    class CreationalDesignPatternProgram
    {
        public static void CDPatternRun()
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine("\n\t------------Creational Design Patterns------------\n");
                    Console.WriteLine("\t\t1. Singleton Link");
                    Console.WriteLine("\t\t2. Factory Pattern");
                    Console.WriteLine("\t\t3. Prototype Design Pattern");
                    Console.WriteLine("\t\t4. Exit");
                    Console.Write("\tEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            SLProgram.SLRun();
                            break;
                        case 2:
                            break;
                        case 3:
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
            catch(Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
