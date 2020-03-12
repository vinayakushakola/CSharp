using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TwoDArray
    {
        public static void input()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Utility.TwoDArray(rows, columns);
        }
    }
}
