using DesignPatterns.CreationalDesignPatterns;
using DesignPatterns.StructuralDesignPatterns;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                int choice;
                while (flag)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n----------------------Design Pattern Programs----------------------\n");
                    Console.WriteLine("\t1. Creational Design Patterns");
                    Console.WriteLine("\t2. Structural Design Patterns");
                    Console.WriteLine("\t3. Behavioural Design Patterns");
                    Console.WriteLine("\t4. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            CreationalDesignPatternProgram.CDPatternRun();
                            break;
                        case 2:
                            StructuralDesignPatternsProgram.SDPatternRun();
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
