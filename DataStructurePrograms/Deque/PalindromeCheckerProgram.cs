using System;
using System.Collections.Generic;
using System.Text;

namespace Deque
{
    class PalindromeCheckerProgram
    {
        public bool CheckPalindrome(string palindromeString)
        {
            Deque deque = new Deque();

            char[] str = palindromeString.ToCharArray();

            for (int i = 0; i < str.Length; i++)
                deque.AddFront(str[i]);

            int n = str.Length / 2;
            bool flag = false;

            for (int i = 1; i <= n; i++)
            {
                char a, b;
                a = deque.RemoveFront();
                b = deque.RemoveRear();

                if (a != b)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                return false;
            else
                return true;
        }
        public void PalindromeChecker()
        {
            Console.Write("Enter the String: ");
            string str = Console.ReadLine();

            if (CheckPalindrome(str))
                Console.WriteLine(str + " is a Palindrome");
            else
                Console.WriteLine(str + " is not a Palindrome");
            Console.WriteLine("----------------------------------------------------------------------\n\n");
        }
    }
}
