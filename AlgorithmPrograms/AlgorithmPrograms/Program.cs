using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\n\n\nAlgorithm Programs");
                    Console.WriteLine("\n\t1.Bubble Sort");
                    Console.WriteLine("\t2.Prime Number in Range");
                    Console.WriteLine("\t3.Insertion Sort");
                    Console.WriteLine("\t6.Exit\n");

                    Console.Write("\tEnter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            BubbleSort.Input();
                            break;
                        case 2:
                            PrimeNumber.Input();
                            break;
                        case 3:
                            InsertionSort.Input();
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("\nEnter valid choice\n");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
