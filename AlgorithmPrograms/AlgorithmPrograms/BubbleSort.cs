using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public static void Input()
        {
            Console.Write("\nEnter size of the Array: ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sizeOfArray];
            for(int i=0; i<sizeOfArray; i++)
            {
                Console.Write("Enter element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Utility.BubbleSort(sizeOfArray, arr);
        }
    }
}
