using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class IsPalindrome
    {
        public static void Input()
        {
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (Utility.IsPalindrome(num))
            {
                Console.Write("Is palindrome");
            }
            else
            {
                Console.Write("Not Palindrome");
            }
        }

    }
}
