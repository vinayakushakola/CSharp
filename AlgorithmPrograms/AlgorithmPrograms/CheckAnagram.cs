using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class CheckAnagram
    {
        public static void Input()
        {
            Console.Write("Enter your string1: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter your string2: ");
            string s2 = Console.ReadLine();
            Utility.CheckAnagram(s1, s2);
        }
    }
}
