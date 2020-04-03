using System;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorPattern
{
    class MediatorProgram
    {
        public static void MediatorRun()
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine("\n\t\t------------Mediator Pattern------------\n");
                    Console.WriteLine("\t\t\t1. Air Traffic Controller (ATC)");
                    Console.WriteLine("\t\t\t2. Exit");
                    Console.Write("\tEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            AirTrafficController.ATCProgram.ATCRun();
                            break;
                        case 2:
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
