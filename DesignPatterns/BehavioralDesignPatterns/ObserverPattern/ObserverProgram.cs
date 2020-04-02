using System;

namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern
{
    class ObserverProgram
    {
        public  static void ObserverRun()
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine("\n\t\t------------Observer Pattern------------\n");
                    Console.WriteLine("\t\t\t1. Bin Hex Oct");
                    Console.WriteLine("\t\t\t2. Youtube");
                    Console.WriteLine("\t\t\t3. Exit");
                    Console.Write("\tEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            BinHexOct.BinHexOctProgram.BinHexOctRun();
                            break;
                        case 2:
                            Youtube.YoutubeProgram.YoutubeRun();
                            break;
                        case 3:
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
