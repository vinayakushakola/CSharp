﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        public static void Input()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Utility.PrimeNumber(num);
        }
    }
}
