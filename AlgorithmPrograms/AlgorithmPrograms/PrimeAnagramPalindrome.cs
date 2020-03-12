using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeAnagramPalindrome
    {
        public static void Input()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Utility.PrimeAnagramPalindrome(num);
        }
    }
}
