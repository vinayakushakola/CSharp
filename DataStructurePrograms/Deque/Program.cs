using System;

namespace Deque
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
                    Console.WriteLine("\t1. Palindrome Checker");
                    Console.WriteLine("\t2. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            PalindromeCheckerProgram palindromeCheck = new PalindromeCheckerProgram();
                            palindromeCheck.PalindromeChecker();
                            break;
                        case 2:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice!!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
