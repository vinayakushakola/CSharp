﻿using DesignPatterns.BehavioralDesignPatterns.MediatorPattern;
using DesignPatterns.BehavioralDesignPatterns.ObserverPattern;
using DesignPatterns.BehavioralDesignPatterns.VisitorPattern;
using System;

namespace DesignPatterns.BehavioralDesignPatterns
{
    class BehavioralDesignPatternProgram
    {
        public static void BDPatternRun()
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine("\n\t------------Behavioral Design Patterns------------\n");
                    Console.WriteLine("\t\t1. Observer Pattern");
                    Console.WriteLine("\t\t2. Visitor Pattern");
                    Console.WriteLine("\t\t3. Mediator Pattern");
                    Console.WriteLine("\t\t4. Exit");
                    Console.Write("\tEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            ObserverProgram.ObserverRun();
                            break;
                        case 2:
                            VisitorProgram.VisitorRun();
                            break;
                        case 3:
                            MediatorProgram.MediatorRun();
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
