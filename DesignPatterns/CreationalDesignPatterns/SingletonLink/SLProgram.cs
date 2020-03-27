using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SingletonLink
{
    class SLProgram
    {
        public static void SLRun()
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine("\n\t\t----------Singleton Link----------");
                    Console.WriteLine("\t\t\t1. Eager Initialization");
                    Console.WriteLine("\t\t\t2. Lazy Initialization");
                    Console.WriteLine("\t\t\t3. Thread Safety");
                    Console.WriteLine("\t\t\t4. Exit");
                    Console.Write("\t\tEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Output:");

                    switch (choice)
                    {
                        case 1:
                            Parallel.Invoke(
                                () => Object1(),
                                () => Object2()
                            );
                            break;
                        case 2:
                            Parallel.Invoke(
                                () => LazyObject1(),
                                () => LazyObject2()
                            );
                            break;
                        case 3:
                            Parallel.Invoke(
                                () => ThreadObject1(),
                                () => ThreadObject2()
                            );
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

        private static void Object1()
        {
            EagerInitialization obj1 = EagerInitialization.Instance;
            obj1.PrintMessage("From Object 1");
        }
        private static void Object2()
        {
            EagerInitialization obj2 = EagerInitialization.Instance;
            obj2.PrintMessage("From Object 2");
        }


        private static void LazyObject1()
        {
            LazyInitialization obj1 = LazyInitialization.GetInstance;
            obj1.PrintMessage("From Object 1");
        }
        private static void LazyObject2()
        {
            LazyInitialization obj2 = LazyInitialization.GetInstance;
            obj2.PrintMessage("From Object 2");
        }


        private static void ThreadObject1()
        {
            ThreadSafety obj1 = ThreadSafety.Instance;
            obj1.PrintMessage("From Object 1");
        }
        private static void ThreadObject2()
        {
            ThreadSafety obj2 = ThreadSafety.Instance;
            obj2.PrintMessage("From Object 2");
        }
    }
}
