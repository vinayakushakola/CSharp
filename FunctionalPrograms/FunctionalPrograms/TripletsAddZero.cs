using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TripletsAddZero
    {
        public static void ArrayInput()
        {
            Console.Write("\nEnter the size of the Array: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("Enter elements: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Utility.TripletsAddZero(sizeArray, arr);
        }
    }
}
