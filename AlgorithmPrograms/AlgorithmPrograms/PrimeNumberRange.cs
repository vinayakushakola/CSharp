using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumberRange
    {
        public static void Input()
        {
            Console.Write("Enter a range: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            Utility.PrimeNumberRange(user_input);
        }
    }
}
