using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumber
    {
        public static void Input()
        {
            Console.Write("Enter a range: ");
            int user_range = Convert.ToInt32(Console.ReadLine());
            Utility.PrimeNumber(user_range);
        }
    }
}
