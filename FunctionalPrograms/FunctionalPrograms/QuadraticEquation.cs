using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class QuadraticEquation
    {
        public static void Input()
        {
            Utility u = new Utility();
            Console.Write("Enter Value For A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Value For B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Value For C:");
            int c = Convert.ToInt32(Console.ReadLine());
            Utility.QuadraticEquation(a, b, c);
        }
    }
}
