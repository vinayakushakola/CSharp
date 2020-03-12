using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public static void Input()
        {
            Console.Write("Enter X Co-ordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y Co-ordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Utility.Distance(x, y);
        }
    }
}
